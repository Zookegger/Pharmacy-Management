using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacist_BUS
{
    public class ReceiptServices
    {
        private PharmacyManagementDB db = new PharmacyManagementDB();

        public KHACHHANG nullCustomer()
        {
            return new KHACHHANG {
                MaKhachHang = GetLatestKhachhang().MaKhachHang + 1,
                HoTen = null,
                DiaChi = null,
                Email = null,
                SoDienThoai = null,
            };
        }

        public KHACHHANG GetLatestKhachhang() {
            var latestCustomer = db.DONTHUOC.OrderByDescending(r => r.NgayLenDon).FirstOrDefault();

            return latestCustomer.KHACHHANG; 
            
        }

        public string GenerateReceiptID()
        {
            string datePart = DateTime.Now.ToString("ddMMyy");
            var latestReceipt = db.DONTHUOC.Where(r => 
                r.MaDonThuoc.StartsWith(datePart))
                .OrderByDescending(r => r.MaDonThuoc)
                .FirstOrDefault();
            
            int sequenceNumber = 1;

            if (latestReceipt != null)
            {
                // Extract the hexadecimal sequence from the latest receipt ID
                string latestHexSequence = latestReceipt.MaDonThuoc.Substring(7);
                sequenceNumber = int.Parse(latestHexSequence, System.Globalization.NumberStyles.HexNumber) + 1;
            }
            string sequencePart = sequenceNumber.ToString("X3");

            return $"{datePart}-{sequencePart}";
        }

        public void ProcessPurchase(int customerId, List<CHITIETDONTHUOC> items, KHACHHANG customer)
        {
            using (var transaction = db.Database.BeginTransaction())
            {

                try
                {
                    // Generate ReceiptID
                    string receiptID = GenerateReceiptID();

                    // Create new DonThuoc (Receipt)
                    var donThuoc = new DONTHUOC
                    {
                        MaDonThuoc = receiptID,
                        MaKhachHang = customer.MaKhachHang,
                        NgayLenDon = DateTime.Now,
                        NgayHetHan = DateTime.Now.AddMonths(6) // Example expiry date
                    };

                    db.DONTHUOC.Add(donThuoc);

                    // Add ChiTietDonThuoc (Details)
                    foreach (var item in items)
                    {
                        item.MaDonThuoc = receiptID;
                        db.CHITIETDONTHUOC.Add(item);
                    }

                    // Save all changes
                    db.SaveChanges();

                    // Commit transaction
                    transaction.Commit();

                    System.Diagnostics.Debug.WriteLine($"Receipt {receiptID} created successfully!");
                }
                catch (Exception ex)
                {
                    // Rollback in case of error
                    transaction.Rollback();
                    System.Diagnostics.Debug.WriteLine($"Error processing purchase: {ex.Message}");
                }
            }
        }
    }
}
