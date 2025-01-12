﻿using HashingPassword;
using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Manager_BUS
{

    public class AccountService
    {
        private PharmacyManagementDB pharmacistDB = new PharmacyManagementDB();
        public List<TAIKHOAN> GetAccountList()
        {
            return pharmacistDB.TAIKHOAN.ToList();
        }
        private HashPassword hashPassword = new HashPassword();
        public bool AddAccount(TAIKHOAN newAccount)
        {
            try
            {

                // Băm mật khẩu trước khi lưu
                newAccount.MatKhau = hashPassword.Hash(newAccount.MatKhau);

                // Thêm tài khoản vào cơ sở dữ liệu
                pharmacistDB.TAIKHOAN.Add(newAccount);
                
                pharmacistDB.SaveChanges();  // Kiểm tra lỗi ở đây

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding account: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
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
    }
}

