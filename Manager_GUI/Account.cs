using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacistManagement_DAL.Model;

namespace Manager_GUI
{
    public partial class frm_Account : Form
    {
        private List<Account> danhSachTaiKhoan;
        public frm_Account()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo danh sách tài khoản
            danhSachTaiKhoan = new List<Account>();
            CapNhatDataGridView();
        }
        public class Account
        {
            public string MaTaiKhoan { get; set; }
            public string TenTaiKhoan { get; set; }
            public string MatKhau { get; set; }
            public string TrangThai { get; set; }
            public string LanCapNhat { get; set; }
        }
        private void CapNhatDataGridView()
        {
            dgv_Account.DataSource = null;
            dgv_Account.DataSource = danhSachTaiKhoan;
        }
        private void XoaTrangTextBox()
        {
            txt_Id.Text = "";
            txt_Name.Text = "";
            txt_Password.Text = "";
            txt_Status.Text = "";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txt_Id.Text) || string.IsNullOrWhiteSpace(txt_Name.Text) || string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm tài khoản mới
            Account taiKhoanMoi = new Account
            {
                MaTaiKhoan = txt_Id.Text,
                TenTaiKhoan = txt_Name.Text,
                MatKhau = txt_Password.Text,
                TrangThai = txt_Status.Text,
                LanCapNhat = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            };

            danhSachTaiKhoan.Add(taiKhoanMoi);
            CapNhatDataGridView();

            MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa trắng các ô nhập liệu
            XoaTrangTextBox();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Account.SelectedRows.Count > 0)
            {
                int index = dgv_Account.SelectedRows[0].Index;

                // Xóa tài khoản trong danh sách
                danhSachTaiKhoan.RemoveAt(index);
                CapNhatDataGridView();

                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dgv_Account.SelectedRows.Count > 0)
            {
                int index = dgv_Account.SelectedRows[0].Index;

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txt_Id.Text) || string.IsNullOrWhiteSpace(txt_Name.Text) || string.IsNullOrWhiteSpace(txt_Password.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Sửa thông tin tài khoản
                danhSachTaiKhoan[index].MaTaiKhoan = txt_Id.Text;
                danhSachTaiKhoan[index].TenTaiKhoan = txt_Name.Text;
                danhSachTaiKhoan[index].MatKhau = txt_Password.Text;
                danhSachTaiKhoan[index].TrangThai = txt_Status.Text;
                danhSachTaiKhoan[index].LanCapNhat = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                CapNhatDataGridView();

                MessageBox.Show("Sửa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa trắng các ô nhập liệu
                XoaTrangTextBox();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
