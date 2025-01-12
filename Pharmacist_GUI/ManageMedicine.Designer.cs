namespace Pharmacist
{
    partial class frm_ManageMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ManageMedicine));
            this.panel_Title = new System.Windows.Forms.Panel();
            this.label_TitleAdd = new System.Windows.Forms.Label();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panel_PricePerUnit = new System.Windows.Forms.Panel();
            this.txt_PricePerUnit = new System.Windows.Forms.TextBox();
            this.panel_Name = new System.Windows.Forms.Panel();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.panel_Id = new System.Windows.Forms.Panel();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label_Name = new DevExpress.XtraEditors.LabelControl();
            this.label_PricePerUnit = new DevExpress.XtraEditors.LabelControl();
            this.label_ID = new DevExpress.XtraEditors.LabelControl();
            this.panel_Description = new System.Windows.Forms.Panel();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label_Description = new DevExpress.XtraEditors.LabelControl();
            this.panel_Dosage = new System.Windows.Forms.Panel();
            this.txt_Dosage = new System.Windows.Forms.TextBox();
            this.label_Dosage = new DevExpress.XtraEditors.LabelControl();
            this.groupControl_MedicineDatabase = new DevExpress.XtraEditors.GroupControl();
            this.btn_RefreshGrid = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_Medicine = new DevExpress.XtraGrid.GridControl();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLieuThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btn_ClearFields = new DevExpress.XtraEditors.SimpleButton();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel_PricePerUnit.SuspendLayout();
            this.panel_Name.SuspendLayout();
            this.panel_Id.SuspendLayout();
            this.panel_Description.SuspendLayout();
            this.panel_Dosage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_MedicineDatabase)).BeginInit();
            this.groupControl_MedicineDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.label_TitleAdd);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1280, 73);
            this.panel_Title.TabIndex = 5;
            // 
            // label_TitleAdd
            // 
            this.label_TitleAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TitleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TitleAdd.Location = new System.Drawing.Point(0, 0);
            this.label_TitleAdd.Name = "label_TitleAdd";
            this.label_TitleAdd.Size = new System.Drawing.Size(1280, 73);
            this.label_TitleAdd.TabIndex = 0;
            this.label_TitleAdd.Text = " Quản lý thuốc";
            this.label_TitleAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.AutoSize = true;
            this.panel_Buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Buttons.Location = new System.Drawing.Point(0, 303);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(1280, 0);
            this.panel_Buttons.TabIndex = 102;
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
            this.btn_Delete.Location = new System.Drawing.Point(323, 13);
            this.btn_Delete.MaximumSize = new System.Drawing.Size(141, 40);
            this.btn_Delete.MinimumSize = new System.Drawing.Size(141, 40);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(141, 40);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "  Xóa";
            this.btn_Delete.ToolTip = "Xóa thuốc hoàn toàn khỏi cơ sở dữ liệu";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.btn_Add.Location = new System.Drawing.Point(12, 13);
            this.btn_Add.MaximumSize = new System.Drawing.Size(141, 40);
            this.btn_Add.MinimumSize = new System.Drawing.Size(141, 40);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(141, 40);
            this.btn_Add.TabIndex = 6;
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
            this.btn_Update.Location = new System.Drawing.Point(167, 13);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Update.MaximumSize = new System.Drawing.Size(141, 40);
            this.btn_Update.MinimumSize = new System.Drawing.Size(141, 40);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(141, 40);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = " Sửa";
            this.btn_Update.ToolTip = "Cập nhật thông tin của thuốc trong cơ sở dữ liệu";
            this.btn_Update.Click += new System.EventHandler(this.btn_InsertUpdate_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.DodgerBlue;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer.Location = new System.Drawing.Point(0, 73);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel1.Controls.Add(this.panel_PricePerUnit);
            this.splitContainer.Panel1.Controls.Add(this.panel_Name);
            this.splitContainer.Panel1.Controls.Add(this.panel_Id);
            this.splitContainer.Panel1.Controls.Add(this.label_Name);
            this.splitContainer.Panel1.Controls.Add(this.label_PricePerUnit);
            this.splitContainer.Panel1.Controls.Add(this.label_ID);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel2.Controls.Add(this.panel_Description);
            this.splitContainer.Panel2.Controls.Add(this.label_Description);
            this.splitContainer.Panel2.Controls.Add(this.panel_Dosage);
            this.splitContainer.Panel2.Controls.Add(this.label_Dosage);
            this.splitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.splitContainer.Size = new System.Drawing.Size(1280, 166);
            this.splitContainer.SplitterDistance = 637;
            this.splitContainer.SplitterWidth = 10;
            this.splitContainer.TabIndex = 103;
            // 
            // panel_PricePerUnit
            // 
            this.panel_PricePerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_PricePerUnit.BackColor = System.Drawing.Color.White;
            this.panel_PricePerUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_PricePerUnit.Controls.Add(this.txt_PricePerUnit);
            this.panel_PricePerUnit.Location = new System.Drawing.Point(155, 118);
            this.panel_PricePerUnit.Name = "panel_PricePerUnit";
            this.panel_PricePerUnit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_PricePerUnit.Size = new System.Drawing.Size(423, 37);
            this.panel_PricePerUnit.TabIndex = 104;
            this.panel_PricePerUnit.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // txt_PricePerUnit
            // 
            this.txt_PricePerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PricePerUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PricePerUnit.Font = new System.Drawing.Font("Tahoma", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_PricePerUnit.Location = new System.Drawing.Point(6, 4);
            this.txt_PricePerUnit.Margin = new System.Windows.Forms.Padding(0);
            this.txt_PricePerUnit.Name = "txt_PricePerUnit";
            this.txt_PricePerUnit.Size = new System.Drawing.Size(412, 29);
            this.txt_PricePerUnit.TabIndex = 3;
            this.txt_PricePerUnit.Enter += new System.EventHandler(this.txtbox_Enter);
            this.txt_PricePerUnit.Leave += new System.EventHandler(this.txtbox_Leave);
            // 
            // panel_Name
            // 
            this.panel_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Name.BackColor = System.Drawing.Color.White;
            this.panel_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Name.Controls.Add(this.txt_Name);
            this.panel_Name.Location = new System.Drawing.Point(155, 64);
            this.panel_Name.Name = "panel_Name";
            this.panel_Name.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_Name.Size = new System.Drawing.Size(423, 37);
            this.panel_Name.TabIndex = 103;
            this.panel_Name.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Font = new System.Drawing.Font("Tahoma", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Name.Location = new System.Drawing.Point(6, 3);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(412, 29);
            this.txt_Name.TabIndex = 2;
            this.txt_Name.Enter += new System.EventHandler(this.txtbox_Enter);
            this.txt_Name.Leave += new System.EventHandler(this.txtbox_Leave);
            // 
            // panel_Id
            // 
            this.panel_Id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Id.BackColor = System.Drawing.Color.White;
            this.panel_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Id.Controls.Add(this.txt_Id);
            this.panel_Id.Location = new System.Drawing.Point(155, 12);
            this.panel_Id.Name = "panel_Id";
            this.panel_Id.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_Id.Size = new System.Drawing.Size(423, 37);
            this.panel_Id.TabIndex = 102;
            this.panel_Id.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // txt_Id
            // 
            this.txt_Id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Id.Font = new System.Drawing.Font("Tahoma", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Id.Location = new System.Drawing.Point(6, 4);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(412, 29);
            this.txt_Id.TabIndex = 1;
            this.txt_Id.Enter += new System.EventHandler(this.txtbox_Enter);
            this.txt_Id.Leave += new System.EventHandler(this.txtbox_Leave);
            // 
            // label_Name
            // 
            this.label_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Name.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Name.Appearance.Options.UseFont = true;
            this.label_Name.Location = new System.Drawing.Point(22, 72);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(90, 23);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Tên Thuốc";
            // 
            // label_PricePerUnit
            // 
            this.label_PricePerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_PricePerUnit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_PricePerUnit.Appearance.Options.UseFont = true;
            this.label_PricePerUnit.Location = new System.Drawing.Point(22, 123);
            this.label_PricePerUnit.Name = "label_PricePerUnit";
            this.label_PricePerUnit.Size = new System.Drawing.Size(120, 23);
            this.label_PricePerUnit.TabIndex = 0;
            this.label_PricePerUnit.Text = "Giá mỗi đơn vị";
            // 
            // label_ID
            // 
            this.label_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ID.Appearance.Options.UseFont = true;
            this.label_ID.Location = new System.Drawing.Point(22, 18);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(78, 23);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID Thuốc";
            // 
            // panel_Description
            // 
            this.panel_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Description.BackColor = System.Drawing.SystemColors.Window;
            this.panel_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Description.Controls.Add(this.txt_Description);
            this.panel_Description.Location = new System.Drawing.Point(151, 72);
            this.panel_Description.Name = "panel_Description";
            this.panel_Description.Size = new System.Drawing.Size(310, 75);
            this.panel_Description.TabIndex = 106;
            this.panel_Description.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // txt_Description
            // 
            this.txt_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Description.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Description.Location = new System.Drawing.Point(0, 0);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(308, 73);
            this.txt_Description.TabIndex = 5;
            // 
            // label_Description
            // 
            this.label_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Description.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Description.Appearance.Options.UseFont = true;
            this.label_Description.Location = new System.Drawing.Point(42, 64);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(47, 23);
            this.label_Description.TabIndex = 104;
            this.label_Description.Text = "Mô tả";
            // 
            // panel_Dosage
            // 
            this.panel_Dosage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Dosage.BackColor = System.Drawing.Color.White;
            this.panel_Dosage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Dosage.Controls.Add(this.txt_Dosage);
            this.panel_Dosage.Location = new System.Drawing.Point(152, 12);
            this.panel_Dosage.Name = "panel_Dosage";
            this.panel_Dosage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_Dosage.Size = new System.Drawing.Size(309, 37);
            this.panel_Dosage.TabIndex = 105;
            this.panel_Dosage.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // txt_Dosage
            // 
            this.txt_Dosage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Dosage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Dosage.Font = new System.Drawing.Font("Tahoma", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Dosage.Location = new System.Drawing.Point(7, 3);
            this.txt_Dosage.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Dosage.Name = "txt_Dosage";
            this.txt_Dosage.Size = new System.Drawing.Size(419, 29);
            this.txt_Dosage.TabIndex = 4;
            this.txt_Dosage.Enter += new System.EventHandler(this.txtbox_Enter);
            this.txt_Dosage.Leave += new System.EventHandler(this.txtbox_Leave);
            // 
            // label_Dosage
            // 
            this.label_Dosage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Dosage.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Dosage.Appearance.Options.UseFont = true;
            this.label_Dosage.Location = new System.Drawing.Point(42, 18);
            this.label_Dosage.Name = "label_Dosage";
            this.label_Dosage.Size = new System.Drawing.Size(88, 23);
            this.label_Dosage.TabIndex = 102;
            this.label_Dosage.Text = "Liều lượng";
            // 
            // groupControl_MedicineDatabase
            // 
            this.groupControl_MedicineDatabase.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl_MedicineDatabase.AppearanceCaption.Options.UseFont = true;
            this.groupControl_MedicineDatabase.Controls.Add(this.btn_RefreshGrid);
            this.groupControl_MedicineDatabase.Controls.Add(this.dgv_Medicine);
            this.groupControl_MedicineDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_MedicineDatabase.Location = new System.Drawing.Point(0, 303);
            this.groupControl_MedicineDatabase.Name = "groupControl_MedicineDatabase";
            this.groupControl_MedicineDatabase.Size = new System.Drawing.Size(1280, 465);
            this.groupControl_MedicineDatabase.TabIndex = 105;
            this.groupControl_MedicineDatabase.Text = "[Bảng Thuốc]";
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
            this.btn_RefreshGrid.Location = new System.Drawing.Point(2, 29);
            this.btn_RefreshGrid.MaximumSize = new System.Drawing.Size(36, 36);
            this.btn_RefreshGrid.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_RefreshGrid.Name = "btn_RefreshGrid";
            this.btn_RefreshGrid.Size = new System.Drawing.Size(30, 30);
            this.btn_RefreshGrid.TabIndex = 106;
            this.btn_RefreshGrid.Click += new System.EventHandler(this.btn_RefreshGrid_Click);
            // 
            // dgv_Medicine
            // 
            this.dgv_Medicine.DataSource = this.medicineBindingSource;
            this.dgv_Medicine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Medicine.Location = new System.Drawing.Point(2, 26);
            this.dgv_Medicine.MainView = this.gridView;
            this.dgv_Medicine.Name = "dgv_Medicine";
            this.dgv_Medicine.Size = new System.Drawing.Size(1276, 437);
            this.dgv_Medicine.TabIndex = 105;
            this.dgv_Medicine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataSource = typeof(PharmacistManagement_DAL.Model.THUOC);
            // 
            // gridView
            // 
            this.gridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaThuoc,
            this.colTenThuoc,
            this.colGiaDonVi,
            this.colLieuThuoc,
            this.colSoLuongTon});
            this.gridView.GridControl = this.dgv_Medicine;
            this.gridView.GroupPanelText = " ";
            this.gridView.Name = "gridView";
            this.gridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_RowCellClick);
            // 
            // colMaThuoc
            // 
            this.colMaThuoc.FieldName = "Mã Thuốc";
            this.colMaThuoc.MinWidth = 23;
            this.colMaThuoc.Name = "colMaThuoc";
            this.colMaThuoc.OptionsColumn.ReadOnly = true;
            this.colMaThuoc.Visible = true;
            this.colMaThuoc.VisibleIndex = 0;
            this.colMaThuoc.Width = 204;
            // 
            // colTenThuoc
            // 
            this.colTenThuoc.FieldName = "Tên Thuốc";
            this.colTenThuoc.MinWidth = 23;
            this.colTenThuoc.Name = "colTenThuoc";
            this.colTenThuoc.OptionsColumn.ReadOnly = true;
            this.colTenThuoc.Visible = true;
            this.colTenThuoc.VisibleIndex = 1;
            this.colTenThuoc.Width = 204;
            // 
            // colGiaDonVi
            // 
            this.colGiaDonVi.DisplayFormat.FormatString = "n0";
            this.colGiaDonVi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGiaDonVi.FieldName = "Giá Đơn Vị";
            this.colGiaDonVi.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGiaDonVi.MinWidth = 23;
            this.colGiaDonVi.Name = "colGiaDonVi";
            this.colGiaDonVi.OptionsColumn.ReadOnly = true;
            this.colGiaDonVi.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colGiaDonVi.UnboundDataType = typeof(long);
            this.colGiaDonVi.Visible = true;
            this.colGiaDonVi.VisibleIndex = 2;
            this.colGiaDonVi.Width = 204;
            // 
            // colLieuThuoc
            // 
            this.colLieuThuoc.FieldName = "Liều Thuốc";
            this.colLieuThuoc.MinWidth = 23;
            this.colLieuThuoc.Name = "colLieuThuoc";
            this.colLieuThuoc.OptionsColumn.ReadOnly = true;
            this.colLieuThuoc.Visible = true;
            this.colLieuThuoc.VisibleIndex = 3;
            this.colLieuThuoc.Width = 184;
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoLuongTon.FieldName = "Số Lượng Tồn";
            this.colSoLuongTon.MinWidth = 23;
            this.colSoLuongTon.Name = "colSoLuongTon";
            this.colSoLuongTon.OptionsColumn.ReadOnly = true;
            this.colSoLuongTon.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colSoLuongTon.UnboundDataType = typeof(long);
            this.colSoLuongTon.Visible = true;
            this.colSoLuongTon.VisibleIndex = 4;
            this.colSoLuongTon.Width = 217;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 239);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Add);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Update);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Delete);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.btn_ClearFields);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1280, 64);
            this.splitContainerControl1.SplitterPosition = 473;
            this.splitContainerControl1.TabIndex = 10;
            // 
            // btn_ClearFields
            // 
            this.btn_ClearFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearFields.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ClearFields.Appearance.Options.UseFont = true;
            this.btn_ClearFields.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_ClearFields.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ClearFields.ImageOptions.SvgImage")));
            this.btn_ClearFields.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btn_ClearFields.Location = new System.Drawing.Point(641, 13);
            this.btn_ClearFields.Name = "btn_ClearFields";
            this.btn_ClearFields.Size = new System.Drawing.Size(142, 39);
            this.btn_ClearFields.TabIndex = 9;
            this.btn_ClearFields.Text = "  Làm sạch";
            this.btn_ClearFields.Click += new System.EventHandler(this.btn_ClearFields_Click);
            // 
            // frm_ManageMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.groupControl_MedicineDatabase);
            this.Controls.Add(this.panel_Buttons);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ManageMedicine";
            this.Text = "Quản Lý Thuốc";
            this.Load += new System.EventHandler(this.frm_ManageMedicine_Load);
            this.panel_Title.ResumeLayout(false);
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
            this.panel_Description.ResumeLayout(false);
            this.panel_Description.PerformLayout();
            this.panel_Dosage.ResumeLayout(false);
            this.panel_Dosage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_MedicineDatabase)).EndInit();
            this.groupControl_MedicineDatabase.ResumeLayout(false);
            this.groupControl_MedicineDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Label label_TitleAdd;
        private System.Windows.Forms.Panel panel_Buttons;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private System.Windows.Forms.SplitContainer splitContainer;
        private DevExpress.XtraEditors.LabelControl label_Name;
        private DevExpress.XtraEditors.LabelControl label_ID;
        private DevExpress.XtraEditors.LabelControl label_PricePerUnit;
        private DevExpress.XtraEditors.LabelControl label_Dosage;
        private System.Windows.Forms.Panel panel_Dosage;
        private System.Windows.Forms.TextBox txt_Dosage;
        private DevExpress.XtraEditors.LabelControl label_Description;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private System.Windows.Forms.Panel panel_Description;
        private System.Windows.Forms.Panel panel_Id;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Panel panel_PricePerUnit;
        private System.Windows.Forms.TextBox txt_PricePerUnit;
        private System.Windows.Forms.Panel panel_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private DevExpress.XtraEditors.GroupControl groupControl_MedicineDatabase;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.TextBox txt_Description;
        private DevExpress.XtraGrid.GridControl dgv_Medicine;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colMaThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colTenThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colLieuThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongTon;
        private DevExpress.XtraEditors.SimpleButton btn_ClearFields;
        private DevExpress.XtraEditors.SimpleButton btn_RefreshGrid;
    }
}