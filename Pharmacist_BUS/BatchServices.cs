using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacist_BUS
{
    public class BatchServices
    {
        private PharmacyManagementDB pharmacistDB = new PharmacyManagementDB();

        public List<LOTHUOC> GetBatchList()
        {
            return pharmacistDB.LOTHUOC.ToList();
        }
        public List<LOTHUOC> SearchBatchList(string search)
        {
            search = search.ToLower();
            return pharmacistDB.LOTHUOC.Where(batch =>
                batch.MaLo.ToLower().Contains(search) ||
                batch.THUOC.TenThuoc.ToLower().Contains(search)
            ).ToList();
        }
        public List<LOTHUOC> GetBatchList(string medicine)
        {
            return pharmacistDB.LOTHUOC.Where(batch => 
                batch.MaThuoc == medicine ||
                batch.THUOC.TenThuoc == medicine
            ).ToList();
        }
        public List<NGUYENNHAN> GetReasonList()
        {
            return pharmacistDB.NGUYENNHAN.ToList();
        }
        public List<GIAODICH> GetTransactionList()
        {
            return pharmacistDB.GIAODICH.ToList();
        }
        public List<GIAODICH> GetTransactionListByStatus(string status)
        {
            return pharmacistDB.GIAODICH.Where(
                transaction => transaction.TinhTrang == status
            ).ToList();
        }
        public List<GIAODICH> GetTransactionByDate(DateTime date)
        {
            return pharmacistDB.GIAODICH.Where(
                transaction => transaction.NgayThucHien == date
            ).ToList();
        }

        public List<NHACUNGCAP> GetProviderList()
        {
            return pharmacistDB.NHACUNGCAP.ToList();
        }

        public GIAODICH GetTransaction(string search)
        {
            return pharmacistDB.GIAODICH.Where(
                transaction => transaction.MaGiaoDich == search
            ).FirstOrDefault();
        }

        public NHACUNGCAP GetProvider(string medicineId)
        {
            return pharmacistDB.NHACUNGCAP.SqlQuery(
                "SELECT * FROM NHACUNGCAP " +
                "JOIN GIAODICH ON NHACUNGCAP.MaNhaCungCap = GIAODICH.MaNhaCungCap " +
                "JOIN LOTHUOC ON GIAODICH.MaLo = LOTHUOC.MaLo " +
                "WHERE NHACUNGCAP.MaNhaCungCap = (SELECT MaNhaCungCap FROM GIAODICH WHERE MaThuoc = @p0)", medicineId
            ).FirstOrDefault();
        }

        public NHACUNGCAP GetProvider(GIAODICH transaction)
        {
            return pharmacistDB.NHACUNGCAP.Where(
                provider => provider.MaNhaCungCap == transaction.MaNhaCungCap
            ).FirstOrDefault();
        }
    }
}
