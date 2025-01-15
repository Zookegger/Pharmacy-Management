using HashingPassword;
using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_BUS
{
    public class AccountServices
    {
        private PharmacyManagementDB db = new PharmacyManagementDB();
        private HashPassword hashPassword = new HashPassword();
        private readonly ManagerServices managerServices = new ManagerServices();

        public DataTable GetAccountTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("col_AccountID", typeof(string));
            table.Columns.Add("col_UserName", typeof(string));
            table.Columns.Add("col_EmployeeName", typeof(string));
            table.Columns.Add("col_AccountStatus", typeof(string));
            table.Columns.Add("col_LastUpdated", typeof(DateTime));

            List<TAIKHOAN> accountList = GetAccountList();

            System.Diagnostics.Debug.WriteLine($"Found {accountList.Count} batches");

            foreach (TAIKHOAN account in accountList)
            {
                string employeeName = managerServices.GetEmployeeByID(account.MaNhanVien).HoTen;

                table.Rows.Add(
                    account.MaTaiKhoan,
                    account.TenTaiKhoan,
                    employeeName,
                    account.TrangThai,
                    account.LanCuoiCapNhat
                );
                System.Diagnostics.Debug.WriteLine($"Added account:\n" +
                    $"\t{account.MaTaiKhoan},\n" +
                    $"\t{account.TenTaiKhoan},\n" +
                    $"\t{employeeName}\n" +
                    $"\t{account.TrangThai}\n" +
                    $"\t{account.LanCuoiCapNhat}\n"
                );
            }

            return table;
        }
        public List<TAIKHOAN> GetAccountList()
        {
            return db.TAIKHOAN.ToList();
        }

        public TAIKHOAN GetAccountById(int maTaiKhoan)
        {
            return db.TAIKHOAN.FirstOrDefault(tk => tk.MaTaiKhoan == maTaiKhoan);
        }

        public bool AddAccount(TAIKHOAN newAccount)
        {
            try
            {
                // Băm mật khẩu trước khi lưu
                newAccount.MatKhau = hashPassword.Hash(newAccount.MatKhau);

                // Thêm tài khoản vào cơ sở dữ liệu
                db.TAIKHOAN.Add(newAccount);
                System.Diagnostics.Debug.WriteLine($"Adding account: {newAccount.MaTaiKhoan}");

                db.SaveChanges();  // Kiểm tra lỗi ở đây

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
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return false;
            }
        }
        
        public void UpdateAccount(TAIKHOAN account)
        {
            try
            {
                db.Entry(account).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public void DeleteAccount(TAIKHOAN account)
        {
            try
            {
                // Xóa tài khoản khỏi cơ sở dữ liệu
                db.TAIKHOAN.Remove(account);
                db.SaveChanges();
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
                throw new Exception("Xóa tài khoản thất bại. Vui lòng thử lại.");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                throw new Exception("Xóa tài khoản thất bại. Vui lòng thử lại.");
            }
        }
        
        public bool IsAccountIdExists(int accountId)
        {
            return db.TAIKHOAN.Any(a => a.MaTaiKhoan == accountId);
        }

        public bool IsEmployeeIdExists(string employeeId)
        {
            return db.TAIKHOAN.Any(a => a.MaNhanVien == employeeId);
        }

        public bool IsAccountNameExists(string accountName)
        {
            return db.TAIKHOAN.Any(a => a.TenTaiKhoan == accountName);
        }
    }
}

