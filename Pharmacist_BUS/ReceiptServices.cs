using Pharmacist;
using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacist_BUS
{
    public class ReceiptServices
    {
        private PharmacyManagementDB db = new PharmacyManagementDB();

        public KHACHHANG GenerateNullCustomer()
        {
            return new KHACHHANG {
                MaKhachHang = GetLatestKhachhang().MaKhachHang + 1,
                HoTen = " ",
                DiaChi = " ",
                Email = " ",
                SoDienThoai = " ",
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

        public void ProcessPurchase(List<CHITIETDONTHUOC> items, KHACHHANG customer, NHANVIEN employee, out DONTHUOC receipt)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    DateTime earliestExpDate = DateTime.MaxValue; // Initialize to the maximum possible date

                    // Go through receipt details to find the earliest expiration date
                    foreach (CHITIETDONTHUOC item in items)
                    {
                        if (earliestExpDate > item.NgayHetHan)
                        {
                            earliestExpDate = item.NgayHetHan;
                        }
                    }

                    // Generate ReceiptID
                    string receiptID = GenerateReceiptID();

                    // Create new DonThuoc (Receipt)
                    var donThuoc = new DONTHUOC
                    {
                        MaDonThuoc = receiptID,
                        MaKhachHang = customer.MaKhachHang, 
                        MaNhanVien = employee.MaNhanVien, // Get current employee
                        NgayLenDon = DateTime.Now,
                        NgayHetHan = earliestExpDate // Use the earliest expiration date found
                    };

                    receipt = donThuoc;

                    db.DONTHUOC.Add(donThuoc);


                    // Add ChiTietDonThuoc (Details)
                    foreach (var item in items)
                    {
                        item.MaDonThuoc = receiptID;
                        System.Diagnostics.Debug.WriteLine($"Adding item {item.MaThuoc} to receipt {receiptID}");
                        db.CHITIETDONTHUOC.Add(item);
                    }

                    // Save all changes
                    db.SaveChanges();

                    // Commit transaction
                    transaction.Commit();

                    System.Diagnostics.Debug.WriteLine($"Receipt {receiptID} created successfully!");
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            System.Diagnostics.Debug.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        }
                    }
                    receipt = null;
                }
                catch (Exception ex)
                {
                    // Rollback in case of error
                    transaction.Rollback();
                    System.Diagnostics.Debug.WriteLine($"Error processing purchase: {ex.Message}");
                    receipt = null;
                }
            }
        }

        public List<CHITIETDONTHUOC> GetCartItemsFromGrid(DataGridView dataGridView)
        {
            List<CHITIETDONTHUOC> items = new List<CHITIETDONTHUOC>();
            BatchServices batchServices = new BatchServices();

            System.Diagnostics.Debug.WriteLine("\nItems in cart:");
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                String medicineId = row.Cells[0].Value.ToString();
                System.Diagnostics.Debug.WriteLine($"Medicine ID: {medicineId}");
                // Convert the expiration date cell value to DateTime
                DateTime prodDate = Convert.ToDateTime(row.Cells[3].Value);
                System.Diagnostics.Debug.WriteLine($"Expiration Date: {prodDate.ToString("dd/MM/yyyy")}");

                // Get batch ID using medicine ID and Batch prod date
                LOTHUOC batch = batchServices.GetBatchByMedIdAndExpDate(medicineId, prodDate);
                if (batch != null)
                {
                    CHITIETDONTHUOC item = new CHITIETDONTHUOC
                    {
                        MaThuoc = batch.MaThuoc,
                        SoLuong = int.Parse(row.Cells[4].Value.ToString()),
                        NgayHetHan = batch.NgayHetHan
                    };
                    items.Add(item);
                } else
                {
                    System.Diagnostics.Debug.WriteLine($"No batch found for Medicine ID: {medicineId} and Production Date: {prodDate}");
                }
            }

            return items;
        }

        public List<CHITIETDONTHUOC> GetReceiptDetails(DONTHUOC receipt)
        {
            return db.CHITIETDONTHUOC.Where(
                r => r.MaDonThuoc == receipt.MaDonThuoc
            ).ToList();
        }

        public void AddCustomer(KHACHHANG customer)
        {
            try
            {
                db.KHACHHANG.Add(customer);
                db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}
