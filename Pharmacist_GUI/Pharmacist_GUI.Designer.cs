namespace Pharmacist
{
    partial class frm_PharmacistGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PharmacistGUI));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.accordionControl_SidePanel = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement_ManageMedicine = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator4 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement_EditMedicine = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement_SellMedicine = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement_LogOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement_UserProfile = new DevExpress.XtraBars.Navigation.AccordionControlElement();
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
            this.accordionControlElement_ManageMedicine,
            this.accordionControlSeparator4,
            this.accordionControlElement_EditMedicine,
            this.accordionControlSeparator3,
            this.accordionControlElement_SellMedicine,
            this.accordionControlSeparator2,
            this.accordionControlElement_LogOut,
            this.accordionControlElement_UserProfile});
            this.accordionControl_SidePanel.Location = new System.Drawing.Point(0, 0);
            this.accordionControl_SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.accordionControl_SidePanel.Name = "accordionControl_SidePanel";
            this.accordionControl_SidePanel.OptionsMinimizing.ElementHeight = 40;
            this.accordionControl_SidePanel.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl_SidePanel.ScaleImages = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControl_SidePanel.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl_SidePanel.SelectElementMode = DevExpress.XtraBars.Navigation.SelectElementMode.MouseDown;
            this.accordionControl_SidePanel.ShowToolTips = false;
            this.accordionControl_SidePanel.Size = new System.Drawing.Size(57, 758);
            this.accordionControl_SidePanel.TabIndex = 0;
            this.accordionControl_SidePanel.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.accordionControl_SidePanel.Click += new System.EventHandler(this.accordionControl_SidePanel_Click);
            // 
            // accordionControlElement_ManageMedicine
            // 
            this.accordionControlElement_ManageMedicine.Height = 70;
            this.accordionControlElement_ManageMedicine.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement_ManageMedicine.ImageOptions.SvgImage")));
            this.accordionControlElement_ManageMedicine.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.accordionControlElement_ManageMedicine.Name = "accordionControlElement_ManageMedicine";
            this.accordionControlElement_ManageMedicine.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_ManageMedicine.Text = "Quản Lý Thuốc";
            this.accordionControlElement_ManageMedicine.Click += new System.EventHandler(this.btn_SelectFunctions);
            // 
            // accordionControlSeparator4
            // 
            this.accordionControlSeparator4.Name = "accordionControlSeparator4";
            // 
            // accordionControlElement_EditMedicine
            // 
            this.accordionControlElement_EditMedicine.Height = 70;
            this.accordionControlElement_EditMedicine.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement_EditMedicine.ImageOptions.SvgImage")));
            this.accordionControlElement_EditMedicine.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.accordionControlElement_EditMedicine.Name = "accordionControlElement_EditMedicine";
            this.accordionControlElement_EditMedicine.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_EditMedicine.Text = "Quản Lý Lô Thuốc";
            this.accordionControlElement_EditMedicine.Click += new System.EventHandler(this.btn_SelectFunctions);
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            // 
            // accordionControlElement_SellMedicine
            // 
            this.accordionControlElement_SellMedicine.Height = 70;
            this.accordionControlElement_SellMedicine.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement_SellMedicine.ImageOptions.SvgImage")));
            this.accordionControlElement_SellMedicine.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.accordionControlElement_SellMedicine.Name = "accordionControlElement_SellMedicine";
            this.accordionControlElement_SellMedicine.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_SellMedicine.Text = "Bán Thuốc";
            this.accordionControlElement_SellMedicine.Click += new System.EventHandler(this.btn_SelectFunctions);
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // accordionControlElement_LogOut
            // 
            this.accordionControlElement_LogOut.Height = 70;
            this.accordionControlElement_LogOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement_LogOut.ImageOptions.Image")));
            this.accordionControlElement_LogOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement_LogOut.ImageOptions.SvgImage")));
            this.accordionControlElement_LogOut.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.accordionControlElement_LogOut.Name = "accordionControlElement_LogOut";
            this.accordionControlElement_LogOut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            toolTipItem1.Text = "Đăng xuất tài khoản người dùng hiện tại";
            superToolTip1.Items.Add(toolTipItem1);
            this.accordionControlElement_LogOut.SuperTip = superToolTip1;
            this.accordionControlElement_LogOut.Text = "Đăng Xuất";
            this.accordionControlElement_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // accordionControlElement_UserProfile
            // 
            this.accordionControlElement_UserProfile.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.accordionControlElement_UserProfile.Height = 70;
            this.accordionControlElement_UserProfile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement_UserProfile.ImageOptions.SvgImage")));
            this.accordionControlElement_UserProfile.Name = "accordionControlElement_UserProfile";
            this.accordionControlElement_UserProfile.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            toolTipItem2.Text = "Xem thông tiin hồ sơ của người dùng hiện tại";
            superToolTip2.Items.Add(toolTipItem2);
            this.accordionControlElement_UserProfile.SuperTip = superToolTip2;
            this.accordionControlElement_UserProfile.Text = "Hồ sơ người dùng";
            this.accordionControlElement_UserProfile.Click += new System.EventHandler(this.accordionControlElement_UserProfile_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(57, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1211, 758);
            this.panel_Main.TabIndex = 1;
            // 
            // frm_PharmacistGUI
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 758);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.accordionControl_SidePanel);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1270, 795);
            this.Name = "frm_PharmacistGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_PharmacistUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl_SidePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl_SidePanel;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_ManageMedicine;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_SellMedicine;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_EditMedicine;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_LogOut;
        private System.Windows.Forms.Panel panel_Main;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_UserProfile;
    }
}