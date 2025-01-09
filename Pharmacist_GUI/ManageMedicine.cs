using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Accessibility;
using DevExpress.XtraRichEdit.Import.OpenXml;
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

namespace Pharmacist
{
    public partial class frm_ManageMedicine : Form
    {
        private MedicineService medicineService = new MedicineService();

        public frm_ManageMedicine()
        {
            InitializeComponent();
        }

        private void frm_AddMedicine_Load(object sender, EventArgs e)
        {
            dgv_Medicine.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10f, FontStyle.Bold);
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
        
            List<THUOC> medicines = medicineService.GetMedicineList();
            BindGrid(medicines);
        }
        private void BindGrid(List<THUOC> medicines)
        {
            dgv_Medicine.Rows.Clear();
            foreach(var medicine in medicines)
            {
                int rowIndex = dgv_Medicine.Rows.Add();
                dgv_Medicine.Rows[rowIndex].Cells[0].Value = medicine.MaThuoc;
                dgv_Medicine.Rows[rowIndex].Cells[1].Value = medicine.TenThuoc;
                dgv_Medicine.Rows[rowIndex].Cells[2].Value = medicine.SoLuongTon;
                dgv_Medicine.Rows[rowIndex].Cells[3].Value = medicine.GiaDonVi;
                dgv_Medicine.Rows[rowIndex].Cells[4].Value = medicine.LieuThuoc;
                dgv_Medicine.Rows[rowIndex].Cells[5].Value = medicine.MoTa;
            }
        }
        // Event handlers
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
        private void dgv_Medicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Medicine.Rows[e.RowIndex];
                txt_Id.Text = row.Cells[0].Value.ToString();
                txt_Name.Text = row.Cells[1].Value.ToString();
                txt_Dosage.Text = row.Cells[4].Value.ToString();
                txt_PricePerUnit.Text = row.Cells[3].Value.ToString();
                txt_Description.Text = row.Cells[5].Value.ToString();
            }
        }

        public void AddProviderToMedicine(THUOC Medicine)
        {
            try
            {
                using (PharmacyManagementDB db = new PharmacyManagementDB())
                {

                    MedicineService medicineService = new MedicineService();
                    // Check if provider exists or batch exists
                    List<LOTHUOC> batchList = db.LOTHUOC.ToList();
                    var batch = batchList.FirstOrDefault(b => b.MaThuoc == Medicine.MaThuoc);
                    // If batch exists which means provider exists then exit
                    if (batch != null)
                    {
                        // Search for transaction that has the same batch and provider
                        GIAODICH transaction = db.GIAODICH.FirstOrDefault(t => t.MaLo == batch.MaLo);
                        System.Diagnostics.Debug.WriteLine($"Transaction: {transaction}");
                        
                        NHACUNGCAP provider = db.NHACUNGCAP.FirstOrDefault(p => p.MaNhaCungCap == transaction.MaNhaCungCap);
                        System.Diagnostics.Debug.WriteLine($"Provider: {provider}");

                        if (provider != null)
                        {
                            throw new Exception("Nhà cung cấp đã tồn tại!");
                        }
                    } 
                    else
                    {
                        // Add new provider
                        NHACUNGCAP newProvider = new NHACUNGCAP()
                        {
                            MaNhaCungCap = txt_ProviderId.Text,
                            TenNhaCungCap = txt_ProviderName.Text,
                            DiaChi = txt_ProviderAddress.Text,
                            Email = txt_ProviderEmail.Text,
                            SoDienThoai = txt_ProviderPhone.Text
                        };
                        
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
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
                String id = txt_Id.Text,
                               name = txt_Name.Text,
                               dosage = txt_Dosage.Text,
                               description = txt_Description.Text;
                int pricePerUnit = 0;

                System.Diagnostics.Debug.WriteLine($"Price: {label_PricePerUnit.Text}: {txt_PricePerUnit.Text}");
                System.Diagnostics.Debug.WriteLine($"Price: {label_PricePerUnit}(Parsed): {pricePerUnit}");
                if (!Int32.TryParse(txt_PricePerUnit.Text, out pricePerUnit))
                {
                    System.Diagnostics.Debug.WriteLine("Price: Giá thuốc không hợp lệ!");
                    throw new Exception("Giá thuốc không hợp lệ!");
                }

                System.Diagnostics.Debug.WriteLine($"Medicine ID: {label_ID.Text}: {txt_Id.Text}");
                if (String.IsNullOrEmpty(id))
                {
                    System.Diagnostics.Debug.WriteLine($"Chưa nhập phần {label_ID.Text}, Vui lòng điền đầy đủ thông tin!");
                    throw new Exception($"Chưa nhập phần {label_ID.Text}, Vui lòng điền đầy đủ thông tin!");
                }

                System.Diagnostics.Debug.WriteLine($"Medicine Name: {label_Name.Text}: {name}");
                if (String.IsNullOrEmpty(name))
                {
                    System.Diagnostics.Debug.WriteLine($"Chưa nhập phần {label_Name.Text}, Vui lòng điền đầy đủ thông tin!");
                    throw new Exception($"Chưa nhập phần {label_Name.Text}, Vui lòng điền đầy đủ thông tin!");
                }

                System.Diagnostics.Debug.WriteLine($"Medicine Name: {label_Dosage.Text}: {name}");
                if (String.IsNullOrEmpty(dosage))
                {
                    System.Diagnostics.Debug.WriteLine($"Chưa nhập {label_Dosage}, Vui lòng điền đầy đủ thông tin!");
                    throw new Exception($"Chưa nhập phần {label_Dosage}, Vui lòng điền đầy đủ thông tin!");
                }

                System.Diagnostics.Debug.WriteLine($"Medicine Description: {label_Description.Text}: {description}");


                switch (button.Name)
                {
                    // Add new medicine
                    case "btn_Add":
                        System.Diagnostics.Debug.WriteLine("Adding Medicine...");
                        
                        THUOC medicine = new THUOC()
                        {
                            MaThuoc = id,
                            TenThuoc = name,
                            LieuThuoc = dosage,
                            MoTa = description,
                            GiaDonVi = pricePerUnit,
                            SoLuongTon = 0
                        };

                        System.Diagnostics.Debug.WriteLine($"Medicine: " +
                            $"{medicine.MaThuoc}, " +
                            $"{medicine.TenThuoc}, " +
                            $"{medicine.LieuThuoc}, " +
                            $"{medicine.MoTa}, " +
                            $"{medicine.GiaDonVi}, " +
                            $"{medicine.SoLuongTon}"
                        );

                        System.Diagnostics.Debug.WriteLine("Adding Medicine...");
                        medicineService.AddMedicine(medicine);

                        System.Diagnostics.Debug.WriteLine("Medicine added successfully!");
                        ShowMessageBox("Thêm thuốc thành công!", GetIcon("success"));
                        break;

                    // Update existing medicine
                    case "btn_Update":
                        System.Diagnostics.Debug.WriteLine("Updating Medicine...");

                        var medicineToUpdate = medicineService.GetMedicineById(id);
                        if (medicineToUpdate != null)
                        {
                            if (medicineToUpdate.TenThuoc != name ||
                                medicineToUpdate.LieuThuoc != dosage ||
                                medicineToUpdate.MoTa != description ||
                                medicineToUpdate.GiaDonVi != pricePerUnit)
                            {
                                medicineToUpdate.TenThuoc = name;
                                medicineToUpdate.LieuThuoc = dosage;
                                medicineToUpdate.MoTa = description;
                                medicineToUpdate.GiaDonVi = pricePerUnit;

                                System.Diagnostics.Debug.WriteLine($"Medicine: " +
                                    $"{medicineToUpdate.MaThuoc}, " +
                                    $"{medicineToUpdate.TenThuoc}, " +
                                    $"{medicineToUpdate.LieuThuoc}, " +
                                    $"{medicineToUpdate.MoTa}, " +
                                    $"{medicineToUpdate.GiaDonVi}, " +
                                    $"{medicineToUpdate.SoLuongTon}"
                                );

                                System.Diagnostics.Debug.WriteLine("Updating Medicine...");
                                medicineService.UpdateMedicine(medicineToUpdate);

                                System.Diagnostics.Debug.WriteLine("Medicine updated successfully!");
                                ShowMessageBox("Cập nhật thuốc thành công!", GetIcon("success"));
                            }
                            else
                            {
                                System.Diagnostics.Debug.WriteLine("No changes detected, skipping update...");
                                ShowMessageBox("Không có thay đổi nào được phát hiện, bỏ qua cập nhật!");
                            }
                        }
                        break;
                    default:
                        break;
                }
                BindGrid(medicineService.GetMedicineList());
            }

            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message.ToString());
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                String medicineId = txt_Id.Text;
                if (!String.IsNullOrEmpty(medicineId))
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thuốc này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {

                        MedicineService medicineService = new MedicineService();
                        medicineService.DeleteMedicineById(medicineId);

                        ShowMessageBox("Xóa thuốc thành công!", GetIcon("success"));
                        Reload();
                        List<THUOC> medicines = medicineService.GetMedicineList();
                        BindGrid(medicines);
                    }
                } else
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
                throw new Exception(ex.Message); // Re-throw the exception if needed
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
        // Functions
        private void Reload()
        {
            txt_Id.Text = string.Empty;
            txt_Name.Text = string.Empty;
            txt_Dosage.Text = string.Empty;
            txt_PricePerUnit.Text = "0";
            txt_Description.Text = string.Empty;
        }
        private void txt_SearchBox_TextChanged(object sender, EventArgs e)
        {
            List<THUOC> medicines = medicineService.GetMedicineList(txt_SearchBox.Text);
            if (medicines != null)
            {
                BindGrid(medicines);
            }

            if (String.IsNullOrEmpty(txt_SearchBox.Text))
            {
                medicines = medicineService.GetMedicineList();
                BindGrid(medicines);
            }
        }

        private void txt_SearchProvider_TextChanged(object sender, EventArgs e)
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

        private void btn_InsertUpdateProvider_Click(object sender, EventArgs e)
        {

        }
    }
}