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
            this.btn_SearchForMedicine = new DevExpress.XtraEditors.SimpleButton();
            this.numUpDown_BatchQuantity = new System.Windows.Forms.NumericUpDown();
            this.label_Name = new DevExpress.XtraEditors.LabelControl();
            this.panel_Name = new System.Windows.Forms.Panel();
            this.txt_BatchName = new System.Windows.Forms.TextBox();
            this.label_Amount = new DevExpress.XtraEditors.LabelControl();
            this.panel_ID = new System.Windows.Forms.Panel();
            this.txt_BatchId = new System.Windows.Forms.TextBox();
            this.label_ID = new DevExpress.XtraEditors.LabelControl();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Insert = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker_BatchExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_BatchProductionDate = new System.Windows.Forms.DateTimePicker();
            this.label_ProductionDay = new DevExpress.XtraEditors.LabelControl();
            this.label_ExpirationDate = new DevExpress.XtraEditors.LabelControl();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.groupControl_dgv = new DevExpress.XtraEditors.GroupControl();
            this.btn_RefreshGrid = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.BatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_Batches = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProviderName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayHetHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.label_TitleAdd = new System.Windows.Forms.Label();
            this.alertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.popupContainer_ListMedicineNames = new DevExpress.XtraEditors.PopupContainerControl();
            this.listBox_MedicineNames = new DevExpress.XtraEditors.ListBoxControl();
            this.poppanel_SearchMed = new DevExpress.XtraEditors.PanelControl();
            this.label_SearchName = new DevExpress.XtraEditors.LabelControl();
            this.txt_SearchMedicine = new System.Windows.Forms.TextBox();
            this.poppanel_Buttons = new DevExpress.XtraEditors.PanelControl();
            this.btn_CancelSelectionMedicine = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ConfirmSelectionMedicine = new DevExpress.XtraEditors.SimpleButton();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.popupContainer_SelectProvider = new DevExpress.XtraEditors.PopupContainerControl();
            this.listBox_SelectProvider = new DevExpress.XtraEditors.ListBoxControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_CancelProvider = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ConfỉrmProviderSelection = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl_PopupTitle = new DevExpress.XtraEditors.PanelControl();
            this.txt_SearchProvider = new System.Windows.Forms.TextBox();
            this.label_SearchProvider = new DevExpress.XtraEditors.LabelControl();
            splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(splitContainer)).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_BatchQuantity)).BeginInit();
            this.panel_Name.SuspendLayout();
            this.panel_ID.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_dgv)).BeginInit();
            this.groupControl_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Batches)).BeginInit();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainer_ListMedicineNames)).BeginInit();
            this.popupContainer_ListMedicineNames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_MedicineNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppanel_SearchMed)).BeginInit();
            this.poppanel_SearchMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poppanel_Buttons)).BeginInit();
            this.poppanel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainer_SelectProvider)).BeginInit();
            this.popupContainer_SelectProvider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_SelectProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_PopupTitle)).BeginInit();
            this.panelControl_PopupTitle.SuspendLayout();
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
            splitContainer.Panel1.Controls.Add(this.numUpDown_BatchQuantity);
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
            splitContainer.Panel2.Controls.Add(this.btn_Insert);
            splitContainer.Panel2.Controls.Add(this.btn_Update);
            splitContainer.Panel2.Controls.Add(this.dateTimePicker_BatchExpirationDate);
            splitContainer.Panel2.Controls.Add(this.dateTimePicker_BatchProductionDate);
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
            // numUpDown_BatchQuantity
            // 
            this.numUpDown_BatchQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_BatchQuantity.Location = new System.Drawing.Point(132, 126);
            this.numUpDown_BatchQuantity.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numUpDown_BatchQuantity.Name = "numUpDown_BatchQuantity";
            this.numUpDown_BatchQuantity.Size = new System.Drawing.Size(113, 31);
            this.numUpDown_BatchQuantity.TabIndex = 113;
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
            this.panel_Name.Controls.Add(this.txt_BatchName);
            this.panel_Name.Location = new System.Drawing.Point(132, 67);
            this.panel_Name.Name = "panel_Name";
            this.panel_Name.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_Name.Size = new System.Drawing.Size(389, 37);
            this.panel_Name.TabIndex = 111;
            this.panel_Name.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // txt_BatchName
            // 
            this.txt_BatchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BatchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_BatchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_BatchName.Location = new System.Drawing.Point(6, 4);
            this.txt_BatchName.Margin = new System.Windows.Forms.Padding(0);
            this.txt_BatchName.Name = "txt_BatchName";
            this.txt_BatchName.Size = new System.Drawing.Size(378, 28);
            this.txt_BatchName.TabIndex = 1;
            this.txt_BatchName.Enter += new System.EventHandler(this.txt_Enter);
            this.txt_BatchName.Leave += new System.EventHandler(this.txt_Leave);
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
            this.panel_ID.Controls.Add(this.txt_BatchId);
            this.panel_ID.Location = new System.Drawing.Point(132, 15);
            this.panel_ID.Name = "panel_ID";
            this.panel_ID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_ID.Size = new System.Drawing.Size(389, 37);
            this.panel_ID.TabIndex = 110;
            this.panel_ID.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // txt_BatchId
            // 
            this.txt_BatchId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BatchId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_BatchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_BatchId.Location = new System.Drawing.Point(6, 4);
            this.txt_BatchId.Margin = new System.Windows.Forms.Padding(0);
            this.txt_BatchId.Name = "txt_BatchId";
            this.txt_BatchId.Size = new System.Drawing.Size(378, 28);
            this.txt_BatchId.TabIndex = 0;
            this.txt_BatchId.Enter += new System.EventHandler(this.txt_Enter);
            this.txt_BatchId.Leave += new System.EventHandler(this.txt_Leave);
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
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Insert.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold);
            this.btn_Insert.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Insert.Appearance.Options.UseBackColor = true;
            this.btn_Insert.Appearance.Options.UseFont = true;
            this.btn_Insert.Appearance.Options.UseForeColor = true;
            this.btn_Insert.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.btn_Insert.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Insert.AppearanceDisabled.Options.UseBackColor = true;
            this.btn_Insert.AppearanceDisabled.Options.UseFont = true;
            this.btn_Insert.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_Insert.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold);
            this.btn_Insert.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btn_Insert.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Insert.AppearanceHovered.Options.UseFont = true;
            this.btn_Insert.AppearanceHovered.Options.UseForeColor = true;
            this.btn_Insert.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_Insert.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold);
            this.btn_Insert.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btn_Insert.AppearancePressed.Options.UseBackColor = true;
            this.btn_Insert.AppearancePressed.Options.UseFont = true;
            this.btn_Insert.AppearancePressed.Options.UseForeColor = true;
            this.btn_Insert.AutoWidthInLayoutControl = true;
            this.btn_Insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Insert.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Insert.ImageOptions.ImageToTextIndent = 10;
            this.btn_Insert.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Insert.ImageOptions.SvgImage")));
            this.btn_Insert.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.btn_Insert.Location = new System.Drawing.Point(35, 126);
            this.btn_Insert.MaximumSize = new System.Drawing.Size(141, 40);
            this.btn_Insert.MinimumSize = new System.Drawing.Size(141, 40);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(141, 40);
            this.btn_Insert.TabIndex = 110;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.ToolTip = "Thêm thuốc vào cơ sở dữ liệu";
            this.btn_Insert.Click += new System.EventHandler(this.btn_InsertUpdate_Click);
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
            // dateTimePicker_BatchExpirationDate
            // 
            this.dateTimePicker_BatchExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_BatchExpirationDate.CalendarFont = new System.Drawing.Font("Arial", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_BatchExpirationDate.CustomFormat = " dd/MM/yyyy";
            this.dateTimePicker_BatchExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_BatchExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_BatchExpirationDate.Location = new System.Drawing.Point(177, 72);
            this.dateTimePicker_BatchExpirationDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_BatchExpirationDate.Name = "dateTimePicker_BatchExpirationDate";
            this.dateTimePicker_BatchExpirationDate.Size = new System.Drawing.Size(295, 31);
            this.dateTimePicker_BatchExpirationDate.TabIndex = 109;
            // 
            // dateTimePicker_BatchProductionDate
            // 
            this.dateTimePicker_BatchProductionDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_BatchProductionDate.CustomFormat = " dd/MM/yyyy";
            this.dateTimePicker_BatchProductionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_BatchProductionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_BatchProductionDate.Location = new System.Drawing.Point(177, 20);
            this.dateTimePicker_BatchProductionDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_BatchProductionDate.Name = "dateTimePicker_BatchProductionDate";
            this.dateTimePicker_BatchProductionDate.Size = new System.Drawing.Size(295, 31);
            this.dateTimePicker_BatchProductionDate.TabIndex = 108;
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
            this.panel_Buttons.Controls.Add(this.groupControl_dgv);
            this.panel_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Buttons.Location = new System.Drawing.Point(0, 250);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(1280, 470);
            this.panel_Buttons.TabIndex = 102;
            // 
            // groupControl_dgv
            // 
            this.groupControl_dgv.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl_dgv.AppearanceCaption.Options.UseFont = true;
            this.groupControl_dgv.Controls.Add(this.btn_RefreshGrid);
            this.groupControl_dgv.Controls.Add(this.gridControl);
            this.groupControl_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_dgv.Location = new System.Drawing.Point(0, 0);
            this.groupControl_dgv.Name = "groupControl_dgv";
            this.groupControl_dgv.Size = new System.Drawing.Size(1280, 470);
            this.groupControl_dgv.TabIndex = 1;
            this.groupControl_dgv.Text = "[ LÔ THUỐC ]";
            // 
            // btn_RefreshGrid
            // 
            this.btn_RefreshGrid.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btn_RefreshGrid.Appearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_RefreshGrid.Appearance.ForeColor = System.Drawing.Color.Black;
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
            this.btn_RefreshGrid.Location = new System.Drawing.Point(0, 29);
            this.btn_RefreshGrid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_RefreshGrid.MaximumSize = new System.Drawing.Size(36, 36);
            this.btn_RefreshGrid.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_RefreshGrid.Name = "btn_RefreshGrid";
            this.btn_RefreshGrid.Size = new System.Drawing.Size(30, 30);
            this.btn_RefreshGrid.TabIndex = 107;
            this.btn_RefreshGrid.TabStop = false;
            this.btn_RefreshGrid.Click += new System.EventHandler(this.btn_RefreshGrid_Click);
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.BatchBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 26);
            this.gridControl.MainView = this.dgv_Batches;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1276, 442);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_Batches});
            // 
            // BatchBindingSource
            // 
            this.BatchBindingSource.DataSource = typeof(PharmacistManagement_DAL.Model.LOTHUOC);
            // 
            // dgv_Batches
            // 
            this.dgv_Batches.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Batches.Appearance.FocusedRow.Options.UseFont = true;
            this.dgv_Batches.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Batches.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgv_Batches.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgv_Batches.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgv_Batches.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgv_Batches.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgv_Batches.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dgv_Batches.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Batches.Appearance.Row.Options.UseFont = true;
            this.dgv_Batches.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLo,
            this.colProviderName,
            this.colMaThuoc,
            this.colNgaySanXuat,
            this.colNgayHetHan,
            this.colSoLuong});
            this.dgv_Batches.GridControl = this.gridControl;
            this.dgv_Batches.GroupPanelText = " ";
            this.dgv_Batches.Name = "dgv_Batches";
            this.dgv_Batches.OptionsBehavior.ReadOnly = true;
            this.dgv_Batches.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.dgv_Batches_RowCellClick);
            // 
            // colMaLo
            // 
            this.colMaLo.Caption = "Mã Lô";
            this.colMaLo.FieldName = "BatchId";
            this.colMaLo.MinWidth = 23;
            this.colMaLo.Name = "colMaLo";
            this.colMaLo.Visible = true;
            this.colMaLo.VisibleIndex = 0;
            this.colMaLo.Width = 86;
            // 
            // colProviderName
            // 
            this.colProviderName.Caption = "Nhà Cung Cấp";
            this.colProviderName.FieldName = "ProviderName";
            this.colProviderName.MinWidth = 23;
            this.colProviderName.Name = "colProviderName";
            this.colProviderName.Visible = true;
            this.colProviderName.VisibleIndex = 2;
            this.colProviderName.Width = 86;
            // 
            // colMaThuoc
            // 
            this.colMaThuoc.Caption = "Tên Thuốc";
            this.colMaThuoc.FieldName = "MedicineName";
            this.colMaThuoc.MinWidth = 23;
            this.colMaThuoc.Name = "colMaThuoc";
            this.colMaThuoc.Visible = true;
            this.colMaThuoc.VisibleIndex = 1;
            this.colMaThuoc.Width = 86;
            // 
            // colNgaySanXuat
            // 
            this.colNgaySanXuat.Caption = "Ngày Sản Xuất";
            this.colNgaySanXuat.FieldName = "ProdDate";
            this.colNgaySanXuat.MinWidth = 23;
            this.colNgaySanXuat.Name = "colNgaySanXuat";
            this.colNgaySanXuat.Visible = true;
            this.colNgaySanXuat.VisibleIndex = 3;
            this.colNgaySanXuat.Width = 86;
            // 
            // colNgayHetHan
            // 
            this.colNgayHetHan.Caption = "Ngày Hết Hạn";
            this.colNgayHetHan.FieldName = "ExpDate";
            this.colNgayHetHan.MinWidth = 23;
            this.colNgayHetHan.Name = "colNgayHetHan";
            this.colNgayHetHan.Visible = true;
            this.colNgayHetHan.VisibleIndex = 4;
            this.colNgayHetHan.Width = 86;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Sô Lượng";
            this.colSoLuong.FieldName = "Quantity";
            this.colSoLuong.MinWidth = 23;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 5;
            this.colSoLuong.Width = 86;
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
            this.listBox_MedicineNames.DoubleClick += new System.EventHandler(this.btn_ConfirmSelection_Click);
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
            // txt_SearchMedicine
            // 
            this.txt_SearchMedicine.Font = new System.Drawing.Font("Tahoma", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SearchMedicine.Location = new System.Drawing.Point(151, 8);
            this.txt_SearchMedicine.Name = "txt_SearchMedicine";
            this.txt_SearchMedicine.Size = new System.Drawing.Size(164, 24);
            this.txt_SearchMedicine.TabIndex = 0;
            this.txt_SearchMedicine.TextChanged += new System.EventHandler(this.txt_SearchMedicine_TextChanged);
            // 
            // poppanel_Buttons
            // 
            this.poppanel_Buttons.Controls.Add(this.btn_CancelSelectionMedicine);
            this.poppanel_Buttons.Controls.Add(this.btn_ConfirmSelectionMedicine);
            this.poppanel_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.poppanel_Buttons.Location = new System.Drawing.Point(0, 269);
            this.poppanel_Buttons.Name = "poppanel_Buttons";
            this.poppanel_Buttons.Size = new System.Drawing.Size(328, 43);
            this.poppanel_Buttons.TabIndex = 2;
            // 
            // btn_CancelSelectionMedicine
            // 
            this.btn_CancelSelectionMedicine.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btn_CancelSelectionMedicine.Appearance.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_CancelSelectionMedicine.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_CancelSelectionMedicine.Appearance.Options.UseBackColor = true;
            this.btn_CancelSelectionMedicine.Appearance.Options.UseFont = true;
            this.btn_CancelSelectionMedicine.Location = new System.Drawing.Point(229, 6);
            this.btn_CancelSelectionMedicine.Name = "btn_CancelSelectionMedicine";
            this.btn_CancelSelectionMedicine.Size = new System.Drawing.Size(86, 26);
            this.btn_CancelSelectionMedicine.TabIndex = 0;
            this.btn_CancelSelectionMedicine.Text = "Hủy";
            this.btn_CancelSelectionMedicine.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_ConfirmSelectionMedicine
            // 
            this.btn_ConfirmSelectionMedicine.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btn_ConfirmSelectionMedicine.Appearance.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ConfirmSelectionMedicine.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmSelectionMedicine.Appearance.Options.UseBackColor = true;
            this.btn_ConfirmSelectionMedicine.Appearance.Options.UseFont = true;
            this.btn_ConfirmSelectionMedicine.Appearance.Options.UseForeColor = true;
            this.btn_ConfirmSelectionMedicine.Appearance.Options.UseTextOptions = true;
            this.btn_ConfirmSelectionMedicine.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_ConfirmSelectionMedicine.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_ConfirmSelectionMedicine.Location = new System.Drawing.Point(137, 6);
            this.btn_ConfirmSelectionMedicine.Name = "btn_ConfirmSelectionMedicine";
            this.btn_ConfirmSelectionMedicine.Size = new System.Drawing.Size(86, 26);
            this.btn_ConfirmSelectionMedicine.TabIndex = 0;
            this.btn_ConfirmSelectionMedicine.Text = "Xác nhận";
            this.btn_ConfirmSelectionMedicine.Click += new System.EventHandler(this.btn_ConfirmSelection_Click);
            // 
            // popupContainer_SelectProvider
            // 
            this.popupContainer_SelectProvider.Controls.Add(this.listBox_SelectProvider);
            this.popupContainer_SelectProvider.Controls.Add(this.panelControl2);
            this.popupContainer_SelectProvider.Controls.Add(this.panelControl_PopupTitle);
            this.popupContainer_SelectProvider.Location = new System.Drawing.Point(444, 118);
            this.popupContainer_SelectProvider.Name = "popupContainer_SelectProvider";
            this.popupContainer_SelectProvider.Size = new System.Drawing.Size(393, 485);
            this.popupContainer_SelectProvider.TabIndex = 116;
            // 
            // listBox_SelectProvider
            // 
            this.listBox_SelectProvider.Appearance.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBox_SelectProvider.Appearance.Options.UseFont = true;
            this.listBox_SelectProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_SelectProvider.Location = new System.Drawing.Point(0, 56);
            this.listBox_SelectProvider.Name = "listBox_SelectProvider";
            this.listBox_SelectProvider.Size = new System.Drawing.Size(393, 375);
            this.listBox_SelectProvider.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_CancelProvider);
            this.panelControl2.Controls.Add(this.btn_ConfỉrmProviderSelection);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 431);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(393, 54);
            this.panelControl2.TabIndex = 2;
            // 
            // btn_CancelProvider
            // 
            this.btn_CancelProvider.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(188)))));
            this.btn_CancelProvider.Appearance.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_CancelProvider.Appearance.Options.UseBackColor = true;
            this.btn_CancelProvider.Appearance.Options.UseFont = true;
            this.btn_CancelProvider.Location = new System.Drawing.Point(293, 7);
            this.btn_CancelProvider.Name = "btn_CancelProvider";
            this.btn_CancelProvider.Size = new System.Drawing.Size(86, 37);
            this.btn_CancelProvider.TabIndex = 0;
            this.btn_CancelProvider.Text = "Hủy";
            // 
            // btn_ConfỉrmProviderSelection
            // 
            this.btn_ConfỉrmProviderSelection.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(188)))));
            this.btn_ConfỉrmProviderSelection.Appearance.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ConfỉrmProviderSelection.Appearance.Options.UseBackColor = true;
            this.btn_ConfỉrmProviderSelection.Appearance.Options.UseFont = true;
            this.btn_ConfỉrmProviderSelection.Location = new System.Drawing.Point(201, 7);
            this.btn_ConfỉrmProviderSelection.Name = "btn_ConfỉrmProviderSelection";
            this.btn_ConfỉrmProviderSelection.Size = new System.Drawing.Size(86, 37);
            this.btn_ConfỉrmProviderSelection.TabIndex = 0;
            this.btn_ConfỉrmProviderSelection.Text = "Xác nhận";
            // 
            // panelControl_PopupTitle
            // 
            this.panelControl_PopupTitle.Controls.Add(this.txt_SearchProvider);
            this.panelControl_PopupTitle.Controls.Add(this.label_SearchProvider);
            this.panelControl_PopupTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl_PopupTitle.Location = new System.Drawing.Point(0, 0);
            this.panelControl_PopupTitle.Name = "panelControl_PopupTitle";
            this.panelControl_PopupTitle.Size = new System.Drawing.Size(393, 56);
            this.panelControl_PopupTitle.TabIndex = 1;
            // 
            // txt_SearchProvider
            // 
            this.txt_SearchProvider.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SearchProvider.Location = new System.Drawing.Point(212, 15);
            this.txt_SearchProvider.Name = "txt_SearchProvider";
            this.txt_SearchProvider.Size = new System.Drawing.Size(176, 28);
            this.txt_SearchProvider.TabIndex = 1;
            this.txt_SearchProvider.TextChanged += new System.EventHandler(this.txt_SearchProvider_TextChanged);
            // 
            // label_SearchProvider
            // 
            this.label_SearchProvider.Appearance.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_SearchProvider.Appearance.Options.UseFont = true;
            this.label_SearchProvider.Location = new System.Drawing.Point(50, 17);
            this.label_SearchProvider.Name = "label_SearchProvider";
            this.label_SearchProvider.Size = new System.Drawing.Size(156, 21);
            this.label_SearchProvider.TabIndex = 0;
            this.label_SearchProvider.Text = "Tìm nhà cung cấp:";
            // 
            // frm_ManageBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.popupContainer_SelectProvider);
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
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_BatchQuantity)).EndInit();
            this.panel_Name.ResumeLayout(false);
            this.panel_Name.PerformLayout();
            this.panel_ID.ResumeLayout(false);
            this.panel_ID.PerformLayout();
            this.panel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_dgv)).EndInit();
            this.groupControl_dgv.ResumeLayout(false);
            this.groupControl_dgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatchBindingSource)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.popupContainer_SelectProvider)).EndInit();
            this.popupContainer_SelectProvider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBox_SelectProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_PopupTitle)).EndInit();
            this.panelControl_PopupTitle.ResumeLayout(false);
            this.panelControl_PopupTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Buttons;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BatchExpirationDate;
        private System.Windows.Forms.NumericUpDown numUpDown_BatchQuantity;
        private DevExpress.XtraEditors.LabelControl label_ProductionDay;
        private DevExpress.XtraEditors.LabelControl label_ExpirationDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BatchProductionDate;
        private DevExpress.XtraEditors.LabelControl label_Name;
        private System.Windows.Forms.Panel panel_Name;
        private System.Windows.Forms.TextBox txt_BatchName;
        private DevExpress.XtraEditors.LabelControl label_Amount;
        private System.Windows.Forms.Panel panel_ID;
        private System.Windows.Forms.TextBox txt_BatchId;
        private DevExpress.XtraEditors.LabelControl label_ID;
        private System.Windows.Forms.Panel panel_Title;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Insert;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.GroupControl groupControl_dgv;
        private System.Windows.Forms.Label label_TitleAdd;
        private DevExpress.XtraEditors.SimpleButton btn_SearchForMedicine;
        private DevExpress.XtraEditors.PopupContainerControl popupContainer_ListMedicineNames;
        private DevExpress.XtraEditors.ListBoxControl listBox_MedicineNames;
        private DevExpress.XtraEditors.PanelControl poppanel_Buttons;
        private DevExpress.XtraEditors.PanelControl poppanel_SearchMed;
        private DevExpress.XtraEditors.SimpleButton btn_ConfirmSelectionMedicine;
        private DevExpress.XtraEditors.LabelControl label_SearchName;
        private System.Windows.Forms.TextBox txt_SearchMedicine;
        private DevExpress.XtraEditors.SimpleButton btn_CancelSelectionMedicine;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraEditors.PopupContainerControl popupContainer_SelectProvider;
        private DevExpress.XtraEditors.ListBoxControl listBox_SelectProvider;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_CancelProvider;
        private DevExpress.XtraEditors.SimpleButton btn_ConfỉrmProviderSelection;
        private DevExpress.XtraEditors.PanelControl panelControl_PopupTitle;
        private System.Windows.Forms.TextBox txt_SearchProvider;
        private DevExpress.XtraEditors.LabelControl label_SearchProvider;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_Batches;
        private System.Windows.Forms.BindingSource BatchBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLo;
        private DevExpress.XtraGrid.Columns.GridColumn colMaThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayHetHan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraEditors.SimpleButton btn_RefreshGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colProviderName;
    }
}