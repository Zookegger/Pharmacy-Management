using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_BUS
{
    
        public class Account
        {
            public string MaTaiKhoan { get; set; }
            public string TenTaiKhoan { get; set; }
            public string MatKhau { get; set; }
            public string TrangThai { get; set; }
            public string LanCapNhat { get; set; }
        }
        internal class AccountService
        {

            private List<Account> danhSachTaiKhoan;

            public AccountService()
            {
                danhSachTaiKhoan = new List<Account>();
            }

            public List<Account> GetAllAccounts()
            {
                return danhSachTaiKhoan;
            }

            public bool AddAccount(Account account)
            {
                // Kiểm tra tài khoản đã tồn tại hay chưa
                if (danhSachTaiKhoan.Exists(a => a.MaTaiKhoan == account.MaTaiKhoan))
                {
                    return false; // Tài khoản đã tồn tại
                }

                danhSachTaiKhoan.Add(account);
                return true;
            }

            public bool UpdateAccount(string maTaiKhoan, Account updatedAccount)
            {
                var account = danhSachTaiKhoan.Find(a => a.MaTaiKhoan == maTaiKhoan);
                if (account == null)
                {
                    return false; // Không tìm thấy tài khoản
                }

                account.TenTaiKhoan = updatedAccount.TenTaiKhoan;
                account.MatKhau = updatedAccount.MatKhau;
                account.TrangThai = updatedAccount.TrangThai;
                account.LanCapNhat = updatedAccount.LanCapNhat;
                return true;
            }

            public bool DeleteAccount(string maTaiKhoan)
            {
                var account = danhSachTaiKhoan.Find(a => a.MaTaiKhoan == maTaiKhoan);
                if (account == null)
                {
                    return false; // Không tìm thấy tài khoản
                }

                danhSachTaiKhoan.Remove(account);
                return true;
            }
        }
    }

