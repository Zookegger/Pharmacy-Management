namespace PharmacistUI
{
    partial class PharmacistUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacistUI));
            this.accordionControl_SidePanel = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement_Home = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement_Add = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement_Sell = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement_View = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement_Edit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement_LogOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panel_Main = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl_SidePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl_SidePanel
            // 
            this.accordionControl_SidePanel.AllowItemSelection = true;
            this.accordionControl_SidePanel.AllowSmoothScrolling = false;
            this.accordionControl_SidePanel.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.Office2016;
            this.accordionControl_SidePanel.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.accordionControl_SidePanel.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.accordionControl_SidePanel.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl_SidePanel.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl_SidePanel.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl_SidePanel.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl_SidePanel.Appearance.Item.Normal.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.accordionControl_SidePanel.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl_SidePanel.Appearance.Item.Pressed.Font = new System.Drawing.Font("Tahoma", 13.09091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.accordionControl_SidePanel.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionControl_SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl_SidePanel.ElementPositionOnExpanding = DevExpress.XtraBars.Navigation.ElementPositionOnExpanding.Fixed;
            this.accordionControl_SidePanel.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement_Home,
            this.accordionControlElement_Add,
            this.accordionControlElement_Sell,
            this.accordionControlElement_View,
            this.accordionControlElement_Edit,
            this.accordionControlElement_LogOut});
            this.accordionControl_SidePanel.Location = new System.Drawing.Point(0, 0);
            this.accordionControl_SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.accordionControl_SidePanel.Name = "accordionControl_SidePanel";
            this.accordionControl_SidePanel.OptionsMinimizing.ElementHeight = 40;
            this.accordionControl_SidePanel.ScaleImages = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControl_SidePanel.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl_SidePanel.SelectElementMode = DevExpress.XtraBars.Navigation.SelectElementMode.MouseDown;
            this.accordionControl_SidePanel.ShowToolTips = false;
            this.accordionControl_SidePanel.Size = new System.Drawing.Size(365, 723);
            this.accordionControl_SidePanel.TabIndex = 0;
            this.accordionControl_SidePanel.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement_Home
            // 
            this.accordionControlElement_Home.Height = 70;
            this.accordionControlElement_Home.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement_Home.ImageOptions.SvgImage")));
            this.accordionControlElement_Home.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.accordionControlElement_Home.Name = "accordionControlElement_Home";
            this.accordionControlElement_Home.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_Home.Text = "Trang Chủ";
            this.accordionControlElement_Home.Click += new System.EventHandler(this.btn_Click);
            // 
            // accordionControlElement_Add
            // 
            this.accordionControlElement_Add.Height = 70;
            this.accordionControlElement_Add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement_Add.ImageOptions.SvgImage")));
            this.accordionControlElement_Add.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.accordionControlElement_Add.Name = "accordionControlElement_Add";
            this.accordionControlElement_Add.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_Add.Text = "Thêm Thuốc";
            this.accordionControlElement_Add.Click += new System.EventHandler(this.btn_Click);
            // 
            // accordionControlElement_Sell
            // 
            this.accordionControlElement_Sell.Height = 70;
            this.accordionControlElement_Sell.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement_Sell.ImageOptions.SvgImage")));
            this.accordionControlElement_Sell.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.accordionControlElement_Sell.Name = "accordionControlElement_Sell";
            this.accordionControlElement_Sell.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_Sell.Text = "Bán Thuốc";
            this.accordionControlElement_Sell.Click += new System.EventHandler(this.btn_Click);
            // 
            // accordionControlElement_View
            // 
            this.accordionControlElement_View.Height = 70;
            this.accordionControlElement_View.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement_View.ImageOptions.SvgImage")));
            this.accordionControlElement_View.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.accordionControlElement_View.Name = "accordionControlElement_View";
            this.accordionControlElement_View.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_View.Text = "Xem Thuốc";
            this.accordionControlElement_View.Click += new System.EventHandler(this.btn_Click);
            // 
            // accordionControlElement_Edit
            // 
            this.accordionControlElement_Edit.Height = 70;
            this.accordionControlElement_Edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement_Edit.ImageOptions.SvgImage")));
            this.accordionControlElement_Edit.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.accordionControlElement_Edit.Name = "accordionControlElement_Edit";
            this.accordionControlElement_Edit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_Edit.Text = "Chỉnh Sửa Thuốc";
            this.accordionControlElement_Edit.Click += new System.EventHandler(this.btn_Click);
            // 
            // accordionControlElement_LogOut
            // 
            this.accordionControlElement_LogOut.Height = 70;
            this.accordionControlElement_LogOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement_LogOut.ImageOptions.Image")));
            this.accordionControlElement_LogOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement_LogOut.ImageOptions.SvgImage")));
            this.accordionControlElement_LogOut.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.accordionControlElement_LogOut.Name = "accordionControlElement_LogOut";
            this.accordionControlElement_LogOut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_LogOut.Text = "Đăng Xuất";
            this.accordionControlElement_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(365, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(533, 723);
            this.panel_Main.TabIndex = 1;
            // 
            // PharmacistUI
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 723);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.accordionControl_SidePanel);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(900, 760);
            this.Name = "PharmacistUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl_SidePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl_SidePanel;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_Home;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_Add;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_Sell;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_View;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_Edit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_LogOut;
        private System.Windows.Forms.Panel panel_Main;
    }
}