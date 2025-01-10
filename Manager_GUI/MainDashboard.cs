using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manager_GUI
{
    public partial class frm_ManagerGUI : DevExpress.XtraEditors.XtraForm
    {
        public frm_ManagerGUI()
        {
            UserLookAndFeel.Default.SkinName = "My Basic";
            InitializeComponent();
        }

        private void frm_ManagerGUI_Load(object sender, EventArgs e)
        {
            // Uncomment these lines to test loading the form on load
             accordionControl_SidePanel.AllowItemSelection = true;
             accordionControl_SidePanel.SelectedElement = accordionControlElement_Bill;
             LoadForm("accordionControlElement_Bill");
        }

        private void changeTitleName(object sender, EventArgs args)
        {
            // Get button's text as title
            AccordionControlElement btn = sender as AccordionControlElement;
            if (btn != null)
                this.Text = btn.Text.ToString();
        }

        private Dictionary<string, Form> formCache = new Dictionary<string, Form>();

        private void LoadForm(string btnName)
        {
            // If form is already open before, bring it to front instead of creating a new one
            if (formCache.ContainsKey(btnName))
            {
                Form cachedForm = formCache[btnName];
                panel_Main.Controls.Clear();
                panel_Main.Controls.Add(cachedForm);
                cachedForm.BringToFront();
                cachedForm.Show();
                return;
            }

            // Initialize form selector
            Form form = null;

            // Select and add new form
            switch (btnName)
            {
                case "accordionControlElement_Bill":
                    form = new frm_BillingAnalytics();
                    break;
                case "accordionControlElement_personnel":
                    form = new frm_Personel();
                    break;
                // Add other cases here if needed
                default:
                    throw new Exception($"Không tìm thấy form: frm_{btnName.Substring(24)}");
            }

            // Put form into main panel
            form.TopLevel = false;
            form.Parent = panel_Main;
            form.Dock = DockStyle.Fill;

            // Clear everything on panel before adding new form
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(form);

            // Load current form into cache for later usage
            formCache[btnName] = form;

            // Show form
            form.Show();
            form.Refresh();
        }

        private void btn_SelectFunctions(object sender, EventArgs e)
        {
            // Example of how to call LoadForm
            LoadForm("accordionControlElement_Bill");
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            // Spawn XtraMessagebox
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Text = "Bạn có chắc là muốn dăng xuất không";
            args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
            args.Showing += LogOut_Args_Showing;

            // Get Result
            DialogResult dr = XtraMessageBox.Show(args);
            if (dr == DialogResult.OK)
                Application.Exit();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            // Example of how to call LoadForm
            LoadForm("accordionControlElement_Bill");
        }

        private void accordionControlElement_Bill_Click(object sender, EventArgs e)
        {
            // Example of how to call LoadForm
            LoadForm("accordionControlElement_Bill");
        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Custom paint logic for panel_Main
        }

        private void Error_Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            // MessageBox Appearance
            e.MessageBoxForm.StartPosition = FormStartPosition.CenterParent;
            e.MessageBoxForm.FormBorderStyle = FormBorderStyle.None;
            e.MessageBoxForm.Appearance.BackColor = ColorTranslator.FromHtml("#d6d6d6");
            e.MessageBoxForm.Appearance.FontStyleDelta = FontStyle.Bold;
            e.MessageBoxForm.Appearance.FontSizeDelta = 4;

            // Error Message style
            e.MessageBoxForm.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            e.MessageBoxForm.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;

            // Ok button style
            e.Buttons[DialogResult.OK].Text = "OK";
            e.Buttons[DialogResult.OK].Appearance.FontSizeDelta = 4;
            e.Buttons[DialogResult.OK].Appearance.FontStyleDelta = FontStyle.Bold;
            e.Buttons[DialogResult.OK].Padding = new Padding(10);
        }

        private void LogOut_Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            // Main form style
            e.MessageBoxForm.StartPosition = FormStartPosition.CenterParent;
            e.MessageBoxForm.FormBorderStyle = FormBorderStyle.None;
            e.MessageBoxForm.Appearance.BackColor = ColorTranslator.FromHtml("#d6d6d6");
            e.MessageBoxForm.Appearance.FontStyleDelta = FontStyle.Bold;
            e.MessageBoxForm.Appearance.FontSizeDelta = 4;

            // Text Message style
            e.MessageBoxForm.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            e.MessageBoxForm.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;

            // Ok button style
            e.Buttons[DialogResult.OK].Text = "Đăng xuất";
            e.Buttons[DialogResult.OK].Appearance.FontSizeDelta = 4;
            e.Buttons[DialogResult.OK].Appearance.FontStyleDelta = FontStyle.Bold;
            e.Buttons[DialogResult.OK].Padding = new Padding(10); // Vì một nguyên nhân nào đó nó set padding cho cả 2 nút thay vì chỉ set cho chính nó

            // Cancel button style
            e.Buttons[DialogResult.Cancel].Text = "Hủy";
            e.Buttons[DialogResult.Cancel].Appearance.FontSizeDelta = 4;
            e.Buttons[DialogResult.Cancel].Appearance.FontStyleDelta = FontStyle.Bold;
        }

        private void btn_bill(object sender, EventArgs e)
        {
            try
            {
                // Get Selected Option
                AccordionControlElement btn = sender as AccordionControlElement;
                // Load corresponding form
                LoadForm(btn.Name.ToString());
                // Change form's title
                changeTitleName(btn, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Icon errorIcon = null;
                try
                {
                    errorIcon = GetIcon("error");
                }
                catch (FileNotFoundException fnfe)
                {
                    XtraMessageBox.Show($"Error loading icon{fnfe.Message}");
                    errorIcon = SystemIcons.Error;
                }
                ShowMessageBox(ex.Message, errorIcon);
            }
        }

        private Icon GetIcon(string iconName)
        {
            string iconPath = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..")), $"icon/{iconName}_icon.ico");

            if (File.Exists(iconPath))
            {
                return new Icon(iconPath);
            }
            else
            {
                throw new FileNotFoundException($"Icon file {iconName}_icon.ico not found in icon directory");
            }
        }

        private void ShowMessageBox(String message, Icon icon = null) // set to = null or any default value to accept only 1 provided parameter
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Text = message;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            args.Showing += Error_Args_Showing;
            if (icon != null)
            {
                args.Icon = icon;
            }
            XtraMessageBox.Show(args);
        }

        private void btn_Personel(object sender, EventArgs e)
        {
            try
            {
                // Get Selected Option
                AccordionControlElement btn = sender as AccordionControlElement;
                // Load corresponding form
                LoadForm(btn.Name.ToString());
                // Change form's title
                changeTitleName(btn, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Icon errorIcon = null;
                try
                {
                    errorIcon = GetIcon("error");
                }
                catch (FileNotFoundException fnfe)
                {
                    XtraMessageBox.Show($"Error loading icon{fnfe.Message}");
                    errorIcon = SystemIcons.Error;
                }
                ShowMessageBox(ex.Message, errorIcon);
            }
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {

        }
    }
}


