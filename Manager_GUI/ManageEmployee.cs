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
    public partial class frm_Employees : System.Windows.Forms.Form
    {
        private ManagerServices managerServices = new ManagerServices();
        public frm_Employees()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            gridControl_dgv.DataSource = managerServices.GetEmployeeTable();
        }

        private void frm_Personel_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            // Hiển thị dữ liệu lên DataGridView
            BindGrid();
        }
        
        private void LoadComboBoxes()
        {
            // Lấy danh sách chức vụ
            var chucVus = managerServices.GetPositions();
            cmb_Position.DataSource = chucVus;
            cmb_Position.DisplayMember = "TenChucVu"; // Hiển thị tên chức vụ
            cmb_Position.ValueMember = "MaChucVu"; // Giá trị là mã chức vụ

            // Lấy danh sách tiệm thuốc
            var tiemThuocs = managerServices.GetStores();
            cmb_Location.DataSource = tiemThuocs;
            cmb_Location.DisplayMember = "TenChiNhanh"; // Hiển thị tên tiệm thuốc
            cmb_Location.ValueMember = "MaTiemThuoc"; // Giá trị là mã tiệm thuốc
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
                    DiaChi = txt_Address.Text,
                    SoDienThoai = txt_Number.Text,
                    Email = txt_Email.Text,
                    NgayVaoLam = dtp_firstdate.Value,
                    MaChucVu = cmb_Position.SelectedValue?.ToString(),  // Lấy mã chức vụ từ ComboBox
                    MaTiemThuoc = cmb_Location.SelectedValue?.ToString() // Lấy mã tiệm từ ComboBox
                };

                bool result = managerServices.UpdateEmployee(nhanVien);
                if (result)
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                    BindGrid();
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
                    DiaChi = txt_Address.Text,
                    SoDienThoai = txt_Number.Text,
                    Email = txt_Email.Text,
                    NgayVaoLam = dtp_firstdate.Value,
                    MaChucVu = cmb_Position.SelectedValue.ToString(), // Lấy mã chức vụ từ ComboBox
                    MaTiemThuoc = cmb_Location.SelectedValue.ToString() // Lấy mã tiệm từ ComboBox
                };



                bool result = managerServices.AddEmployee(nhanVien);

                System.Diagnostics.Debug.WriteLine($"Mã nhân viên: {nhanVien.MaNhanVien}");
                System.Diagnostics.Debug.WriteLine($"Họ tên: {nhanVien.HoTen}");

                if (result)
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    BindGrid();
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhanVien = txt_Id.Text;
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    bool result = managerServices.DeleteEmployee(maNhanVien);
                    if (result)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        BindGrid();
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
