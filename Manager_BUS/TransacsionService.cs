using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_BUS
{
    
        internal class TransactionService
        {
            private List<GiaoDich> _danhSachGiaoDich;

            public TransactionService()
            {
                _danhSachGiaoDich = new List<GiaoDich>();
            }

            // Lấy danh sách giao dịch
            public List<GiaoDich> GetAllTransactions()
            {
                return _danhSachGiaoDich;
            }

            // Thêm giao dịch mới
            public string AddTransaction(GiaoDich giaoDichMoi)
            {
                if (_danhSachGiaoDich.Exists(x => x.MaGiaoDich == giaoDichMoi.MaGiaoDich))
                {
                    return "Mã giao dịch đã tồn tại.";
                }

                _danhSachGiaoDich.Add(giaoDichMoi);
                return "Thêm giao dịch thành công.";
            }

            // Xóa giao dịch
            public string DeleteTransaction(string maGiaoDich)
            {
                var giaoDich = _danhSachGiaoDich.Find(x => x.MaGiaoDich == maGiaoDich);
                if (giaoDich == null)
                {
                    return "Không tìm thấy giao dịch để xóa.";
                }

                _danhSachGiaoDich.Remove(giaoDich);
                return "Xóa giao dịch thành công.";
            }

            // Cập nhật giao dịch
            public string UpdateTransaction(GiaoDich giaoDichCapNhat)
            {
                var giaoDich = _danhSachGiaoDich.Find(x => x.MaGiaoDich == giaoDichCapNhat.MaGiaoDich);
                if (giaoDich == null)
                {
                    return "Không tìm thấy giao dịch để cập nhật.";
                }

                giaoDich.TenKhachHang = giaoDichCapNhat.TenKhachHang;
                giaoDich.Email = giaoDichCapNhat.Email;
                giaoDich.SoDienThoai = giaoDichCapNhat.SoDienThoai;
                giaoDich.DiaChi = giaoDichCapNhat.DiaChi;
                giaoDich.LoaiGiaoDich = giaoDichCapNhat.LoaiGiaoDich;
                giaoDich.SoTien = giaoDichCapNhat.SoTien;
                giaoDich.NgayGiaoDich = giaoDichCapNhat.NgayGiaoDich;
                giaoDich.TrangThai = giaoDichCapNhat.TrangThai;

                return "Cập nhật giao dịch thành công.";
            }
        }

        // Lớp GiaoDich
        public class GiaoDich
        {
            public string MaGiaoDich { get; set; }
            public string TenKhachHang { get; set; }
            public string Email { get; set; }
            public string SoDienThoai { get; set; }
            public string DiaChi { get; set; }
            public string LoaiGiaoDich { get; set; }
            public decimal SoTien { get; set; }
            public DateTime NgayGiaoDich { get; set; }
            public string TrangThai { get; set; }
        }
    }

