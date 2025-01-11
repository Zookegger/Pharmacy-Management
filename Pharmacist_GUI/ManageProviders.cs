using DevExpress.XtraEditors;
using Pharmacist_BUS;
using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Pharmacist
{
    public partial class frm_ManageProviders : DevExpress.XtraEditors.XtraForm
    {
        private readonly MedicineServices medicineService = new MedicineServices();
        private readonly BatchServices batchServices = new BatchServices();
        private readonly ProviderServices providerServices = new ProviderServices();
        public frm_ManageProviders()
        {
            InitializeComponent();
        }
        
        // Exception handling
        private void HandleException(Exception ex)
        {
            if (ex.InnerException != null && string.IsNullOrEmpty(ex.InnerException.Message))
            {
                ShowErrorMessage(ex.ToString());
            }
            else
            {
                ShowErrorMessage(ex.Message);
            }

            // Print error details to the Debug output
            System.Diagnostics.Debug.WriteLine(ex.ToString());
        }
        private void ShowErrorMessage(string errorMessage)
        {
            Icon errorIcon = null;
            try
            {
                errorIcon = GetIcon("error");
            }
            catch (FileNotFoundException fnfe)
            {
                XtraMessageBox.Show($"Error loading icon{fnfe.Message}");
                errorIcon = SystemIcons.Error;
            }
            ShowMessageBox(errorMessage, errorIcon);
        }
        private void Error_Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            // MessageBox Appearance
            e.MessageBoxForm.StartPosition = FormStartPosition.CenterParent;
            e.MessageBoxForm.FormBorderStyle = FormBorderStyle.None;
            e.MessageBoxForm.Appearance.BackColor = ColorTranslator.FromHtml("#d6d6d6");
            e.MessageBoxForm.Appearance.FontStyleDelta = FontStyle.Bold;
            e.MessageBoxForm.Appearance.FontSizeDelta = 4;

            // Error Message style
            e.MessageBoxForm.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            e.MessageBoxForm.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;

            // Ok button style
            e.Buttons[DialogResult.OK].Text = "OK";
            e.Buttons[DialogResult.OK].Appearance.FontSizeDelta = 4;
            e.Buttons[DialogResult.OK].Appearance.FontStyleDelta = FontStyle.Bold;
            e.Buttons[DialogResult.OK].Padding = new Padding(10);
        }

        // Custom MessageBox
        private void ShowMessageBox(String message, Icon icon = null) // set to = null or any default value to accept only 1 provided parameter
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Text = message;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            args.Showing += Error_Args_Showing;
            if (icon != null)
            {
                args.Icon = icon;
            }
            XtraMessageBox.Show(args);
        }
        private void Add_Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            // Main form style
            e.MessageBoxForm.StartPosition = FormStartPosition.CenterParent;
            e.MessageBoxForm.FormBorderStyle = FormBorderStyle.None;
            e.MessageBoxForm.Appearance.BackColor = ColorTranslator.FromHtml("#d6d6d6");
            e.MessageBoxForm.Appearance.FontStyleDelta = FontStyle.Bold;
            e.MessageBoxForm.Appearance.FontSizeDelta = 4;

            // Text Message style
            e.MessageBoxForm.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            e.MessageBoxForm.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;

            // Ok button style
            e.Buttons[DialogResult.OK].Text = "Đăng xuất";
            e.Buttons[DialogResult.OK].Appearance.FontSizeDelta = 4;
            e.Buttons[DialogResult.OK].Appearance.FontStyleDelta = FontStyle.Bold;
            e.Buttons[DialogResult.OK].Padding = new Padding(10); // Vì một nguyên nhân nào đó nó set padding cho cả 2 nút thay vì chỉ set cho chính nó

            // Cancel button style
            e.Buttons[DialogResult.Cancel].Text = "Hủy";
            e.Buttons[DialogResult.Cancel].Appearance.FontSizeDelta = 4;
            e.Buttons[DialogResult.Cancel].Appearance.FontStyleDelta = FontStyle.Bold;
        }
        private void View_Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            // Main form style
            e.MessageBoxForm.StartPosition = FormStartPosition.CenterParent;
            e.MessageBoxForm.FormBorderStyle = FormBorderStyle.None;
            e.MessageBoxForm.Appearance.BackColor = ColorTranslator.FromHtml("#d6d6d6");
            e.MessageBoxForm.Appearance.FontStyleDelta = FontStyle.Bold;
            e.MessageBoxForm.Appearance.FontSizeDelta = 4;

            // Text Message style
            e.MessageBoxForm.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            e.MessageBoxForm.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;

            // Ok button style
            e.Buttons[DialogResult.OK].Text = "OK";
            e.Buttons[DialogResult.OK].Appearance.FontSizeDelta = 4;
            e.Buttons[DialogResult.OK].Appearance.FontStyleDelta = FontStyle.Bold;
        }

        // Event Handlers
        private void frm_ManageProviders_Load(object sender, EventArgs e)
        {
            try
            {
                //dgv_Providers.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10f, FontStyle.Bold);
                List<NHACUNGCAP> providers = providerServices.GetProviders();
                BindGrid();
            } 
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void gridView_Providers_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    txt_ProviderId.Text = gridView_Providers.GetRowCellValue(e.RowHandle, "Mã nhà cung cấp").ToString();
                    txt_ProviderName.Text = gridView_Providers.GetRowCellValue(e.RowHandle, "Tên nhà cung cấp").ToString();
                    txt_ProviderAddress.Text = gridView_Providers.GetRowCellValue(e.RowHandle, "Địa chỉ").ToString();
                    txt_ProviderEmail.Text = gridView_Providers.GetRowCellValue(e.RowHandle, "Email").ToString();
                    txt_ProviderPhone.Text = gridView_Providers.GetRowCellValue(e.RowHandle, "Số điện thoại").ToString();
                }
            } 
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void btn_RefreshGrid_Click(object sender, EventArgs e)
        {
            try
            {
                BindGrid();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void btn_ClearFields_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFields();
            } catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void btn_InsertUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(sender is SimpleButton))
                {
                    throw new Exception("Invalid Sender, expected SimpleButton");
                }
                SimpleButton btn = sender as SimpleButton;

                switch (btn.Name)
                {
                    case "btn_Insert":
                        InsertProvider();
                        break;
                    case "btn_Update":
                        UpdateProvider();
                        break;
                    default:
                        throw new Exception("Invalid Button");
                }

                BindGrid();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        // Custom Methods
        private void ClearFields()
        {
            txt_ProviderId.Text = string.Empty;
            txt_ProviderName.Text = string.Empty;
            txt_ProviderAddress.Text = string.Empty;
            txt_ProviderEmail.Text = string.Empty;
            txt_ProviderPhone.Text = string.Empty;
        }
        private void ValidateFields()
        {
            if (string.IsNullOrEmpty(txt_ProviderName.Text))
            {
                throw new Exception("Tên nhà cung cấp không được để trống");
            }
            if (string.IsNullOrEmpty(txt_ProviderAddress.Text))
            {
                throw new Exception("Địa chỉ nhà cung cấp không được để trống");
            }
            if (string.IsNullOrEmpty(txt_ProviderEmail.Text))
            {
                throw new Exception("Email nhà cung cấp không được để trống");
            }
            if (string.IsNullOrEmpty(txt_ProviderPhone.Text))
            {
                throw new Exception("Số điện thoại nhà cung cấp không được để trống");
            }
            if (txt_ProviderPhone.Text.Length != 10)
            {
                throw new Exception("Số điện thoại không hợp lệ");
            }
        }
        private void InsertProvider()
        {
            ValidateFields();
            NHACUNGCAP provider = new NHACUNGCAP
            {
                MaNhaCungCap = txt_ProviderId.Text,
                TenNhaCungCap = txt_ProviderName.Text,
                DiaChi = txt_ProviderAddress.Text,
                Email = txt_ProviderEmail.Text,
                SoDienThoai = txt_ProviderPhone.Text
            };
            providerServices.InsertProvider(provider);
            ShowMessageBox("Thêm thông tin thành công");
        }
        private void UpdateProvider()
        {
            ValidateFields();
            NHACUNGCAP updatedProvider = new NHACUNGCAP
            {
                MaNhaCungCap = txt_ProviderId.Text,
                TenNhaCungCap = txt_ProviderName.Text,
                DiaChi = txt_ProviderAddress.Text,
                Email = txt_ProviderEmail.Text,
                SoDienThoai = txt_ProviderPhone.Text
            };
            providerServices.UpdateProvider(updatedProvider);
            ShowMessageBox("Cập nhật thông tin thành công");
        }
        private void DeleteProvider()
        {
            ValidateFields();
            providerServices.DeleteProvider(txt_ProviderId.Text);
            ShowMessageBox("Xóa thông tin thành công");
        }
        private void BindGrid()
        {
            gridControl_data.DataSource = providerServices.GetProviderTable();
        }
        private Icon GetIcon(string iconName)
        {
            string iconPath = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..")), $"icon/{iconName}_icon.ico");

            if (File.Exists(iconPath))
            {
                return new Icon(iconPath);
            }
            else
            {
                throw new FileNotFoundException($"Icon file {iconName}_icon.ico not found in icon directory");
            }
        }
    }
}