using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacistManagement_DAL.Model;
using Manager_BUS;
using HashingPassword;
using System.Data.Entity.Validation;
using DevExpress.Data.Helpers;
using static DevExpress.XtraBars.Painters.PrimitivesPainterWindowsXP;
using System.Data.Entity;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;

namespace Manager_GUI
{
    public partial class frm_Accounts : DevExpress.XtraEditors.XtraForm
    {
        private AccountServices accountServices = new AccountServices();
        private ManagerServices managerServices = new ManagerServices();
        public frm_Accounts()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            gridControl.DataSource = accountServices.GetAccountTable();
        }

        private void frm_Account_Load(object sender, EventArgs e)
        {
            cbb_AccountStatus.SelectedText = "Active";
            BindGrid();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các TextBox
                int mataikhoan = int.Parse(txt_AccountId.Text);
                string maNhanVien = txt_EmployeeId.Text;
                if (string.IsNullOrEmpty(maNhanVien))
                {
                    MessageBox.Show("Mã nhân viên không được để trống.");
                    return;
                }

                NHANVIEN employee = managerServices.GetEmployeeByID(maNhanVien);

                if (employee == null)
                {
                    throw new Exception("Không tìm thấy nhân viên");
                }

                string trangthai = "Active",
                       tenTaiKhoan = txt_UserName.Text,
                       matKhau = txt_Password.Text;

                // Kiểm tra tính hợp lệ
                if (string.IsNullOrEmpty(tenTaiKhoan) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                // Tạo đối tượng tài khoản mới
                TAIKHOAN newAccount = new TAIKHOAN
                {
                    MaTaiKhoan = mataikhoan,
                    MaNhanVien = employee.MaNhanVien,
                    TenTaiKhoan = tenTaiKhoan,
                    MatKhau = matKhau,
                    TrangThai = trangthai,
                    LanCuoiCapNhat = DateTime.Now
                };

                System.Diagnostics.Debug.WriteLine($"{newAccount.MatKhau}");
                System.Diagnostics.Debug.WriteLine($"{newAccount.MaTaiKhoan}");
                System.Diagnostics.Debug.WriteLine($"{newAccount.MaNhanVien}");
                System.Diagnostics.Debug.WriteLine($"{newAccount.TenTaiKhoan}");
                System.Diagnostics.Debug.WriteLine($"{newAccount.TrangThai}");
                System.Diagnostics.Debug.WriteLine($"{newAccount.LanCuoiCapNhat}");

                // Gọi phương thức AddAccount từ AccountService
                bool result = accountServices.AddAccount(newAccount);

                System.Diagnostics.Debug.WriteLine($"Result: {result}");

                if (result)
                {
                    ShowSuccessMessage("Thêm tài khoản thành công!");
                    BindGrid();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại. Vui lòng thử lại.");
                }
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
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show($"Error adding account: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txt_AccountId.Text, out int accountId))
                {
                    throw new Exception("Mã tài khoản không hợp lệ");
                }

                TAIKHOAN account = accountServices.GetAccountById(accountId);
                if (account == null)
                {
                    throw new Exception("Không tìm thấy tài khoản với mã này");
                }

                // Xác nhận trước khi xóa
                DialogResult confirmResult = ShowConfirmationMessage("Bạn có chắc chắn muốn xóa tài khoản này?");
                if (confirmResult == DialogResult.Yes)
                {
                    // Gọi phương thức xóa tài khoản
                    accountServices.DeleteAccount(account);
                    ShowSuccessMessage("Xóa tài khoản thành công!");
                    BindGrid();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txt_AccountId.Text, out int accountId))
                {
                    throw new Exception("Mã tài khoản không hợp lệ");
                }

                // Tìm tài khoản theo Mã tài khoản
                TAIKHOAN account = accountServices.GetAccountById(accountId);

                if (account == null)
                {
                    throw new Exception("Không tìm thấy tài khoản với mã tài khoản đã chọn.");
                }
                else 
                {
                    // Cập nhật thông tin tài khoản
                    account.MaNhanVien = listBox_SearchEmployeeByName.SelectedValue?.ToString();
                    account.TenTaiKhoan = txt_UserName.Text;
                    account.TrangThai = cbb_AccountStatus.Text;
                    account.LanCuoiCapNhat = DateTime.Now;

                    // Nếu mật khẩu được nhập, băm lại mật khẩu
                    if (!string.IsNullOrEmpty(txt_Password.Text))
                    {
                        account.MatKhau = new HashPassword().Hash(txt_Password.Text);
                    }

                    // Gọi phương thức cập nhật tài khoản
                    accountServices.UpdateAccount(account);

                    ShowSuccessMessage("Cập nhật tài khoản thành công!");
                    BindGrid();
                }
            }
            catch (Exception ex)
            {
                ShowMessageBox($"Cập nhật tài khoản thất bại. {ex.Message}");
                HandleException(ex);
            }
        }

