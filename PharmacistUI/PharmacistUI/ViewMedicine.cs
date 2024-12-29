using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacistUI
{
    public partial class frm_ViewMedicine : DevExpress.XtraEditors.XtraForm
    {
        public frm_ViewMedicine()
        {
            InitializeComponent();
        }
        private void btn_DeleteRow_Click(object sender, EventArgs e)
        {
            if (dgv_Medicine.SelectedRows.Count == 0)
            {
                XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                args.Text = "Chưa chọn thuốc trong danh sách!";
                args.Buttons = new DialogResult[] { DialogResult.OK };
                args.Showing += Args_Showing;
                //args.Appearance.Heigh
                DialogResult dr = XtraMessageBox.Show(args);
            } else
            {
                return;
            }
        }
        private void Args_Showing(object sender, XtraMessageShowingArgs e)
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
        private void frm_ViewMedicine_Load(object sender, EventArgs e)
        {
            // Set header font to grid view since value from properties for some reason doesn't want to apply
            dgv_Medicine.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12);
        }
    }
}