using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacist
{
    public class MedicineServices
    {
        private readonly PharmacyManagementDB pharmacistDB = new PharmacyManagementDB();
        public List<THUOC> GetMedicineList()
        {
            return pharmacistDB.THUOC.ToList();
        }
        public DataTable GetMedicineTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã Thuốc", typeof(string));
            table.Columns.Add("Tên Thuốc", typeof(string));
            table.Columns.Add("Giá Đơn Vị", typeof(string));
            table.Columns.Add("Liều Thuốc", typeof(string));
            table.Columns.Add("Mô Tả", typeof(String));
            table.Columns.Add("Số Lượng Tồn", typeof(int));
            foreach (THUOC medicine in GetMedicineList())
            {
                table.Rows.Add(medicine.MaThuoc, medicine.TenThuoc, medicine.GiaDonVi, medicine.LieuThuoc, medicine.MoTa, medicine.SoLuongTon);
                System.Diagnostics.Debug.WriteLine($"Added medicine:\n" +
                    $"\t{medicine.MaThuoc},\n" +
                    $"\t{medicine.TenThuoc},\n" +
                    $"\t{medicine.GiaDonVi}\n" +
                    $"\t{medicine.LieuThuoc}\n" +
                    $"\t{medicine.MoTa}\n" +
                    $"\t{medicine.SoLuongTon}\n"
                );
            }
            return table;
        }
        public List<THUOC> GetMedicineList(string search)
        {
            search = search.ToLower();
            return pharmacistDB.THUOC.Where(med => 
                med.MaThuoc.ToLower().Contains(search) ||
                med.TenThuoc.ToLower().Contains(search) 
            ).ToList();
        }
        public THUOC GetMedicineByName(string name)
        {
            return pharmacistDB.THUOC.Where(med => med.TenThuoc == name).FirstOrDefault();
        }
        public THUOC GetMedicineById(string id)
        {
            return pharmacistDB.THUOC.Where(med => med.MaThuoc == id).FirstOrDefault();
        }
        public void DeleteMedicineById(string id)
        {
            try
            {
                THUOC medicine = pharmacistDB.THUOC.Where(med => med.MaThuoc == id).FirstOrDefault();
                if (medicine != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Found medicine: {medicine.TenThuoc}");

                    // Handle references in CHITIETDONTHUOC table
                    var details = pharmacistDB.CHITIETDONTHUOC.Where(ctdt => ctdt.MaThuoc == id).ToList();
                    foreach (var detail in details)
                    {
                        System.Diagnostics.Debug.WriteLine($"Deleting CHITIETDONTHUOC: {detail.MaDonThuoc}, {detail.MaThuoc}");
                    }
                    pharmacistDB.CHITIETDONTHUOC.RemoveRange(details);

                    // Handle references in LOTHUOC table (batches)
                    var batches = pharmacistDB.LOTHUOC.Where(lot => lot.MaThuoc == id).ToList();
                    foreach (var batch in batches)
                    {
                        System.Diagnostics.Debug.WriteLine($"Deleting batch: {batch.MaLo}");

                        var transactions = pharmacistDB.GIAODICH.Where(gd => gd.MaLo == batch.MaLo).ToList();

                        System.Diagnostics.Debug.WriteLine("Found transactions:");
                        foreach (var transaction in transactions)
                        {
                            System.Diagnostics.Debug.WriteLine($"{transaction.MaGiaoDich}");
                        }
                        foreach (var transaction in transactions)
                        {
                            System.Diagnostics.Debug.WriteLine($"Deleting transaction: {transaction.MaGiaoDich}");
                        }
                        pharmacistDB.GIAODICH.RemoveRange(transactions);
                    }
                    pharmacistDB.LOTHUOC.RemoveRange(batches);

                    // Now delete the medicine itself
                    System.Diagnostics.Debug.WriteLine($"Deleting medicine: {medicine.MaThuoc}, {medicine.TenThuoc}");
                    pharmacistDB.THUOC.Remove(medicine);

                    // Save changes to the database
                    System.Diagnostics.Debug.WriteLine("Saving changes to Database...");
                    pharmacistDB.SaveChanges();
                }
                else
                {
                    throw new Exception("Không tìm thấy thuốc cần xóa!");
                }

            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationError in ex.EntityValidationErrors)
                {
                    foreach (var error in validationError.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine($"Property: {error.PropertyName}, Error: {error.ErrorMessage}");
                    }
                }
                throw; // Re-throw the exception if needed
            }
            catch (DbUpdateException ex)
            {
                // Log DbUpdateException details
                System.Diagnostics.Debug.WriteLine($"DbUpdateException: {ex.ToString()}");
                System.Diagnostics.Debug.WriteLine($"Inner Exception: {ex.InnerException?.Message}");
                throw; // Re-throw the exception for further handling
            }
            catch (Exception ex)
            {
                // General exception handler
                System.Diagnostics.Debug.WriteLine($"Exception: {ex.ToString()}");
                System.Diagnostics.Debug.WriteLine($"Inner Exception: {ex.InnerException?.Message}");
                throw; // Re-throw the exception
            }
        }
        public void AddOrUpdateMedicine(THUOC medicine)
        {
            try
            {
                pharmacistDB.THUOC.AddOrUpdate(medicine);
                System.Diagnostics.Debug.WriteLine("Saving changes...");
                pharmacistDB.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationError in ex.EntityValidationErrors)
                {
                    foreach (var error in validationError.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine($"Property: {error.PropertyName}, Error: {error.ErrorMessage}");
                    }
                }
                throw; // Re-throw the exception if needed
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                throw;
            }
        }
        public void UpdateMedicineQuantity(string medicineId, int newBatchQuantity)
        {
            System.Diagnostics.Debug.WriteLine("Updating stock quantity...");
            System.Diagnostics.Debug.WriteLine("Searching for medicine to update stock...");
            THUOC medicine = pharmacistDB.THUOC.Where(med => med.MaThuoc == medicineId).FirstOrDefault();
            if (medicine == null)
            {
                System.Diagnostics.Debug.WriteLine("Found no medicine");
                throw new Exception("Không tìm thấy thuốc");
            }
            System.Diagnostics.Debug.WriteLine($"Found medicine:\n" +
                $"MedicineID: {medicine.MaThuoc}\n" +
                $"MedicineName: {medicine.TenThuoc}\n" +
                $"Price per unit: {medicine.GiaDonVi}\n" +
                $"Quantity: {medicine.SoLuongTon}\n" +
                $"Description: {medicine.MoTa}\n"
            );
            medicine.SoLuongTon += newBatchQuantity;

            System.Diagnostics.Debug.WriteLine("Saving changes...");
            pharmacistDB.SaveChanges();
        }
        public void AddOrUpdateProvider(NHACUNGCAP provider)
        {
            pharmacistDB.NHACUNGCAP.AddOrUpdate(provider);
            pharmacistDB.SaveChanges();
        }
    }
}
