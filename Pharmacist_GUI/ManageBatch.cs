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
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Pharmacist
{
    public partial class frm_ManageBatch : DevExpress.XtraEditors.XtraForm
    {
        private readonly MedicineServices medicineServices = new MedicineServices();
        private readonly BatchServices batchServices = new BatchServices();
        public frm_ManageBatch()
        {
            InitializeComponent();
            btn_RefreshGrid.LookAndFeel.SetSkinStyle("Flat");
        }

        /*------------------------ Event handlers ------------------------*/
        private void frm_ManageBatch_Load(object sender, EventArgs e)
        {
            List<LOTHUOC> batches = batchServices.GetBatchList();
            BindGrid();
            BindList();
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
        private async void btn_InsertUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Validate if required fields are empty
                // Check if any required fields are left empty. If so, throw an exception with a message.
                if (AreFieldsEmpty())
                {
                    throw new Exception("Vui lòng điền đầy đủ thông tin");
                }

                // Step 2: Validate if the sender is a valid button (Check if sender is of type SimpleButton)
                // Check if sender is a valid button
                if (sender as SimpleButton == null)
                {
                    throw new Exception("Invalid sender type");
                }

                // Step 3: Validate the input fields for batch details (such as quantity)
                int quantity = 0;
                ValidateInputs(out quantity);

                // Step 4: Determine if the operation is Insert or Update based on the button clicked
                SimpleButton button = sender as SimpleButton;
                System.Diagnostics.Debug.WriteLine($"Button: {button.Name}");
                
                if (button == null)
                {
                    throw new Exception("Invalid sender type");
                }
                LOTHUOC batch = batchServices.GetBatchById(txt_BatchId.Text);
                string transactionType = string.Empty;
                // Step 5: Handle Insert or Update operation based on button name
                switch (button.Name)
                {
                    case "btn_Insert":
                        transactionType = "Nhập";
                        // For Insert: Ensure batch ID is not already present in the system
                        if (!String.IsNullOrEmpty(txt_BatchId.Text))
                        {
                            // Check if the batch already exists
                            if (batch != null) // If batch exists, throw error
                            {
                                throw new Exception("Mã lô đã tồn tại");
                            }
                            InsertBatch(quantity, out batch); // Proceed with inserting the batch.
                        } 
                        else
                        {
                            throw new Exception("Chưa nhập mã lô cần thêm");
                        }
                        break;
                    case "btn_Update":
                        DialogResult dr = ShowConfirmationMessage("Bạn có chắc là muốn cập nhật không?");
                        if (dr == DialogResult.Yes)
                        {
                            transactionType = "Cập nhật";
                            // For Update: Ensure batch ID is entered, then check if it exists
                            if (String.IsNullOrEmpty(txt_BatchId.Text)) 
                            {
                                throw new Exception("Chưa nhập mã lô cần cập nhật");
                            }
                            if (batch == null)
                            {
                                throw new Exception("Không tìm thấy lô thuốc cần cập nhật");
                            } 
                            else
                            {
                                UpdateBatch(quantity, out batch);
                            }
                        }
                        else
                        {
                            ShowSuccessMessage("Hủy thành công!");
                            return;
                        }
                        break;
                    default:
                        throw new Exception("Invalid button name");
                }
                /*-------------------------------------------------*/         

                // Step 6: Determine the medicine ID (from either the list box or batch name) and ensure it exists
                string medicineId = string.Empty;
                if (listBox_MedicineNames.SelectedItems.Count > 0 && !String.IsNullOrEmpty(txt_BatchId.Text))
                {
                    // If the medicine is selected in the list box, retrieve its ID.
                    medicineId = listBox_MedicineNames.SelectedValue.ToString();
                }
                else
                {
                    // Otherwise, fetch the medicine by its name entered in the batch name text field
                    medicineId = medicineServices.GetMedicineByName(txt_BatchName.Text).MaThuoc;
                }

                // Step 7: Fetch the medicine by its ID and ensure it exists in the system
                var medicine = medicineServices.GetMedicineById(medicineId);
                if (medicine == null)
                {
                    throw new Exception("Không tìm thấy thuốc");
                }
                /*-------------------------------------------------*/

                // Step 8: Update the quantity of the medicine in the system
                medicineServices.UpdateMedicineQuantity(medicine.MaThuoc, quantity);

                // Step 9: Prompt the user to select a provider for the batch.
                // This ensures that the batch is associated with a provider.
                NHACUNGCAP provider = await GetProviderFromUserAsync();
                if (provider == null)
                {
                    throw new Exception("Vui lòng chọn nhà cung cấp!");
                }
                // Step 10: Add or Update Batch
                batchServices.AddOrUpdateBatch(batch);

                // Step 11: Create new transaction from this batch
                batchServices.CreateNewTransaction(batch, provider, transactionType);

                if (transactionType == "Cập nhật")
                {
                    ShowMessageBox("Cập nhật lô thuốc thành công", GetIcon("success"));
                } else
                {
                    ShowMessageBox("Thêm lô thuốc thành công", GetIcon("success"));
                }

                // Step 10: Refresh the batch list in the grid and clear input fields
                List<LOTHUOC> batches = batchServices.GetBatchList();
                BindGrid();
                ClearFields();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        // Get Batch ID, then use the quantity in the transaction to update quantity then delete from transaction. THEN delete from batch
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = ShowConfirmationMessage("Bạn có chắc là muốn xóa không?");
                if (dr == DialogResult.Yes)
                {
                    // Step 1: Validate if the sender is a valid button (Check if sender is of type SimpleButton)
                    // Check if sender is a valid button
                    if (sender as SimpleButton == null)
                    {
                        throw new Exception("Invalid sender type");
                    }
                    // Step 2: Validate if batch id has been provided
                    if (String.IsNullOrEmpty(txt_BatchId.Text) || txt_BatchId.Text == null)
                    {
                        throw new Exception("Chưa nhập mã lô cần xóa");
                    }
                    // Step 3: Check if information for the batch exists
                    LOTHUOC batch = batchServices.GetBatchById(txt_BatchId.Text);
                    if (batch == null)
                    {
                        throw new Exception("Không tìm thấy lô thuốc cần xóa");
                    }
                    // Step 4: Update quantity on medicine table
                    medicineServices.UpdateMedicineQuantity(batch.MaThuoc, batch.SoLuong * -1);

                    // Step 5: Delete transaction from database
                    batchServices.DeleteTransaction(batch.MaLo);

                    // Step 6: Delete batch from database
                    batchServices.DeleteBatch(batch.MaLo);

                    // Step 7: Confirm and reload grid
                    ShowMessageBox("", GetIcon("success"));
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void btn_SearchForMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                List<THUOC> medicines = medicineServices.GetMedicineList();
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
                    medicines = medicineServices.GetMedicineList();
                } else
                {
                    medicines = medicineServices.GetMedicineList(txt_SearchMedicine.Text);
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
        private void txt_SearchProvider_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<NHACUNGCAP> providers = batchServices.GetProviderList(txt_SearchProvider.Text);
                if (String.IsNullOrEmpty(txt_SearchProvider.Text) || txt_SearchProvider.Text == null)
                {
                    providers = batchServices.GetProviderList();
                }
                listBox_SelectProvider.DataSource = providers;
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
        private void btn_RefreshGrid_Click(object sender, EventArgs e)
        {
            try
            {
                BindGrid();
                ShowSuccessMessage("Dữ liệu đã được cập nhật!");    
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void dgv_Batches_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                txt_BatchId.Text = dgv_Batches.GetRowCellValue(e.RowHandle, "BatchId").ToString();
                txt_BatchName.Text = dgv_Batches.GetRowCellValue(e.RowHandle, "MedicineName").ToString();
                numUpDown_BatchQuantity.Value = int.Parse(dgv_Batches.GetRowCellValue(e.RowHandle, "Quantity").ToString());
                dateTimePicker_BatchProductionDate.Value = Convert.ToDateTime(dgv_Batches.GetRowCellValue(e.RowHandle, "ProdDate"));
                dateTimePicker_BatchExpirationDate.Value = Convert.ToDateTime(dgv_Batches.GetRowCellValue(e.RowHandle, "ExpDate"));
            }
        }

        /*------------------------ Helper methods ------------------------*/
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
        private void ShowSuccessMessage(string message)
        {
            Icon sucessIcon = null;
            try
            {
                sucessIcon = GetIcon("success");
            }
            catch (FileNotFoundException fnfe)
            {
                XtraMessageBox.Show($"Error loading icon{fnfe.Message}");
                sucessIcon = SystemIcons.Error;
            }
            ShowMessageBox(message, sucessIcon);
        }
        private DialogResult ShowConfirmationMessage(string message)
        {
            try
            {
                Icon icon = GetIcon("question");

                XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                args.Text = message;
                args.Buttons = new DialogResult[] { DialogResult.Yes, DialogResult.No };
                args.Showing += Confirm_Args_Showing;
                if (icon != null)
                {
                    args.Icon = icon;
                }
                return XtraMessageBox.Show(args);
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return DialogResult.No;
            }
        }
        private void Confirm_Args_Showing(object sender, XtraMessageShowingArgs e)
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

            // Yes button style
            e.Buttons[DialogResult.Yes].Text = "Xác nhận";
            e.Buttons[DialogResult.Yes].Appearance.FontSizeDelta = 4;
            e.Buttons[DialogResult.Yes].Appearance.FontStyleDelta = FontStyle.Bold;
            e.Buttons[DialogResult.Yes].Padding = new Padding(10); // Vì một nguyên nhân nào đó nó set padding cho cả 2 nút thay vì chỉ set cho chính nó

            // No button style
            e.Buttons[DialogResult.No].Text = "Hủy";
            e.Buttons[DialogResult.No].Appearance.FontSizeDelta = 4;
            e.Buttons[DialogResult.No].Appearance.FontStyleDelta = FontStyle.Bold;
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
        private void BindList()
        {
            listBox_SelectProvider.DataSource = batchServices.GetProviderList();
            listBox_SelectProvider.DisplayMember = "TenNhaCungCap";
            listBox_SelectProvider.ValueMember = "MaNhaCungCap";
        }
        private void BindGrid()
        {
            try
            {
                gridControl.DataSource = batchServices.GetBatchTable();
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
        private void InsertBatch(int quantity, out LOTHUOC newBatch)
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
                }
                else
                {
                    medicineId = medicineServices.GetMedicineByName(txt_BatchName.Text).MaThuoc;
                }
            }

            // Create and validate the batch object
            newBatch = new LOTHUOC
            {
                MaLo = txt_BatchId.Text.ToUpper(),
                MaThuoc = medicineId,
                SoLuong = quantity,
                NgaySanXuat = dateTimePicker_BatchProductionDate.Value,
                NgayHetHan = dateTimePicker_BatchExpirationDate.Value
            };
            if (newBatch == null)
            {
                System.Diagnostics.Debug.WriteLine($"Oject batch: {newBatch}");
                throw new Exception($"Object batch is null");
            }

            batchServices.AddOrUpdateBatch(newBatch);
        }
        private void UpdateBatch(int quantity, out LOTHUOC updatedBatch)
        {
            // Update
            if (listBox_MedicineNames.SelectedItems.Count > 0 && !String.IsNullOrEmpty(txt_BatchId.Text))
            {
                updatedBatch = new LOTHUOC
                {
                    MaLo = txt_BatchId.Text.ToUpper(),
                    MaThuoc = listBox_MedicineNames.SelectedValue.ToString(),
                    SoLuong = quantity,
                    NgaySanXuat = dateTimePicker_BatchProductionDate.Value,
                    NgayHetHan = dateTimePicker_BatchExpirationDate.Value
                };
            }
            else
            {
                string medicineId = medicineServices.GetMedicineByName(txt_BatchName.Text).MaThuoc;
                updatedBatch = new LOTHUOC
                {
                    MaLo = txt_BatchId.Text.ToUpper(),
                    MaThuoc = medicineId,
                    SoLuong = quantity,
                    NgaySanXuat = dateTimePicker_BatchProductionDate.Value,
                    NgayHetHan = dateTimePicker_BatchExpirationDate.Value
                };
            }

            System.Diagnostics.Debug.WriteLine($"Batch: {updatedBatch}");

        }
        private async Task<NHACUNGCAP> GetProviderFromUserAsync()
        {
            // Show popup to select provider
            var providerSelectedEvent = new TaskCompletionSource<bool>();
            NHACUNGCAP selectedProvider = null;

            // Event handler for when the Confirm button is clicked
            btn_ConfỉrmProviderSelection.Click += (s, args) =>
            {
                if (!providerSelectedEvent.Task.IsCompleted)
                {
                    var selected = listBox_SelectProvider.SelectedItem;
                    if (selected != null && selected is NHACUNGCAP)
                    {
                        selectedProvider = selected as NHACUNGCAP;
                        popupContainer_SelectProvider.Hide();

                        // Signal the providerSelectedEvent (set it to true) so that the waiting thread can proceed
                        providerSelectedEvent.SetResult(true);
                    }
                    else
                    {
                        providerSelectedEvent.SetResult(false);
                        throw new Exception("Vui lòng chọn nhà cung cấp!");
                    }
                }
            };

            // Event handler for when the Cancel button is clicked
            btn_CancelProvider.Click += (s, args) =>
            {
                if (!providerSelectedEvent.Task.IsCompleted)
                {
                    if (popupContainer_SelectProvider.Visible)
                    {
                        popupContainer_SelectProvider.Hide();
                        providerSelectedEvent.SetResult(false);
                        throw new Exception("Hủy xử lý thành công");
                    }
                }
            };
            popupContainer_SelectProvider.Show();
            // Wait for the providerSelectedEvent to be set (i.e., the user has confirmed a selection)
            // The thread will pause here until the user selects a provider and clicks "Confirm"
            await providerSelectedEvent.Task;

            return selectedProvider;
        }
    }
}
