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


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInList());
        }

        private static GeneralOptionsService _generalOptionsService = null;
        private static SignInListService _signInListService = null;
        public static GeneralOptionsService generalOptionsService { get => _generalOptionsService; private set => _generalOptionsService = value; }
        public static SignInListService signInListService { get => _signInListService; private set => _signInListService = value; }
    }
}
