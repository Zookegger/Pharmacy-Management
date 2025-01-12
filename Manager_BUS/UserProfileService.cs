using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_BUS
{
    public class UserProfileService
    {
        // Class đại diện cho dữ liệu người dùng
        public class UserProfileData
        {
            public string HoTen { get; set; }
            public string DiaChi { get; set; }
            public string SoDienThoai { get; set; }
            public string Email { get; set; }
            public string ChucVu { get; set; }
            public string GioiTinh { get; set; }
            public DateTime NgaySinh { get; set; }
        }

        // Phương thức làm mới (reset thông tin người dùng)
        public UserProfileData ResetUserProfile()
        {
            return new UserProfileData
            {
                HoTen = string.Empty,
                DiaChi = string.Empty,
                SoDienThoai = string.Empty,
                Email = string.Empty,
                ChucVu = null,
                GioiTinh = null,
                NgaySinh = DateTime.Now
            };
        }

        // Phương thức cập nhật thông tin người dùng
        public string UpdateUserProfile(UserProfileData data)
        {
            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrEmpty(data.HoTen))
                return "Họ Tên không được để trống.";
            if (string.IsNullOrEmpty(data.SoDienThoai))
                return "Số Điện Thoại không được để trống.";
            if (string.IsNullOrEmpty(data.Email))
                return "Email không được để trống.";

            // Giả lập lưu trữ dữ liệu (hoặc cập nhật vào cơ sở dữ liệu nếu cần)
            // Ở đây chỉ trả về thông báo thành công
            return "Thông tin đã được cập nhật thành công.";
        }
    }
}
