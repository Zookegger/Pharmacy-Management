using DevExpress.XtraEditors;
using Pharmacist_BUS;
using PharmacistManagement_DAL.Model;
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

namespace Pharmacist
{
    public partial class frm_ManageBatch : Form
    {
        private MedicineService medicineService = new MedicineService();
        private BatchServices batchService = new BatchServices();
        public frm_ManageBatch()
        {
            InitializeComponent();
        }

        /*------------------------ Event handlers ------------------------*/
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Panel panel = sender as Panel; // Make sure it's a Panel
                if (panel != null)
                {
                    TextBox focusedTextBox = panel.Controls.OfType<TextBox>().FirstOrDefault(txt => txt.Focused);
                    System.Diagnostics.Debug.WriteLine(focusedTextBox);
                    if (focusedTextBox != null)
                    {
                        ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
                    }
                    else
                    {
                        ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, this.BackColor, ButtonBorderStyle.Solid);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && String.IsNullOrEmpty(ex.InnerException.Message))
                {
                    ShowErrorMessage(ex.ToString());
                }
                else
                {
                    ShowErrorMessage(ex.Message);
                }
                // Print to Output stream
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        // Event handlers for textbox focus, to draw a border around the panel
        private void txt_Enter(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
                System.Diagnostics.Debug.WriteLine(txt);

                if (txt?.Parent is Panel panel)
                {
                    panel.Invalidate(); // Trigger a repaint of the panel when the textbox gains focus
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && String.IsNullOrEmpty(ex.InnerException.Message))
                {
                    ShowErrorMessage(ex.ToString());
                }
                else
                {
                    ShowErrorMessage(ex.Message);
                }
                // Print to Output stream
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
                System.Diagnostics.Debug.WriteLine(txt);

                if (txt?.Parent is Panel panel)
                {
                    panel.Invalidate(); // Trigger a repaint of the panel when the textbox loses focus
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && String.IsNullOrEmpty(ex.InnerException.Message))
                {
                    ShowErrorMessage(ex.ToString());
                }
                else
                {
                    ShowErrorMessage(ex.Message);
                }
                // Print to Output stream
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        private void btn_InsertUpdate_Click(object sender, EventArgs e)
        {

        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
        private void dgv_Batches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_Id.Text = dgv_Batches.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_Name.Text = dgv_Batches.Rows[e.RowIndex].Cells[1].Value.ToString();
                
                if (int.TryParse(dgv_Batches.Rows[e.RowIndex].Cells[5].Value.ToString(), out int quantity)) {
                    numUpDown_Quantity.Value = quantity;
                } else
                {
                    throw new Exception("Invalid quantity value");
                }
                System.Diagnostics.Debug.WriteLine($"{dgv_Batches.Rows[e.RowIndex].Cells[3].Value.ToString()} -> {Convert.ToDateTime(dgv_Batches.Rows[e.RowIndex].Cells[3].Value.ToString())}");
                dateTimePicker_ProductionDate.Value = Convert.ToDateTime(dgv_Batches.Rows[e.RowIndex].Cells[3].Value.ToString());
                System.Diagnostics.Debug.WriteLine($"{dgv_Batches.Rows[e.RowIndex].Cells[4].Value.ToString()} -> {Convert.ToDateTime(dgv_Batches.Rows[e.RowIndex].Cells[4].Value.ToString())}");
                dateTimePicker_ExpirationDate.Value = Convert.ToDateTime(dgv_Batches.Rows[e.RowIndex].Cells[4].Value.ToString());
            } 
            catch (Exception ex)
            {
                if (ex.InnerException != null && String.IsNullOrEmpty(ex.InnerException.Message))
                {
                    ShowErrorMessage(ex.ToString());
                }
                else
                {
                    ShowErrorMessage(ex.Message);
                }
                // Print to Output stream
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        private void frm_ManageBatch_Load(object sender, EventArgs e)
        {
            List<LOTHUOC> batches = batchService.GetBatchList();
            BindGrid(batches);
        }
        private void txt_SearchBar_TextChanged(object sender, EventArgs e)
        {
            try
            {

            } catch (Exception ex)
            {
                if (ex.InnerException != null && String.IsNullOrEmpty(ex.InnerException.Message))
                {
                    ShowErrorMessage(ex.ToString());
                }
                else
                {
                    ShowErrorMessage(ex.Message);
                }
                // Print to Output stream
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }


        /*------------------------ Helper methods ------------------------*/
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
            try
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
            catch (Exception ex)
            {
                if (ex.InnerException != null && String.IsNullOrEmpty(ex.InnerException.Message))
                {
                    ShowErrorMessage(ex.ToString());
                }
                else
                {
                    ShowErrorMessage(ex.Message);
                }
                // Print to Output stream
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        private void ShowErrorMessage(string errorMessage)
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
            ShowMessageBox(errorMessage, errorIcon);
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
        private void BindGrid(List<LOTHUOC> batches)
        {
            try
            {
                dgv_Batches.Rows.Clear();
                foreach (LOTHUOC batch in batches)
                {
                    int rowIndex = dgv_Batches.Rows.Add();
                    dgv_Batches.Rows[rowIndex].Cells[0].Value = batch.MaLo;
                    String medicineName = medicineService.GetMedicineById(batch.MaThuoc).TenThuoc;
                    dgv_Batches.Rows[rowIndex].Cells[1].Value = medicineName;

                    var provider = batchService.GetProvider(batch.MaThuoc);
                    dgv_Batches.Rows[rowIndex].Cells[2].Value = provider != null ? provider.TenNhaCungCap.ToString() : "";
                    dgv_Batches.Rows[rowIndex].Cells[3].Value = batch.NgaySanXuat.ToShortDateString();
                    dgv_Batches.Rows[rowIndex].Cells[4].Value = batch.NgayHetHan.ToShortDateString();
                    dgv_Batches.Rows[rowIndex].Cells[5].Value = batch.SoLuong;
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && String.IsNullOrEmpty(ex.InnerException.Message))
                {
                    ShowErrorMessage(ex.ToString());
                }
                else
                {
                    ShowErrorMessage(ex.Message);
                }
                // Print to Output stream
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        private void ClearFields()
        {
            txt_Id.Text = string.Empty;
            txt_Name.Text = string.Empty;
            numUpDown_Quantity.Value = 0;
            dateTimePicker_ProductionDate.Value = DateTime.Now;
            dateTimePicker_ExpirationDate.Value = DateTime.Now;
        }

    }
}
