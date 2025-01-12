using HashingPassword;
using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Manager_BUS
{

    public class AccountService
    {
        private PharmacyManagementDB pharmacistDB = new PharmacyManagementDB();
        private HashPassword hashPassword = new HashPassword();
        public List<TAIKHOAN> GetAccountList()
        {
            return pharmacistDB.TAIKHOAN.ToList();
        }
        public bool AddAccount(TAIKHOAN newAccount)
        {
            try
            {
                // Băm mật khẩu trước khi lưu
                newAccount.MatKhau = hashPassword.Hash(newAccount.MatKhau);

                // Thêm tài khoản vào cơ sở dữ liệu
                pharmacistDB.TAIKHOAN.Add(newAccount);
                
                System.Diagnostics.Debug.WriteLine($"Adding account: {newAccount.MaTaiKhoan}");

                pharmacistDB.SaveChanges();  // Kiểm tra lỗi ở đây



                return true;
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
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding account: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
                System.Diagnostics.Debug.WriteLine($"Exception: {ex}");
                if (ex.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                return false;
            }
        }
        public TAIKHOAN GetAccountById(int maTaiKhoan)
        {
            return pharmacistDB.TAIKHOAN.FirstOrDefault(tk => tk.MaTaiKhoan == maTaiKhoan);
        }
        public bool UpdateAccount(TAIKHOAN account)
        {
            try
            {
                pharmacistDB.Entry(account).State = System.Data.Entity.EntityState.Modified;
                pharmacistDB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating account: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
                return false;
            }
        }

        public bool DeleteAccount(int maTaiKhoan)
        {
            try
            {
                // Tìm tài khoản theo mã tài khoản
                TAIKHOAN account = GetAccountById(maTaiKhoan);
                if (account != null)
                {
                    // Xóa tài khoản khỏi cơ sở dữ liệu
                    pharmacistDB.TAIKHOAN.Remove(account);
                    pharmacistDB.SaveChanges();
                    return true;
                }
                return false; // Không tìm thấy tài khoản
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting account: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
                return false;
            }

        }
        public bool IsAccountIdExists(int accountId)
        {
            return pharmacistDB.TAIKHOAN.Any(a => a.MaTaiKhoan == accountId);
        }

        public bool IsEmployeeIdExists(string employeeId)
        {
            return pharmacistDB.TAIKHOAN.Any(a => a.MaNhanVien == employeeId);
        }

        public bool IsAccountNameExists(string accountName)
        {
            return pharmacistDB.TAIKHOAN.Any(a => a.TenTaiKhoan == accountName);
        }
    }
}

