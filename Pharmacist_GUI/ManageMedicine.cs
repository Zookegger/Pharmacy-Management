using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Accessibility;
using DevExpress.XtraRichEdit.Import.OpenXml;
using Pharmacist;
using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Threading;
using static DevExpress.DataProcessing.InMemoryDataProcessor.AddSurrogateOperationAlgorithm;

namespace Pharmacist
{
    public partial class frm_ManageMedicine : DevExpress.XtraEditors.XtraForm
    {
        private readonly MedicineServices medicineService = new MedicineServices();
        private readonly BatchServices batchServices = new BatchServices();

        public frm_ManageMedicine()
        {
            InitializeComponent();
        }
        // Event handlers
        private void frm_ManageMedicine_Load(object sender, EventArgs e)
        {
            try
            {
                // Add event handlers to all TextBox and RichTextBox controls within the form
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
                BindGrid();
            } 
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void Control_Enter(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Focused");
                if (sender is Control)
                {
                    (sender as Control).Parent?.Invalidate();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void Control_Leave(object sender, EventArgs e)
        {
            try 
            { 
                if (sender is Control)
                {
                    (sender as Control).Parent?.Invalidate();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void txtbox_Enter(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
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
        private void txtbox_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
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
        private void btn_InsertUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleButton button = sender as SimpleButton;
                if (button == null)
                {
                    throw new NullReferenceException();
                }
                
                ValidateInputs(out String id, out String name, out String dosage, out String description, out int pricePerUnit);

                THUOC medicine = new THUOC()
                {
                    MaThuoc = id.ToUpper(),
                    TenThuoc = name,
                    LieuThuoc = dosage,
                    MoTa = description,
                    GiaDonVi = pricePerUnit,
                    SoLuongTon = 0
                };

                switch (button.Name)
                {
                    // Add new medicine
                    case "btn_Add":
                        InsertMedicine(medicine);
                        break;

                    // Update existing medicine
                    case "btn_Update":
                        UpdateMedicine(medicine);
                        break;
                    default:
                        break;
                }

                BindGrid();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string medicineId = txt_Id.Text;
                if (!String.IsNullOrEmpty(medicineId))
                {
                    THUOC medicine = medicineService.GetMedicineById(medicineId);
                    DeleteMedicine(medicine);
                }
                else
                {
                    throw new Exception("Vui lòng chọn thuốc cần xóa!");
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationError in ex.EntityValidationErrors)
                {
                    foreach (var error in validationError.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine($"Property: {error.PropertyName}, Error: {error.ErrorMessage}");
                    }
                }
                System.Diagnostics.Debug.WriteLine($"DbEntityValidationException: {ex.ToString()}");
                throw new Exception(ex.ToString()); // Re-throw the exception if needed
            }
            catch (Exception ex)
            {
                if (String.IsNullOrEmpty(ex.InnerException?.Message))
                    ShowErrorMessage(ex.Message);
                else
                    ShowErrorMessage(ex.InnerException?.Message);
                System.Diagnostics.Debug.WriteLine($"Exception: {ex.ToString()}");
            }
        }
        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    txt_Id.Text = gridView.GetRowCellValue(e.RowHandle, "Mã Thuốc").ToString();
                    System.Diagnostics.Debug.WriteLine($"Medicine ID: {label_ID.Text}: {txt_Id.Text}");

                    txt_Name.Text = gridView.GetRowCellValue(e.RowHandle, "Tên Thuốc").ToString();
                    System.Diagnostics.Debug.WriteLine($"Medicine Name: {label_Name.Text}: {txt_Name.Text}");

                    txt_Dosage.Text = gridView.GetRowCellValue(e.RowHandle, "Liều Thuốc").ToString();
                    System.Diagnostics.Debug.WriteLine($"Medicine Dosage: {label_Dosage.Text}: {txt_Dosage.Text}");

                    txt_PricePerUnit.Text = gridView.GetRowCellValue(e.RowHandle, "Giá Đơn Vị").ToString();
                    System.Diagnostics.Debug.WriteLine($"Price: {label_PricePerUnit.Text}: {txt_PricePerUnit.Text}");

                    txt_Description.Text = gridView.GetRowCellValue(e.RowHandle, "Mô Tả").ToString();
                    System.Diagnostics.Debug.WriteLine($"Medicine Description: {label_Description.Text}: {txt_Description.Text}");
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void btn_ClearFields_Click(object sender, EventArgs e)
        {
            try
            {
                ClearText();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
        private void btn_RefreshGrid_Click(object sender, EventArgs e)
        {
            try
            {
                BindGrid();
                ShowSuccessMessage("Dữ liệu đã được cập nhật!");
            } catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        // Custom message box
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
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Icon icon = null;
                //Icon icon = GetIcon("question");

                XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                args.Text = message;
                args.Buttons = new DialogResult[] { DialogResult.Yes, DialogResult.No };
                args.Showing += Confirm_Args_Showing;
                if (icon != null)
                {
                    args.Icon = icon;
                }
                XtraMessageBox.Show(args);
                return DialogResult.Yes;
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return DialogResult.No;
            }
        }
        private void Confirm_Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            if (e.MessageBoxForm != null)
            {
                // Proceed with customizations
            
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
                e.Buttons[DialogResult.Yes].Text = "Xác nhận";
                e.Buttons[DialogResult.Yes].Appearance.FontSizeDelta = 4;
                e.Buttons[DialogResult.Yes].Appearance.FontStyleDelta = FontStyle.Bold;
                e.Buttons[DialogResult.Yes].Padding = new Padding(10); // Vì một nguyên nhân nào đó nó set padding cho cả 2 nút thay vì chỉ set cho chính nó

                // Cancel button style
                e.Buttons[DialogResult.No].Text = "Hủy";
                e.Buttons[DialogResult.No].Appearance.FontSizeDelta = 4;
                e.Buttons[DialogResult.No].Appearance.FontStyleDelta = FontStyle.Bold;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("MessageBoxForm is null.");
            }
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
        
        // Functions
        private void BindGrid()
        {
            medicineBindingSource.DataSource = medicineService.GetMedicineTable();
        }
        private void ClearText()
        {
            txt_Id.Text = string.Empty;
            txt_Name.Text = string.Empty;
            txt_Dosage.Text = string.Empty;
            txt_PricePerUnit.Text = "0";
            txt_Description.Text = string.Empty;
        }
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
        private void ValidateInputs(out String id, out String name, out String dosage, out String description, out int pricePerUnit)
        {
            id = txt_Id.Text.ToUpper();
            name = txt_Name.Text;
            dosage = txt_Dosage.Text;
            description = txt_Description.Text;
            pricePerUnit = 0;

            System.Diagnostics.Debug.WriteLine($"Medicine ID: {id}");
            if (String.IsNullOrEmpty(id))
            {
                System.Diagnostics.Debug.WriteLine($"Chưa nhập phần {label_ID.Text}, Vui lòng điền đầy đủ thông tin!");
                txt_Id.Focus();
                throw new Exception($"Chưa nhập phần {label_ID.Text}, Vui lòng điền đầy đủ thông tin!");
            }

            System.Diagnostics.Debug.WriteLine($"Medicine Name: {name}");
            if (String.IsNullOrEmpty(name))
            {
                System.Diagnostics.Debug.WriteLine($"Chưa nhập phần {label_Name.Text}, Vui lòng điền đầy đủ thông tin!");
                txt_Name.Focus();
                throw new Exception($"Chưa nhập phần {label_Name.Text}, Vui lòng điền đầy đủ thông tin!");
            }

            System.Diagnostics.Debug.WriteLine($"Price: {txt_PricePerUnit.Text}");
            if (!Int32.TryParse(txt_PricePerUnit.Text, out pricePerUnit))
            {
                System.Diagnostics.Debug.WriteLine($"Price (Parsed): {pricePerUnit}");
                System.Diagnostics.Debug.WriteLine("Price: Giá thuốc không hợp lệ!");
                txt_PricePerUnit.Focus();
                throw new Exception("Giá thuốc không hợp lệ!");
            }
            System.Diagnostics.Debug.WriteLine($"Price (Parsed): {pricePerUnit}");

            System.Diagnostics.Debug.WriteLine($"Medicine Dosage: {dosage}");
            if (String.IsNullOrEmpty(dosage))
            {
                System.Diagnostics.Debug.WriteLine($"Chưa nhập {label_Dosage}, Vui lòng điền đầy đủ thông tin!");
                txt_Dosage.Focus();
                throw new Exception($"Chưa nhập phần {label_Dosage}, Vui lòng điền đầy đủ thông tin!");
            }
            System.Diagnostics.Debug.WriteLine($"Medicine Description: {description}");
        }
        private void InsertMedicine(THUOC medicine)
        {
            System.Diagnostics.Debug.WriteLine("Adding Medicine...");

            System.Diagnostics.Debug.WriteLine($"Medicine: " +
                $"Medicine ID: {medicine.MaThuoc}\n" +
                $"Medicine Name: {medicine.TenThuoc}\n" +
                $"Dosage: {medicine.LieuThuoc}\n" +
                $"Price per unit: {medicine.GiaDonVi}\n" +
                $"Stock quantity: {medicine.SoLuongTon}\n" +
                $"Description: {medicine.MoTa}"
            );

            System.Diagnostics.Debug.WriteLine("Adding Medicine to database");
            medicineService.AddOrUpdateMedicine(medicine);

            System.Diagnostics.Debug.WriteLine("Medicine added successfully!");
            ShowMessageBox("Thêm thuốc thành công!", GetIcon("success"));
        }
        private void UpdateMedicine(THUOC medicine)
        {
            DialogResult dr = ShowConfirmationMessage("Bạn có chắc là muốn cập nhật không?");
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Debug.WriteLine("Updating Medicine...");

                var medicineToUpdate = medicineService.GetMedicineById(medicine.MaThuoc);
                if (medicineToUpdate != null)
                {
                    if (medicineToUpdate.TenThuoc != medicine.TenThuoc ||
                        medicineToUpdate.LieuThuoc != medicine.LieuThuoc ||
                        medicineToUpdate.MoTa != medicine.MoTa ||
                        medicineToUpdate.GiaDonVi != medicine.GiaDonVi)
                    {
                        medicineToUpdate.TenThuoc = medicine.TenThuoc;
                        medicineToUpdate.LieuThuoc = medicine.LieuThuoc;
                        medicineToUpdate.MoTa = medicine.MoTa;
                        medicineToUpdate.GiaDonVi = medicine.GiaDonVi;

                        System.Diagnostics.Debug.WriteLine($"Updating Medicine: " +
                            $"Medicine ID: {medicineToUpdate.MaThuoc}\n" +
                            $"Medicine Name: {medicineToUpdate.TenThuoc}\n" +
                            $"Dosage: {medicineToUpdate.LieuThuoc}\n" +
                            $"Price per unit: {medicineToUpdate.GiaDonVi}\n" +
                            $"Stock quantity: {medicineToUpdate.SoLuongTon}\n" +
                            $"Description: {medicineToUpdate.MoTa}" 
                        );

                        medicineService.AddOrUpdateMedicine(medicineToUpdate);

                        System.Diagnostics.Debug.WriteLine("Medicine updated successfully!");
                        ShowMessageBox("Cập nhật thuốc thành công!", GetIcon("success"));
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("No changes detected, skipping update...");
                        throw new Exception("Không có thay đổi nào được phát hiện, bỏ qua cập nhật!");
                    }
                }
            }
        }
        private void DeleteMedicine(THUOC medicine) {
            if (medicine == null) 
            {
                throw new ArgumentNullException("Không tìm thấy thuốc cần xóa");
            }
            
            DialogResult dr = ShowConfirmationMessage("Bạn có chắc chắn muốn xóa thuốc này?");
            if (dr == DialogResult.Yes)
            {
                MedicineServices medicineService = new MedicineServices();
                medicineService.DeleteMedicineById(medicine.MaThuoc);

                ShowMessageBox("Xóa thuốc thành công!", GetIcon("success"));
                ClearText();
                BindGrid();
            }
        }
    }
}