        private void btn_SearchForEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                List<NHANVIEN> employeeList = managerServices.GetEmployeeList();
                if (employeeList == null || employeeList.Count == 0)
                {
                    throw new Exception("No Person found");
                }
                listBox_SearchEmployeeByName.DataSource = employeeList;
                listBox_SearchEmployeeByName.ValueMember = "MaNhanVien";
                listBox_SearchEmployeeByName.DisplayMember = "HoTen";

                // Debug
                System.Diagnostics.Debug.WriteLine($"Employee Found: {employeeList.Count}");
                foreach (var employee in employeeList)
                {
                    System.Diagnostics.Debug.WriteLine(employee.HoTen);
                }
                popupContainerControl_GetEmployee.Show();
            }
            catch (Exception ex)
            {
                
                // Print to Output stream
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine($"Selected Item: {listBox_SearchEmployeeByName.SelectedItem}");
                int itemIndex = listBox_SearchEmployeeByName.SelectedIndex;
                System.Diagnostics.Debug.WriteLine($"Selected Index: {itemIndex}");

                string maNhanVien = listBox_SearchEmployeeByName.SelectedValue?.ToString();

                if (listBox_SearchEmployeeByName.SelectedItem == null || itemIndex == -1)
                {
                    throw new Exception("No person selected");
                }

                txt_EmployeeId.Text = maNhanVien;
                popupContainerControl_GetEmployee.Hide();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void gridView_AccountDetaiis_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                txt_AccountId.Text = gridView_AccountDetaiis.GetRowCellValue(e.RowHandle, "col_AccountID").ToString();
                System.Diagnostics.Debug.WriteLine($"Account ID: {txt_AccountId.Text}");

                NHANVIEN employee = managerServices.GetEmployeeByName(gridView_AccountDetaiis.GetRowCellValue(e.RowHandle, "col_EmployeeName").ToString());
                txt_EmployeeId.Text = employee.MaNhanVien;
                System.Diagnostics.Debug.WriteLine($"Employee: {employee.MaNhanVien} - {employee.HoTen}");

                cbb_AccountStatus.Text = gridView_AccountDetaiis.GetRowCellValue(e.RowHandle, "col_AccountStatus").ToString();
                System.Diagnostics.Debug.WriteLine($"Account Status: {cbb_AccountStatus.Text}");

                txt_UserName.Text = gridView_AccountDetaiis.GetRowCellValue(e.RowHandle, "col_UserName").ToString();
                System.Diagnostics.Debug.WriteLine($"Username: {txt_UserName.Text}");
            }
        }

        private void txt_SearchEmployeeByName_TextChanged(object sender, EventArgs e)
        {
            listBox_SearchEmployeeByName.DataSource = managerServices.GetEmployeeByNameList(txt_SearchEmployeeByName.Text);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                listBox_SearchEmployeeByName.SelectedIndex = -1;
                popupContainerControl_GetEmployee.Hide();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        // Handle exception and show error message
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
    }
}

