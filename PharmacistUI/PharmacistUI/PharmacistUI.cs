using DevExpress.XtraEditors;
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

namespace PharmacistUI
{
    public partial class PharmacistUI : DevExpress.XtraEditors.XtraForm
    {
        public PharmacistUI()
        {
            UserLookAndFeel.Default.SkinName = "My Basic";
            InitializeComponent();
            LoadForm("Trang Chủ");
        }

        private void changeTitleName(object sender, EventArgs args)
        {
            AccordionControlElement btn = sender as AccordionControlElement;
            if (btn != null)
                this.Text = btn.Text.ToString();
        }
        // Lưu form mới mở và sử dụng lại thay vì tạo form mới mỗi lần bấm nút
        private Dictionary<string, Form> formCache = new Dictionary<string, Form>();
        private void LoadForm(string formName)
        {
            if (formCache.ContainsKey(formName))
            {
                Form cachedForm = formCache[formName];
                panel_Main.Controls.Clear();
                panel_Main.Controls.Add(cachedForm);
                cachedForm.BringToFront();
                cachedForm.Show();
                return;
            }

            Form form = null;
            switch (formName.ToLower())
            {
                case "trang chủ":
                    form = new Home();
                    break;
                case "thêm thuốc":
                    form = new frm_AddMedicine();
                    break;
                case "xem thuốc":
                    form = new frm_ViewMedicine();
                    break;
                case "chỉnh sửa thuốc":
                    form = new frm_EditMedicine();
                    break;
                default:
                    throw new Exception($"Không tìm thấy chức năng: {formName}");
            }
            form.TopLevel = false;
            form.Parent = panel_Main;
            form.Dock = DockStyle.Fill;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(form);
            formCache[formName] = form;

            form.Show();
            form.Refresh();
        }

        private void btn_SelectFunctions(object sender, EventArgs e)
        {
            AccordionControlElement btn = sender as AccordionControlElement;
            LoadForm(btn.Text);
            changeTitleName(btn, EventArgs.Empty);
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Text = "Bạn có chắc là muốn dăng xuất không";
            args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
            args.Showing += Args_Showing;
            //args.Appearance.Heigh
            DialogResult dr = XtraMessageBox.Show(args);
            if (dr == DialogResult.OK)
                Application.Exit();
        }

        private void Args_Showing(object sender, XtraMessageShowingArgs e)
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

        
    }
}