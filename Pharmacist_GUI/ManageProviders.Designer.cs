namespace Pharmacist
{
    partial class frm_ManageProviders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ManageProviders));
            this.label_ProviderEmail = new DevExpress.XtraEditors.LabelControl();
            this.label_ProviderName = new DevExpress.XtraEditors.LabelControl();
            this.label_ProviderPhone = new DevExpress.XtraEditors.LabelControl();
            this.label_ProviderAddress = new DevExpress.XtraEditors.LabelControl();
            this.label_ProviderId = new DevExpress.XtraEditors.LabelControl();
            this.txt_ProviderPhone = new System.Windows.Forms.TextBox();
            this.txt_ProviderEmail = new System.Windows.Forms.TextBox();
            this.txt_ProviderAddress = new System.Windows.Forms.TextBox();
            this.txt_ProviderName = new System.Windows.Forms.TextBox();
            this.txt_ProviderId = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panel_PricePerUnit = new System.Windows.Forms.Panel();
            this.panel_Name = new System.Windows.Forms.Panel();
            this.panel_Id = new System.Windows.Forms.Panel();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl_Title = new DevExpress.XtraEditors.LabelControl();
            this.panelControl_Title = new DevExpress.XtraEditors.PanelControl();
            this.btn_ClearFields = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl_dgv = new DevExpress.XtraEditors.GroupControl();
            this.btn_RefreshGrid = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_data = new DevExpress.XtraGrid.GridControl();
            this.gridView_Providers = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel_PricePerUnit.SuspendLayout();
            this.panel_Name.SuspendLayout();
            this.panel_Id.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_Title)).BeginInit();
            this.panelControl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_dgv)).BeginInit();
            this.groupControl_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Providers)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ProviderEmail
            // 
            this.label_ProviderEmail.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ProviderEmail.Appearance.Options.UseFont = true;
            this.label_ProviderEmail.Location = new System.Drawing.Point(89, 24);
            this.label_ProviderEmail.Name = "label_ProviderEmail";
            this.label_ProviderEmail.Size = new System.Drawing.Size(48, 22);
            this.label_ProviderEmail.TabIndex = 19;
            this.label_ProviderEmail.Text = "Email:";
            // 
            // label_ProviderName
            // 
            this.label_ProviderName.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ProviderName.Appearance.Options.UseFont = true;
            this.label_ProviderName.Location = new System.Drawing.Point(29, 72);
            this.label_ProviderName.Name = "label_ProviderName";
            this.label_ProviderName.Size = new System.Drawing.Size(161, 23);
            this.label_ProviderName.TabIndex = 20;
            this.label_ProviderName.Text = "Tên nhà cung cấp:";
            // 
            // label_ProviderPhone
            // 
            this.label_ProviderPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ProviderPhone.Appearance.Options.UseFont = true;
            this.label_ProviderPhone.Location = new System.Drawing.Point(89, 72);
            this.label_ProviderPhone.Name = "label_ProviderPhone";
            this.label_ProviderPhone.Size = new System.Drawing.Size(117, 23);
            this.label_ProviderPhone.TabIndex = 21;
            this.label_ProviderPhone.Text = "Số điện thoại:";
            // 
            // label_ProviderAddress
            // 
            this.label_ProviderAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ProviderAddress.Appearance.Options.UseFont = true;
            this.label_ProviderAddress.Location = new System.Drawing.Point(29, 121);
            this.label_ProviderAddress.Name = "label_ProviderAddress";
            this.label_ProviderAddress.Size = new System.Drawing.Size(64, 23);
            this.label_ProviderAddress.TabIndex = 22;
            this.label_ProviderAddress.Text = "Địa chỉ:";
            // 
            // label_ProviderId
            // 
            this.label_ProviderId.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ProviderId.Appearance.Options.UseFont = true;
            this.label_ProviderId.Location = new System.Drawing.Point(30, 23);
            this.label_ProviderId.Name = "label_ProviderId";
            this.label_ProviderId.Size = new System.Drawing.Size(160, 23);
            this.label_ProviderId.TabIndex = 23;
            this.label_ProviderId.Text = "Mã Nhà Cung Cấp:";
            // 
            // txt_ProviderPhone
            // 
            this.txt_ProviderPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ProviderPhone.Font = new System.Drawing.Font("Tahoma", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ProviderPhone.Location = new System.Drawing.Point(6, 3);
            this.txt_ProviderPhone.Name = "txt_ProviderPhone";
            this.txt_ProviderPhone.Size = new System.Drawing.Size(329, 29);
            this.txt_ProviderPhone.TabIndex = 14;
            // 
            // txt_ProviderEmail
            // 
            this.txt_ProviderEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ProviderEmail.Font = new System.Drawing.Font("Tahoma", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ProviderEmail.Location = new System.Drawing.Point(6, 2);
            this.txt_ProviderEmail.Name = "txt_ProviderEmail";
            this.txt_ProviderEmail.Size = new System.Drawing.Size(329, 29);
            this.txt_ProviderEmail.TabIndex = 15;
            // 
            // txt_ProviderAddress
            // 
            this.txt_ProviderAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ProviderAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ProviderAddress.Font = new System.Drawing.Font("Tahoma", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ProviderAddress.Location = new System.Drawing.Point(6, 3);
            this.txt_ProviderAddress.Name = "txt_ProviderAddress";
            this.txt_ProviderAddress.Size = new System.Drawing.Size(337, 29);
            this.txt_ProviderAddress.TabIndex = 16;
            // 
            // txt_ProviderName
            // 
            this.txt_ProviderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ProviderName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ProviderName.Font = new System.Drawing.Font("Tahoma", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ProviderName.Location = new System.Drawing.Point(6, 3);
            this.txt_ProviderName.Name = "txt_ProviderName";
            this.txt_ProviderName.Size = new System.Drawing.Size(337, 29);
            this.txt_ProviderName.TabIndex = 17;
            // 
            // txt_ProviderId
            // 
            this.txt_ProviderId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ProviderId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ProviderId.Font = new System.Drawing.Font("Tahoma", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ProviderId.Location = new System.Drawing.Point(6, 3);
            this.txt_ProviderId.Name = "txt_ProviderId";
            this.txt_ProviderId.Size = new System.Drawing.Size(337, 29);
            this.txt_ProviderId.TabIndex = 18;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.DodgerBlue;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 64);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel1.Controls.Add(this.label_ProviderId);
            this.splitContainer.Panel1.Controls.Add(this.label_ProviderAddress);
            this.splitContainer.Panel1.Controls.Add(this.label_ProviderName);
            this.splitContainer.Panel1.Controls.Add(this.panel_PricePerUnit);
            this.splitContainer.Panel1.Controls.Add(this.panel_Name);
            this.splitContainer.Panel1.Controls.Add(this.panel_Id);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel2.Controls.Add(this.btn_Add);
            this.splitContainer.Panel2.Controls.Add(this.btn_Update);
            this.splitContainer.Panel2.Controls.Add(this.btn_Delete);
            this.splitContainer.Panel2.Controls.Add(this.label_ProviderEmail);
            this.splitContainer.Panel2.Controls.Add(this.label_ProviderPhone);
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Panel2.Controls.Add(this.panel2);
            this.splitContainer.Size = new System.Drawing.Size(1278, 174);
            this.splitContainer.SplitterDistance = 631;
            this.splitContainer.SplitterWidth = 10;
            this.splitContainer.TabIndex = 104;
            // 
            // panel_PricePerUnit
            // 
            this.panel_PricePerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_PricePerUnit.BackColor = System.Drawing.Color.White;
            this.panel_PricePerUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_PricePerUnit.Controls.Add(this.txt_ProviderAddress);
            this.panel_PricePerUnit.Location = new System.Drawing.Point(202, 119);
            this.panel_PricePerUnit.Name = "panel_PricePerUnit";
            this.panel_PricePerUnit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_PricePerUnit.Size = new System.Drawing.Size(350, 37);
            this.panel_PricePerUnit.TabIndex = 106;
            // 
            // panel_Name
            // 
            this.panel_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Name.BackColor = System.Drawing.Color.White;
            this.panel_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Name.Controls.Add(this.txt_ProviderName);
            this.panel_Name.Location = new System.Drawing.Point(202, 65);
            this.panel_Name.Name = "panel_Name";
            this.panel_Name.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_Name.Size = new System.Drawing.Size(350, 37);
            this.panel_Name.TabIndex = 105;
            // 
            // panel_Id
            // 
            this.panel_Id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Id.BackColor = System.Drawing.Color.White;
            this.panel_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Id.Controls.Add(this.txt_ProviderId);
            this.panel_Id.Location = new System.Drawing.Point(202, 13);
            this.panel_Id.Name = "panel_Id";
            this.panel_Id.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_Id.Size = new System.Drawing.Size(350, 37);
            this.panel_Id.TabIndex = 104;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Add.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Appearance.Options.UseBackColor = true;
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.Appearance.Options.UseForeColor = true;
            this.btn_Add.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.btn_Add.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Add.AppearanceDisabled.Options.UseBackColor = true;
            this.btn_Add.AppearanceDisabled.Options.UseFont = true;
            this.btn_Add.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_Add.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold);
            this.btn_Add.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btn_Add.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Add.AppearanceHovered.Options.UseFont = true;
            this.btn_Add.AppearanceHovered.Options.UseForeColor = true;
            this.btn_Add.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_Add.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold);
            this.btn_Add.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btn_Add.AppearancePressed.Options.UseBackColor = true;
            this.btn_Add.AppearancePressed.Options.UseFont = true;
            this.btn_Add.AppearancePressed.Options.UseForeColor = true;
            this.btn_Add.AutoWidthInLayoutControl = true;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Add.ImageOptions.ImageToTextIndent = 10;
            this.btn_Add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Add.ImageOptions.SvgImage")));
            this.btn_Add.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.btn_Add.Location = new System.Drawing.Point(65, 123);
            this.btn_Add.MaximumSize = new System.Drawing.Size(141, 40);
            this.btn_Add.MinimumSize = new System.Drawing.Size(141, 40);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(141, 40);
            this.btn_Add.TabIndex = 109;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.ToolTip = "Thêm thuốc vào cơ sở dữ liệu";
            this.btn_Add.Click += new System.EventHandler(this.btn_InsertUpdate_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Update.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Update.Appearance.Options.UseBackColor = true;
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Appearance.Options.UseTextOptions = true;
            this.btn_Update.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_Update.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold);
            this.btn_Update.AppearanceHovered.Options.UseFont = true;
            this.btn_Update.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_Update.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_Update.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Update.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold);
            this.btn_Update.AppearancePressed.Options.UseFont = true;
            this.btn_Update.AppearancePressed.Options.UseTextOptions = true;
            this.btn_Update.AppearancePressed.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.btn_Update.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_Update.AutoWidthInLayoutControl = true;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Update.ImageOptions.ImageToTextIndent = 10;
            this.btn_Update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Update.ImageOptions.SvgImage")));
            this.btn_Update.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_Update.Location = new System.Drawing.Point(250, 123);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Update.MaximumSize = new System.Drawing.Size(141, 40);
            this.btn_Update.MinimumSize = new System.Drawing.Size(141, 40);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(141, 40);
            this.btn_Update.TabIndex = 110;
            this.btn_Update.Text = " Sửa";
            this.btn_Update.ToolTip = "Cập nhật thông tin của thuốc trong cơ sở dữ liệu";
            this.btn_Update.Click += new System.EventHandler(this.btn_InsertUpdate_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Delete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Appearance.Options.UseBackColor = true;
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Delete.AppearanceHovered.Options.UseFont = true;
            this.btn_Delete.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Delete.AppearancePressed.Options.UseFont = true;
            this.btn_Delete.AutoWidthInLayoutControl = true;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Delete.ImageOptions.SvgImage")));
            this.btn_Delete.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.btn_Delete.Location = new System.Drawing.Point(430, 123);
            this.btn_Delete.MaximumSize = new System.Drawing.Size(141, 40);
            this.btn_Delete.MinimumSize = new System.Drawing.Size(141, 40);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(141, 40);
            this.btn_Delete.TabIndex = 111;
            this.btn_Delete.Text = "  Xóa";
            this.btn_Delete.ToolTip = "Xóa thuốc hoàn toàn khỏi cơ sở dữ liệu";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_ProviderPhone);
            this.panel1.Location = new System.Drawing.Point(231, 71);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(340, 37);
            this.panel1.TabIndex = 108;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_ProviderEmail);
            this.panel2.Location = new System.Drawing.Point(231, 17);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(340, 37);
            this.panel2.TabIndex = 107;
            // 
            // labelControl_Title
            // 
            this.labelControl_Title.Appearance.Font = new System.Drawing.Font("Tahoma", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl_Title.Appearance.Options.UseFont = true;
            this.labelControl_Title.Appearance.Options.UseTextOptions = true;
            this.labelControl_Title.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl_Title.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl_Title.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl_Title.Location = new System.Drawing.Point(2, 2);
            this.labelControl_Title.Name = "labelControl_Title";
            this.labelControl_Title.Size = new System.Drawing.Size(1274, 60);
            this.labelControl_Title.TabIndex = 24;
            this.labelControl_Title.Text = "   Thông tin nhà cung cấp";
            // 
            // panelControl_Title
            // 
            this.panelControl_Title.Controls.Add(this.btn_ClearFields);
            this.panelControl_Title.Controls.Add(this.labelControl_Title);
            this.panelControl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl_Title.Location = new System.Drawing.Point(0, 0);
            this.panelControl_Title.Name = "panelControl_Title";
            this.panelControl_Title.Size = new System.Drawing.Size(1278, 64);
            this.panelControl_Title.TabIndex = 25;
            // 
            // btn_ClearFields
            // 
            this.btn_ClearFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearFields.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ClearFields.Appearance.Options.UseFont = true;
            this.btn_ClearFields.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_ClearFields.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ClearFields.ImageOptions.SvgImage")));
            this.btn_ClearFields.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btn_ClearFields.Location = new System.Drawing.Point(1124, 12);
            this.btn_ClearFields.Name = "btn_ClearFields";
            this.btn_ClearFields.Size = new System.Drawing.Size(142, 39);
            this.btn_ClearFields.TabIndex = 108;
            this.btn_ClearFields.Text = "  Làm sạch";
            this.btn_ClearFields.Click += new System.EventHandler(this.btn_ClearFields_Click);
            // 
            // groupControl_dgv
            // 
            this.groupControl_dgv.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold);
            this.groupControl_dgv.AppearanceCaption.Options.UseFont = true;
            this.groupControl_dgv.Controls.Add(this.btn_RefreshGrid);
            this.groupControl_dgv.Controls.Add(this.gridControl_data);
            this.groupControl_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_dgv.Location = new System.Drawing.Point(0, 238);
            this.groupControl_dgv.Name = "groupControl_dgv";
            this.groupControl_dgv.Size = new System.Drawing.Size(1278, 445);
            this.groupControl_dgv.TabIndex = 107;
            this.groupControl_dgv.Text = "[ Danh Sách Nhà Cung Cấp ]";
            // 
            // btn_RefreshGrid
            // 
            this.btn_RefreshGrid.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btn_RefreshGrid.Appearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_RefreshGrid.Appearance.Options.UseBackColor = true;
            this.btn_RefreshGrid.Appearance.Options.UseBorderColor = true;
            this.btn_RefreshGrid.Appearance.Options.UseForeColor = true;
            this.btn_RefreshGrid.AppearanceHovered.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_RefreshGrid.AppearanceHovered.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_RefreshGrid.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_RefreshGrid.AppearanceHovered.Options.UseBackColor = true;
            this.btn_RefreshGrid.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_RefreshGrid.AppearanceHovered.Options.UseForeColor = true;
            this.btn_RefreshGrid.AppearancePressed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_RefreshGrid.AppearancePressed.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_RefreshGrid.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btn_RefreshGrid.AppearancePressed.Options.UseBackColor = true;
            this.btn_RefreshGrid.AppearancePressed.Options.UseBorderColor = true;
            this.btn_RefreshGrid.AppearancePressed.Options.UseForeColor = true;
            this.btn_RefreshGrid.AutoSize = true;
            this.btn_RefreshGrid.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_RefreshGrid.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_RefreshGrid.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_RefreshGrid.ImageOptions.SvgImage")));
            this.btn_RefreshGrid.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_RefreshGrid.Location = new System.Drawing.Point(0, 26);
            this.btn_RefreshGrid.MaximumSize = new System.Drawing.Size(36, 36);
            this.btn_RefreshGrid.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_RefreshGrid.Name = "btn_RefreshGrid";
            this.btn_RefreshGrid.Size = new System.Drawing.Size(30, 30);
            this.btn_RefreshGrid.TabIndex = 107;
            this.btn_RefreshGrid.Click += new System.EventHandler(this.btn_RefreshGrid_Click);
            // 
            // gridControl_data
            // 
            this.gridControl_data.DataSource = typeof(PharmacistManagement_DAL.Model.NHACUNGCAP);
            this.gridControl_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_data.Location = new System.Drawing.Point(2, 26);
            this.gridControl_data.MainView = this.gridView_Providers;
            this.gridControl_data.Name = "gridControl_data";
            this.gridControl_data.Size = new System.Drawing.Size(1274, 417);
            this.gridControl_data.TabIndex = 0;
            this.gridControl_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Providers});
            // 
            // gridView_Providers
            // 
            this.gridView_Providers.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView_Providers.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView_Providers.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView_Providers.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView_Providers.Appearance.HeaderPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gridView_Providers.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView_Providers.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView_Providers.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView_Providers.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_Providers.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView_Providers.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_Providers.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_Providers.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_Providers.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView_Providers.Appearance.Row.Options.UseFont = true;
            this.gridView_Providers.Appearance.SelectedRow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridView_Providers.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Black;
            this.gridView_Providers.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView_Providers.Appearance.SelectedRow.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView_Providers.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView_Providers.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView_Providers.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView_Providers.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView_Providers.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView_Providers.GridControl = this.gridControl_data;
            this.gridView_Providers.GroupPanelText = " ";
            this.gridView_Providers.Name = "gridView_Providers";
            this.gridView_Providers.OptionsBehavior.Editable = false;
            this.gridView_Providers.OptionsBehavior.ReadOnly = true;
            this.gridView_Providers.OptionsView.ShowFooter = true;
            this.gridView_Providers.OptionsView.ShowIndicator = false;
            this.gridView_Providers.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_Providers_RowCellClick);
            // 
            // frm_ManageProviders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 683);
            this.Controls.Add(this.groupControl_dgv);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panelControl_Title);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ManageProviders";
            this.Text = "Quản Lý Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.frm_ManageProviders_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel_PricePerUnit.ResumeLayout(false);
            this.panel_PricePerUnit.PerformLayout();
            this.panel_Name.ResumeLayout(false);
            this.panel_Name.PerformLayout();
            this.panel_Id.ResumeLayout(false);
            this.panel_Id.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_Title)).EndInit();
            this.panelControl_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_dgv)).EndInit();
            this.groupControl_dgv.ResumeLayout(false);
            this.groupControl_dgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Providers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label_ProviderEmail;
        private DevExpress.XtraEditors.LabelControl label_ProviderName;
        private DevExpress.XtraEditors.LabelControl label_ProviderPhone;
        private DevExpress.XtraEditors.LabelControl label_ProviderAddress;
        private DevExpress.XtraEditors.LabelControl label_ProviderId;
        private System.Windows.Forms.TextBox txt_ProviderPhone;
        private System.Windows.Forms.TextBox txt_ProviderEmail;
        private System.Windows.Forms.TextBox txt_ProviderAddress;
        private System.Windows.Forms.TextBox txt_ProviderName;
        private System.Windows.Forms.TextBox txt_ProviderId;
        private System.Windows.Forms.SplitContainer splitContainer;
        private DevExpress.XtraEditors.LabelControl labelControl_Title;
        private DevExpress.XtraEditors.PanelControl panelControl_Title;
        private System.Windows.Forms.Panel panel_PricePerUnit;
        private System.Windows.Forms.Panel panel_Name;
        private System.Windows.Forms.Panel panel_Id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.GroupControl groupControl_dgv;
        private DevExpress.XtraGrid.GridControl gridControl_data;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Providers;
        private DevExpress.XtraEditors.SimpleButton btn_RefreshGrid;
        private DevExpress.XtraEditors.SimpleButton btn_ClearFields;
    }
}