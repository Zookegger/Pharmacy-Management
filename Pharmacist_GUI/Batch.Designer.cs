namespace Pharmacist
{
    partial class frm_EditMedicine
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
            System.Windows.Forms.SplitContainer splitContainer;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditMedicine));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.numUpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.label_Name = new DevExpress.XtraEditors.LabelControl();
            this.panel_Name = new System.Windows.Forms.Panel();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label_Amount = new DevExpress.XtraEditors.LabelControl();
            this.panel_ID = new System.Windows.Forms.Panel();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label_ID = new DevExpress.XtraEditors.LabelControl();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker_ExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ProductionDate = new System.Windows.Forms.DateTimePicker();
            this.label_ProductionDay = new DevExpress.XtraEditors.LabelControl();
            this.label_ExpirationDate = new DevExpress.XtraEditors.LabelControl();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.panel_Functions = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_SearchBar = new DevExpress.XtraEditors.LabelControl();
            this.groupControl_dgv = new DevExpress.XtraEditors.GroupControl();
            this.dgv_Batches = new System.Windows.Forms.DataGridView();
            this.col_BatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProviderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProductionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BatchQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.label_TitleAdd = new System.Windows.Forms.Label();
            this.alertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(splitContainer)).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Quantity)).BeginInit();
            this.panel_Name.SuspendLayout();
            this.panel_ID.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Functions)).BeginInit();
            this.panel_Functions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_dgv)).BeginInit();
            this.groupControl_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Batches)).BeginInit();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.BackColor = System.Drawing.Color.DodgerBlue;
            splitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            splitContainer.IsSplitterFixed = true;
            splitContainer.Location = new System.Drawing.Point(0, 73);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            splitContainer.Panel1.Controls.Add(this.numUpDown_Quantity);
            splitContainer.Panel1.Controls.Add(this.label_Name);
            splitContainer.Panel1.Controls.Add(this.panel_Name);
            splitContainer.Panel1.Controls.Add(this.label_Amount);
            splitContainer.Panel1.Controls.Add(this.panel_ID);
            splitContainer.Panel1.Controls.Add(this.label_ID);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            splitContainer.Panel2.Controls.Add(this.btn_Delete);
            splitContainer.Panel2.Controls.Add(this.btn_Add);
            splitContainer.Panel2.Controls.Add(this.btn_Update);
            splitContainer.Panel2.Controls.Add(this.dateTimePicker_ExpirationDate);
            splitContainer.Panel2.Controls.Add(this.dateTimePicker_ProductionDate);
            splitContainer.Panel2.Controls.Add(this.label_ProductionDay);
            splitContainer.Panel2.Controls.Add(this.label_ExpirationDate);
            splitContainer.Size = new System.Drawing.Size(1280, 193);
            splitContainer.SplitterDistance = 632;
            splitContainer.SplitterWidth = 10;
            splitContainer.TabIndex = 103;
            // 
            // numUpDown_Quantity
            // 
            this.numUpDown_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_Quantity.Location = new System.Drawing.Point(132, 126);
            this.numUpDown_Quantity.Name = "numUpDown_Quantity";
            this.numUpDown_Quantity.Size = new System.Drawing.Size(113, 31);
            this.numUpDown_Quantity.TabIndex = 113;
            // 
            // label_Name
            // 
            this.label_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Name.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Name.Appearance.Options.UseFont = true;
            this.label_Name.Location = new System.Drawing.Point(21, 75);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(90, 23);
            this.label_Name.TabIndex = 104;
            this.label_Name.Text = "Tên Thuốc";
            // 
            // panel_Name
            // 
            this.panel_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Name.BackColor = System.Drawing.Color.White;
            this.panel_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Name.Controls.Add(this.txt_Name);
            this.panel_Name.Location = new System.Drawing.Point(132, 67);
            this.panel_Name.Name = "panel_Name";
            this.panel_Name.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_Name.Size = new System.Drawing.Size(389, 37);
            this.panel_Name.TabIndex = 111;
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
            this.txt_Name.Size = new System.Drawing.Size(378, 28);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.Enter += new System.EventHandler(this.txt_Enter);
            this.txt_Name.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label_Amount
            // 
            this.label_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Amount.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Amount.Appearance.Options.UseFont = true;
            this.label_Amount.Location = new System.Drawing.Point(21, 126);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(80, 23);
            this.label_Amount.TabIndex = 105;
            this.label_Amount.Text = "Số Lượng";
            // 
            // panel_ID
            // 
            this.panel_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ID.BackColor = System.Drawing.Color.White;
            this.panel_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ID.Controls.Add(this.txt_Id);
            this.panel_ID.Location = new System.Drawing.Point(132, 15);
            this.panel_ID.Name = "panel_ID";
            this.panel_ID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_ID.Size = new System.Drawing.Size(389, 37);
            this.panel_ID.TabIndex = 110;
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
            this.txt_Id.Size = new System.Drawing.Size(378, 28);
            this.txt_Id.TabIndex = 0;
            this.txt_Id.Enter += new System.EventHandler(this.txt_Enter);
            this.txt_Id.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label_ID
            // 
            this.label_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ID.Appearance.Options.UseFont = true;
            this.label_ID.Location = new System.Drawing.Point(21, 23);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(48, 22);
            this.label_ID.TabIndex = 107;
            this.label_ID.Text = "Mã Lô";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btn_Delete.Location = new System.Drawing.Point(474, 126);
            this.btn_Delete.MaximumSize = new System.Drawing.Size(141, 40);
            this.btn_Delete.MinimumSize = new System.Drawing.Size(141, 40);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(141, 40);
            this.btn_Delete.TabIndex = 112;
            this.btn_Delete.Text = "  Xóa";
            this.btn_Delete.ToolTip = "Xóa thuốc hoàn toàn khỏi cơ sở dữ liệu";
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btn_Add.Location = new System.Drawing.Point(35, 126);
            this.btn_Add.MaximumSize = new System.Drawing.Size(141, 40);
            this.btn_Add.MinimumSize = new System.Drawing.Size(141, 40);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(141, 40);
            this.btn_Add.TabIndex = 110;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.ToolTip = "Thêm thuốc vào cơ sở dữ liệu";
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btn_Update.Location = new System.Drawing.Point(253, 126);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Update.MaximumSize = new System.Drawing.Size(141, 40);
            this.btn_Update.MinimumSize = new System.Drawing.Size(141, 40);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(141, 40);
            this.btn_Update.TabIndex = 111;
            this.btn_Update.Text = " Sửa";
            this.btn_Update.ToolTip = "Cập nhật thông tin của thuốc trong cơ sở dữ liệu";
            // 
            // dateTimePicker_ExpirationDate
            // 
            this.dateTimePicker_ExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_ExpirationDate.CalendarFont = new System.Drawing.Font("Arial", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_ExpirationDate.CustomFormat = " dd/MM/yyyy";
            this.dateTimePicker_ExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_ExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ExpirationDate.Location = new System.Drawing.Point(177, 72);
            this.dateTimePicker_ExpirationDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_ExpirationDate.Name = "dateTimePicker_ExpirationDate";
            this.dateTimePicker_ExpirationDate.Size = new System.Drawing.Size(355, 31);
            this.dateTimePicker_ExpirationDate.TabIndex = 109;
            // 
            // dateTimePicker_ProductionDate
            // 
            this.dateTimePicker_ProductionDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_ProductionDate.CustomFormat = " dd/MM/yyyy";
            this.dateTimePicker_ProductionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_ProductionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ProductionDate.Location = new System.Drawing.Point(177, 20);
            this.dateTimePicker_ProductionDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_ProductionDate.Name = "dateTimePicker_ProductionDate";
            this.dateTimePicker_ProductionDate.Size = new System.Drawing.Size(355, 31);
            this.dateTimePicker_ProductionDate.TabIndex = 108;
            // 
            // label_ProductionDay
            // 
            this.label_ProductionDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ProductionDay.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ProductionDay.Appearance.Options.UseFont = true;
            this.label_ProductionDay.Location = new System.Drawing.Point(35, 22);
            this.label_ProductionDay.Name = "label_ProductionDay";
            this.label_ProductionDay.Size = new System.Drawing.Size(125, 23);
            this.label_ProductionDay.TabIndex = 102;
            this.label_ProductionDay.Text = "Ngày Sản Xuất";
            // 
            // label_ExpirationDate
            // 
            this.label_ExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ExpirationDate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ExpirationDate.Appearance.Options.UseFont = true;
            this.label_ExpirationDate.Location = new System.Drawing.Point(35, 75);
            this.label_ExpirationDate.Name = "label_ExpirationDate";
            this.label_ExpirationDate.Size = new System.Drawing.Size(118, 23);
            this.label_ExpirationDate.TabIndex = 103;
            this.label_ExpirationDate.Text = "Ngày Hết Hạn";
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Controls.Add(this.panel_Functions);
            this.panel_Buttons.Controls.Add(this.groupControl_dgv);
            this.panel_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Buttons.Location = new System.Drawing.Point(0, 266);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(1280, 454);
            this.panel_Buttons.TabIndex = 102;
            // 
            // panel_Functions
            // 
            this.panel_Functions.Controls.Add(this.simpleButton2);
            this.panel_Functions.Controls.Add(this.textBox1);
            this.panel_Functions.Controls.Add(this.label_SearchBar);
            this.panel_Functions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Functions.Location = new System.Drawing.Point(0, 0);
            this.panel_Functions.Name = "panel_Functions";
            this.panel_Functions.Size = new System.Drawing.Size(1280, 56);
            this.panel_Functions.TabIndex = 115;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Silver;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.simpleButton2.Location = new System.Drawing.Point(15, 11);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(224, 34);
            this.simpleButton2.TabIndex = 114;
            this.simpleButton2.Text = "Điều chỉnh kho";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(1027, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 24);
            this.textBox1.TabIndex = 2;
            // 
            // label_SearchBar
            // 
            this.label_SearchBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_SearchBar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F);
            this.label_SearchBar.Appearance.Options.UseFont = true;
            this.label_SearchBar.Location = new System.Drawing.Point(910, 17);
            this.label_SearchBar.Name = "label_SearchBar";
            this.label_SearchBar.Size = new System.Drawing.Size(111, 23);
            this.label_SearchBar.TabIndex = 1;
            this.label_SearchBar.Text = "Tìm lô thuốc:";
            // 
            // groupControl_dgv
            // 
            this.groupControl_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl_dgv.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl_dgv.AppearanceCaption.Options.UseFont = true;
            this.groupControl_dgv.Controls.Add(this.dgv_Batches);
            this.groupControl_dgv.Location = new System.Drawing.Point(15, 62);
            this.groupControl_dgv.Name = "groupControl_dgv";
            this.groupControl_dgv.Size = new System.Drawing.Size(1245, 380);
            this.groupControl_dgv.TabIndex = 1;
            this.groupControl_dgv.Text = "[ LÔ THUỐC ]";
            // 
            // dgv_Batches
            // 
            this.dgv_Batches.AllowUserToAddRows = false;
            this.dgv_Batches.AllowUserToDeleteRows = false;
            this.dgv_Batches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Batches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Batches.ColumnHeadersHeight = 50;
            this.dgv_Batches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_BatchId,
            this.col_MedicineName,
            this.col_ProviderName,
            this.col_ProductionDate,
            this.col_ExpirationDate,
            this.col_BatchQuantity});
            this.dgv_Batches.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.dgv_Batches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Batches.Location = new System.Drawing.Point(2, 26);
            this.dgv_Batches.Name = "dgv_Batches";
            this.dgv_Batches.ReadOnly = true;
            this.dgv_Batches.RowHeadersWidth = 47;
            this.dgv_Batches.Size = new System.Drawing.Size(1241, 352);
            this.dgv_Batches.TabIndex = 0;
            // 
            // col_BatchId
            // 
            this.col_BatchId.HeaderText = "Mã Lô Thuốc";
            this.col_BatchId.MinimumWidth = 6;
            this.col_BatchId.Name = "col_BatchId";
            this.col_BatchId.ReadOnly = true;
            // 
            // col_MedicineName
            // 
            this.col_MedicineName.HeaderText = "Tên Thuốc";
            this.col_MedicineName.MinimumWidth = 6;
            this.col_MedicineName.Name = "col_MedicineName";
            this.col_MedicineName.ReadOnly = true;
            // 
            // col_ProviderName
            // 
            this.col_ProviderName.HeaderText = "Nhà cung cấp";
            this.col_ProviderName.MinimumWidth = 6;
            this.col_ProviderName.Name = "col_ProviderName";
            this.col_ProviderName.ReadOnly = true;
            // 
            // col_ProductionDate
            // 
            this.col_ProductionDate.HeaderText = "Ngày sản xuất";
            this.col_ProductionDate.MinimumWidth = 6;
            this.col_ProductionDate.Name = "col_ProductionDate";
            this.col_ProductionDate.ReadOnly = true;
            // 
            // col_ExpirationDate
            // 
            this.col_ExpirationDate.HeaderText = "Hạn sử dụng";
            this.col_ExpirationDate.MinimumWidth = 6;
            this.col_ExpirationDate.Name = "col_ExpirationDate";
            this.col_ExpirationDate.ReadOnly = true;
            // 
            // col_BatchQuantity
            // 
            this.col_BatchQuantity.HeaderText = "Số lượng";
            this.col_BatchQuantity.MinimumWidth = 6;
            this.col_BatchQuantity.Name = "col_BatchQuantity";
            this.col_BatchQuantity.ReadOnly = true;
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.label_TitleAdd);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1280, 73);
            this.panel_Title.TabIndex = 7;
            // 
            // label_TitleAdd
            // 
            this.label_TitleAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_TitleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TitleAdd.Location = new System.Drawing.Point(0, 0);
            this.label_TitleAdd.Name = "label_TitleAdd";
            this.label_TitleAdd.Size = new System.Drawing.Size(1280, 73);
            this.label_TitleAdd.TabIndex = 0;
            this.label_TitleAdd.Text = " Quản Lý Lô Thuốc";
            this.label_TitleAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_EditMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel_Buttons);
            this.Controls.Add(splitContainer);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EditMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer)).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Quantity)).EndInit();
            this.panel_Name.ResumeLayout(false);
            this.panel_Name.PerformLayout();
            this.panel_ID.ResumeLayout(false);
            this.panel_ID.PerformLayout();
            this.panel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_Functions)).EndInit();
            this.panel_Functions.ResumeLayout(false);
            this.panel_Functions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_dgv)).EndInit();
            this.groupControl_dgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Batches)).EndInit();
            this.panel_Title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Buttons;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ExpirationDate;
        private System.Windows.Forms.NumericUpDown numUpDown_Quantity;
        private DevExpress.XtraEditors.LabelControl label_ProductionDay;
        private DevExpress.XtraEditors.LabelControl label_ExpirationDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ProductionDate;
        private DevExpress.XtraEditors.LabelControl label_Name;
        private System.Windows.Forms.Panel panel_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private DevExpress.XtraEditors.LabelControl label_Amount;
        private System.Windows.Forms.Panel panel_ID;
        private System.Windows.Forms.TextBox txt_Id;
        private DevExpress.XtraEditors.LabelControl label_ID;
        private System.Windows.Forms.Panel panel_Title;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl;
        private System.Windows.Forms.DataGridView dgv_Batches;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProviderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProductionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BatchQuantity;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl label_SearchBar;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.GroupControl groupControl_dgv;
        private System.Windows.Forms.Label label_TitleAdd;
        private DevExpress.XtraEditors.PanelControl panel_Functions;
    }
}