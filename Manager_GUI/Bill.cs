using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manager_BUS;
using PharmacistManagement_DAL.Model;

namespace Manager_GUI
{
    public partial class frm_BillingAnalytics : Form
    {
        public frm_BillingAnalytics()
        {
            InitializeComponent();
            newManagerServices = new ManagerServices();
        }
        private ManagerServices newManagerServices;

        private void dgv_Medicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frm_BillingAnalytics_Load(object sender, EventArgs e)
        {
            LoadBillDetails();
        }

        private void LoadBillDetails()
        {
            // Lấy dữ liệu từ BUS
            var bills = newManagerServices.GetBillDetails();

            // Dọn dẹp các hàng hiện tại trong DataGridView
            dgv_Bill.Rows.Clear();

            // Lặp qua các bản ghi và thêm vào DataGridView
            foreach (var bill in bills)
            {
                // Thêm một hàng mới vào DataGridView
                int rowIndex = dgv_Bill.Rows.Add();

                // Gán giá trị vào các cột đã có sẵn
                dgv_Bill.Rows[rowIndex].Cells[0].Value = bill.MaDonThuoc;
                dgv_Bill.Rows[rowIndex].Cells[1].Value = bill.MaKhachHang;
                dgv_Bill.Rows[rowIndex].Cells[2].Value = bill.TenThuoc;
                dgv_Bill.Rows[rowIndex].Cells[3].Value = bill.SoLuong;
                dgv_Bill.Rows[rowIndex].Cells[4].Value = bill.NgayLenDon.ToString("dd/MM/yyyy");
                dgv_Bill.Rows[rowIndex].Cells[5].Value = bill.TongTien;
            }

            // Tùy chỉnh hiển thị cột (nếu cần)
            dgv_Bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_ID_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng được chọn có hợp lệ không
            if (e.RowIndex >= 0 && e.RowIndex < dgv_Bill.Rows.Count)
            {
                // Lấy mã khách hàng từ cột "MaKhachHang" của hàng được chọn
                string maKhachHang = dgv_Bill.Rows[e.RowIndex].Cells[1].Value?.ToString();

                if (!string.IsNullOrEmpty(maKhachHang))
                {
                    // Gọi phương thức lấy thông tin khách hàng
                    var khachHang = newManagerServices.GetCustomerDetails(maKhachHang);

                    if (khachHang != null)
                    {
                        // Hiển thị dữ liệu khách hàng lên giao diện (ví dụ: TextBox hoặc các Control khác)
                        txt_Id.Text = khachHang.MaKhachHang;
                        txt_Name.Text = khachHang.TenKhachHang;
                        txt_number.Text = khachHang.SoDienThoai;
                        txt_Address.Text = khachHang.DiaChi;
                        txt_Email.Text = khachHang.Email;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
