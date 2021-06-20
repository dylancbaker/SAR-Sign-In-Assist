using ICAClassLibrary;
using ICAClassLibrary.Models;
using ICAClassLibrary.networking;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using NetworkCommsDotNet.Connections.TCP;
using NetworkCommsDotNet.DPSBase;
using NetworkCommsDotNet.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SAR_Sign_In_Assist.Services
{
   public   class NetworkService
    {
        public Dictionary<ShortGuid, NetworkSendObject> lastPeerSendObjectDict = new Dictionary<ShortGuid, NetworkSendObject>();

        public bool CheckIP(string ip)
        {
            bool ipGood = false;
            using (Ping pingSender = new Ping())
            {


                //a little regex to check if the texbox contains a valid ip adress (ipv4 only).
                //This way you limit the number of useless calls to ping.
                Regex rgx = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");
                if (rgx.IsMatch(ip))
                {
                    int timeout = 120;
                    try
                    {
                        var reply = pingSender.SendPingAsync(ip, timeout);
                        //textBlock.Text = reply.Status == IPStatus.Success ? "OK" : "KO";
                        ipGood = true;
                    }
                    catch (Exception ex) when (ex is TimeoutException || ex is PingException)
                    {
                        ipGood = false;
                    }
                }
                else
                {
                    ipGood = false;
                }
            }
            return ipGood;
        }

        public bool GetIsFirewallEnabled()
        {
            // Create the firewall type.
            Type FWManagerType = Type.GetTypeFromProgID("HNetCfg.FwMgr");

            // Use the firewall type to create a firewall manager object.
            dynamic FWManager = Activator.CreateInstance(FWManagerType);

            // Check the status of the firewall.
            return FWManager.LocalPolicy.CurrentProfile.FirewallEnabled;

        }

        public bool GetIsPortAvailable(int port)
        {
            bool isAvailable = true;

            // Evaluate current system tcp connections. This is the same information provided
            // by the netstat command line application, just in .Net strongly-typed object
            // form.  We will look through the list, and if our port we would like to use
            // in our TcpClient is occupied, we will set isAvailable to false.
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();

            foreach (TcpConnectionInformation tcpi in tcpConnInfoArray)
            {
                if (tcpi.LocalEndPoint.Port == port)
                {
                    isAvailable = false;
                    break;
                }
            }
            return isAvailable;
        }

        public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public List<string> SendNetworkSarTaskRequest(NetworkSARTaskRequest request)
        {

            List<string> log = new List<string>();

            //We may or may not have entered some server connection information
            ConnectionInfo serverConnectionInfo = null;
            if (!string.IsNullOrEmpty(Program.ServerIP))
            {
                try { serverConnectionInfo = new ConnectionInfo(Program.ServerIP, int.Parse(Program.ServerPortStr)); }
                catch (Exception)
                {
                    log.Add("Failed to parse the server IP and port. Please ensure it is correct and try again");
                    return log;
                }
            }

            //If we provided server information we send to the server first
            if (serverConnectionInfo != null)
            {
                //We perform the send within a try catch to ensure the application continues to run if there is a problem.
                try
                {
                    TCPConnection.GetConnection(serverConnectionInfo).SendObject("NetworkSARTaskRequest", request);
                    DateTime today = DateTime.Now;
                    //addToNetworkLog(string.Format("{0:HH:mm:ss}", today) + " - sent task request" + "\r\n");
                }
                catch (CommsException) { log.Add("A Network CommsException occurred while trying to send a task request (001) to " + serverConnectionInfo); }
            }

            //If we have any other connections we now send the message to those as well
            //This ensures that if we are the server everyone who is connected to us gets our message
            var otherConnectionInfos = (from current in NetworkComms.AllConnectionInfo() where current != serverConnectionInfo select current).ToArray();
            foreach (ConnectionInfo info in otherConnectionInfos)
            {
                //We perform the send within a try catch to ensure the application continues to run if there is a problem.
                try { TCPConnection.GetConnection(info).SendObject("NetworkSARTaskRequest", request); }
                catch (CommsException) { log.Add("A Network CommsException occurred while trying to send a task request (002) to " + info); }
                catch (Exception ex) { log.Add("A Network CommsException occurred while trying to send a task request (003) to " + ex.ToString()); }
            }

            /*
            this.BeginInvoke((Action)delegate ()
            {
                MessageBox.Show("Your request has been sent to the server computer.  A user there will need to confirm it.  In the interim, please do not attempt any work - it will be overwritten.");

            });*/
            return log;
        }

        public List<string> SendNetworkObject(object objToSend, string comment = null, string ip = null, string port = null)
        {
            List<string> errors = new List<string>();

            if (objToSend != null)
            {
                NetworkSendObject networkSendObject = new NetworkSendObject();
                switch (objToSend)
                {


                    case Guid g:
                        networkSendObject.GuidValue = g;
                        break;

                    case SignInRecord sir:
                        networkSendObject.signInRecord = sir;
                        break;
                    case TeamMember member:
                        networkSendObject.teamMember = member;
                        break;

                    case List<TeamMember> memberList:
                        networkSendObject.memberList = memberList;
                        break;

                    case null:
                        break;
                }
                networkSendObject.RequestID = Guid.NewGuid();
                networkSendObject.objectType = objToSend.GetType().ToString();
                networkSendObject.SourceName = HostInfo.HostName;
                networkSendObject.SourceIdentifier = NetworkComms.NetworkIdentifier;
                networkSendObject.comment = comment;


                string iptouse = ip;
                int porttouse = 42999;
                if (ip != null) { iptouse = ip; }
                if (port != null)
                {
                    int.TryParse(port, out porttouse);
                }
                DateTime today = DateTime.Now;

                //We may or may not have entered some server connection information
                ConnectionInfo serverConnectionInfo = null;
                if (!string.IsNullOrEmpty(iptouse))
                {
                    try { serverConnectionInfo = new ConnectionInfo(iptouse, porttouse); }
                    catch (Exception)
                    {
                        errors.Add(string.Format(Globals.cultureInfo, "{0:HH:mm:ss}", today) + " Error - Failed to parse the server IP and port. Please ensure it is correct and try again\r\n\r\n");
                        //MessageBox.Show("Failed to parse the server IP and port. Please ensure it is correct and try again", "Server IP & Port Parse Error", MessageBoxButtons.OK);
                        return errors;
                    }
                }

                lock (lastPeerSendObjectDict) lastPeerSendObjectDict[NetworkComms.NetworkIdentifier] = networkSendObject;

                //If we provided server information we send to the server first
                if (serverConnectionInfo != null)
                {
                    //We perform the send within a try catch to ensure the application continues to run if there is a problem.
                    try
                    {
                        TCPConnection connection = TCPConnection.GetConnection(serverConnectionInfo);
                        connection.SendObject("NetworkSendObject", networkSendObject);
                        errors.Add(string.Format(Globals.cultureInfo, "{0:HH:mm:ss}", today) + " - sent " + networkSendObject.objectType + " - " + networkSendObject.comment + "\r\n");
                    }
                    catch (CommsException ce)
                    {

                        errors.Add(string.Format(Globals.cultureInfo, "{0:HH:mm:ss}", today) + " Error - " + ce.ToString() + "\r\n\r\n");
                        //MessageBox.Show("A CommsException occurred while trying to send a " + networkSendObject.GetType() + " to " + serverConnectionInfo + "\r\n\r\n" + ce.ToString(), "Network Comms Exception", MessageBoxButtons.OK);
                        //MessageBox.Show("A CommsException occurred while trying to send message to " + serverConnectionInfo, "CommsException", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        errors.Add(string.Format(Globals.cultureInfo, "{0:HH:mm:ss}", today) + " Error - " + ex.ToString() + "\r\n\r\n");
                        //MessageBox.Show("A CommsException occurred while trying to send a " + networkSendObject.GetType() + " to " + ex.ToString(), "CommsException", MessageBoxButtons.OK);
                    }

                }

                //If we have any other connections we now send the message to those as well
                //This ensures that if we are the server everyone who is connected to us gets our message
                var otherConnectionInfos = (from current in NetworkComms.AllConnectionInfo() where current != serverConnectionInfo select current).ToArray();
                foreach (ConnectionInfo info in otherConnectionInfos)
                {
                    //We perform the send within a try catch to ensure the application continues to run if there is a problem.
                    try { TCPConnection.GetConnection(info).SendObject("NetworkSendObject", networkSendObject); }
                    catch (CommsException ce)
                    {

                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return errors;
        }
        public NetworkListenResult startListening(int port = 0)
        {
            NetworkListenResult result = new NetworkListenResult();

            try
            {
                Connection.StartListening(ConnectionType.TCP, new IPEndPoint(IPAddress.Any, port));



                List<String> ips = new List<String>();


                foreach (IPEndPoint listenEndPoint in Connection.ExistingLocalListenEndPoints(ConnectionType.TCP))
                {
                    if (listenEndPoint.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && listenEndPoint.Address.ToString() != "127.0.0.1")
                    {
                        //server.Append("IP Address: "); server.Append(listenEndPoint.Address); server.Append("\r\nPort Number: "); server.Append(listenEndPoint.Port);
                        result.TempServerIP = listenEndPoint.Address.ToString();
                        ips.Add(listenEndPoint.Address.ToString());
                        result.TempPort = listenEndPoint.Port.ToString();
                    }
                }

                RijndaelPSKEncrypter.AddPasswordToOptions(NetworkComms.DefaultSendReceiveOptions.Options, Program.EncryptionKey);
                if (!NetworkComms.DefaultSendReceiveOptions.DataProcessors.Contains(DPSManager.GetDataProcessor<RijndaelPSKEncrypter>()))
                {
                    NetworkComms.DefaultSendReceiveOptions.DataProcessors.Add(DPSManager.GetDataProcessor<RijndaelPSKEncrypter>());
                }

                if (ips.Count > 1)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Warning: your computer may be connected in more than one way to a network.  The following IP addresses were detected."); sb.Append(Environment.NewLine);
                    foreach (string s in ips) { sb.Append(s); sb.Append(Environment.NewLine); }
                    sb.Append("If the first one displayed doesn't work when connecting from another computer, try the other(s).");
                    result.Message = sb.ToString();
                }
            }
            catch (CommsSetupShutdownException SdEx)
            {
                result.Message = SdEx.ToString();
            }

            return result;
        }

        


    }

    public class NetworkListenResult
    {
        public string TempServerIP { get; set; }
        public string TempPort { get; set; }
        public string Message { get; set; }
    }

    public class NetworkTestResult
    {
       public Guid TestID { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }
}
