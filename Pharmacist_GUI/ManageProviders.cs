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
            // Set up grid view. Load in data
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
        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void frm_ManageProviders_Load(object sender, EventArgs e)
        {
            try
            {
                //dgv_Providers.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10f, FontStyle.Bold);
                List<NHACUNGCAP> providers = providerServices.GetProviders();
                //BindGrid(providers);
            } 
            catch (Exception ex)
            {
                if (ex.InnerException != null && String.IsNullOrEmpty(ex.InnerException.Message))
                {
                    ShowErrorMessage(ex.ToString());
                }
                else
                {
                    ShowErrorMessage(ex.Message);
                }
                // Print to Output stream
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        private void AddProviderToMedicine(THUOC Medicine)
        {
            try
            {
                using (PharmacyManagementDB db = new PharmacyManagementDB())
                {

                    MedicineServices medicineService = new MedicineServices();
                    // Check if provider exists or batch exists
                    List<LOTHUOC> batchList = db.LOTHUOC.ToList();
                    var batch = batchList.FirstOrDefault(b => b.MaThuoc == Medicine.MaThuoc);
                    // If batch exists which means provider exists then exit
                    if (batch != null)
                    {
                        // Search for transaction that has the same batch and provider
                        GIAODICH transaction = db.GIAODICH.FirstOrDefault(t => t.MaLo == batch.MaLo);
                        System.Diagnostics.Debug.WriteLine($"Transaction: {transaction}");
                        
                        NHACUNGCAP provider = db.NHACUNGCAP.FirstOrDefault(p => p.MaNhaCungCap == transaction.MaNhaCungCap);
                        System.Diagnostics.Debug.WriteLine($"Provider: {provider}");

                        if (provider != null)
                        {
                            throw new Exception("Nhà cung cấp đã tồn tại!");
                        }
                    } 
                    else
                    {
                        // Add new provider
                        NHACUNGCAP newProvider = new NHACUNGCAP()
                        {
                            MaNhaCungCap = txt_ProviderId.Text,
                            TenNhaCungCap = txt_ProviderName.Text,
                            DiaChi = txt_ProviderAddress.Text,
                            Email = txt_ProviderEmail.Text,
                            SoDienThoai = txt_ProviderPhone.Text
                        };
                        
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
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
                if (ex.InnerException != null && String.IsNullOrEmpty(ex.InnerException.Message))
                {
                    ShowErrorMessage(ex.ToString());
                }
                else
                {
                    ShowErrorMessage(ex.Message);
                }
                // Print to Output stream
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}