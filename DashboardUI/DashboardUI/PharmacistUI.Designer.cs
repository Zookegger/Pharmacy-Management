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
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.btn_EditMedicine = new System.Windows.Forms.Button();
            this.btn_ViewMedicine = new System.Windows.Forms.Button();
            this.btn_SellMedicine = new System.Windows.Forms.Button();
            this.btn_AddMedicine = new System.Windows.Forms.Button();
            this.btn_DashBoard = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1162, 36);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(91)))), ((int)(((byte)(102)))));
            this.panelMenu.Controls.Add(this.btn_LogOut);
            this.panelMenu.Controls.Add(this.btn_EditMedicine);
            this.panelMenu.Controls.Add(this.btn_ViewMedicine);
            this.panelMenu.Controls.Add(this.btn_SellMedicine);
            this.panelMenu.Controls.Add(this.btn_AddMedicine);
            this.panelMenu.Controls.Add(this.btn_DashBoard);
            this.panelMenu.Controls.Add(this.panel_Logo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 36);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(284, 595);
            this.panelMenu.TabIndex = 3;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_LogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LogOut.FlatAppearance.BorderSize = 0;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.Transparent;
            this.btn_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LogOut.ImageIndex = 5;
            this.btn_LogOut.ImageList = this.iconList;
            this.btn_LogOut.Location = new System.Drawing.Point(0, 446);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_LogOut.Size = new System.Drawing.Size(284, 73);
            this.btn_LogOut.TabIndex = 6;
            this.btn_LogOut.Tag = "6";
            this.btn_LogOut.Text = "  Đăng Xuất";
            this.btn_LogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "dashboard.png");
            this.iconList.Images.SetKeyName(1, "Add.png");
            this.iconList.Images.SetKeyName(2, "cart.png");
            this.iconList.Images.SetKeyName(3, "view.png");
            this.iconList.Images.SetKeyName(4, "adjust.png");
            this.iconList.Images.SetKeyName(5, "logout.png");
            // 
            // btn_EditMedicine
            // 
            this.btn_EditMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_EditMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_EditMedicine.FlatAppearance.BorderSize = 0;
            this.btn_EditMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditMedicine.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_EditMedicine.ForeColor = System.Drawing.Color.Transparent;
            this.btn_EditMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditMedicine.ImageIndex = 4;
            this.btn_EditMedicine.ImageList = this.iconList;
            this.btn_EditMedicine.Location = new System.Drawing.Point(0, 373);
            this.btn_EditMedicine.Name = "btn_EditMedicine";
            this.btn_EditMedicine.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_EditMedicine.Size = new System.Drawing.Size(284, 73);
            this.btn_EditMedicine.TabIndex = 5;
            this.btn_EditMedicine.Tag = "5";
            this.btn_EditMedicine.Text = "  Chỉnh Sửa Thuốc";
            this.btn_EditMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EditMedicine.UseVisualStyleBackColor = true;
            this.btn_EditMedicine.Click += new System.EventHandler(this.btn_EditMedicine_Click);
            // 
            // btn_ViewMedicine
            // 
            this.btn_ViewMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ViewMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ViewMedicine.FlatAppearance.BorderSize = 0;
            this.btn_ViewMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewMedicine.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ViewMedicine.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ViewMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewMedicine.ImageIndex = 3;
            this.btn_ViewMedicine.ImageList = this.iconList;
            this.btn_ViewMedicine.Location = new System.Drawing.Point(0, 300);
            this.btn_ViewMedicine.Name = "btn_ViewMedicine";
            this.btn_ViewMedicine.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_ViewMedicine.Size = new System.Drawing.Size(284, 73);
            this.btn_ViewMedicine.TabIndex = 4;
            this.btn_ViewMedicine.Tag = "4";
            this.btn_ViewMedicine.Text = "  Xem Thuốc";
            this.btn_ViewMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ViewMedicine.UseVisualStyleBackColor = true;
            this.btn_ViewMedicine.Click += new System.EventHandler(this.btn_ViewMedicine_Click);
            // 
            // btn_SellMedicine
            // 
            this.btn_SellMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SellMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SellMedicine.FlatAppearance.BorderSize = 0;
            this.btn_SellMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SellMedicine.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SellMedicine.ForeColor = System.Drawing.Color.Transparent;
            this.btn_SellMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SellMedicine.ImageIndex = 2;
            this.btn_SellMedicine.ImageList = this.iconList;
            this.btn_SellMedicine.Location = new System.Drawing.Point(0, 227);
            this.btn_SellMedicine.Name = "btn_SellMedicine";
            this.btn_SellMedicine.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_SellMedicine.Size = new System.Drawing.Size(284, 73);
            this.btn_SellMedicine.TabIndex = 3;
            this.btn_SellMedicine.Tag = "3";
            this.btn_SellMedicine.Text = "  Bán Thuốc";
            this.btn_SellMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SellMedicine.UseVisualStyleBackColor = true;
            this.btn_SellMedicine.Click += new System.EventHandler(this.btn_SellMedicine_Click);
            // 
            // btn_AddMedicine
            // 
            this.btn_AddMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddMedicine.FlatAppearance.BorderSize = 0;
            this.btn_AddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddMedicine.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_AddMedicine.ForeColor = System.Drawing.Color.Transparent;
            this.btn_AddMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddMedicine.ImageIndex = 1;
            this.btn_AddMedicine.ImageList = this.iconList;
            this.btn_AddMedicine.Location = new System.Drawing.Point(0, 154);
            this.btn_AddMedicine.Name = "btn_AddMedicine";
            this.btn_AddMedicine.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_AddMedicine.Size = new System.Drawing.Size(284, 73);
            this.btn_AddMedicine.TabIndex = 2;
            this.btn_AddMedicine.Tag = "2";
            this.btn_AddMedicine.Text = "  Thêm Thuốc";
            this.btn_AddMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddMedicine.UseVisualStyleBackColor = true;
            this.btn_AddMedicine.Click += new System.EventHandler(this.btn_AddMedicine_Click);
            // 
            // btn_DashBoard
            // 
            this.btn_DashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_DashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DashBoard.FlatAppearance.BorderSize = 0;
            this.btn_DashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DashBoard.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DashBoard.ForeColor = System.Drawing.Color.Transparent;
            this.btn_DashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DashBoard.ImageIndex = 0;
            this.btn_DashBoard.ImageList = this.iconList;
            this.btn_DashBoard.Location = new System.Drawing.Point(0, 81);
            this.btn_DashBoard.Name = "btn_DashBoard";
            this.btn_DashBoard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_DashBoard.Size = new System.Drawing.Size(284, 73);
            this.btn_DashBoard.TabIndex = 1;
            this.btn_DashBoard.Tag = "1";
            this.btn_DashBoard.Text = "  Trang chủ";
            this.btn_DashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DashBoard.UseVisualStyleBackColor = true;
            this.btn_DashBoard.Click += new System.EventHandler(this.btn_DashBoard_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.CadetBlue;
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(284, 81);
            this.panel_Logo.TabIndex = 0;
            // 
            // frm_PharmacistUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 631);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frm_PharmacistUI";
            this.Text = "Quản Lý Bán Thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_DashBoard;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_EditMedicine;
        private System.Windows.Forms.Button btn_ViewMedicine;
        private System.Windows.Forms.Button btn_SellMedicine;
        private System.Windows.Forms.Button btn_AddMedicine;
    }
}

