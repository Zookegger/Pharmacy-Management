using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.OpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacistUI
{
    public delegate void AddMedicineDelegate(String id, String name, int amount, long price, DateTime prodDate, DateTime expDate);
    public partial class frm_AddMedicine : Form
    {
        public AddMedicineDelegate OnAddMedicine;
        public frm_AddMedicine()
        {
            InitializeComponent();
        }

        private void frm_AddMedicine_Load(object sender, EventArgs e)
        {
            dgv_Medicine.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12);

            foreach (Control control in this.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control childControl in panel.Controls)
                    {
                        if (childControl is TextBox || childControl is RichTextBox)
                        {
                            childControl.Enter += Control_Enter;
                            childControl.Leave += Control_Leave;
                        }
                    }
                }
            }
        }

        private void Control_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Focused");
            if (sender is Control)
            {
                (sender as Control).Parent?.Invalidate();
            }
        }

        private void Control_Leave(object sender, EventArgs e)
        {
            if (sender is Control)
            {
                (sender as Control).Parent?.Invalidate();
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                TextBox focusedTextBox = panel.Controls.OfType<TextBox>().FirstOrDefault(txt => txt.Focused);
                if (focusedTextBox != null)
                {
                    ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
                }
                else
                {
                    RichTextBox focusedRichTextBox = panel.Controls.OfType<RichTextBox>().FirstOrDefault(richTxt => richTxt.Focused);
                
                    if (focusedRichTextBox != null)
                    {
                        ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
                    } 
                    else
                    {
                        ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, this.BackColor, ButtonBorderStyle.Solid);
                    }
                }
            }
        }

        private void txtbox_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt?.Parent is Panel panel)
            {
                panel.Invalidate(); // Trigger a repaint of the panel when the textbox gains focus
            }
        }

        private void txtbox_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt?.Parent is Panel panel)
            {
                panel.Invalidate(); // Trigger a repaint of the panel when the textbox loses focus
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

        private void addMedicine()
        {
            try
            {
                //String id = txt_Id.Text,
                //       name = txt_Name.Text;
                //int amount = 0;
                //long price = 0;
                //DateTime prodDate = dateTimePicker_ProductionDate.Value,
                //         expDate = dateTimePicker_ExpirationDate.Value;

                //if (String.IsNullOrEmpty(id))
                //{
                //    txt_Id.Focus();
                //    throw new Exception($"{label_ID.Text} không được bỏ trống!");
                //}
                //if (String.IsNullOrEmpty(name)) 
                //{
                //    txt_Name.Focus();
                //    throw new Exception($"{label_Name.Text} không được bỏ trống!");
                //}

                //if (!int.TryParse(txt_Amount.Text, out amount))
                //{
                //    txt_Amount.Focus();
                //    throw new Exception($"Giá trị vùng {label_Amount.Text} không hợp lệ!");
                //}
                //if (!long.TryParse(txt_PricePerUnit.Text, out price))
                //{
                //    txt_PricePerUnit.Focus();
                //    throw new Exception($"Giá trị vùng {label_PricePerUnit.Text} không hợp lệ!");
                //}
                //if (expDate <= DateTime.Now)
                //{
                //    throw new Exception($"Thuốc hết hạn sử dụng!");
                //}
                //if (prodDate > DateTime.Now)
                //{
                //    throw new Exception($"Ngày sản xuất không hợp lệ!");
                //}
                //OnAddMedicine?.Invoke(id, name, amount, price, prodDate, expDate);
                //ShowMessageBox("Thêm thuốc thành công!", GetIcon("success"));
            }
            catch (Exception ex)
            {
                ShowMessageBox(ex.Message.ToString(), GetIcon("error"));
            }
        }

        private void Add_Args_Showing(object sender, XtraMessageShowingArgs e)
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            addMedicine();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                addMedicine();
            }
            if (keyData == (Keys.F4))
            {
                Reload();
            }
            return base.ProcessCmdKey(ref msg, keyData); 
        }

        private void Reload()
        {
            //txt_Id.Text = string.Empty;
            //txt_Name.Text = string.Empty;
            //txt_Amount.Text = "0";
            //txt_PricePerUnit.Text = "0";
            //dateTimePicker_ProductionDate.Value = DateTime.Now;
            //dateTimePicker_ExpirationDate.Value = DateTime.Now;
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            try
            {
                Reload();
                ShowMessageBox("Tải lại thành công");
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
        private void View_Args_Showing(object sender, XtraMessageShowingArgs e)
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
            e.Buttons[DialogResult.OK].Text = "OK";
            e.Buttons[DialogResult.OK].Appearance.FontSizeDelta = 4;
            e.Buttons[DialogResult.OK].Appearance.FontStyleDelta = FontStyle.Bold;
        }

        
    }
}
