using DevExpress.XtraEditors;
using Pharmacist;
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
    public partial class frm_ManageBatch : DevExpress.XtraEditors.XtraForm
    {
        private MedicineServices medicineService = new MedicineServices();
        private BatchServices batchService = new BatchServices();
        public frm_ManageBatch()
        {
            InitializeComponent();
        }

        /*------------------------ Event handlers ------------------------*/
        private void HandleException(Exception ex)
        {
            if (ex.InnerException != null && string.IsNullOrEmpty(ex.InnerException.Message))
            {
                ShowErrorMessage(ex.ToString());
            }
            else
            {
                ShowErrorMessage(ex.Message);
            }

            // Print error details to the Debug output
            System.Diagnostics.Debug.WriteLine(ex.ToString());
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Panel panel = sender as Panel; // Make sure it's a Panel
                if (panel != null)
                {
                    TextBox focusedTextBox = panel.Controls.OfType<TextBox>().FirstOrDefault(txt => txt.Focused);
                    System.Diagnostics.Debug.WriteLine($"panel_Paint: {focusedTextBox}");
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
                HandleException(ex);
            }
        }
        // Event handlers for textbox focus, to draw a border around the panel
        private void txt_Enter(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
                System.Diagnostics.Debug.WriteLine($"txt_Enter: {txt}");

                if (txt?.Parent is Panel panel)
                {
                    panel.Invalidate(); // Trigger a repaint of the panel when the textbox gains focus
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
                System.Diagnostics.Debug.WriteLine($"txt_Leave: {txt}");

                if (txt?.Parent is Panel panel)
                {
                    panel.Invalidate(); // Trigger a repaint of the panel when the textbox loses focus
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private bool AreFieldsEmpty()
        {
            if (String.IsNullOrEmpty(txt_BatchId.Text))
            {
                txt_BatchId.Focus();
                return true;
            }
            if (String.IsNullOrEmpty(txt_BatchName.Text))
            {
                txt_BatchName.Focus();
                return true;
            }
            return false;
        }

        private void ValidateInputs(out int quantity)
        {
            quantity = 0;
            // Check if values are valid
            System.Diagnostics.Debug.WriteLine($"BatchID: {txt_BatchId.Text}");
            if (String.IsNullOrEmpty(txt_BatchId.Text))
            {
                txt_BatchId.Focus();
                throw new Exception("Chưa nhập mã lô");
            }

            System.Diagnostics.Debug.WriteLine($"Quantity: {quantity} ({int.TryParse(numUpDown_BatchQuantity.Value.ToString(), out quantity)})");
            if (!int.TryParse(numUpDown_BatchQuantity.Value.ToString(), out quantity))
            {
                numUpDown_BatchQuantity.Focus();
                throw new Exception("Số lượng không hợp lệ");
            }

            System.Diagnostics.Debug.WriteLine($"Production Date: {dateTimePicker_BatchProductionDate.Value}");
            if (dateTimePicker_BatchProductionDate.Value > dateTimePicker_BatchExpirationDate.Value)
            {
                dateTimePicker_BatchProductionDate.Focus();
                throw new Exception("Ngày sản xuất không thể sau ngày hết hạn");
            }

            System.Diagnostics.Debug.WriteLine($"Expiration Date: {dateTimePicker_BatchExpirationDate.Value}");
            if (dateTimePicker_BatchExpirationDate.Value <= DateTime.Now)
            {
                dateTimePicker_BatchExpirationDate.Focus();
                throw new Exception("Ngày hết hạn không thể trước ngày hiện tại");
            }
        }

        private void InsertBatch(int quantity)
        {
            // Insert
            String medicineId = listBox_MedicineNames.SelectedValue.ToString();
            if (String.IsNullOrEmpty(medicineId))
            {
                // Validate selected medicine
                if (String.IsNullOrEmpty(txt_BatchName.Text))
                {
                    System.Diagnostics.Debug.WriteLine($"Selected Medicine Name: {listBox_MedicineNames.SelectedValue}");
                    System.Diagnostics.Debug.WriteLine($"Medicine Name in textbox: {txt_BatchName.Text}");
                    throw new Exception("Vui lòng chọn thuốc");
                } else
                {
                    medicineId = medicineService.GetMedicineByName(txt_BatchName.Text).MaThuoc;
                }
            }
            
            // Create and validate the batch object
            var batch = new LOTHUOC
            {
                MaThuoc = medicineId,
                SoLuong = quantity,
                NgaySanXuat = dateTimePicker_BatchProductionDate.Value,
                NgayHetHan = dateTimePicker_BatchExpirationDate.Value
            };
            if (batch == null)
            {
                System.Diagnostics.Debug.WriteLine($"Oject batch: {batch}");
                throw new Exception($"Object batch is null");
            }

            // Add the new batch
            batchService.AddOrUpdateBatch(batch);
            ShowMessageBox("Thêm lô thuốc thành công", GetIcon("success"));
        }

        private void UpdateBatch(int quantity)
        {
            // Update
            LOTHUOC batch = null;
            if (listBox_MedicineNames.SelectedItems.Count > 0 && !String.IsNullOrEmpty(txt_BatchId.Text))
            {
                batch = new LOTHUOC{
                    MaLo = txt_BatchId.Text,
                    MaThuoc = listBox_MedicineNames.SelectedValue.ToString(),
                    SoLuong = quantity,
                    NgaySanXuat = dateTimePicker_BatchProductionDate.Value,
                    NgayHetHan = dateTimePicker_BatchExpirationDate.Value
                };
            } else
            {
                string medicineId = medicineService.GetMedicineByName(txt_BatchName.Text).MaThuoc;
                batch = new LOTHUOC
                {
                    MaLo = txt_BatchId.Text,
                    MaThuoc = medicineId,
                    SoLuong = quantity,
                    NgaySanXuat = dateTimePicker_BatchProductionDate.Value,
                    NgayHetHan = dateTimePicker_BatchExpirationDate.Value
                };
            }

            System.Diagnostics.Debug.WriteLine($"Batch: {batch}");

            batchService.AddOrUpdateBatch(batch);
            ShowMessageBox("Cập nhật lô thuốc thành công", GetIcon("success"));
        }

        private void btn_InsertUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Validate if required fields are empty
                if (AreFieldsEmpty())
                {
                    throw new Exception("Vui lòng điền đầy đủ thông tin");
                }
                // Check if sender is a valid button
                if (sender as SimpleButton == null)
                {
                    throw new Exception("Invalid sender type");
                }

                // Step 2: Perform input validation for batch details
                int quantity = 0;
                ValidateInputs(out quantity);

                // Step 3: Check if this is an Insert or Update operation based on txt_Id
                if (String.IsNullOrEmpty(txt_BatchId.Text))
                {
                    InsertBatch(quantity);
                }
                else
                {
                    UpdateBatch(quantity);
                }

                string medicineId = string.Empty;
                if (listBox_MedicineNames.SelectedItems.Count > 0 && !String.IsNullOrEmpty(txt_BatchId.Text))
                {
                    medicineId = listBox_MedicineNames.SelectedValue.ToString();
                }
                else
                {
                    medicineId = medicineService.GetMedicineByName(txt_BatchName.Text).MaThuoc;
                }

                // Update the quantity of the medicine
                medicineService.UpdateMedicineQuantity(medicineId, quantity);

                // Step 4: Refresh the batch list in the grid and clear input fields
                List<LOTHUOC> batches = batchService.GetBatchList();
                BindGrid(batches);
                ClearFields();

            } 
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
        private void dgv_Batches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_BatchId.Text = dgv_Batches.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_BatchName.Text = dgv_Batches.Rows[e.RowIndex].Cells[1].Value.ToString();
                
                if (int.TryParse(dgv_Batches.Rows[e.RowIndex].Cells[5].Value.ToString(), out int quantity)) {
                    numUpDown_BatchQuantity.Value = quantity;
                } else
                {
                    throw new Exception("Invalid quantity value");
                }
                System.Diagnostics.Debug.WriteLine($"{dgv_Batches.Rows[e.RowIndex].Cells[3].Value.ToString()} -> {Convert.ToDateTime(dgv_Batches.Rows[e.RowIndex].Cells[3].Value.ToString())}");
                dateTimePicker_BatchProductionDate.Value = Convert.ToDateTime(dgv_Batches.Rows[e.RowIndex].Cells[3].Value.ToString());
                System.Diagnostics.Debug.WriteLine($"{dgv_Batches.Rows[e.RowIndex].Cells[4].Value.ToString()} -> {Convert.ToDateTime(dgv_Batches.Rows[e.RowIndex].Cells[4].Value.ToString())}");
                dateTimePicker_BatchExpirationDate.Value = Convert.ToDateTime(dgv_Batches.Rows[e.RowIndex].Cells[4].Value.ToString());
            } 
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void frm_ManageBatch_Load(object sender, EventArgs e)
        {
            dgv_Batches.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10f, FontStyle.Bold);

            List<LOTHUOC> batches = batchService.GetBatchList();
            BindGrid(batches);
        }
        private void txt_SearchBar_TextChanged(object sender, EventArgs e)
        {
            try
            {

            } catch (Exception ex)
            {
                HandleException(ex);
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
                HandleException(ex);
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
                HandleException(ex);
            }
        }
        private void ClearFields()
        {
            txt_BatchId.Text = string.Empty;
            txt_BatchName.Text = string.Empty;
            numUpDown_BatchQuantity.Value = 0;
            dateTimePicker_BatchProductionDate.Value = DateTime.Now;
            dateTimePicker_BatchExpirationDate.Value = DateTime.Now;
        }

        private void btn_SearchForMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                List<THUOC> medicines = medicineService.GetMedicineList();
                if (medicines == null || medicines.Count == 0)
                {
                    throw new Exception("No medicine found");
                }
                listBox_MedicineNames.DataSource = medicines;
                listBox_MedicineNames.ValueMember = "MaThuoc";
                listBox_MedicineNames.DisplayMember = "TenThuoc";

                // Debug
                System.Diagnostics.Debug.WriteLine($"Medicine Found: {medicines.Count}");
                foreach(var medicine in medicines)
                {
                    System.Diagnostics.Debug.WriteLine(medicine.TenThuoc);
                }
                popupContainer_ListMedicineNames.Show();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void btn_ConfirmSelection_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine($"Selected Item: {listBox_MedicineNames.SelectedItem}");
                int itemIndex = listBox_MedicineNames.SelectedIndex;
                System.Diagnostics.Debug.WriteLine($"Selected Index: {itemIndex}");


                if (listBox_MedicineNames.SelectedItem == null || itemIndex == -1)
                {
                    throw new Exception("No medicine selected");
                }
                
                txt_BatchName.Text = listBox_MedicineNames.GetItemText(itemIndex);
                popupContainer_ListMedicineNames.Hide();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            popupContainer_ListMedicineNames.Hide();
        }
        private void txt_SearchMedicine_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<THUOC> medicines = null;
                if (String.IsNullOrEmpty(txt_SearchMedicine.Text))
                {
                    medicines = medicineService.GetMedicineList();
                } else
                {
                    medicines = medicineService.GetMedicineList(txt_SearchMedicine.Text);
                }
                listBox_MedicineNames.DataSource = medicines;
                listBox_MedicineNames.ValueMember = "MaThuoc";
                listBox_MedicineNames.DisplayMember = "TenThuoc";
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
    }
}
