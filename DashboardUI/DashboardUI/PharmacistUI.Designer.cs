using DevExpress.XtraBars.Navigation;
using System.Drawing;

namespace DashboardUI
{
    partial class frm_PharmacistUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PharmacistUI));
            this.titlebar_Top = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.sidePanel_Menu = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionBtn_DashBoard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionBtn_AddMedicine = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionBtn_SellMedicine = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionBtn_ViewMedicine = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator4 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionBtn_EditMedicine = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator5 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordianBtn_LogOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panel_Main = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.titlebar_Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // titlebar_Top
            // 
            this.titlebar_Top.FluentDesignForm = this;
            this.titlebar_Top.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titlebar_Top.Location = new System.Drawing.Point(0, 0);
            this.titlebar_Top.Name = "titlebar_Top";
            this.titlebar_Top.Size = new System.Drawing.Size(1184, 36);
            this.titlebar_Top.TabIndex = 0;
            this.titlebar_Top.TabStop = false;
            // 
            // sidePanel_Menu
            // 
            this.sidePanel_Menu.AllowItemSelection = true;
            this.sidePanel_Menu.AllowSmoothScrolling = false;
            this.sidePanel_Menu.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.Spline;
            this.sidePanel_Menu.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(91)))), ((int)(((byte)(102)))));
            this.sidePanel_Menu.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidePanel_Menu.Appearance.AccordionControl.ForeColor = System.Drawing.Color.White;
            this.sidePanel_Menu.Appearance.AccordionControl.Options.UseBackColor = true;
            this.sidePanel_Menu.Appearance.AccordionControl.Options.UseFont = true;
            this.sidePanel_Menu.Appearance.AccordionControl.Options.UseForeColor = true;
            this.sidePanel_Menu.Appearance.Item.Default.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sidePanel_Menu.Appearance.Item.Default.Options.UseFont = true;
            this.sidePanel_Menu.Appearance.Item.Disabled.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sidePanel_Menu.Appearance.Item.Disabled.Options.UseFont = true;
            this.sidePanel_Menu.Appearance.Item.Hovered.BackColor = System.Drawing.Color.White;
            this.sidePanel_Menu.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sidePanel_Menu.Appearance.Item.Hovered.ForeColor = System.Drawing.Color.Black;
            this.sidePanel_Menu.Appearance.Item.Hovered.Options.UseBackColor = true;
            this.sidePanel_Menu.Appearance.Item.Hovered.Options.UseFont = true;
            this.sidePanel_Menu.Appearance.Item.Hovered.Options.UseForeColor = true;
            this.sidePanel_Menu.Appearance.Item.Normal.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sidePanel_Menu.Appearance.Item.Normal.Options.UseFont = true;
            this.sidePanel_Menu.Appearance.Item.Pressed.BackColor = System.Drawing.Color.White;
            this.sidePanel_Menu.Appearance.Item.Pressed.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sidePanel_Menu.Appearance.Item.Pressed.ForeColor = System.Drawing.Color.Black;
            this.sidePanel_Menu.Appearance.Item.Pressed.Options.UseBackColor = true;
            this.sidePanel_Menu.Appearance.Item.Pressed.Options.UseFont = true;
            this.sidePanel_Menu.Appearance.Item.Pressed.Options.UseForeColor = true;
            this.sidePanel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel_Menu.ElementPositionOnExpanding = DevExpress.XtraBars.Navigation.ElementPositionOnExpanding.ScrollUp;
            this.sidePanel_Menu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionBtn_DashBoard,
            this.accordionControlSeparator1,
            this.accordionBtn_AddMedicine,
            this.accordionControlSeparator2,
            this.accordionBtn_SellMedicine,
            this.accordionControlSeparator3,
            this.accordionBtn_ViewMedicine,
            this.accordionControlSeparator4,
            this.accordionBtn_EditMedicine,
            this.accordionControlSeparator5,
            this.accordianBtn_LogOut});
            this.sidePanel_Menu.HtmlTemplates.HamburgerHeaderPanel.Styles = "html{\r\n\tbackground-color: rgb(0, 0, 0);\r\n}";
            this.sidePanel_Menu.HtmlTemplates.HamburgerHeaderPanel.Template = "<html>\r\n\t\r\n</html>";
            this.sidePanel_Menu.Location = new System.Drawing.Point(0, 36);
            this.sidePanel_Menu.LookAndFeel.UseDefaultLookAndFeel = false;
            this.sidePanel_Menu.Name = "sidePanel_Menu";
            this.sidePanel_Menu.OptionsMinimizing.AllowFooterResizing = false;
            this.sidePanel_Menu.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            this.sidePanel_Menu.OptionsMinimizing.CaptionShowMode = DevExpress.XtraBars.Navigation.CaptionShowMode.None;
            this.sidePanel_Menu.OptionsMinimizing.ElementHeight = 60;
            this.sidePanel_Menu.OptionsMinimizing.MinimizeButtonMode = DevExpress.XtraBars.Navigation.MinimizeButtonMode.Inverted;
            this.sidePanel_Menu.OptionsMinimizing.MinimizedWidth = 57;
            this.sidePanel_Menu.OptionsMinimizing.NormalWidth = 252;
            this.sidePanel_Menu.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.sidePanel_Menu.ScaleImages = DevExpress.Utils.DefaultBoolean.True;
            this.sidePanel_Menu.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.sidePanel_Menu.SelectElementMode = DevExpress.XtraBars.Navigation.SelectElementMode.MouseDown;
            this.sidePanel_Menu.Size = new System.Drawing.Size(65, 763);
            this.sidePanel_Menu.TabIndex = 6;
            this.sidePanel_Menu.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionBtn_DashBoard
            // 
            this.accordionBtn_DashBoard.Height = 60;
            this.accordionBtn_DashBoard.ImageOptions.ImageIndex = 1;
            this.accordionBtn_DashBoard.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionBtn_DashBoard.ImageOptions.SvgImage")));
            this.accordionBtn_DashBoard.Name = "accordionBtn_DashBoard";
            this.accordionBtn_DashBoard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionBtn_DashBoard.Text = "Trang chủ";
            this.accordionBtn_DashBoard.Click += new System.EventHandler(this.btn_DashBoard_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accordionBtn_AddMedicine
            // 
            this.accordionBtn_AddMedicine.Height = 60;
            this.accordionBtn_AddMedicine.ImageOptions.ImageIndex = 0;
            this.accordionBtn_AddMedicine.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionBtn_AddMedicine.ImageOptions.SvgImage")));
            this.accordionBtn_AddMedicine.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.accordionBtn_AddMedicine.Name = "accordionBtn_AddMedicine";
            this.accordionBtn_AddMedicine.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionBtn_AddMedicine.Text = "Thêm Thuốc";
            this.accordionBtn_AddMedicine.Click += new System.EventHandler(this.btn_AddMedicine_Click);
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // accordionBtn_SellMedicine
            // 
            this.accordionBtn_SellMedicine.Height = 60;
            this.accordionBtn_SellMedicine.ImageOptions.ImageIndex = 2;
            this.accordionBtn_SellMedicine.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionBtn_SellMedicine.ImageOptions.SvgImage")));
            this.accordionBtn_SellMedicine.Name = "accordionBtn_SellMedicine";
            this.accordionBtn_SellMedicine.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionBtn_SellMedicine.Text = "Bán Thuốc";
            this.accordionBtn_SellMedicine.Click += new System.EventHandler(this.btn_SellMedicine_Click);
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            // 
            // accordionBtn_ViewMedicine
            // 
            this.accordionBtn_ViewMedicine.Height = 60;
            this.accordionBtn_ViewMedicine.ImageOptions.ImageIndex = 3;
            this.accordionBtn_ViewMedicine.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionBtn_ViewMedicine.ImageOptions.SvgImage")));
            this.accordionBtn_ViewMedicine.Name = "accordionBtn_ViewMedicine";
            this.accordionBtn_ViewMedicine.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionBtn_ViewMedicine.Text = "Xem Thuốc";
            this.accordionBtn_ViewMedicine.Click += new System.EventHandler(this.btn_ViewMedicine_Click);
            // 
            // accordionControlSeparator4
            // 
            this.accordionControlSeparator4.Name = "accordionControlSeparator4";
            // 
            // accordionBtn_EditMedicine
            // 
            this.accordionBtn_EditMedicine.Height = 60;
            this.accordionBtn_EditMedicine.ImageOptions.ImageIndex = 4;
            this.accordionBtn_EditMedicine.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionBtn_EditMedicine.ImageOptions.SvgImage")));
            this.accordionBtn_EditMedicine.Name = "accordionBtn_EditMedicine";
            this.accordionBtn_EditMedicine.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionBtn_EditMedicine.Text = "Chỉnh Sửa Thuốc";
            this.accordionBtn_EditMedicine.Click += new System.EventHandler(this.btn_EditMedicine_Click);
            // 
            // accordionControlSeparator5
            // 
            this.accordionControlSeparator5.Name = "accordionControlSeparator5";
            // 
            // accordianBtn_LogOut
            // 
            this.accordianBtn_LogOut.Height = 60;
            this.accordianBtn_LogOut.ImageOptions.ImageIndex = 5;
            this.accordianBtn_LogOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordianBtn_LogOut.ImageOptions.SvgImage")));
            this.accordianBtn_LogOut.Name = "accordianBtn_LogOut";
            this.accordianBtn_LogOut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordianBtn_LogOut.Text = "Đăng Xuất";
            this.accordianBtn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(65, 36);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1119, 763);
            this.panel_Main.TabIndex = 11;
            // 
            // frm_PharmacistUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 799);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.sidePanel_Menu);
            this.Controls.Add(this.titlebar_Top);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FluentDesignFormControl = this.titlebar_Top;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(745, 600);
            this.Name = "frm_PharmacistUI";
            this.NavigationControl = this.sidePanel_Menu;
            this.ShowText = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Thuốc";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_PharmacistUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titlebar_Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl titlebar_Top;
        private DevExpress.XtraBars.Navigation.AccordionControl sidePanel_Menu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionBtn_DashBoard;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionBtn_AddMedicine;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionBtn_SellMedicine;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionBtn_ViewMedicine;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionBtn_EditMedicine;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordianBtn_LogOut;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator5;
        private DevExpress.XtraEditors.PanelControl panel_Main;
    }
}

