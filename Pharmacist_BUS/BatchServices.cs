using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacist
{
    public class BatchServices
    {
        private readonly PharmacyManagementDB pharmacistDB = new PharmacyManagementDB();
        // Getters
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
                batch.MaThuoc.ToLower() == medicine.ToLower() ||
                batch.THUOC.TenThuoc.ToLower() == medicine.ToLower()
            ).ToList();
        }
        public LOTHUOC GetBatchById(string batchId)
        {
            return pharmacistDB.LOTHUOC.Where(batch => batch.MaLo == batchId).FirstOrDefault();
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
        public List<NHACUNGCAP> GetProviderList(string search)
        {
            return pharmacistDB.NHACUNGCAP.Where(provider => 
                provider.TenNhaCungCap == search ||
                provider.MaNhaCungCap == search
            ).ToList();
        }
        public GIAODICH GetTransaction(string search)
        {
            return pharmacistDB.GIAODICH.Where(
                transaction => transaction.MaGiaoDich == search
            ).FirstOrDefault();
        }
        public GIAODICH GetLatestTransaction()
        {
            return pharmacistDB.GIAODICH.OrderByDescending(transaction => transaction.NgayThucHien).FirstOrDefault();
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
        // Setters and Updaters
        public void AddOrUpdateBatch(LOTHUOC batch)
        {
            pharmacistDB.LOTHUOC.AddOrUpdate(batch);
            pharmacistDB.SaveChanges();
        }
        public void AddOrUpdateTransaction(GIAODICH transaction)
        {
            pharmacistDB.GIAODICH.AddOrUpdate(transaction);
            pharmacistDB.SaveChanges();
        }
        public void AddOrUpdateProvider(NHACUNGCAP provider)
        {
            pharmacistDB.NHACUNGCAP.AddOrUpdate(provider);
            pharmacistDB.SaveChanges();
        }
        // Deleters
        public void DeleteBatch(string id)
        {
            LOTHUOC batch = pharmacistDB.LOTHUOC.Where(
                lot => lot.MaLo == id
            ).FirstOrDefault();
            if (batch != null)
            {
                pharmacistDB.LOTHUOC.Remove(batch);
                pharmacistDB.SaveChanges();
            }
        }
        public void DeleteTransaction(string id)
        {
            GIAODICH transaction = pharmacistDB.GIAODICH.Where(
                gd => gd.MaGiaoDich == id
            ).FirstOrDefault();
            if (transaction != null)
            {
                pharmacistDB.GIAODICH.Remove(transaction);
                pharmacistDB.SaveChanges();
            }
        }
        public void DeleteProvider(string id)
        {
            NHACUNGCAP provider = pharmacistDB.NHACUNGCAP.Where(
                ncc => ncc.MaNhaCungCap == id
            ).FirstOrDefault();
            if (provider != null)
            {
                pharmacistDB.NHACUNGCAP.Remove(provider);
                pharmacistDB.SaveChanges();
            }
        }
        // Other methods
        public void CreateNewTransaction(LOTHUOC batch, NHACUNGCAP provider, string transactionType)
        {
            if (String.IsNullOrEmpty(transactionType))
            {
                throw new ArgumentException("Loại giao dịch không được để trống", nameof(transactionType));
            }
            // TransactionID format: ddMMyyyy + FFF(hexadecimal)
            
            // Step 1: Get the latest transaction
            GIAODICH latestTransaction = GetLatestTransaction();

            // Step 2: Get the last 3 characters of the latest transaction ID
            // Set to 000 if there is no latest transaction
            string latestTransactionID = latestTransaction.MaGiaoDich ?? string.Empty;

            // Step 3: Generate the hexadecimal part
            string hexPart = "000"; // Default value if no valid transaction exists today

            if (!string.IsNullOrEmpty(latestTransactionID) && latestTransaction.NgayThucHien.HasValue)
            {
                if (latestTransaction.NgayThucHien.Value.Date < DateTime.Now.Date)
                {
                    hexPart = "000";
                }
                else
                {
                    // Extract the hexadecimal part from the last transaction ID
                    hexPart = latestTransactionID.Substring(8); // Assuming the last 3 characters are the hex part
                    int hexValue = int.Parse(hexPart, System.Globalization.NumberStyles.HexNumber);
                    hexValue++;
                    hexPart = hexValue.ToString("X3"); // Format as 3-digit hexadecimal
                }
            }
            // Step 4: Combine date and hexadecimal parts to generate the new Transaction ID
            string newTransactionId = DateTime.Now.ToString("ddMMyyyy") + hexPart;
            System.Diagnostics.Debug.WriteLine($"New Transaction ID: {newTransactionId}");

            // Step 5: Create the new transaction
            GIAODICH newTransaction = new GIAODICH
            {
                MaGiaoDich = newTransactionId,
                MaLo = batch.MaLo,
                MaNhaCungCap = provider.MaNhaCungCap,
                LoaiGiaoDich = transactionType,
                NgayThucHien = DateTime.Now,
                SoLuongTonConLai = batch.SoLuong,
                TinhTrang = "Đã nhập"
            };

            AddOrUpdateTransaction(newTransaction);
        }
    }
}
