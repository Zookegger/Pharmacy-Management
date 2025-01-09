using System;
using System.Linq;
using HashingPassword;
using System.Data.Entity.Validation;
using System.Data.Entity.Migrations;
using System.Collections.Generic;
using PharmacistManagement_DAL.Model;

namespace Login_BUS
{
    public class LoginServices
    {
        private PharmacyManagementDB loginDB = new PharmacyManagementDB();
        private HashPassword hashPassword = new HashPassword();

        public bool Login(String username, String password, out string role)
        {
            System.Diagnostics.Debug.WriteLine("Checking login credentials...");

            var account = loginDB.TAIKHOAN.Where(x => x.TenTaiKhoan == username).FirstOrDefault();
            role = account.NHANVIEN.CHUCVU.TenChucVu;

            System.Diagnostics.Debug.WriteLine($"Found account: {account.MaTaiKhoan}");
            System.Diagnostics.Debug.WriteLine($"Role: {role}");
            if (account == null)
            {
                role = null;
                return false;
            }
            System.Diagnostics.Debug.WriteLine($"Checking Password...");
            bool isPasswordValid = hashPassword.Verify(password, account.MatKhau);
            System.Diagnostics.Debug.WriteLine($"Password is valid: {isPasswordValid}");
            return isPasswordValid;
        }

        public void Register(string username, string password, string employeeId)
        {
            if (loginDB.TAIKHOAN.Any(acc => acc.TenTaiKhoan == username))
            {
                System.Diagnostics.Debug.WriteLine("Username already exists.");
                throw new Exception("Tên tài khoản đã được sử dụng.");
            }

            var nhanvien = loginDB.NHANVIEN.Where(nv => nv.MaNhanVien == employeeId).FirstOrDefault();
            string hashedPassword = hashPassword.Hash(password);

            TAIKHOAN newAccount = new TAIKHOAN
            {
                NHANVIEN = nhanvien,
                TenTaiKhoan = username,
                MatKhau = hashedPassword,
                TrangThai = "Active",
                LanCuoiCapNhat = DateTime.Now
            };

            loginDB.TAIKHOAN.Add(newAccount);
            loginDB.SaveChanges();

            System.Diagnostics.Debug.WriteLine("Account created successfully.");
        }
    }
}
