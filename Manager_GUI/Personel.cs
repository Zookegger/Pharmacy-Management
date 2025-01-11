using Manager_BUS;
using PharmacistManagement_DAL.Model;
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
    public partial class frm_Personel : Form
    {
        private  ManagerServices ManagerServices = new ManagerServices();
        public frm_Personel()
        {
            InitializeComponent();
        }

        private void BindGrid(List<NHANVIEN> nhanViens)
        {
            dgv_Personel.Rows.Clear();
            foreach (var nhanVien in nhanViens)
            {
                int rowIndex = dgv_Personel.Rows.Add();
                dgv_Personel.Rows[rowIndex].Cells[0].Value = nhanVien.MaNhanVien;
                dgv_Personel.Rows[rowIndex].Cells[1].Value = nhanVien.HoTen;            
                dgv_Personel.Rows[rowIndex].Cells[2].Value = nhanVien.NgaySinh.ToString("dd/MM/yyyy");
                dgv_Personel.Rows[rowIndex].Cells[3].Value = nhanVien.GioiTinh ? "nam" : "nữ";
                dgv_Personel.Rows[rowIndex].Cells[4].Value = nhanVien.DiaChi;
                dgv_Personel.Rows[rowIndex].Cells[5].Value = nhanVien.SoDienThoai;            
                dgv_Personel.Rows[rowIndex].Cells[6].Value = nhanVien.Email;
                dgv_Personel.Rows[rowIndex].Cells[7].Value = nhanVien.NgayVaoLam.ToString("dd/MM/yyyy");
                dgv_Personel.Rows[rowIndex].Cells[8].Value = nhanVien.MaChucVu;
                dgv_Personel.Rows[rowIndex].Cells[9].Value = nhanVien.MaTiemThuoc;
            }
        }

        private void frm_Personel_Load(object sender, EventArgs e)
        {
            // Lấy danh sách nhân viên từ BUS
            List<NHANVIEN> nhanViens = ManagerServices.GetEmployeeList();
            // Hiển thị dữ liệu lên DataGridView
            BindGrid(nhanViens);

            
        }

        private void dgv_Personel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
