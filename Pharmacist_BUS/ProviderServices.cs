using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacist_BUS
{
    public class ProviderServices
    {
        private readonly PharmacyManagementDB db = new PharmacyManagementDB();
        public List<NHACUNGCAP> GetProviders()
        {
            return db.NHACUNGCAP.ToList();
        }     
        public List<NHACUNGCAP> GetProviders(string search)
        {
            return db.NHACUNGCAP.Where(provider => 
                provider.MaNhaCungCap.ToLower().Contains(search.ToLower()) ||
                provider.TenNhaCungCap.ToLower().Contains(search.ToLower())
            ).ToList();
        }
        public DataTable GetProviderTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã nhà cung cấp", typeof(string));
            table.Columns.Add("Tên nhà cung cấp", typeof(string));
            table.Columns.Add("Địa chỉ", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Số điện thoại", typeof(string));
            foreach (NHACUNGCAP provider in GetProviders())
            {
                table.Rows.Add(provider.MaNhaCungCap, provider.TenNhaCungCap, provider.DiaChi, provider.Email, provider.SoDienThoai);
            }
            return table;
        }
        public void InsertProvider(NHACUNGCAP provider)
        {
            db.NHACUNGCAP.Add(provider);
            db.SaveChanges();
        }
        public void UpdateProvider(NHACUNGCAP provider)
        {
            NHACUNGCAP oldProvider = db.NHACUNGCAP.Find(provider.MaNhaCungCap);
            if (oldProvider != null)
            {
                oldProvider.TenNhaCungCap = provider.TenNhaCungCap;
                oldProvider.DiaChi = provider.DiaChi;
                oldProvider.Email = provider.Email;
                oldProvider.SoDienThoai = provider.SoDienThoai;
                db.SaveChanges();
            } else
            {
                throw new Exception("Không tìm thấy nhà cung cấp");
            }
        }
        public void DeleteProvider(string providerId)
        {
            NHACUNGCAP provider = db.NHACUNGCAP.Find(providerId);
            if (provider != null)
            {
                db.NHACUNGCAP.Remove(provider);
                db.SaveChanges();
            }
            else
            {
                throw new Exception("Không tìm thấy nhà cung cấp");
            }
        }
    }
}
