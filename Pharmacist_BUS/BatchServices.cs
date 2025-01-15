using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable GetBatchTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("BatchId", typeof(string));
            table.Columns.Add("MedicineName", typeof(string));
            table.Columns.Add("ProviderName", typeof(string));
            table.Columns.Add("ProdDate", typeof(DateTime));
            table.Columns.Add("ExpDate", typeof(DateTime));
            table.Columns.Add("Quantity", typeof(int));

            int batchListCount = GetBatchList().Count;
            System.Diagnostics.Debug.WriteLine($"Found {batchListCount} batches");

            foreach (LOTHUOC batch in GetBatchList())
            {
                string providerName = GetProviderByBatch(batch.MaLo).TenNhaCungCap;
                System.Diagnostics.Debug.WriteLine($"{providerName}");

                table.Rows.Add(
                    batch.MaLo,
                    batch.THUOC.TenThuoc,
                    providerName,
                    batch.NgaySanXuat,
                    batch.NgayHetHan,
                    batch.SoLuong
                );
                System.Diagnostics.Debug.WriteLine($"Added batch:\n" +
                    $"\t{batch.MaLo},\n" +
                    $"\t{batch.THUOC.TenThuoc},\n" +
                    $"\t{providerName}\n" +
                    $"\t{batch.NgaySanXuat}\n" +
                    $"\t{batch.NgayHetHan}\n" +
                    $"\t{batch.SoLuong}\n"
                );
            }
            
            return table;
        }

        public List<LOTHUOC> GetBatchList()
        {
            return pharmacistDB.LOTHUOC.Include("THUOC").ToList();
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

        public LOTHUOC GetBatchByMedIdAndExpDate(string medicineID, DateTime expDate)
        {
            return pharmacistDB.LOTHUOC.Where(batch => 
                batch.MaThuoc == medicineID && 
                batch.NgayHetHan == expDate
            ).FirstOrDefault();
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

        public NHACUNGCAP GetProviderByMedicineId(string medicineId)
        {
            return pharmacistDB.NHACUNGCAP.SqlQuery(
                "SELECT * FROM NHACUNGCAP " +
                "JOIN GIAODICH ON NHACUNGCAP.MaNhaCungCap = GIAODICH.MaNhaCungCap " +
                "JOIN LOTHUOC ON GIAODICH.MaLo = LOTHUOC.MaLo " +
                "WHERE NHACUNGCAP.MaNhaCungCap = (SELECT MaNhaCungCap FROM GIAODICH WHERE MaThuoc = @p0)", medicineId
            ).FirstOrDefault();
        }

        public NHACUNGCAP GetProviderByBatch(String batchId)
        {
            return pharmacistDB.NHACUNGCAP.SqlQuery(
                "SELECT TOP 1 NHACUNGCAP.* " +
                "FROM LOTHUOC " +
                "LEFT JOIN GIAODICH ON GIAODICH.MaLo = LOTHUOC.MaLo " +
                "LEFT JOIN NHACUNGCAP ON GIAODICH.MaNhaCungCap = NHACUNGCAP.MaNhaCungCap " +
                "WHERE NHACUNGCAP.MaNhaCungCap = ( " +
                "    SELECT TOP 1 MaNhaCungCap " +
                "    FROM GIAODICH " +
                "    WHERE MaLo = @p0 " +
                "    ORDER BY NgayThucHien DESC " +
                ") " +
                "ORDER BY NgayThucHien DESC",
                batchId
            ).FirstOrDefault();
        }

        public NHACUNGCAP GetProvider(GIAODICH transaction)
        {
            return pharmacistDB.NHACUNGCAP.Where(
                provider => provider.MaNhaCungCap == transaction.MaNhaCungCap
            ).FirstOrDefault();
        }
        public DateTime GetExpiration(string batchId, DateTime prodDate)
        {
            System.Diagnostics.Debug.WriteLine($"{batchId}, {prodDate}");

            var batch = pharmacistDB.LOTHUOC
                .Where(b => b.MaLo == batchId && b.NgaySanXuat == prodDate)
                .FirstOrDefault();

            System.Diagnostics.Debug.WriteLine($"BatchID: {batch.MaLo}");

            return batch.NgayHetHan;
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
            System.Diagnostics.Debug.WriteLine("Deleting batch...");
            System.Diagnostics.Debug.WriteLine("Finding batch to delete...");
            LOTHUOC batch = pharmacistDB.LOTHUOC.Include("THUOC").Where(
                lot => lot.MaLo == id
            ).FirstOrDefault();

            if (batch == null)
            {
                System.Diagnostics.Debug.WriteLine("Found no batch");
                System.Diagnostics.Debug.WriteLine("Delete batch failed");
                throw new Exception("Không tìm thấy lô thuốc cần xóa");
            }
            System.Diagnostics.Debug.WriteLine($"Found batch:\n" +
                $"Batch ID: {batch.MaLo}\n" +
                $"Batch Name: {batch.THUOC.TenThuoc}\n" +
                $"Production Date: {batch.NgaySanXuat}\n" +
                $"Expiration Date: {batch.NgayHetHan}\n" +
                $"Batch Quantity: {batch.SoLuong}\n"
            );
            pharmacistDB.LOTHUOC.Remove(batch);

            System.Diagnostics.Debug.WriteLine("Saving changes...");
            pharmacistDB.SaveChanges();
            System.Diagnostics.Debug.WriteLine("Delete batch successful");
        }

        public void DeleteTransaction(string id)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Deleting transaction...");
                System.Diagnostics.Debug.WriteLine("Finding transaction to delete...");
                GIAODICH transaction = pharmacistDB.GIAODICH.Where(
                    gd => gd.MaLo == id
                ).FirstOrDefault();

                if (transaction == null)
                {
                    System.Diagnostics.Debug.WriteLine("Found no transaction!");
                    System.Diagnostics.Debug.WriteLine("Delete transaction failed");
                    throw new Exception("Không tìm thấy giao dịch cần xóa");
                }
                System.Diagnostics.Debug.WriteLine("Found transaction:\n" +
                        $"TransactionID: {transaction.MaGiaoDich}\n" +
                        $"BatchID: {transaction.MaLo}\n" +
                        $"ProviderID: {transaction.MaNhaCungCap}\n" +
                        $"Type: {transaction.LoaiGiaoDich}\n" +
                        $"Date: {transaction.NgayThucHien?.ToString("ddMMyyyy")}\n" +
                        $"RemainingQuantity: {transaction.SoLuongTonConLai}\n" +
                        $"Status: {transaction.TinhTrang}\n"
                    );
                pharmacistDB.GIAODICH.Remove(transaction);

                System.Diagnostics.Debug.WriteLine("Saving changes...");
                pharmacistDB.SaveChanges();
                System.Diagnostics.Debug.WriteLine("Delete transaction successful");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteTransactionByProvider(string providerId)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Deleting transaction...");
                System.Diagnostics.Debug.WriteLine("Finding transaction to delete...");
                List<GIAODICH> transactions = pharmacistDB.GIAODICH.Where(
                    gd => gd.MaNhaCungCap == providerId
                ).ToList();

                if (transactions == null)
                {
                    System.Diagnostics.Debug.WriteLine("Found no transaction!");
                    System.Diagnostics.Debug.WriteLine("Delete transaction failed");
                    throw new Exception("Không tìm thấy giao dịch cần xóa");
                }
                foreach (GIAODICH transaction in transactions)
                {
                    System.Diagnostics.Debug.WriteLine("Deleting transaction:\n" +
                            $"TransactionID: {transaction.MaGiaoDich}\n" +
                            $"BatchID: {transaction.MaLo}\n" +
                            $"ProviderID: {transaction.MaNhaCungCap}\n" +
                            $"Type: {transaction.LoaiGiaoDich}\n" +
                            $"Date: {transaction.NgayThucHien?.ToString("ddMMyyyy")}\n" +
                            $"RemainingQuantity: {transaction.SoLuongTonConLai}\n" +
                            $"Status: {transaction.TinhTrang}\n"
                        );
                    pharmacistDB.GIAODICH.Remove(transaction);
                }

                System.Diagnostics.Debug.WriteLine("Saving changes...");
                pharmacistDB.SaveChanges();
                System.Diagnostics.Debug.WriteLine("Delete transaction successful");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteProvider(string id)
        {
            System.Diagnostics.Debug.WriteLine("Deleting provider...");
            System.Diagnostics.Debug.WriteLine("Searching for provider by id");
            NHACUNGCAP provider = pharmacistDB.NHACUNGCAP.Where(
                ncc => ncc.MaNhaCungCap == id
            ).FirstOrDefault();
            System.Diagnostics.Debug.WriteLine($"Found provider: {provider}");

            System.Diagnostics.Debug.Write($"Process status: ");
            if (provider != null)
            {
                pharmacistDB.NHACUNGCAP.Remove(provider);
                pharmacistDB.SaveChanges();
                System.Diagnostics.Debug.WriteLine($"Delete successful!");
            }
            System.Diagnostics.Debug.WriteLine($"Delete failed!");
        }

        // Other methods
        public void CreateNewTransaction(LOTHUOC batch, NHACUNGCAP provider, string transactionType)
        {
            if (batch == null)
            {
                throw new ArgumentException("Lô thuốc không được để trống");
            }
            if (provider == null)
            {
                throw new ArgumentException("Nhà cung cấp không được để trống");
            }

            if (String.IsNullOrEmpty(transactionType))
            {
                throw new ArgumentException("Loại giao dịch không được để trống", nameof(transactionType));
            }
            // TransactionID format: ddMMyyyy + FFF(hexadecimal)
            System.Diagnostics.Debug.WriteLine("Creating new transaction...");
            // Step 1: Get the latest transaction
            GIAODICH latestTransaction = GetLatestTransaction();
            System.Diagnostics.Debug.WriteLine("Getting latest transaction...");
            System.Diagnostics.Debug.WriteLine($"Latest transaction: {latestTransaction.MaGiaoDich} [{latestTransaction.NgayThucHien}]");

            System.Diagnostics.Debug.WriteLine($"Buiilding new transaction ID...");
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

            System.Diagnostics.Debug.WriteLine($"Adding new transaction:\n" +
                $"TransactionID: {newTransaction.MaGiaoDich}\n" +
                $"BatchID: {newTransaction.MaLo}\n" +
                $"ProviderID: {newTransaction.MaNhaCungCap}\n" +
                $"TransactionType: {newTransaction.LoaiGiaoDich}\n" +
                $"TransactionDate: {newTransaction.NgayThucHien}\n" +
                $"RemainingQuantity: {newTransaction.SoLuongTonConLai}\n" +
                $"TransactionStatus: {newTransaction.TinhTrang}\n"
            );
            AddOrUpdateTransaction(newTransaction);
            pharmacistDB.SaveChanges();
        }
    }
}
