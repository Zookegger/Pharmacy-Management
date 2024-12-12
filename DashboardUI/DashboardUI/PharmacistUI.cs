using DevExpress.DocumentView;
using DevExpress.Utils.Extensions;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardUI
{
    public partial class frm_PharmacistUI : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private Dictionary<string, Form> openForms = new Dictionary<string, Form>();
        protected override bool ExtendNavigationControlToFormTitle
        {
            get { return true; }
        }
        public frm_PharmacistUI()
        {
            InitializeComponent();
            
            LoadForm("Dashboard");
        }

        private void LoadForm(string formName)
        {
            Form form = null;
            switch (formName)
            {
                case "Dashboard":
                    // Kiểm tra xem form nào đang hiện, nếu form chưa có trong map thì tạo cái mới
                    if (!openForms.ContainsKey(formName))
                    {
                        form = new Dashboard();
                    }
                    // Nếu có rồi thì load nó (Mang nó lên trc và để form cũ ra sau)
                    else 
                    {
                        form = openForms[formName];
                        form.BringToFront();
                    }
                    break;
                case "AddMedicine":
                    if (!openForms.ContainsKey(formName))
                    {
                        form = new AddMedicine();
                    }
                    else
                    {
                        form = openForms[formName];
                        form.BringToFront();
                    }
            break;
                // Nếu không tìm thấy form thì báo lỗi
                default:
                    throw new Exception($"Không tìm thấy form {formName}.cs");
            }

            form.TopLevel = false;
            form.Parent = panel_Main;
            form.Dock = DockStyle.Fill;

            openForms[formName] = form;
            
            form.Show();

        }

        private void btn_DashBoard_Click(object sender, EventArgs e)
        {
            try
            {
                LoadForm("Dashboard");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_AddMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                LoadForm("AddMedicine");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SellMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                LoadForm("SellMedicine");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ViewMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                LoadForm("ViewMedicine");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_EditMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                LoadForm("EditMedicine");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void frm_PharmacistUI_Load(object sender, EventArgs e)
        {
            LoadForm("Dashboard");
        }

        private void titlebar_Top_Click(object sender, EventArgs e)
        {

        }
    }
}
