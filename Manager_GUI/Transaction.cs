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
using Manager_BUS;
using static Manager_BUS.TransactionService;

namespace Manager_GUI
{
    public partial class frm_Transaction : Form
    {


        private TransactionService transaction = new TransactionService();
        public frm_Transaction()
        {
            InitializeComponent();
        }

        private void BindGrid(List<GIAODICH> giaodichs)
        {
            dgv_Transaction.Rows.Clear();



            foreach (var giaodich in giaodichs)
            {
                int rowIndex = dgv_Transaction.Rows.Add();
                dgv_Transaction.Rows[rowIndex].Cells[0].Value = giaodich.MaGiaoDich;
                dgv_Transaction.Rows[rowIndex].Cells[1].Value = giaodich.MaLo;
                dgv_Transaction.Rows[rowIndex].Cells[2].Value = giaodich.MaNhaCungCap;
                dgv_Transaction.Rows[rowIndex].Cells[3].Value = giaodich.LoaiGiaoDich;
                dgv_Transaction.Rows[rowIndex].Cells[4].Value = giaodich.NgayThucHien;
                dgv_Transaction.Rows[rowIndex].Cells[5].Value = giaodich.SoLuongTonConLai;
                dgv_Transaction.Rows[rowIndex].Cells[6].Value = giaodich.TinhTrang;



            }
        }


        private void Transaction_Load(object sender, EventArgs e)
        {
            List<GIAODICH> giaodichs = transaction.GetTransactionList();
            BindGrid(giaodichs);
        }

        private void dgv_Transaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng người dùng chọn một hàng hợp lệ
            {
                DataGridViewRow selectedRow = dgv_Transaction.Rows[e.RowIndex];

                // Lấy thông tin giao dịch từ DataGridView
                string maGiaoDich = selectedRow.Cells[0].Value?.ToString();
                string loaiGiaoDich = selectedRow.Cells[3].Value?.ToString();

                // Lấy Mã Nhà Cung Cấp từ cột tương ứng
                string maNhaCungCap = selectedRow.Cells[2].Value?.ToString();

                // Hiển thị thông tin giao dịch
                txt_Id.Text = maGiaoDich;
                txt_TransactionType.Text = loaiGiaoDich;

                if (!string.IsNullOrEmpty(maNhaCungCap))
                {
                    // Tìm nhà cung cấp trong database
                    NhaCungCapService supplierService = new NhaCungCapService();
                    NHACUNGCAP supplier = supplierService.GetSupplierById(maNhaCungCap);

                    if (supplier != null)
                    {
                        // Đổ dữ liệu nhà cung cấp lên các TextBox
                        txt_idsupply.Text = supplier.MaNhaCungCap;
                        txt_Name.Text = supplier.TenNhaCungCap;
                        txt_Address.Text = supplier.DiaChi;
                        txt_number.Text = supplier.SoDienThoai;
                        txt_Email.Text = supplier.Email;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin nhà cung cấp!");
                    }
                }
            }
        }
        
    }
}
 

