﻿using DevExpress.XtraEditors;
using PharmacistManagement_DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacist
{
    public partial class frm_SellMedicine : DevExpress.XtraEditors.XtraForm
    {
        private readonly MedicineServices medicineServices = new MedicineServices();
        private readonly BatchServices batchServices = new BatchServices();
        public frm_SellMedicine()
        {
            InitializeComponent();
        }

        private void frm_SellMedicine_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void FillList()
        {
            THUOC tHUOC = new THUOC();
            listBox_AvailableMedicine.DataSource = medicineServices.GetMedicineList();
            listBox_AvailableMedicine.DisplayMember = "TenThuoc";
            listBox_AvailableMedicine.ValueMember = "MaThuoc";
        }
        // Handle exception and show error message
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
            try
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
            catch (Exception ex)
            {
                HandleException(ex);
            }
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

        private void txt_SearchMedicine_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listBox_AvailableMedicine.Items.Clear();
                var newList = medicineServices.GetMedicineList(txt_SearchMedicine.Text);
                listBox_AvailableMedicine.DataSource = newList;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void FillFields(string medicineId)
        {
            THUOC medicine = medicineServices.GetMedicineById(medicineId);

            if (medicine != null)
            {
                List<LOTHUOC> batchList = batchServices.GetBatchList(medicine.MaThuoc);
                if (batchList == null || batchList.Count == 0)
                {
                    ShowMessageBox("Không có lô tương ứng với thuốc");
                    return;
                }

                txt_ID.Text = medicine.MaThuoc;
                txt_Name.Text = medicine.TenThuoc;
                cbb_ProductionDate.DataSource = batchList;
                cbb_ProductionDate.DisplayMember = "NgaySanXuat";
                cbb_ProductionDate.ValueMember = "MaLo";
                
                cbb_ProductionDate.SelectedIndex = batchList.Count > 0 ? 0 : -1;

                txt_PricePerUnit.Text = medicine.GiaDonVi.ToString();
                txt_TotalPrice.Text = (numUpDown_BuyAmount.Value * medicine.GiaDonVi).ToString();

                if (cbb_ProductionDate.SelectedIndex != -1)
                {
                    LOTHUOC selectedBatch = (LOTHUOC)cbb_ProductionDate.SelectedItem;
                    if (selectedBatch != null)
                    {
                        DateTime? expirationDate = batchServices.GetExpiration(cbb_ProductionDate.SelectedValue.ToString(), selectedBatch.NgaySanXuat);
                        System.Diagnostics.Debug.WriteLine($"Exp Date: {expirationDate?.ToString("dd/MM/yyyy")}");
                        txt_ExpDate.Text = expirationDate?.ToString("dd/MM/yyyy");
                    }
                }
                else
                {
                    txt_ExpDate.Text = "Invalid Date";
                }
            }
            else
            {
                ShowMessageBox("Không tìm thấy thuốc");
            }
        }

        private void listBox_AvailableMedicine_Click(object sender, EventArgs e)
        {
            if (listBox_AvailableMedicine.SelectedItems.Count > 0)
            {
                string medicineId = listBox_AvailableMedicine.SelectedValue.ToString();
                FillFields(medicineId);
            }
        }

        private void numUpDown_BuyAmount_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ID.Text) && !string.IsNullOrEmpty(txt_Name.Text) && !string.IsNullOrEmpty(txt_PricePerUnit.Text))
            {
                THUOC medicine = medicineServices.GetMedicineById(txt_ID.Text);
                txt_TotalPrice.Text = (numUpDown_BuyAmount.Value * medicine.GiaDonVi).ToString();
            }
        }

        private void cbb_ProductionDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private long totalCartPrice = 0;
        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txt_ID.Text) && !String.IsNullOrEmpty(cbb_ProductionDate.Text))
                {

                    bool itemExists = false;

                    int unitPrice = int.Parse(txt_PricePerUnit.Text.ToString());
                    int quantityToAdd = (int)numUpDown_BuyAmount.Value;
                    int itemTotalPrice = unitPrice * quantityToAdd;

                    // Iterate through rows to check if the item already exists in the cart
                    foreach (DataGridViewRow row in dgv_SellCart.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[2].Value != null &&
                            row.Cells[0].Value.ToString() == txt_ID.Text && // Match ID
                            row.Cells[2].Value.ToString() == cbb_ProductionDate.Text) // Match Production Date
                        {
                            // Update quantity and total price
                            int existingQuantity = int.Parse(row.Cells[4].Value.ToString());
                            int newQuantity = existingQuantity + quantityToAdd;
                            row.Cells[4].Value = newQuantity;

                            int oldTotalPrice = int.Parse(row.Cells[5].Value.ToString());
                            row.Cells[5].Value = (newQuantity * unitPrice);

                            totalCartPrice += (newQuantity * unitPrice) - oldTotalPrice;

                            itemExists = true;
                            break;
                        }
                    }

                    // If the item is not already in the cart, add it as a new row
                    if (!itemExists)
                    {
                        int rowIndex = dgv_SellCart.Rows.Add();
                        dgv_SellCart.Rows[rowIndex].Cells[0].Value = txt_ID.Text; // ID
                        dgv_SellCart.Rows[rowIndex].Cells[1].Value = txt_Name.Text; // Name
                        dgv_SellCart.Rows[rowIndex].Cells[2].Value = cbb_ProductionDate.Text; // Production Date
                        dgv_SellCart.Rows[rowIndex].Cells[3].Value = txt_ExpDate.Text; // Expiration Date
                        dgv_SellCart.Rows[rowIndex].Cells[4].Value = numUpDown_BuyAmount.Value; // Quantity
                        dgv_SellCart.Rows[rowIndex].Cells[5].Value = txt_TotalPrice.Text; // Total Price

                        totalCartPrice += (long)itemTotalPrice;
                    }

                    txt_TotalCartPrice.Text = totalCartPrice.ToString();
                }
                else
                {
                    ShowErrorMessage("Please select a valid item and production date.");
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void btn_Discard_Click(object sender, EventArgs e)
        {
            if (dgv_SellCart.SelectedRows.Count > 0)
            {
                for (int i = dgv_SellCart.SelectedRows.Count - 1; i >= 0 ; i--)
                {
                    int index = dgv_SellCart.Rows.IndexOf(dgv_SellCart.SelectedRows[i]);
                    dgv_SellCart.Rows.RemoveAt(i);
                }
            }
        }
    }
}
