using SAR_Sign_In_Assist.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAR_Sign_In_Assist
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            generalOptionsService = new GeneralOptionsService(true);
            signInListService = new SignInListService();
            ICAClassLibrary.Globals._generalOptionsService = generalOptionsService;
            fileManagementService = new FileManagementService();
            networkService = new NetworkService();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInList());
        }

        private static GeneralOptionsService _generalOptionsService = null;
        private static SignInListService _signInListService = null;
        private static FileManagementService _fileManagementService = null;
        private static NetworkService _networkService = null;
        public static GeneralOptionsService generalOptionsService { get => _generalOptionsService; private set => _generalOptionsService = value; }
        public static SignInListService signInListService { get => _signInListService; private set => _signInListService = value; }
        public static FileManagementService fileManagementService { get => _fileManagementService; private set => _fileManagementService = value; }
        public static NetworkService networkService { get => _networkService; private set => _networkService = value; }
        
        //netowrk stuff
        private static string _encryptionKey = "b504f478-23c1-4d57-8a4d-31a9ca372209";
        public static string EncryptionKey { get => _encryptionKey; set => _encryptionKey = value; }



        private static bool _ThisMachineIsClient = false;
        public static bool ThisMachineIsClient { get => _ThisMachineIsClient; set => _ThisMachineIsClient = value; }
        private static string _ServerIP;
        public static string ServerIP { get => _ServerIP; set => _ServerIP = value; }
        private static string _ServerPortStr;
        public static string ServerPortStr { get => _ServerPortStr; set => _ServerPortStr = value; }
        private static bool _AutomaticallySendToICA = false;
        public static bool AutomaticallySendToICA { get => _AutomaticallySendToICA; set => _AutomaticallySendToICA = value; }
    }
}
