namespace PharmacistUI
{
    partial class frm_AddMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddMedicine));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.label_TitleAdd = new System.Windows.Forms.Label();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.panel_SearchBar = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_SearchBox = new System.Windows.Forms.TextBox();
            this.btn_DeleteRow = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panel_PricePerUnit = new System.Windows.Forms.Panel();
            this.txt_PricePerUnit = new System.Windows.Forms.TextBox();
            this.label_Name = new DevExpress.XtraEditors.LabelControl();
            this.panel_Name = new System.Windows.Forms.Panel();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label_PricePerUnit = new DevExpress.XtraEditors.LabelControl();
            this.panel_ID = new System.Windows.Forms.Panel();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label_ID = new DevExpress.XtraEditors.LabelControl();
            this.panel_Description = new System.Windows.Forms.Panel();
            this.richtxt_Description = new System.Windows.Forms.RichTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel_Dosage = new System.Windows.Forms.Panel();
            this.txt_Dosage = new System.Windows.Forms.TextBox();
            this.label_Dosage = new DevExpress.XtraEditors.LabelControl();
            this.dgv_Medicine = new System.Windows.Forms.DataGridView();
            this.MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Title.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            this.panel_SearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel_PricePerUnit.SuspendLayout();
            this.panel_Name.SuspendLayout();
            this.panel_ID.SuspendLayout();
            this.panel_Description.SuspendLayout();
            this.panel_Dosage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicine)).BeginInit();
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
            this.label_TitleAdd.Text = "Quản lý thuốc";
            this.label_TitleAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Controls.Add(this.panel_SearchBar);
            this.panel_Buttons.Controls.Add(this.btn_DeleteRow);
            this.panel_Buttons.Controls.Add(this.btn_Add);
            this.panel_Buttons.Controls.Add(this.btn_Update);
            this.panel_Buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Buttons.Location = new System.Drawing.Point(0, 239);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(1280, 52);
            this.panel_Buttons.TabIndex = 102;
            // 
            // panel_SearchBar
            // 
            this.panel_SearchBar.Controls.Add(this.labelControl2);
            this.panel_SearchBar.Controls.Add(this.txt_SearchBox);
            this.panel_SearchBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_SearchBar.Location = new System.Drawing.Point(878, 0);
            this.panel_SearchBar.Name = "panel_SearchBar";
            this.panel_SearchBar.Size = new System.Drawing.Size(402, 52);
            this.panel_SearchBar.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(136, 23);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Nhập ID Thuốc:";
            // 
            // txt_SearchBox
            // 
            this.txt_SearchBox.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SearchBox.Location = new System.Drawing.Point(154, 12);
            this.txt_SearchBox.Name = "txt_SearchBox";
            this.txt_SearchBox.Size = new System.Drawing.Size(217, 29);
            this.txt_SearchBox.TabIndex = 6;
            // 
            // btn_DeleteRow
            // 
            this.btn_DeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DeleteRow.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DeleteRow.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteRow.Appearance.Options.UseBackColor = true;
            this.btn_DeleteRow.Appearance.Options.UseFont = true;
            this.btn_DeleteRow.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_DeleteRow.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_DeleteRow.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_DeleteRow.ImageOptions.SvgImage")));
            this.btn_DeleteRow.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.btn_DeleteRow.Location = new System.Drawing.Point(333, 6);
            this.btn_DeleteRow.MaximumSize = new System.Drawing.Size(141, 40);
            this.btn_DeleteRow.MinimumSize = new System.Drawing.Size(141, 40);
            this.btn_DeleteRow.Name = "btn_DeleteRow";
            this.btn_DeleteRow.Size = new System.Drawing.Size(141, 40);
            this.btn_DeleteRow.TabIndex = 8;
            this.btn_DeleteRow.Text = "  Xóa";
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Add.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
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
            this.btn_Add.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Add.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btn_Add.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Add.AppearanceHovered.Options.UseFont = true;
            this.btn_Add.AppearanceHovered.Options.UseForeColor = true;
            this.btn_Add.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_Add.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold);
            this.btn_Add.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btn_Add.AppearancePressed.Options.UseBackColor = true;
            this.btn_Add.AppearancePressed.Options.UseFont = true;
            this.btn_Add.AppearancePressed.Options.UseForeColor = true;
            this.btn_Add.AutoWidthInLayoutControl = true;
            this.btn_Add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Add.ImageOptions.ImageToTextIndent = 10;
            this.btn_Add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Add.ImageOptions.SvgImage")));
            this.btn_Add.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.btn_Add.Location = new System.Drawing.Point(22, 6);
            this.btn_Add.MaximumSize = new System.Drawing.Size(141, 40);
            this.btn_Add.MinimumSize = new System.Drawing.Size(141, 40);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(141, 40);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
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
            this.btn_Update.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 14.74545F, System.Drawing.FontStyle.Bold);
            this.btn_Update.AppearanceHovered.Options.UseFont = true;
            this.btn_Update.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_Update.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_Update.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Update.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Update.AppearancePressed.Options.UseFont = true;
            this.btn_Update.AppearancePressed.Options.UseTextOptions = true;
            this.btn_Update.AppearancePressed.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.btn_Update.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_Update.AutoWidthInLayoutControl = true;
            this.btn_Update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Update.ImageOptions.ImageToTextIndent = 10;
            this.btn_Update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Update.ImageOptions.SvgImage")));
            this.btn_Update.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_Update.Location = new System.Drawing.Point(177, 6);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Update.MaximumSize = new System.Drawing.Size(141, 40);
            this.btn_Update.MinimumSize = new System.Drawing.Size(141, 40);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(141, 40);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.DodgerBlue;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 73);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel1.Controls.Add(this.panel_PricePerUnit);
            this.splitContainer.Panel1.Controls.Add(this.label_Name);
            this.splitContainer.Panel1.Controls.Add(this.panel_Name);
            this.splitContainer.Panel1.Controls.Add(this.label_PricePerUnit);
            this.splitContainer.Panel1.Controls.Add(this.panel_ID);
            this.splitContainer.Panel1.Controls.Add(this.label_ID);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel2.Controls.Add(this.panel_Description);
            this.splitContainer.Panel2.Controls.Add(this.labelControl1);
            this.splitContainer.Panel2.Controls.Add(this.panel_Dosage);
            this.splitContainer.Panel2.Controls.Add(this.label_Dosage);
            this.splitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.splitContainer.Size = new System.Drawing.Size(1280, 166);
            this.splitContainer.SplitterDistance = 631;
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
            this.panel_PricePerUnit.Location = new System.Drawing.Point(155, 111);
            this.panel_PricePerUnit.Name = "panel_PricePerUnit";
            this.panel_PricePerUnit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_PricePerUnit.Size = new System.Drawing.Size(417, 36);
            this.panel_PricePerUnit.TabIndex = 100;
            this.panel_PricePerUnit.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // txt_PricePerUnit
            // 
            this.txt_PricePerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PricePerUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PricePerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_PricePerUnit.Location = new System.Drawing.Point(7, 6);
            this.txt_PricePerUnit.Margin = new System.Windows.Forms.Padding(0);
            this.txt_PricePerUnit.Name = "txt_PricePerUnit";
            this.txt_PricePerUnit.Size = new System.Drawing.Size(401, 28);
            this.txt_PricePerUnit.TabIndex = 2;
            this.txt_PricePerUnit.Text = "0";
            this.txt_PricePerUnit.Enter += new System.EventHandler(this.txtbox_Enter);
            this.txt_PricePerUnit.Leave += new System.EventHandler(this.txtbox_Leave);
            // 
            // label_Name
            // 
            this.label_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Name.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Name.Appearance.Options.UseFont = true;
            this.label_Name.Location = new System.Drawing.Point(22, 68);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(90, 23);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Tên Thuốc";
            // 
            // panel_Name
            // 
            this.panel_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Name.BackColor = System.Drawing.Color.White;
            this.panel_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Name.Controls.Add(this.txt_Name);
            this.panel_Name.Location = new System.Drawing.Point(155, 61);
            this.panel_Name.Name = "panel_Name";
            this.panel_Name.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_Name.Size = new System.Drawing.Size(416, 37);
            this.panel_Name.TabIndex = 9;
            this.panel_Name.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Name.Location = new System.Drawing.Point(6, 7);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(405, 28);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.Enter += new System.EventHandler(this.txtbox_Enter);
            this.txt_Name.Leave += new System.EventHandler(this.txtbox_Leave);
            // 
            // label_PricePerUnit
            // 
            this.label_PricePerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_PricePerUnit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_PricePerUnit.Appearance.Options.UseFont = true;
            this.label_PricePerUnit.Location = new System.Drawing.Point(22, 118);
            this.label_PricePerUnit.Name = "label_PricePerUnit";
            this.label_PricePerUnit.Size = new System.Drawing.Size(120, 23);
            this.label_PricePerUnit.TabIndex = 0;
            this.label_PricePerUnit.Text = "Giá mỗi đơn vị";
            // 
            // panel_ID
            // 
            this.panel_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ID.BackColor = System.Drawing.Color.White;
            this.panel_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ID.Controls.Add(this.txt_Id);
            this.panel_ID.Location = new System.Drawing.Point(155, 11);
            this.panel_ID.Name = "panel_ID";
            this.panel_ID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_ID.Size = new System.Drawing.Size(416, 37);
            this.panel_ID.TabIndex = 8;
            this.panel_ID.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // txt_Id
            // 
            this.txt_Id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Id.Location = new System.Drawing.Point(6, 7);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(405, 28);
            this.txt_Id.TabIndex = 0;
            this.txt_Id.Enter += new System.EventHandler(this.txtbox_Enter);
            this.txt_Id.Leave += new System.EventHandler(this.txtbox_Leave);
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
            this.panel_Description.Controls.Add(this.richtxt_Description);
            this.panel_Description.Location = new System.Drawing.Point(161, 63);
            this.panel_Description.Name = "panel_Description";
            this.panel_Description.Size = new System.Drawing.Size(441, 84);
            this.panel_Description.TabIndex = 105;
            this.panel_Description.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // richtxt_Description
            // 
            this.richtxt_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtxt_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxt_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richtxt_Description.Location = new System.Drawing.Point(3, 0);
            this.richtxt_Description.Name = "richtxt_Description";
            this.richtxt_Description.Size = new System.Drawing.Size(433, 82);
            this.richtxt_Description.TabIndex = 103;
            this.richtxt_Description.Text = "";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(35, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 23);
            this.labelControl1.TabIndex = 104;
            this.labelControl1.Text = "Mô tả";
            // 
            // panel_Dosage
            // 
            this.panel_Dosage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Dosage.BackColor = System.Drawing.Color.White;
            this.panel_Dosage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Dosage.Controls.Add(this.txt_Dosage);
            this.panel_Dosage.Location = new System.Drawing.Point(161, 4);
            this.panel_Dosage.Name = "panel_Dosage";
            this.panel_Dosage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_Dosage.Size = new System.Drawing.Size(441, 37);
            this.panel_Dosage.TabIndex = 101;
            this.panel_Dosage.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // txt_Dosage
            // 
            this.txt_Dosage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Dosage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Dosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Dosage.Location = new System.Drawing.Point(6, 7);
            this.txt_Dosage.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Dosage.Name = "txt_Dosage";
            this.txt_Dosage.Size = new System.Drawing.Size(430, 28);
            this.txt_Dosage.TabIndex = 1;
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
            this.label_Dosage.Location = new System.Drawing.Point(35, 11);
            this.label_Dosage.Name = "label_Dosage";
            this.label_Dosage.Size = new System.Drawing.Size(88, 23);
            this.label_Dosage.TabIndex = 102;
            this.label_Dosage.Text = "Liều lượng";
            // 
            // dgv_Medicine
            // 
            this.dgv_Medicine.AllowUserToAddRows = false;
            this.dgv_Medicine.AllowUserToDeleteRows = false;
            this.dgv_Medicine.AllowUserToResizeColumns = false;
            this.dgv_Medicine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Medicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Medicine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Medicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Medicine.ColumnHeadersHeight = 50;
            this.dgv_Medicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Medicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineID,
            this.MedicineName,
            this.Amount,
            this.PricePerUnit,
            this.ProductionDate,
            this.ExpirationDate});
            this.dgv_Medicine.Location = new System.Drawing.Point(22, 297);
            this.dgv_Medicine.Name = "dgv_Medicine";
            this.dgv_Medicine.ReadOnly = true;
            this.dgv_Medicine.RowHeadersVisible = false;
            this.dgv_Medicine.RowHeadersWidth = 47;
            this.dgv_Medicine.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Medicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Medicine.Size = new System.Drawing.Size(1227, 446);
            this.dgv_Medicine.TabIndex = 104;
            // 
            // MedicineID
            // 
            this.MedicineID.HeaderText = "ID Thuốc";
            this.MedicineID.MinimumWidth = 6;
            this.MedicineID.Name = "MedicineID";
            this.MedicineID.ReadOnly = true;
            // 
            // MedicineName
            // 
            this.MedicineName.HeaderText = "Tên Thuốc";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Số lượng";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.HeaderText = "Giá mỗi đơn vị";
            this.PricePerUnit.MinimumWidth = 6;
            this.PricePerUnit.Name = "PricePerUnit";
            this.PricePerUnit.ReadOnly = true;
            // 
            // ProductionDate
            // 
            this.ProductionDate.HeaderText = "Ngày sản xuất";
            this.ProductionDate.MinimumWidth = 6;
            this.ProductionDate.Name = "ProductionDate";
            this.ProductionDate.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.HeaderText = "Ngày hết hạn";
            this.ExpirationDate.MinimumWidth = 6;
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            // 
            // frm_AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.dgv_Medicine);
            this.Controls.Add(this.panel_Buttons);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AddMedicine";
            this.Text = "AddMedicine";
            this.Load += new System.EventHandler(this.frm_AddMedicine_Load);
            this.panel_Title.ResumeLayout(false);
            this.panel_Buttons.ResumeLayout(false);
            this.panel_SearchBar.ResumeLayout(false);
            this.panel_SearchBar.PerformLayout();
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
            this.panel_ID.ResumeLayout(false);
            this.panel_ID.PerformLayout();
            this.panel_Description.ResumeLayout(false);
            this.panel_Dosage.ResumeLayout(false);
            this.panel_Dosage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Label label_TitleAdd;
        private System.Windows.Forms.Panel panel_Buttons;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private System.Windows.Forms.SplitContainer splitContainer;
        private DevExpress.XtraEditors.LabelControl label_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private DevExpress.XtraEditors.LabelControl label_ID;
        private System.Windows.Forms.Panel panel_PricePerUnit;
        private System.Windows.Forms.TextBox txt_PricePerUnit;
        private DevExpress.XtraEditors.LabelControl label_PricePerUnit;
        private DevExpress.XtraEditors.LabelControl label_Dosage;
        private System.Windows.Forms.Panel panel_Dosage;
        private System.Windows.Forms.TextBox txt_Dosage;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox richtxt_Description;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteRow;
        private System.Windows.Forms.Panel panel_SearchBar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txt_SearchBox;
        private System.Windows.Forms.DataGridView dgv_Medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Panel panel_Name;
        private System.Windows.Forms.Panel panel_ID;
        private System.Windows.Forms.Panel panel_Description;
    }
}