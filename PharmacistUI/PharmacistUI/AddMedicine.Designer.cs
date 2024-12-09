namespace PharmacistUI
{
    partial class AddMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicine));
            this.panel_Title = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.groupBox_Input = new System.Windows.Forms.GroupBox();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panel_Amount = new System.Windows.Forms.Panel();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label_Name = new DevExpress.XtraEditors.LabelControl();
            this.panel_Name = new System.Windows.Forms.Panel();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label_Amount = new DevExpress.XtraEditors.LabelControl();
            this.panel_ID = new System.Windows.Forms.Panel();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label_ID = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePicker_ExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.panel_PricePerUnit = new System.Windows.Forms.Panel();
            this.txt_PricePerUnit = new System.Windows.Forms.TextBox();
            this.labelControl_ProductionDay = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_ExpirationDate = new DevExpress.XtraEditors.LabelControl();
            this.label_PricePerUnit = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePicker_ProductionDate = new System.Windows.Forms.DateTimePicker();
            this.panel_Title.SuspendLayout();
            this.groupBox_Input.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel_Amount.SuspendLayout();
            this.panel_Name.SuspendLayout();
            this.panel_ID.SuspendLayout();
            this.panel_PricePerUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.label_Title);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(887, 73);
            this.panel_Title.TabIndex = 5;
            // 
            // label_Title
            // 
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(887, 73);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = " Thêm Thuốc";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox_Input
            // 
            this.groupBox_Input.Controls.Add(this.panel_Buttons);
            this.groupBox_Input.Controls.Add(this.splitContainer);
            this.groupBox_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Input.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Input.Name = "groupBox_Input";
            this.groupBox_Input.Size = new System.Drawing.Size(887, 553);
            this.groupBox_Input.TabIndex = 4;
            this.groupBox_Input.TabStop = false;
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Controls.Add(this.btn_Add);
            this.panel_Buttons.Controls.Add(this.simpleButton2);
            this.panel_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Buttons.Location = new System.Drawing.Point(3, 412);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(881, 138);
            this.panel_Buttons.TabIndex = 102;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Add.ImageOptions.ImageToTextIndent = 10;
            this.btn_Add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Add.ImageOptions.SvgImage")));
            this.btn_Add.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.btn_Add.Location = new System.Drawing.Point(228, 40);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(177, 58);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.simpleButton2.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 14.74545F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.AppearanceHovered.Options.UseFont = true;
            this.simpleButton2.AppearanceHovered.Options.UseTextOptions = true;
            this.simpleButton2.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.simpleButton2.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton2.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton2.AppearancePressed.Options.UseFont = true;
            this.simpleButton2.AppearancePressed.Options.UseTextOptions = true;
            this.simpleButton2.AppearancePressed.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.simpleButton2.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.simpleButton2.AutoWidthInLayoutControl = true;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.ImageOptions.ImageToTextIndent = 10;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(482, 40);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(187, 58);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Tải lại";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(3, 16);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panel_Amount);
            this.splitContainer.Panel1.Controls.Add(this.label_Name);
            this.splitContainer.Panel1.Controls.Add(this.panel_Name);
            this.splitContainer.Panel1.Controls.Add(this.label_Amount);
            this.splitContainer.Panel1.Controls.Add(this.panel_ID);
            this.splitContainer.Panel1.Controls.Add(this.label_ID);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dateTimePicker_ExpirationDate);
            this.splitContainer.Panel2.Controls.Add(this.panel_PricePerUnit);
            this.splitContainer.Panel2.Controls.Add(this.labelControl_ProductionDay);
            this.splitContainer.Panel2.Controls.Add(this.labelControl_ExpirationDate);
            this.splitContainer.Panel2.Controls.Add(this.label_PricePerUnit);
            this.splitContainer.Panel2.Controls.Add(this.dateTimePicker_ProductionDate);
            this.splitContainer.Size = new System.Drawing.Size(881, 534);
            this.splitContainer.SplitterDistance = 444;
            this.splitContainer.TabIndex = 101;
            // 
            // panel_Amount
            // 
            this.panel_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Amount.Controls.Add(this.txt_Amount);
            this.panel_Amount.Location = new System.Drawing.Point(57, 312);
            this.panel_Amount.Name = "panel_Amount";
            this.panel_Amount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_Amount.Size = new System.Drawing.Size(301, 37);
            this.panel_Amount.TabIndex = 10;
            this.panel_Amount.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
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
            this.txt_Amount.Size = new System.Drawing.Size(293, 28);
            this.txt_Amount.TabIndex = 2;
            this.txt_Amount.Enter += new System.EventHandler(this.txt_Enter);
            this.txt_Amount.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label_Name
            // 
            this.label_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Name.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Name.Appearance.Options.UseFont = true;
            this.label_Name.Location = new System.Drawing.Point(61, 193);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(99, 25);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Tên Thuốc";
            // 
            // panel_Name
            // 
            this.panel_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Name.Controls.Add(this.txt_Name);
            this.panel_Name.Location = new System.Drawing.Point(57, 222);
            this.panel_Name.Name = "panel_Name";
            this.panel_Name.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_Name.Size = new System.Drawing.Size(301, 37);
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
            this.txt_Name.Size = new System.Drawing.Size(292, 28);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.Enter += new System.EventHandler(this.txt_Enter);
            this.txt_Name.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label_Amount
            // 
            this.label_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Amount.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Amount.Appearance.Options.UseFont = true;
            this.label_Amount.Location = new System.Drawing.Point(61, 283);
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
            this.panel_ID.Location = new System.Drawing.Point(57, 133);
            this.panel_ID.Name = "panel_ID";
            this.panel_ID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_ID.Size = new System.Drawing.Size(301, 37);
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
            this.txt_Id.Size = new System.Drawing.Size(292, 28);
            this.txt_Id.TabIndex = 0;
            this.txt_Id.Enter += new System.EventHandler(this.txt_Enter);
            this.txt_Id.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label_ID
            // 
            this.label_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ID.Appearance.Options.UseFont = true;
            this.label_ID.Location = new System.Drawing.Point(61, 107);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(86, 25);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID Thuốc";
            // 
            // dateTimePicker_ExpirationDate
            // 
            this.dateTimePicker_ExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_ExpirationDate.CalendarFont = new System.Drawing.Font("Arial", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_ExpirationDate.CustomFormat = " dd/M/yyyy";
            this.dateTimePicker_ExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_ExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ExpirationDate.Location = new System.Drawing.Point(76, 312);
            this.dateTimePicker_ExpirationDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_ExpirationDate.Name = "dateTimePicker_ExpirationDate";
            this.dateTimePicker_ExpirationDate.Size = new System.Drawing.Size(298, 35);
            this.dateTimePicker_ExpirationDate.TabIndex = 4;
            // 
            // panel_PricePerUnit
            // 
            this.panel_PricePerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_PricePerUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_PricePerUnit.Controls.Add(this.txt_PricePerUnit);
            this.panel_PricePerUnit.Location = new System.Drawing.Point(76, 136);
            this.panel_PricePerUnit.Name = "panel_PricePerUnit";
            this.panel_PricePerUnit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_PricePerUnit.Size = new System.Drawing.Size(301, 36);
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
            this.txt_PricePerUnit.Size = new System.Drawing.Size(292, 28);
            this.txt_PricePerUnit.TabIndex = 5;
            this.txt_PricePerUnit.Enter += new System.EventHandler(this.txt_Enter);
            this.txt_PricePerUnit.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // labelControl_ProductionDay
            // 
            this.labelControl_ProductionDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl_ProductionDay.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl_ProductionDay.Appearance.Options.UseFont = true;
            this.labelControl_ProductionDay.Location = new System.Drawing.Point(81, 193);
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
            this.labelControl_ExpirationDate.Location = new System.Drawing.Point(81, 283);
            this.labelControl_ExpirationDate.Name = "labelControl_ExpirationDate";
            this.labelControl_ExpirationDate.Size = new System.Drawing.Size(130, 25);
            this.labelControl_ExpirationDate.TabIndex = 0;
            this.labelControl_ExpirationDate.Text = "Ngày Hết Hạn";
            // 
            // label_PricePerUnit
            // 
            this.label_PricePerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_PricePerUnit.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_PricePerUnit.Appearance.Options.UseFont = true;
            this.label_PricePerUnit.Location = new System.Drawing.Point(81, 107);
            this.label_PricePerUnit.Name = "label_PricePerUnit";
            this.label_PricePerUnit.Size = new System.Drawing.Size(136, 25);
            this.label_PricePerUnit.TabIndex = 0;
            this.label_PricePerUnit.Text = "Giá mỗi đơn vị";
            // 
            // dateTimePicker_ProductionDate
            // 
            this.dateTimePicker_ProductionDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_ProductionDate.CustomFormat = " dd/M/yyyy";
            this.dateTimePicker_ProductionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_ProductionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ProductionDate.Location = new System.Drawing.Point(76, 225);
            this.dateTimePicker_ProductionDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_ProductionDate.Name = "dateTimePicker_ProductionDate";
            this.dateTimePicker_ProductionDate.Size = new System.Drawing.Size(298, 35);
            this.dateTimePicker_ProductionDate.TabIndex = 3;
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 553);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.groupBox_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMedicine";
            this.Text = "AddMedicine";
            this.panel_Title.ResumeLayout(false);
            this.groupBox_Input.ResumeLayout(false);
            this.panel_Buttons.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel_Amount.ResumeLayout(false);
            this.panel_Amount.PerformLayout();
            this.panel_Name.ResumeLayout(false);
            this.panel_Name.PerformLayout();
            this.panel_ID.ResumeLayout(false);
            this.panel_ID.PerformLayout();
            this.panel_PricePerUnit.ResumeLayout(false);
            this.panel_PricePerUnit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.GroupBox groupBox_Input;
        private System.Windows.Forms.Panel panel_PricePerUnit;
        private System.Windows.Forms.TextBox txt_PricePerUnit;
        private System.Windows.Forms.Panel panel_Amount;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Panel panel_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Panel panel_ID;
        private System.Windows.Forms.TextBox txt_Id;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ExpirationDate;
        private DevExpress.XtraEditors.LabelControl label_ID;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ProductionDate;
        private DevExpress.XtraEditors.LabelControl label_Amount;
        private DevExpress.XtraEditors.LabelControl label_PricePerUnit;
        private DevExpress.XtraEditors.LabelControl labelControl_ExpirationDate;
        private DevExpress.XtraEditors.LabelControl labelControl_ProductionDay;
        private DevExpress.XtraEditors.LabelControl label_Name;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panel_Buttons;
    }
}