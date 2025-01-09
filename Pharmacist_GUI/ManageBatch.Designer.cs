namespace Pharmacist
{
    partial class frm_ManageBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ManageBatch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_SearchForMedicine = new DevExpress.XtraEditors.SimpleButton();
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
            this.txt_SearchBar = new System.Windows.Forms.TextBox();
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
            this.popupContainer_ListMedicineNames = new DevExpress.XtraEditors.PopupContainerControl();
            this.listBox_MedicineNames = new DevExpress.XtraEditors.ListBoxControl();
            this.poppanel_SearchMed = new DevExpress.XtraEditors.PanelControl();
            this.poppanel_Buttons = new DevExpress.XtraEditors.PanelControl();
            this.btn_ConfirmSelection = new DevExpress.XtraEditors.SimpleButton();
            this.txt_SearchMedicine = new System.Windows.Forms.TextBox();
            this.label_SearchName = new DevExpress.XtraEditors.LabelControl();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.popupContainer_ListMedicineNames)).BeginInit();
            this.popupContainer_ListMedicineNames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_MedicineNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppanel_SearchMed)).BeginInit();
            this.poppanel_SearchMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poppanel_Buttons)).BeginInit();
            this.poppanel_Buttons.SuspendLayout();
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
            splitContainer.Panel1.Controls.Add(this.btn_SearchForMedicine);
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
            splitContainer.Size = new System.Drawing.Size(1280, 177);
            splitContainer.SplitterDistance = 632;
            splitContainer.SplitterWidth = 10;
            splitContainer.TabIndex = 103;
            // 
            // btn_SearchForMedicine
            // 
            this.btn_SearchForMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SearchForMedicine.AutoSize = true;
            this.btn_SearchForMedicine.AutoWidthInLayoutControl = true;
            this.btn_SearchForMedicine.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_SearchForMedicine.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_SearchForMedicine.ImageOptions.SvgImage")));
            this.btn_SearchForMedicine.Location = new System.Drawing.Point(544, 67);
            this.btn_SearchForMedicine.MaximumSize = new System.Drawing.Size(40, 40);
            this.btn_SearchForMedicine.MinimumSize = new System.Drawing.Size(40, 40);
            this.btn_SearchForMedicine.Name = "btn_SearchForMedicine";
            this.btn_SearchForMedicine.Size = new System.Drawing.Size(40, 40);
            this.btn_SearchForMedicine.TabIndex = 114;
            this.btn_SearchForMedicine.Click += new System.EventHandler(this.btn_SearchForMedicine_Click);
            // 
            // numUpDown_Quantity
            // 
            this.numUpDown_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_Quantity.Location = new System.Drawing.Point(132, 126);
            this.numUpDown_Quantity.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
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
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.btn_Add.Click += new System.EventHandler(this.btn_InsertUpdate_Click);
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
            this.btn_Update.Click += new System.EventHandler(this.btn_InsertUpdate_Click);
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
            this.dateTimePicker_ExpirationDate.Size = new System.Drawing.Size(319, 31);
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
            this.dateTimePicker_ProductionDate.Size = new System.Drawing.Size(319, 31);
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
            this.panel_Buttons.Location = new System.Drawing.Point(0, 250);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(1280, 470);
            this.panel_Buttons.TabIndex = 102;
            // 
            // panel_Functions
            // 
            this.panel_Functions.Controls.Add(this.txt_SearchBar);
            this.panel_Functions.Controls.Add(this.label_SearchBar);
            this.panel_Functions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Functions.Location = new System.Drawing.Point(0, 0);
            this.panel_Functions.Name = "panel_Functions";
            this.panel_Functions.Size = new System.Drawing.Size(1280, 41);
            this.panel_Functions.TabIndex = 115;
            // 
            // txt_SearchBar
            // 
            this.txt_SearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SearchBar.Location = new System.Drawing.Point(1035, 6);
            this.txt_SearchBar.Name = "txt_SearchBar";
            this.txt_SearchBar.Size = new System.Drawing.Size(233, 24);
            this.txt_SearchBar.TabIndex = 2;
            this.txt_SearchBar.TextChanged += new System.EventHandler(this.txt_SearchBar_TextChanged);
            // 
            // label_SearchBar
            // 
            this.label_SearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SearchBar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F);
            this.label_SearchBar.Appearance.Options.UseFont = true;
            this.label_SearchBar.Location = new System.Drawing.Point(918, 7);
            this.label_SearchBar.Name = "label_SearchBar";
            this.label_SearchBar.Size = new System.Drawing.Size(121, 23);
            this.label_SearchBar.TabIndex = 1;
            this.label_SearchBar.Text = "Tìm Lô Thuốc:";
            // 
            // groupControl_dgv
            // 
            this.groupControl_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl_dgv.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl_dgv.AppearanceCaption.Options.UseFont = true;
            this.groupControl_dgv.Controls.Add(this.dgv_Batches);
            this.groupControl_dgv.Location = new System.Drawing.Point(15, 47);
            this.groupControl_dgv.Name = "groupControl_dgv";
            this.groupControl_dgv.Size = new System.Drawing.Size(1245, 411);
            this.groupControl_dgv.TabIndex = 1;
            this.groupControl_dgv.Text = "[ LÔ THUỐC ]";
            // 
            // dgv_Batches
            // 
            this.dgv_Batches.AllowUserToAddRows = false;
            this.dgv_Batches.AllowUserToDeleteRows = false;
            this.dgv_Batches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Batches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Batches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Batches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Batches.ColumnHeadersHeight = 50;
            this.dgv_Batches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Batches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_BatchId,
            this.col_MedicineName,
            this.col_ProviderName,
            this.col_ProductionDate,
            this.col_ExpirationDate,
            this.col_BatchQuantity});
            this.dgv_Batches.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_Batches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Batches.Location = new System.Drawing.Point(2, 26);
            this.dgv_Batches.Name = "dgv_Batches";
            this.dgv_Batches.ReadOnly = true;
            this.dgv_Batches.RowHeadersVisible = false;
            this.dgv_Batches.RowHeadersWidth = 47;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Batches.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Batches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Batches.Size = new System.Drawing.Size(1241, 383);
            this.dgv_Batches.TabIndex = 0;
            this.dgv_Batches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Batches_CellClick);
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
            // popupContainer_ListMedicineNames
            // 
            this.popupContainer_ListMedicineNames.Controls.Add(this.listBox_MedicineNames);
            this.popupContainer_ListMedicineNames.Controls.Add(this.poppanel_SearchMed);
            this.popupContainer_ListMedicineNames.Controls.Add(this.poppanel_Buttons);
            this.popupContainer_ListMedicineNames.Location = new System.Drawing.Point(256, 190);
            this.popupContainer_ListMedicineNames.MaximumSize = new System.Drawing.Size(328, 312);
            this.popupContainer_ListMedicineNames.MinimumSize = new System.Drawing.Size(328, 312);
            this.popupContainer_ListMedicineNames.Name = "popupContainer_ListMedicineNames";
            this.popupContainer_ListMedicineNames.Size = new System.Drawing.Size(328, 312);
            this.popupContainer_ListMedicineNames.TabIndex = 115;
            // 
            // listBox_MedicineNames
            // 
            this.listBox_MedicineNames.Appearance.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBox_MedicineNames.Appearance.Options.UseFont = true;
            this.listBox_MedicineNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_MedicineNames.Location = new System.Drawing.Point(0, 44);
            this.listBox_MedicineNames.Name = "listBox_MedicineNames";
            this.listBox_MedicineNames.Size = new System.Drawing.Size(328, 225);
            this.listBox_MedicineNames.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.listBox_MedicineNames.TabIndex = 0;
            // 
            // poppanel_SearchMed
            // 
            this.poppanel_SearchMed.Controls.Add(this.label_SearchName);
            this.poppanel_SearchMed.Controls.Add(this.txt_SearchMedicine);
            this.poppanel_SearchMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.poppanel_SearchMed.Location = new System.Drawing.Point(0, 0);
            this.poppanel_SearchMed.Name = "poppanel_SearchMed";
            this.poppanel_SearchMed.Size = new System.Drawing.Size(328, 44);
            this.poppanel_SearchMed.TabIndex = 1;
            // 
            // poppanel_Buttons
            // 
            this.poppanel_Buttons.Controls.Add(this.btn_Cancel);
            this.poppanel_Buttons.Controls.Add(this.btn_ConfirmSelection);
            this.poppanel_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.poppanel_Buttons.Location = new System.Drawing.Point(0, 269);
            this.poppanel_Buttons.Name = "poppanel_Buttons";
            this.poppanel_Buttons.Size = new System.Drawing.Size(328, 43);
            this.poppanel_Buttons.TabIndex = 2;
            // 
            // btn_ConfirmSelection
            // 
            this.btn_ConfirmSelection.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btn_ConfirmSelection.Appearance.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ConfirmSelection.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmSelection.Appearance.Options.UseBackColor = true;
            this.btn_ConfirmSelection.Appearance.Options.UseFont = true;
            this.btn_ConfirmSelection.Appearance.Options.UseForeColor = true;
            this.btn_ConfirmSelection.Appearance.Options.UseTextOptions = true;
            this.btn_ConfirmSelection.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_ConfirmSelection.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_ConfirmSelection.Location = new System.Drawing.Point(137, 6);
            this.btn_ConfirmSelection.Name = "btn_ConfirmSelection";
            this.btn_ConfirmSelection.Size = new System.Drawing.Size(86, 26);
            this.btn_ConfirmSelection.TabIndex = 0;
            this.btn_ConfirmSelection.Text = "Xác nhận";
            this.btn_ConfirmSelection.Click += new System.EventHandler(this.btn_ConfirmSelection_Click);
            // 
            // txt_SearchMedicine
            // 
            this.txt_SearchMedicine.Font = new System.Drawing.Font("Tahoma", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SearchMedicine.Location = new System.Drawing.Point(151, 8);
            this.txt_SearchMedicine.Name = "txt_SearchMedicine";
            this.txt_SearchMedicine.Size = new System.Drawing.Size(164, 24);
            this.txt_SearchMedicine.TabIndex = 0;
            this.txt_SearchMedicine.TextChanged += new System.EventHandler(this.txt_SearchMedicine_TextChanged);
            // 
            // label_SearchName
            // 
            this.label_SearchName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_SearchName.Appearance.Options.UseFont = true;
            this.label_SearchName.Location = new System.Drawing.Point(91, 12);
            this.label_SearchName.Name = "label_SearchName";
            this.label_SearchName.Size = new System.Drawing.Size(54, 17);
            this.label_SearchName.TabIndex = 1;
            this.label_SearchName.Text = "Tìm Tên:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Cancel.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Cancel.Appearance.Options.UseBackColor = true;
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Location = new System.Drawing.Point(229, 6);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(86, 26);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_ManageBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.popupContainer_ListMedicineNames);
            this.Controls.Add(this.panel_Buttons);
            this.Controls.Add(splitContainer);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ManageBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_ManageBatch_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.popupContainer_ListMedicineNames)).EndInit();
            this.popupContainer_ListMedicineNames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBox_MedicineNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppanel_SearchMed)).EndInit();
            this.poppanel_SearchMed.ResumeLayout(false);
            this.poppanel_SearchMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poppanel_Buttons)).EndInit();
            this.poppanel_Buttons.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProviderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProductionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BatchQuantity;
        private System.Windows.Forms.TextBox txt_SearchBar;
        private DevExpress.XtraEditors.LabelControl label_SearchBar;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.GroupControl groupControl_dgv;
        private System.Windows.Forms.Label label_TitleAdd;
        private DevExpress.XtraEditors.PanelControl panel_Functions;
        private DevExpress.XtraEditors.SimpleButton btn_SearchForMedicine;
        private DevExpress.XtraEditors.PopupContainerControl popupContainer_ListMedicineNames;
        private DevExpress.XtraEditors.ListBoxControl listBox_MedicineNames;
        private DevExpress.XtraEditors.PanelControl poppanel_Buttons;
        private DevExpress.XtraEditors.PanelControl poppanel_SearchMed;
        private DevExpress.XtraEditors.SimpleButton btn_ConfirmSelection;
        private DevExpress.XtraEditors.LabelControl label_SearchName;
        private System.Windows.Forms.TextBox txt_SearchMedicine;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
    }
}