using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Manager_BUS
{
    public class ManagerServices
    {
        private PharmacyManagementDB db = new PharmacyManagementDB();

        public DataTable GetEmployeeTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("col_StoreName", typeof(string));
            table.Columns.Add("col_EmployeeName", typeof(string));
            table.Columns.Add("col_DateOfBirth", typeof(DateTime));
            table.Columns.Add("col_JobName", typeof(string));

            List<NHANVIEN> employeeList = GetEmployeeList();
            System.Diagnostics.Debug.WriteLine($"Found {employeeList.Count} Employees");

            foreach (NHANVIEN employee in employeeList)
            {
                string storeName = employee.TIEMTHUOCTAY.TenChiNhanh;

                table.Rows.Add(
                    employee.TIEMTHUOCTAY.TenChiNhanh,
                    employee.HoTen,
                    employee.NgaySinh,
                    employee.CHUCVU.TenChucVu
                );
                System.Diagnostics.Debug.WriteLine($"Added employee to table:\n" +
                    $"\t{employee.TIEMTHUOCTAY.TenChiNhanh},\n" +
                    $"\t{employee.HoTen},\n" +
                    $"\t{employee.NgaySinh}\n" +
                    $"\t{employee.CHUCVU.TenChucVu}\n"
                );
            }

            return table;
        }

        public List<NHANVIEN> GetEmployeeList()
        {
            return db.NHANVIEN.ToList();
        }

        public List<NHANVIEN> GetEmployeeList(string search)
        {
            // Chuyển search về chữ thường để so sánh
            search = search?.ToLower();

            // Lọc nhân viên theo từ khóa
            return db.NHANVIEN.Where(emp =>
                emp.MaNhanVien.ToLower().Contains(search) ||  // Lọc theo mã nhân viên
                emp.HoTen.ToLower().Contains(search)    // Lọc theo tên nhân viên
            ).ToList();
        }

        public NHANVIEN GetEmployeeByID(String employeeId)
        {
            return db.NHANVIEN.Where(employee => employee.MaNhanVien == employeeId).FirstOrDefault();
        }

        public NHANVIEN GetEmployeeByName(String employeeName)
        {
            return db.NHANVIEN.Where(employee => employee.HoTen.ToLower() == employeeName.ToLower()).FirstOrDefault();
        }

        public List<NHANVIEN> GetEmployeeByNameList(string employeeName)
        {
            return db.NHANVIEN.Where(
                employee => employee.HoTen.ToLower().Contains(employeeName)
            ).ToList();
        }

        public List<BillDetailDTO> GetBillDetails()
        {
            var query = from d in db.DONTHUOC
                        join c in db.CHITIETDONTHUOC on d.MaDonThuoc equals c.MaDonThuoc
                        join t in db.THUOC on c.MaThuoc equals t.MaThuoc
                        select new
                        {
                            d.MaDonThuoc,
                            d.MaKhachHang,
                            t.TenThuoc,
                            c.SoLuong,
                            d.NgayLenDon,
                            TongTien = c.SoLuong * t.GiaDonVi
                        };

            // Thực hiện chuyển đổi sau khi truy vấn
            var result = query.AsEnumerable() // Chuyển đổi từ LINQ to Entities sang LINQ to Objects
                              .Select(x => new BillDetailDTO
                              {
                                  // Sử dụng TryParse để kiểm tra và chuyển đổi dữ liệu
                                  MaDonThuoc = x.MaDonThuoc,
                                  MaKhachHang = x.MaKhachHang,
                                  TenThuoc = x.TenThuoc,
                                  SoLuong = x.SoLuong,
                                  NgayLenDon = x.NgayLenDon,
                                  TongTien = x.TongTien
                              })
                              .ToList();

            return result;
        }

        public CustomerDTO GetCustomerDetails(int maKhachHang)
        {
            var khachHang = db.KHACHHANG
                                   .Where(kh => kh.MaKhachHang == maKhachHang)
                                   .Select(kh => new CustomerDTO
                                   {
                                       MaKhachHang = kh.MaKhachHang,
                                       TenKhachHang = kh.HoTen,
                                       SoDienThoai = kh.SoDienThoai,
                                       DiaChi = kh.DiaChi,
                                       Email = kh.Email
                                   })
                                   .FirstOrDefault();

            return khachHang;
        }


        public class BillDetailDTO
        {
            public string MaDonThuoc { get; set; }
            public int MaKhachHang { get; set; }
            public string TenThuoc { get; set; }
            public int SoLuong { get; set; }
            public DateTime NgayLenDon { get; set; }
            public decimal TongTien { get; set; }
        }

        public class CustomerDTO
        {
            public int MaKhachHang { get; set; }
            public string TenKhachHang { get; set; }
            public string SoDienThoai { get; set; }
            public string DiaChi { get; set; }
            public string Email { get; set; }
        }

        public List<CHUCVU> GetPositions()
        {
            return db.CHUCVU.ToList();
        }
        public List<TIEMTHUOCTAY> GetStores()
        {
            return db.TIEMTHUOCTAY.ToList();
        }
        public bool AddEmployee(NHANVIEN nhanVien)
        {
            try
            {
                db.NHANVIEN.Add(nhanVien);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateEmployee(NHANVIEN updatedNhanVien)
        {
            try
            {
                var nhanVien = db.NHANVIEN.Find(updatedNhanVien.MaNhanVien);
                if (nhanVien != null)
                {
                    nhanVien.HoTen = updatedNhanVien.HoTen;
                    nhanVien.NgaySinh = updatedNhanVien.NgaySinh;
                    nhanVien.GioiTinh = updatedNhanVien.GioiTinh;
                    nhanVien.DiaChi = updatedNhanVien.DiaChi;
                    nhanVien.SoDienThoai = updatedNhanVien.SoDienThoai;
                    nhanVien.Email = updatedNhanVien.Email;
                    nhanVien.NgayVaoLam = updatedNhanVien.NgayVaoLam;
                    nhanVien.MaChucVu = updatedNhanVien.MaChucVu;
                    nhanVien.MaTiemThuoc = updatedNhanVien.MaTiemThuoc;

                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteEmployee(string maNhanVien)
        {
            try
            {
                var nhanVien = db.NHANVIEN.Find(maNhanVien);
                if (nhanVien != null)
                {
                    db.NHANVIEN.Remove(nhanVien);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
