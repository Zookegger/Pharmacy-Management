﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.UserSkins.PharmacistUIColor;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Navigation;
using PharmacistUI;
using PharmacistUI.Properties;
using System.IO;
using DevExpress.Utils.Svg;

namespace PharmacistUI
{
    public partial class PharmacistUI : DevExpress.XtraEditors.XtraForm
    {
        public PharmacistUI()
        {
            UserLookAndFeel.Default.SkinName = "My Basic";
            InitializeComponent();
            //LoadForm("Trang Chủ");
        }

        private void changeTitleName(object sender, EventArgs args)
        {
            // Get button's text as title
            AccordionControlElement btn = sender as AccordionControlElement;
            if (btn != null)
                this.Text = btn.Text.ToString();
        }
        // Initialize form cache for reopening old form instead of making a new form every single time it opens
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
                case "accordionControlElement_Home":
                    form = new Home();
                    break;
                case "accordionControlElement_AddMedicine":
                    form = new frm_AddMedicine();
                    break;
                case "accordionControlElement_SellMedicine":
                    form = new frm_SellMedicine();
                    break;
                case "accordionControlElement_ViewMedicine":
                    form = new frm_ViewMedicine();
                    break;
                case "accordionControlElement_EditMedicine":
                    form = new frm_EditMedicine();
                    break;
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

        private void btn_SelectFunctions(object sender, EventArgs e)
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
    }
}