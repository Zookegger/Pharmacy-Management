using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacistManagement_DAL.Model;
using static DevExpress.XtraBars.Painters.PrimitivesPainterWindowsXP;
using static Manager_GUI.frm_Transaction;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Manager_GUI
{
    public partial class frm_Transaction : Form
    {
        private List<GiaoDich> danhSachGiaoDich;
        public frm_Transaction()
        {
            InitializeComponent();
        }
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

        private void Transaction_Load(object sender, EventArgs e)
        {
            danhSachGiaoDich = new List<GiaoDich>();
            CapNhatDataGridView();
        }

        private void CapNhatDataGridView()
        {
            dgv_Transaction.DataSource = null;
            dgv_Transaction.DataSource = danhSachGiaoDich;
        }
        private void XoaTrangTextBox()
        {
            txt_Id.Text = "";
            txt_Name.Text = "";
            txt_Email.Text = "";
            txt_number.Text = "";
            txt_Address.Text = "";
            txt_TransactionType.Text = "";
            txt_Money.Text = "";
            txt_Status.Text = "";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txt_Id.Text) || string.IsNullOrWhiteSpace(txt_Name.Text) || string.IsNullOrWhiteSpace(txt_TransactionType.Text) || string.IsNullOrWhiteSpace(txt_Money.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm giao dịch mới
            GiaoDich giaoDichMoi = new GiaoDich
            {
                MaGiaoDich = txt_Id.Text,
                TenKhachHang = txt_Name.Text,
                Email = txt_Email.Text,
                SoDienThoai = txt_number.Text,
                DiaChi = txt_Address.Text,
                LoaiGiaoDich = txt_TransactionType.Text,
                SoTien = decimal.Parse(txt_Money.Text),
                NgayGiaoDich = DateTime.Now,
                TrangThai = txt_Status.Text
            };

            danhSachGiaoDich.Add(giaoDichMoi);
            CapNhatDataGridView();

            MessageBox.Show("Thêm giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa trắng các ô nhập liệu
            XoaTrangTextBox();

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Transaction.SelectedRows.Count > 0)
            {
                int index = dgv_Transaction.SelectedRows[0].Index;

                // Xóa giao dịch trong danh sách
                danhSachGiaoDich.RemoveAt(index);
                CapNhatDataGridView();

                MessageBox.Show("Xóa giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một giao dịch để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dgv_Transaction.SelectedRows.Count > 0)
            {
                int index = dgv_Transaction.SelectedRows[0].Index;

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txt_Id.Text) || string.IsNullOrWhiteSpace(txt_Name.Text) || string.IsNullOrWhiteSpace(txt_TransactionType.Text) || string.IsNullOrWhiteSpace(txt_Money.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               

                CapNhatDataGridView();

                MessageBox.Show("Sửa giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa trắng các ô nhập liệu
                XoaTrangTextBox();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một giao dịch để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

