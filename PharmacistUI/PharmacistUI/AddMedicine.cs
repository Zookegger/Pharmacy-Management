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
    public delegate void AddMedicineDelegate(String id, String name, int amount, long price);
    public partial class AddMedicine : Form
    {
        public AddMedicineDelegate OnAddMedicine;
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel; // Make sure it's a Panel
            if (panel != null)
            {
                TextBox focusedTextBox = panel.Controls.OfType<TextBox>().FirstOrDefault(txt => txt.Focused);
                if (focusedTextBox != null)
                {
                    ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
                }
                else
                {
                    ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, this.BackColor, ButtonBorderStyle.Solid);
                }
            }
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt?.Parent is Panel panel)
            {
                panel.Invalidate(); // Trigger a repaint of the panel when the textbox gains focus
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt?.Parent is Panel panel)
            {
                panel.Invalidate(); // Trigger a repaint of the panel when the textbox loses focus
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                String id = txt_Id.Text,
                       name = txt_Name.Text;
                int amount = 0;
                long price = 0;
                if (!int.TryParse(txt_Amount.Text, out amount))
                {
                    txt_Amount.Focus();
                    throw new Exception($"Giá trị vùng {label_Amount} không hợp lệ!");
                }
                if (!long.TryParse(txt_PricePerUnit.Text, out price))
                {
                    txt_PricePerUnit.Focus();
                    throw new Exception($"Giá trị vùng {label_PricePerUnit}");
                }
                OnAddMedicine?.Invoke(id, name, amount, price);
                MessageBox.Show("Medicine added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
