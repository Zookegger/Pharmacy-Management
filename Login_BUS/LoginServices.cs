using Login_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashingPassword;

namespace Login_BUS
{
    public class LoginServices
    {
        ModelPharmacyLogin modelDB = new ModelPharmacyLogin();
        HashPassword hashPassword = new HashPassword();

        public bool Login(String username, String password)
        {
            var account = modelDB.TAIKHOAN.Where(x => x.TenTaiKhoan == username).FirstOrDefault();
            if (account == null)
            {
                return false;
            }

            bool isPasswordValid = hashPassword.Verify(password, account.MatKhau);
            return isPasswordValid;
        }

        public void Register(string username, string password)
        {
            if (modelDB.TAIKHOAN.Any(acc => acc.TenTaiKhoan == username))
            {
                Console.WriteLine("Username already exists.");
                throw new Exception("Tên tài khoản đã được sử dụng.");
            }

            string hashedPassword = hashPassword.Hash(password);

            TAIKHOAN newAccount = new TAIKHOAN
            {
                TenTaiKhoan = username,
                MatKhau = hashedPassword,
                TrangThai = "Active",
                LanCuoiCapNhat = DateTime.Now
            };

            modelDB.TAIKHOAN.Add(newAccount);
            modelDB.SaveChanges();

            Console.WriteLine("Account created successfully.");
        }
    }
}
