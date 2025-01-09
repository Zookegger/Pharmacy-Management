using DevExpress.XtraEditors;
using Login_BUS;
using PharmacistUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Login
{
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        private LoginServices loginServices = new LoginServices();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            try
            {
                XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                args.Text = "Bạn có chắc là muốn thoát không";
                args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
                args.Showing += Exit_Args_Showing;

                // Get Result
                DialogResult dr = XtraMessageBox.Show(args);
                if (dr == DialogResult.OK)
                    Application.Exit();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = !txt_Password.UseSystemPasswordChar;
            } else
            {
                txt_Password.UseSystemPasswordChar = !txt_Password.UseSystemPasswordChar;
            }
        }

        private void Exit_Args_Showing(object sender, XtraMessageShowingArgs e)
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
            e.Buttons[DialogResult.OK].Text = "Thoát";
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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                String username = txt_Username.Text, password = txt_Password.Text;
                if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                {
                    throw new Exception("Vui lòng nhập tên tài khoản và mật khẩu");
                }

                bool isLoginSuccess = loginServices.Login(txt_Username.Text, txt_Password.Text);
                if (isLoginSuccess)
                {
                    frm_PharmacistGUI pharmacistGUI = new frm_PharmacistGUI();
                    pharmacistGUI.FormClosed += (s, args) => this.Close();
                    pharmacistGUI.Show();
                    this.Hide();
                }
                else
                {
                    XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                    args.Text = "Tên tài khoản hoặc mật khẩu không hợp lệ";
                    args.Buttons = new DialogResult[] { DialogResult.OK};
                    args.Showing += Error_Args_Showing;
                    XtraMessageBox.Show(args);
                }
            } 
            catch (Exception ex)
            {
                XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                args.Text = ex.Message;
                args.Buttons = new DialogResult[] { DialogResult.OK };
                args.Showing += Error_Args_Showing;
                XtraMessageBox.Show(args);
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
        }
    }
}
