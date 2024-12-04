using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DashboardUI
{
    public partial class frm_PharmacistUI : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private Button currentButton;
        
        public frm_PharmacistUI()
        {
            InitializeComponent();
        }

        private int previousInvertedIconIndex = -1;
        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    if (previousInvertedIconIndex != -1)
                    {

                        InvertImageColors(previousInvertedIconIndex);
                    }

                    DeactivateButton();
                    currentButton = (Button)sender;
                    currentButton.BackColor = Color.Silver;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Tahoma", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    int iconIndex = int.Parse(currentButton.Tag.ToString()) - 1;
                    InvertImageColors(iconIndex);
                    previousInvertedIconIndex = iconIndex;
                }
            }
        }

        private void DeactivateButton()
        {
            foreach (Control previousButton in panelMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(38, 91, 102);
                    previousButton.ForeColor = Color.White;
                    previousButton.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                }
            }
        }

        private void InvertImageColors(int iconIndex)
        {
            if (iconIndex != -1)
            {
                Image icon = iconList.Images[iconIndex];
                Bitmap bmp = new Bitmap(icon);

                for (int y = 0; y < bmp.Height; y++) 
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixelColor = bmp.GetPixel(x, y);
                        Color invertedPixelColor = Color.FromArgb(pixelColor.A, 255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
                        bmp.SetPixel(x, y, invertedPixelColor);
                    }
                }
                iconList.Images[iconIndex] = bmp;
            }
        }

        private void btn_DashBoard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_AddMedicine_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_SellMedicine_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_ViewMedicine_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_EditMedicine_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Application.Exit();
        }
    }
}
