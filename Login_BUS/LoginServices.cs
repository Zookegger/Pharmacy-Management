using System;
using System.Linq;
using HashingPassword;
using System.Data.Entity.Validation;
using Login_DAL.Models;
using System.Data.Entity.Migrations;
using System.Collections.Generic;

namespace Login_BUS
{
    public class LoginServices
    {
        private ModelPharmacyLogin loginDB = new ModelPharmacyLogin();
        private HashPassword hashPassword = new HashPassword();

        public bool Login(String username, String password)
        {
            var account = loginDB.TAIKHOAN.Where(x => x.TenTaiKhoan == username).FirstOrDefault();
            if (account == null)
            {
                return false;
            }

            bool isPasswordValid = hashPassword.Verify(password, account.MatKhau);
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
