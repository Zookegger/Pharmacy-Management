namespace PharmacistUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditMedicine));
            this.labelControl_ProductionDay = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_ExpirationDate = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePicker_ProductionDate = new System.Windows.Forms.DateTimePicker();
            this.txt_PricePerUnit = new System.Windows.Forms.TextBox();
            this.dateTimePicker_ExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.panel_PricePerUnit = new System.Windows.Forms.Panel();
            this.label_ID = new DevExpress.XtraEditors.LabelControl();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label_Amount = new DevExpress.XtraEditors.LabelControl();
            this.panel_ID = new System.Windows.Forms.Panel();
            this.label_PricePerUnit = new DevExpress.XtraEditors.LabelControl();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new DevExpress.XtraEditors.LabelControl();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.panel_Amount = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panel_Name = new System.Windows.Forms.Panel();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Reload = new DevExpress.XtraEditors.SimpleButton();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.groupBox_Input = new System.Windows.Forms.GroupBox();
            this.label_TitleAdd = new System.Windows.Forms.Label();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.panel_PricePerUnit.SuspendLayout();
            this.panel_ID.SuspendLayout();
            this.panel_Amount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel_Name.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            this.groupBox_Input.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl_ProductionDay
            // 
            this.labelControl_ProductionDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl_ProductionDay.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl_ProductionDay.Appearance.Options.UseFont = true;
            this.labelControl_ProductionDay.Location = new System.Drawing.Point(82, 127);
            this.labelControl_ProductionDay.Name = "labelControl_ProductionDay";
            this.labelControl_ProductionDay.Size = new System.Drawing.Size(138, 25);
            this.labelControl_ProductionDay.TabIndex = 0;
            this.labelControl_ProductionDay.Text = "Ngày Sản Xuất";
            // 
            // labelControl_ExpirationDate
            // 
            this.labelControl_ExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl_ExpirationDate.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl_ExpirationDate.Appearance.Options.UseFont = true;
            this.labelControl_ExpirationDate.Location = new System.Drawing.Point(82, 217);
            this.labelControl_ExpirationDate.Name = "labelControl_ExpirationDate";
            this.labelControl_ExpirationDate.Size = new System.Drawing.Size(130, 25);
            this.labelControl_ExpirationDate.TabIndex = 0;
            this.labelControl_ExpirationDate.Text = "Ngày Hết Hạn";
            // 
            // dateTimePicker_ProductionDate
            // 
            this.dateTimePicker_ProductionDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_ProductionDate.CustomFormat = " dd/M/yyyy";
            this.dateTimePicker_ProductionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_ProductionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ProductionDate.Location = new System.Drawing.Point(77, 159);
            this.dateTimePicker_ProductionDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_ProductionDate.Name = "dateTimePicker_ProductionDate";
            this.dateTimePicker_ProductionDate.Size = new System.Drawing.Size(299, 35);
            this.dateTimePicker_ProductionDate.TabIndex = 3;
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
            this.txt_PricePerUnit.Size = new System.Drawing.Size(293, 28);
            this.txt_PricePerUnit.TabIndex = 5;
            // 
            // dateTimePicker_ExpirationDate
            // 
            this.dateTimePicker_ExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_ExpirationDate.CalendarFont = new System.Drawing.Font("Arial", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_ExpirationDate.CustomFormat = " dd/M/yyyy";
            this.dateTimePicker_ExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_ExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ExpirationDate.Location = new System.Drawing.Point(77, 246);
            this.dateTimePicker_ExpirationDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_ExpirationDate.Name = "dateTimePicker_ExpirationDate";
            this.dateTimePicker_ExpirationDate.Size = new System.Drawing.Size(299, 35);
            this.dateTimePicker_ExpirationDate.TabIndex = 4;
            // 
            // panel_PricePerUnit
            // 
            this.panel_PricePerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_PricePerUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_PricePerUnit.Controls.Add(this.txt_PricePerUnit);
            this.panel_PricePerUnit.Location = new System.Drawing.Point(77, 70);
            this.panel_PricePerUnit.Name = "panel_PricePerUnit";
            this.panel_PricePerUnit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_PricePerUnit.Size = new System.Drawing.Size(302, 36);
            this.panel_PricePerUnit.TabIndex = 100;
            // 
            // label_ID
            // 
            this.label_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ID.Appearance.Options.UseFont = true;
            this.label_ID.Location = new System.Drawing.Point(57, 40);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(86, 25);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID Thuốc";
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
            this.txt_Id.Size = new System.Drawing.Size(286, 28);
            this.txt_Id.TabIndex = 0;
            // 
            // label_Amount
            // 
            this.label_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Amount.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Amount.Appearance.Options.UseFont = true;
            this.label_Amount.Location = new System.Drawing.Point(57, 216);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(89, 25);
            this.label_Amount.TabIndex = 0;
            this.label_Amount.Text = "Số Lượng";
            // 
            // panel_ID
            // 
            this.panel_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ID.Controls.Add(this.txt_Id);
            this.panel_ID.Location = new System.Drawing.Point(53, 66);
            this.panel_ID.Name = "panel_ID";
            this.panel_ID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_ID.Size = new System.Drawing.Size(295, 37);
            this.panel_ID.TabIndex = 8;
            // 
            // label_PricePerUnit
            // 
            this.label_PricePerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_PricePerUnit.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_PricePerUnit.Appearance.Options.UseFont = true;
            this.label_PricePerUnit.Location = new System.Drawing.Point(82, 41);
            this.label_PricePerUnit.Name = "label_PricePerUnit";
            this.label_PricePerUnit.Size = new System.Drawing.Size(136, 25);
            this.label_PricePerUnit.TabIndex = 0;
            this.label_PricePerUnit.Text = "Giá mỗi đơn vị";
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
            this.txt_Name.Size = new System.Drawing.Size(286, 28);
            this.txt_Name.TabIndex = 1;
            // 
            // label_Name
            // 
            this.label_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Name.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Name.Appearance.Options.UseFont = true;
            this.label_Name.Location = new System.Drawing.Point(57, 126);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(99, 25);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Tên Thuốc";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Amount.Location = new System.Drawing.Point(5, 7);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(287, 28);
            this.txt_Amount.TabIndex = 2;
            this.txt_Amount.Text = "0";
            // 
            // panel_Amount
            // 
            this.panel_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Amount.Controls.Add(this.txt_Amount);
            this.panel_Amount.Location = new System.Drawing.Point(53, 245);
            this.panel_Amount.Name = "panel_Amount";
            this.panel_Amount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_Amount.Size = new System.Drawing.Size(295, 37);
            this.panel_Amount.TabIndex = 10;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.DodgerBlue;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(3, 16);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel1.Controls.Add(this.btn_Search);
            this.splitContainer.Panel1.Controls.Add(this.panel_Amount);
            this.splitContainer.Panel1.Controls.Add(this.label_Name);
            this.splitContainer.Panel1.Controls.Add(this.panel_Name);
            this.splitContainer.Panel1.Controls.Add(this.label_Amount);
            this.splitContainer.Panel1.Controls.Add(this.panel_ID);
            this.splitContainer.Panel1.Controls.Add(this.label_ID);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel2.Controls.Add(this.dateTimePicker_ExpirationDate);
            this.splitContainer.Panel2.Controls.Add(this.panel_PricePerUnit);
            this.splitContainer.Panel2.Controls.Add(this.labelControl_ProductionDay);
            this.splitContainer.Panel2.Controls.Add(this.labelControl_ExpirationDate);
            this.splitContainer.Panel2.Controls.Add(this.label_PricePerUnit);
            this.splitContainer.Panel2.Controls.Add(this.dateTimePicker_ProductionDate);
            this.splitContainer.Size = new System.Drawing.Size(886, 405);
            this.splitContainer.SplitterDistance = 438;
            this.splitContainer.SplitterWidth = 10;
            this.splitContainer.TabIndex = 101;
            // 
            // panel_Name
            // 
            this.panel_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Name.Controls.Add(this.txt_Name);
            this.panel_Name.Location = new System.Drawing.Point(53, 155);
            this.panel_Name.Name = "panel_Name";
            this.panel_Name.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_Name.Size = new System.Drawing.Size(295, 37);
            this.panel_Name.TabIndex = 9;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Update.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold);
            this.btn_Update.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Appearance.Options.UseBackColor = true;
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Appearance.Options.UseForeColor = true;
            this.btn_Update.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.btn_Update.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Update.AppearanceDisabled.Options.UseBackColor = true;
            this.btn_Update.AppearanceDisabled.Options.UseFont = true;
            this.btn_Update.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_Update.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Update.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btn_Update.AppearanceHovered.Options.UseBackColor = true;
            this.btn_Update.AppearanceHovered.Options.UseFont = true;
            this.btn_Update.AppearanceHovered.Options.UseForeColor = true;
            this.btn_Update.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_Update.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold);
            this.btn_Update.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btn_Update.AppearancePressed.Options.UseBackColor = true;
            this.btn_Update.AppearancePressed.Options.UseFont = true;
            this.btn_Update.AppearancePressed.Options.UseForeColor = true;
            this.btn_Update.AutoWidthInLayoutControl = true;
            this.btn_Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.ImageOptions.Image")));
            this.btn_Update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Update.ImageOptions.ImageToTextIndent = 10;
            this.btn_Update.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.btn_Update.Location = new System.Drawing.Point(225, 39);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(177, 56);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Cập nhật";
            // 
            // btn_Reload
            // 
            this.btn_Reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Reload.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_Reload.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Reload.Appearance.Options.UseBackColor = true;
            this.btn_Reload.Appearance.Options.UseFont = true;
            this.btn_Reload.Appearance.Options.UseTextOptions = true;
            this.btn_Reload.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_Reload.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 14.74545F, System.Drawing.FontStyle.Bold);
            this.btn_Reload.AppearanceHovered.Options.UseFont = true;
            this.btn_Reload.AppearanceHovered.Options.UseTextOptions = true;
            this.btn_Reload.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_Reload.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_Reload.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Reload.AppearancePressed.Options.UseFont = true;
            this.btn_Reload.AppearancePressed.Options.UseTextOptions = true;
            this.btn_Reload.AppearancePressed.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.btn_Reload.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_Reload.AutoWidthInLayoutControl = true;
            this.btn_Reload.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Reload.ImageOptions.ImageToTextIndent = 10;
            this.btn_Reload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Reload.ImageOptions.SvgImage")));
            this.btn_Reload.Location = new System.Drawing.Point(479, 39);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(187, 56);
            this.btn_Reload.TabIndex = 7;
            this.btn_Reload.Text = "Tải lại";
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Controls.Add(this.btn_Update);
            this.panel_Buttons.Controls.Add(this.btn_Reload);
            this.panel_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Buttons.Location = new System.Drawing.Point(3, 421);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(886, 136);
            this.panel_Buttons.TabIndex = 102;
            // 
            // groupBox_Input
            // 
            this.groupBox_Input.Controls.Add(this.splitContainer);
            this.groupBox_Input.Controls.Add(this.panel_Buttons);
            this.groupBox_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Input.Location = new System.Drawing.Point(0, 55);
            this.groupBox_Input.Name = "groupBox_Input";
            this.groupBox_Input.Size = new System.Drawing.Size(892, 560);
            this.groupBox_Input.TabIndex = 6;
            this.groupBox_Input.TabStop = false;
            // 
            // label_TitleAdd
            // 
            this.label_TitleAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TitleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TitleAdd.Location = new System.Drawing.Point(0, 0);
            this.label_TitleAdd.Name = "label_TitleAdd";
            this.label_TitleAdd.Size = new System.Drawing.Size(892, 55);
            this.label_TitleAdd.TabIndex = 0;
            this.label_TitleAdd.Text = " Sửa Thuốc";
            this.label_TitleAdd.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.label_TitleAdd);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(892, 55);
            this.panel_Title.TabIndex = 7;
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_Search.Location = new System.Drawing.Point(149, 39);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(35, 26);
            this.btn_Search.TabIndex = 11;
            // 
            // frm_EditMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 615);
            this.Controls.Add(this.groupBox_Input);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EditMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_PricePerUnit.ResumeLayout(false);
            this.panel_PricePerUnit.PerformLayout();
            this.panel_ID.ResumeLayout(false);
            this.panel_ID.PerformLayout();
            this.panel_Amount.ResumeLayout(false);
            this.panel_Amount.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel_Name.ResumeLayout(false);
            this.panel_Name.PerformLayout();
            this.panel_Buttons.ResumeLayout(false);
            this.groupBox_Input.ResumeLayout(false);
            this.panel_Title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl_ProductionDay;
        private DevExpress.XtraEditors.LabelControl labelControl_ExpirationDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ProductionDate;
        private System.Windows.Forms.TextBox txt_PricePerUnit;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ExpirationDate;
        private System.Windows.Forms.Panel panel_PricePerUnit;
        private DevExpress.XtraEditors.LabelControl label_ID;
        private System.Windows.Forms.TextBox txt_Id;
        private DevExpress.XtraEditors.LabelControl label_Amount;
        private System.Windows.Forms.Panel panel_ID;
        private DevExpress.XtraEditors.LabelControl label_PricePerUnit;
        private System.Windows.Forms.TextBox txt_Name;
        private DevExpress.XtraEditors.LabelControl label_Name;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Panel panel_Amount;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panel_Name;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Reload;
        private System.Windows.Forms.Panel panel_Buttons;
        private System.Windows.Forms.GroupBox groupBox_Input;
        private System.Windows.Forms.Label label_TitleAdd;
        private System.Windows.Forms.Panel panel_Title;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
    }
}