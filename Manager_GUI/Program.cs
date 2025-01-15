using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Manager_GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            Assembly asm = typeof(DevExpress.UserSkins.PharmacistUIColor.PharmacistUIColor).Assembly;
            DevExpress.XtraEditors.WindowsFormsSettings.RegisterUserSkins(asm);
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(asm);
            Application.EnableVisualStyles();
            Application.Run(new frm_ManagerGUI(null));
        }
    }
}
