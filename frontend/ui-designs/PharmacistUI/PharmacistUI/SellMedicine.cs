using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacistUI
{
    public partial class frm_SellMedicine : DevExpress.XtraEditors.XtraForm
    {
        public frm_SellMedicine()
        {
            InitializeComponent();
            ApplyRoundedButtonStyle(this);
        }

        private void ApplyRoundedButtonStyle(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is RoundedButton)
                {
                    continue; // Skip this iteration
                }
                Debug.WriteLine($"Checking control: {control.GetType().Name}");
                if (control is SimpleButton simpleButton)
                {
                    // Replace SimpleButton with RoundedButton at runtime
                    var roundedButton = new RoundedButton
                    {
                        Text = simpleButton.Text, // Copy text from the old button
                        Size = simpleButton.Size, // Copy size
                        Location = simpleButton.Location, // Copy location
                        CornerRadius = 25, // Customize as needed
                        BackColor = Color.FromArgb(26, 141, 210), // Customize background color
                        BorderColor = Color.CadetBlue, // Customize border color
                        BorderThickness = 1.75f, // Customize border thickness
                        ForeColor = Color.White, // Customize foreground color
                        Font = new Font("Tahoma", 12f, FontStyle.Bold)
                    };

                    // Remove the old SimpleButton and add RoundedButton to the form
                    parent.Controls.Remove(simpleButton);
                    parent.Controls.Add(roundedButton);
                }

                // Apply recursively for nested controls (e.g., inside panels or group boxes)
                if (control.HasChildren)
                {
                    ApplyRoundedButtonStyle(control);
                }
            }
        }
    }
}