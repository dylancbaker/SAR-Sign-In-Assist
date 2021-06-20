using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using NetworkCommsDotNet.DPSBase;
using ICAClassLibrary;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ICAClassLibrary.Models;
using System.Collections.Generic;
using SAR_Sign_In_Assist.Services;
using static SAR_Sign_In_Assist.Services.NetworkService;

namespace SAR_Sign_In_Assist
{
    public partial class NetworkSettings : Form
    {
        public NetworkSettings()
        {
            InitializeComponent();
        }

        int preferredPort = 42999;
        private string tempServerIP = null; private string tempPort = null;


        private void btnImportCoordinatesHelp_Click(object sender, EventArgs e)
        {
            HelpInfo info = new HelpInfo();
            if (info.loadByTopic("NetworkSettings"))
            {
                using (BasicHelpInfo help = new BasicHelpInfo())
                {
                    help.Title = info.Title;
                    help.Body = info.Body;
                    help.ShowDialog();
                }
            }
        }

        private void rbStandalone_CheckedChanged(object sender, EventArgs e)
        {
            pnlClientSettings.Enabled = false; pnlClientSettings.BackColor = SystemColors.Control;
           // pnlServerInfo.Enabled = false; pnlServerInfo.BackColor = SystemColors.Control;
            //lblServerInfo.Text = "--";
        }

        private void rbClient_CheckedChanged(object sender, EventArgs e)
        {
            pnlClientSettings.Enabled = true; pnlClientSettings.BackColor = Color.White;
           // pnlServerInfo.Enabled = false; pnlServerInfo.BackColor = SystemColors.Control;
           // lblServerInfo.Text = "--";
            RijndaelPSKEncrypter.AddPasswordToOptions(NetworkComms.DefaultSendReceiveOptions.Options, Program.EncryptionKey);
            if (!NetworkComms.DefaultSendReceiveOptions.DataProcessors.Contains(DPSManager.GetDataProcessor<RijndaelPSKEncrypter>()))
            {
                NetworkComms.DefaultSendReceiveOptions.DataProcessors.Add(DPSManager.GetDataProcessor<RijndaelPSKEncrypter>());
            }
            NetworkComms.Shutdown();

            NetworkListenResult result = Program.networkService.startListening();
            if (!string.IsNullOrEmpty(result.Message)) { MessageBox.Show(result.Message); }
            else
            {
                tempPort = result.TempPort;
                tempServerIP = result.TempServerIP;
            }

            NetworkComms.Shutdown();

            GeneralOptions options = Program.generalOptionsService.GetGeneralOptions();
            txtServerIP.Text = options.LastServerIP;
            txtServerPort.Text = options.LastPort.ToString();
            txtServerIP.Focus();
        }

        

      
        private void txtServerIP_TextChanged(object sender, EventArgs e)
        {

        }


        

        private void NetworkSettings_Load(object sender, EventArgs e)
        {
            GeneralOptions options = Program.generalOptionsService.GetGeneralOptions();
            preferredPort = options.DefaultPortNumber;
            txtServerPort.Text = preferredPort.ToString(); 
            rbClient.Checked = Program.ThisMachineIsClient;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close                ();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Program.ThisMachineIsClient = rbClient.Checked;

            if (rbClient.Checked)
            {
                int port = 0;
                _ = int.TryParse(txtServerPort.Text, out port);
                bool firewallEnabled = Program.networkService.GetIsFirewallEnabled();
                bool portAvailable = Program.networkService.GetIsPortAvailable(port);

                if (firewallEnabled && !portAvailable)
                {
                    MessageBox.Show("A firewall may be blocking this application. Please try an alternate port, or make an exception in your firewall to allow this program to operate over a network.");
                }

                NetworkComms.Shutdown();
                Program.ServerIP = txtServerIP.Text;
                Program.ServerPortStr = txtServerPort.Text;
                GeneralOptions options = Program.generalOptionsService.GetGeneralOptions();

                options.LastServerIP = Program.ServerIP;
                options.LastPort =Program.ServerPortStr;
                Program.generalOptionsService.SaveGeneralOptions(options);
                DateTime today = DateTime.Now;
                //parent.addToNetworkLog(string.Format("{0:HH:mm:ss}", today) + " - Attempting to connect to server " + parent.ServerIP + "\r\n");
            }
            else
            {
                DateTime today = DateTime.Now;
               // parent.addToNetworkLog(string.Format("{0:HH:mm:ss}", today) + " - end network communications and work stand-alone" + "\r\n");
                NetworkComms.Shutdown();
                Program.ServerIP = null;
                Program.ServerPortStr = null;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
