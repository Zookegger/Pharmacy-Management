using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Manager_BUS
{

    public class TransactionService
    {
        private PharmacyManagementDB context = new PharmacyManagementDB();


        public THUOC GetThuocByMaThuoc(string maThuoc)
        {
            var thuoc = context.THUOC.FirstOrDefault(t => t.MaThuoc == maThuoc);
            if (thuoc == null)
            {
                Console.WriteLine($"Không tìm thấy thuốc với mã {maThuoc}");
            }
            return thuoc;
        }
        public string GetMaThuocByMaLo(string maLo)
        {
            var loThuoc = context.LOTHUOC.FirstOrDefault(l => l.MaLo == maLo);
            return loThuoc?.MaThuoc ?? string.Empty; // Trả về mã thuốc nếu có, nếu không thì trả về chuỗi trống
        }


        public List<GIAODICH> GetTransactionList()
        {
            return context.GIAODICH.ToList();
        }
        public class NhaCungCapService
        {
            private PharmacyManagementDB context = new PharmacyManagementDB();

            // Tìm nhà cung cấp theo tên
            public NHACUNGCAP GetSupplierByName(string tenNhaCungCap)
            {
                return context.NHACUNGCAP.FirstOrDefault(s => s.TenNhaCungCap == tenNhaCungCap);
            }
            public NHACUNGCAP GetSupplierById(string maNhaCungCap)
            {
                return context.NHACUNGCAP.FirstOrDefault(s => s.MaNhaCungCap == maNhaCungCap);
            }
        }


    }

}

