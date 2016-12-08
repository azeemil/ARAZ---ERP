using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraPrinting.Preview;
using ERP.General;

namespace ERP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        
        {
            PrintDialogRunner.Instance = new SystemPrintDialogRunner();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
           SignOut:
            Variables.ExitMode = true;
            CheckSkinProperty:if (string.IsNullOrEmpty(Registr.GetSkin()))
            
            {
                Registr.SetSkin("Metropolis");
                goto CheckSkinProperty;
            }
            UserLookAndFeel.Default.SetSkinStyle(Registr.GetSkin());
            var loginPanel = new LoginPanel();
            if (loginPanel.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
               
            Application.Run(new MainForm());
            if (!Variables.ExitMode) goto SignOut;


        }
    }
}
