using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Manager_BUS
{
    public class ManagerServices
    {
        private PharmacyManagementDB context = new PharmacyManagementDB();

        public List<NHANVIEN> GetEmployeeList()
        {
            return context.NHANVIEN.ToList();
        }

        public List<NHANVIEN> GetEmployeeList(string search)
        {
            // Chuyển search về chữ thường để so sánh
            search = search?.ToLower();

            // Lọc nhân viên theo từ khóa
            return context.NHANVIEN.Where(emp =>
                emp.MaNhanVien.ToLower().Contains(search) ||  // Lọc theo mã nhân viên
                emp.HoTen.ToLower().Contains(search)    // Lọc theo tên nhân viên
            ).ToList();
        }


        public List<BillDetailDTO> GetBillDetails()
        {
            var query = from d in context.DONTHUOC
                        join c in context.CHITIETDONTHUOC on d.MaDonThuoc equals c.MaDonThuoc
                        join t in context.THUOC on c.MaThuoc equals t.MaThuoc
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

        public CustomerDTO GetCustomerDetails(string maKhachHang)
        {
            var khachHang = context.KHACHHANG
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
            public string MaKhachHang { get; set; }
            public string TenThuoc { get; set; }
            public int SoLuong { get; set; }
            public DateTime NgayLenDon { get; set; }
            public decimal TongTien { get; set; }
        }

        public class CustomerDTO
        {
            public string MaKhachHang { get; set; }
            public string TenKhachHang { get; set; }
            public string SoDienThoai { get; set; }
            public string DiaChi { get; set; }
            public string Email { get; set; }
        }
    }
}
