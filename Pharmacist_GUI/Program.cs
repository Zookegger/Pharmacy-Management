using DevExpress.LookAndFeel;
using DevExpress.LookAndFeel.Design;
using DevExpress.Skins;
using DevExpress.Skins.Info;
using DevExpress.UserSkins;
using DevExpress.UserSkins.PharmacistUIColor;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Pharmacist
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // If your custom skin is derived from a template skin that resides in the BonusSkins library, ensure that you register the template skin first using the BonusSkins.Register method.  
            DevExpress.UserSkins.BonusSkins.Register();  
            Assembly asm = typeof(DevExpress.UserSkins.PharmacistUIColor.PharmacistUIColor).Assembly;
            DevExpress.XtraEditors.WindowsFormsSettings.RegisterUserSkins(asm);
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(asm);
            Application.EnableVisualStyles();
            Application.Run(new frm_PharmacistGUI(null));
        }
    }
}