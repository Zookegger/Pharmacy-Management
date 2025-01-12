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

namespace Manager_GUI
{
    public partial class frm_Account : Form
    {
        private AccountService accountService = new AccountService();
        private ManagerServices managerServices = new ManagerServices();
        public frm_Account()
        {
            InitializeComponent();

        }


        private void BindGrid(List<TAIKHOAN> taiKhoans)
        {
            // Xóa hết dữ liệu trong DataGridView trước khi thêm dữ liệu mới
            dgv_Account.Rows.Clear();

            // Duyệt qua danh sách tài khoản và thêm vào DataGridView
            foreach (var taiKhoan in taiKhoans)
            {
                int rowIndex = dgv_Account.Rows.Add();

                // Gán giá trị vào các cột trong DataGridView
                dgv_Account.Rows[rowIndex].Cells[0].Value = taiKhoan.MaTaiKhoan.ToString();
                dgv_Account.Rows[rowIndex].Cells[1].Value = taiKhoan.MaNhanVien;
                dgv_Account.Rows[rowIndex].Cells[2].Value = taiKhoan.TenTaiKhoan;
                dgv_Account.Rows[rowIndex].Cells[3].Value = taiKhoan.MatKhau;
                dgv_Account.Rows[rowIndex].Cells[4].Value = taiKhoan.TrangThai;
                dgv_Account.Rows[rowIndex].Cells[5].Value = taiKhoan.LanCuoiCapNhat.ToString();
            }
        }

        private void dgv_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Account_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_Account_Load(object sender, EventArgs e)
        {
            cmb_Status.SelectedText = "Active";

            List<TAIKHOAN> taiKhoans = accountService.GetAccountList();

            BindGrid(taiKhoans);
        }

    

 

        

        private void dgv_Account_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Account_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo người dùng chọn một hàng hợp lệ
            {
                DataGridViewRow selectedRow = dgv_Account.Rows[e.RowIndex];

                // Lấy giá trị từ từng cột của hàng được chọn và gán vào các TextBox
                txt_Id.Text = selectedRow.Cells[0].Value?.ToString();
                txt_Idperson.Text = selectedRow.Cells[1].Value?.ToString();
                txt_Name.Text = selectedRow.Cells[2].Value?.ToString();
                txt_Password.Text = selectedRow.Cells[3].Value?.ToString(); 
                cmb_Status.Text = selectedRow.Cells[4].Value?.ToString();

            
              
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các TextBox
                int mataikhoan = int.Parse(txt_Id.Text);
                string maNhanVien = txt_Idperson.Text;
                if (string.IsNullOrEmpty(maNhanVien))
                {
                    MessageBox.Show("Mã nhân viên không được để trống.");
                    return;
                }

                NHANVIEN employee = managerServices.GetEmployee(maNhanVien);

                if (employee == null)
                {
                    throw new Exception("Không tìm thấy nhân viên");
                }
                string trangthai = "Active";
                string tenTaiKhoan = txt_Name.Text;
                string matKhau = txt_Password.Text;



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
                bool result = accountService.AddAccount(newAccount);

                System.Diagnostics.Debug.WriteLine($"Result: {result}");

                if (result)
                {
                    MessageBox.Show("Thêm tài khoản thành công!");

                    // Cập nhật lại DataGridView
                    List<TAIKHOAN> taiKhoans = accountService.GetAccountList();
                    BindGrid(taiKhoans);
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

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            if (dgv_Account.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa.");
                return;
            }

            // Lấy mã tài khoản từ DataGridView và chuyển đổi sang int
            if (!int.TryParse(dgv_Account.SelectedRows[0].Cells[0].Value.ToString(), out int maTaiKhoan))
            {
                MessageBox.Show("Mã tài khoản không hợp lệ.");
                return;
            }

            // Xác nhận trước khi xóa
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?",
                                                "Xác nhận xóa",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Gọi phương thức xóa tài khoản
                bool result = accountService.DeleteAccount(maTaiKhoan);

                if (result)
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                    BindGrid(accountService.GetAccountList()); // Cập nhật lại DataGridView
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại. Vui lòng thử lại.");
                }
            }
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            if (dgv_Account.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa.");
                return;
            }

            // Lấy giá trị Mã tài khoản từ DataGridView và chuyển đổi sang int
            if (!int.TryParse(dgv_Account.SelectedRows[0].Cells[0].Value.ToString(), out int maTaiKhoan))
            {
                MessageBox.Show("Mã tài khoản không hợp lệ.");
                return;
            }

            // Tìm tài khoản theo Mã tài khoản
            TAIKHOAN account = accountService.GetAccountById(maTaiKhoan);

            if (account != null)
            {
                // Cập nhật thông tin tài khoản
                account.MaNhanVien = txt_Idperson.Text;
                account.TenTaiKhoan = txt_Name.Text;
                account.TrangThai = cmb_Status.Text;
                account.LanCuoiCapNhat = DateTime.UtcNow;

                // Nếu mật khẩu được nhập, băm lại mật khẩu
                if (!string.IsNullOrEmpty(txt_Password.Text))
                {
                    account.MatKhau = new HashPassword().Hash(txt_Password.Text);
                }

                // Gọi phương thức cập nhật tài khoản
                bool result = accountService.UpdateAccount(account);

                if (result)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!");
                    BindGrid(accountService.GetAccountList());
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại. Vui lòng thử lại.");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản với Mã tài khoản đã chọn.");
            }
        }

        private void btn_SearchForMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                List<NHANVIEN> nhanviens = managerServices.GetEmployeeList();
                if (nhanviens == null || nhanviens.Count == 0)
                {
                    throw new Exception("No Person found");
                }
                listBox_SearchPerson.DataSource = nhanviens;
                listBox_SearchPerson.ValueMember = "MaNhanVien";
                listBox_SearchPerson.DisplayMember = "HoTen";

                // Debug
                System.Diagnostics.Debug.WriteLine($"Medicine Found: {nhanviens.Count}");
                foreach (var nhanvien in nhanviens)
                {
                    System.Diagnostics.Debug.WriteLine(nhanvien.HoTen);
                }
                popupContainerControl1.Show();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && String.IsNullOrEmpty(ex.InnerException.Message))
                {
                    
                }
                else
                {
                    
                }
                // Print to Output stream
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine($"Selected Item: {listBox_SearchPerson.SelectedItem}");
                int itemIndex = listBox_SearchPerson.SelectedIndex;
                System.Diagnostics.Debug.WriteLine($"Selected Index: {itemIndex}");

                string maNhanVien = listBox_SearchPerson.SelectedValue?.ToString();

                if (listBox_SearchPerson.SelectedItem == null || itemIndex == -1)
                {
                    throw new Exception("No person selected");
                }

                txt_Idperson.Text = maNhanVien;
                popupContainerControl1.Hide();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && String.IsNullOrEmpty(ex.InnerException.Message))
                {
                 
                }
                else
                {
                    
                }
                // Print to Output stream
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

