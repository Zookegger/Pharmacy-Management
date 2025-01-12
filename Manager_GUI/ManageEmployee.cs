using Manager_BUS;
using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_GUI
{
    public partial class frm_Personel : System.Windows.Forms.Form
    {
        private ManagerServices ManagerServices = new ManagerServices();
        public frm_Personel()
        {
            InitializeComponent();
        }

        private void BindGrid(List<NHANVIEN> nhanViens)
        {
            dgv_Personel.Rows.Clear();

            // Lấy danh sách chức vụ và tiệm để sử dụng trong việc đổi mã thành tên
            var chucVus = ManagerServices.GetPositions();  // Lấy danh sách chức vụ
            var tiemThuocs = ManagerServices.GetStores();  // Lấy danh sách tiệm thuốc

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

                // Tìm tên chức vụ từ danh sách chức vụ
                var chucVu = chucVus.FirstOrDefault(cv => cv.MaChucVu == nhanVien.MaChucVu);
                dgv_Personel.Rows[rowIndex].Cells[8].Value = chucVu?.TenChucVu ?? "Chưa có chức vụ";

                // Tìm tên tiệm từ danh sách tiệm
                var tiemThuoc = tiemThuocs.FirstOrDefault(t => t.MaTiemThuoc == nhanVien.MaTiemThuoc);
                dgv_Personel.Rows[rowIndex].Cells[9].Value = tiemThuoc?.TenChiNhanh ?? "Chưa có tiệm";
            }
        }

        private void frm_Personel_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            // Lấy danh sách nhân viên từ BUS
            List<NHANVIEN> nhanViens = ManagerServices.GetEmployeeList();
            // Hiển thị dữ liệu lên DataGridView
            BindGrid(nhanViens);


        }

        private void dgv_Personel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadComboBoxes()
        {
            // Lấy danh sách chức vụ
            var chucVus = ManagerServices.GetPositions();
            cmb_position.DataSource = chucVus;
            cmb_position.DisplayMember = "TenChucVu"; // Hiển thị tên chức vụ
            cmb_position.ValueMember = "MaChucVu"; // Giá trị là mã chức vụ

            // Lấy danh sách tiệm thuốc
            var tiemThuocs = ManagerServices.GetStores();
            cmb_id.DataSource = tiemThuocs;
            cmb_id.DisplayMember = "TenChiNhanh"; // Hiển thị tên tiệm thuốc
            cmb_id.ValueMember = "MaTiemThuoc"; // Giá trị là mã tiệm thuốc
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                var nhanVien = new NHANVIEN
                {
                    MaNhanVien = txt_Id.Text,
                    HoTen = txt_name.Text,
                    NgaySinh = dtp_dateborn.Value,
                    GioiTinh = ckb_Male.Checked,
                    DiaChi = txt_address.Text,
                    SoDienThoai = txt_number.Text,
                    Email = txt_email.Text,
                    NgayVaoLam = dtp_firstdate.Value,
                    MaChucVu = cmb_position.SelectedValue?.ToString(),  // Lấy mã chức vụ từ ComboBox
                    MaTiemThuoc = cmb_id.SelectedValue?.ToString() // Lấy mã tiệm từ ComboBox
                };

                bool result = ManagerServices.UpdateEmployee(nhanVien);
                if (result)
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                    BindGrid(ManagerServices.GetEmployeeList());
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var nhanVien = new NHANVIEN
                {
                    MaNhanVien = txt_Id.Text,
                    HoTen = txt_name.Text,
                    NgaySinh = dtp_dateborn.Value,
                    GioiTinh = ckb_Male.Checked,
                    DiaChi = txt_address.Text,
                    SoDienThoai = txt_number.Text,
                    Email = txt_email.Text,
                    NgayVaoLam = dtp_firstdate.Value,
                    MaChucVu = cmb_position.SelectedValue.ToString(), // Lấy mã chức vụ từ ComboBox
                    MaTiemThuoc = cmb_id.SelectedValue.ToString() // Lấy mã tiệm từ ComboBox
                };



                bool result = ManagerServices.AddEmployee(nhanVien);

                System.Diagnostics.Debug.WriteLine($"Mã nhân viên: {nhanVien.MaNhanVien}");
                System.Diagnostics.Debug.WriteLine($"Họ tên: {nhanVien.HoTen}");

                if (result)
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    BindGrid(ManagerServices.GetEmployeeList());
                    ClearControls(this);
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!");
                    ClearControls(this);
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        private void dgv_Personel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo click vào hàng, không phải tiêu đề
            {
                DataGridViewRow row = dgv_Personel.Rows[e.RowIndex];

                txt_Id.Text = row.Cells[0].Value.ToString();
                txt_name.Text = row.Cells[1].Value.ToString();
                dtp_dateborn.Value = DateTime.ParseExact(
                row.Cells[2].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                ckb_Male.Checked = row.Cells[3].Value.ToString() == "nam";
                ckb_Female.Checked = row.Cells[3].Value.ToString() == "nữ";
                txt_address.Text = row.Cells[4].Value.ToString();
                txt_number.Text = row.Cells[5].Value.ToString();
                txt_email.Text = row.Cells[6].Value.ToString();
                dtp_firstdate.Value = DateTime.Parse(row.Cells[7].Value.ToString());

                var chucVus = ManagerServices.GetPositions();
                var tiemThuocs = ManagerServices.GetStores();

                string tenChucVu = row.Cells[8].Value.ToString();
                var chucVu = chucVus.FirstOrDefault(cv => cv.TenChucVu == tenChucVu);
                if (chucVu != null)
                {
                    cmb_position.SelectedValue = chucVu.MaChucVu; // Gán mã chức vụ vào ComboBox
                }
                string tenTiemThuoc = row.Cells[9].Value.ToString();
                var tiemThuoc = tiemThuocs.FirstOrDefault(t => t.TenChiNhanh == tenTiemThuoc);
                if (tiemThuoc != null)
                {
                    cmb_id.SelectedValue = tiemThuoc.MaTiemThuoc; // Gán mã tiệm vào ComboBox
                }

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhanVien = txt_Id.Text;
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    bool result = ManagerServices.DeleteEmployee(maNhanVien);
                    if (result)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        BindGrid(ManagerServices.GetEmployeeList());
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }
        private void ClearControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear(); // Xóa nội dung TextBox
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false; // Bỏ chọn RadioButton
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now; // Đặt về ngày hiện tại
                }
                else if (control.HasChildren)
                {
                    // Gọi đệ quy nếu control chứa các control con (như Panel, GroupBox)
                    ClearControls(control);
                }
            }
        }

        private void ckb_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Male.Checked)
            {
                ckb_Female.Checked = false; // Bỏ chọn Nữ nếu chọn Nam
            }
        }

        private void ckb_Female_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Female.Checked)
            {
                ckb_Male.Checked = false; // Bỏ chọn Nam nếu chọn Nữ
            }

        }
    }
}
