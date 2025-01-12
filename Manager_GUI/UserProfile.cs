using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_GUI
{
    public partial class frm_UserProfile : Form
    {
        public frm_UserProfile()
        {
            InitializeComponent();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            // Clear all TextBoxes
            txt_Name.Clear();
            txt_address.Clear();
            txt_number.Clear();
            txt_email.Clear();

            // Reset ComboBox
            cmb_position.SelectedIndex = -1;

            // Uncheck CheckBoxes
            ckb_Male.Checked = false;
            ckb_Female.Checked = false;

            // Reset DateTimePicker to current date
            dtp_dateborn.Value = DateTime.Now;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            // Collect user input
            string hoTen = txt_Name.Text;
            string diaChi = txt_address.Text;
            string soDienThoai = txt_number.Text;
            string email = txt_email.Text;
            string chucVu = cmb_position.SelectedItem != null ? cmb_position.SelectedItem.ToString() : "";
            string gioiTinh = ckb_Male.Checked ? "Nam" : ckb_Female.Checked ? "Nữ" : "Chưa chọn";
            DateTime ngaySinh = dtp_dateborn.Value;

            // Display a confirmation message
            MessageBox.Show($"Thông tin đã được cập nhật:\n" +
                $"- Họ Tên: {hoTen}\n" +
                $"- Địa Chỉ: {diaChi}\n" +
                $"- Số Điện Thoại: {soDienThoai}\n" +
                $"- Email: {email}\n" +
                $"- Chức Vụ: {chucVu}\n" +
                $"- Giới Tính: {gioiTinh}\n" +
                $"- Ngày Sinh: {ngaySinh.ToShortDateString()}",
                "Thông Báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
