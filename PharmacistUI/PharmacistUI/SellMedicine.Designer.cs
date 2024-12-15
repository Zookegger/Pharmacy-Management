namespace PharmacistUI
{
    partial class frm_SellMedicine
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
            this.txt_SearchMediicine = new System.Windows.Forms.TextBox();
            this.panel_Title = new DevExpress.XtraEditors.PanelControl();
            this.label_Title = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgv_SellCart = new System.Windows.Forms.DataGridView();
            this.txt_TotalCartPrice = new System.Windows.Forms.TextBox();
            this.btn_Discard = new DevExpress.XtraEditors.SimpleButton();
            this.bttn_AddToCart = new DevExpress.XtraEditors.SimpleButton();
            this.listBox_AvailableMedicine = new DevExpress.XtraEditors.ListBoxControl();
            this.group_MedicationInfo = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl_MedicationInfo = new DevExpress.XtraEditors.SplitContainerControl();
            this.label_MedicineName = new DevExpress.XtraEditors.LabelControl();
            this.label_MedicineID = new DevExpress.XtraEditors.LabelControl();
            this.label_ExpirationDate = new DevExpress.XtraEditors.LabelControl();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.dateTimePicker_ExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.label_TotalPrice = new DevExpress.XtraEditors.LabelControl();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.label_BuyAmount = new DevExpress.XtraEditors.LabelControl();
            this.numUpDown_BuyAmount = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupControl_SellCart = new DevExpress.XtraEditors.GroupControl();
            this.panelControl_BottomCartControls = new DevExpress.XtraEditors.PanelControl();
            this.btn_Checkout = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Title)).BeginInit();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SellCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_AvailableMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_MedicationInfo)).BeginInit();
            this.group_MedicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl_MedicationInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl_MedicationInfo.Panel1)).BeginInit();
            this.splitContainerControl_MedicationInfo.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl_MedicationInfo.Panel2)).BeginInit();
            this.splitContainerControl_MedicationInfo.Panel2.SuspendLayout();
            this.splitContainerControl_MedicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_BuyAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_SellCart)).BeginInit();
            this.groupControl_SellCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_BottomCartControls)).BeginInit();
            this.panelControl_BottomCartControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_SearchMediicine
            // 
            this.txt_SearchMediicine.Location = new System.Drawing.Point(58, 75);
            this.txt_SearchMediicine.Name = "txt_SearchMediicine";
            this.txt_SearchMediicine.Size = new System.Drawing.Size(167, 21);
            this.txt_SearchMediicine.TabIndex = 1;
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.label_Title);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(892, 60);
            this.panel_Title.TabIndex = 2;
            // 
            // label_Title
            // 
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Bold);
            this.label_Title.Location = new System.Drawing.Point(2, 2);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(888, 56);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = " Bán Thuốc";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 22);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tìm:";
            // 
            // dgv_SellCart
            // 
            this.dgv_SellCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SellCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SellCart.Location = new System.Drawing.Point(2, 26);
            this.dgv_SellCart.Name = "dgv_SellCart";
            this.dgv_SellCart.RowHeadersWidth = 47;
            this.dgv_SellCart.Size = new System.Drawing.Size(624, 269);
            this.dgv_SellCart.TabIndex = 6;
            // 
            // txt_TotalCartPrice
            // 
            this.txt_TotalCartPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TotalCartPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TotalCartPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TotalCartPrice.Enabled = false;
            this.txt_TotalCartPrice.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TotalCartPrice.Location = new System.Drawing.Point(468, 11);
            this.txt_TotalCartPrice.Name = "txt_TotalCartPrice";
            this.txt_TotalCartPrice.Size = new System.Drawing.Size(153, 22);
            this.txt_TotalCartPrice.TabIndex = 7;
            this.txt_TotalCartPrice.Text = "0đ";
            this.txt_TotalCartPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Discard
            // 
            this.btn_Discard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Discard.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_Discard.Appearance.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Discard.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Discard.Appearance.Options.UseBackColor = true;
            this.btn_Discard.Appearance.Options.UseFont = true;
            this.btn_Discard.Appearance.Options.UseForeColor = true;
            this.btn_Discard.Location = new System.Drawing.Point(2, 3);
            this.btn_Discard.MaximumSize = new System.Drawing.Size(400, 0);
            this.btn_Discard.MinimumSize = new System.Drawing.Size(193, 38);
            this.btn_Discard.Name = "btn_Discard";
            this.btn_Discard.Size = new System.Drawing.Size(227, 38);
            this.btn_Discard.TabIndex = 8;
            this.btn_Discard.Text = "Loại Bỏ";
            // 
            // bttn_AddToCart
            // 
            this.bttn_AddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_AddToCart.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.bttn_AddToCart.Appearance.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttn_AddToCart.Appearance.ForeColor = System.Drawing.Color.White;
            this.bttn_AddToCart.Appearance.Options.UseBackColor = true;
            this.bttn_AddToCart.Appearance.Options.UseFont = true;
            this.bttn_AddToCart.Appearance.Options.UseForeColor = true;
            this.bttn_AddToCart.Location = new System.Drawing.Point(8, 149);
            this.bttn_AddToCart.Name = "bttn_AddToCart";
            this.bttn_AddToCart.Size = new System.Drawing.Size(298, 38);
            this.bttn_AddToCart.TabIndex = 10;
            this.bttn_AddToCart.Text = "Thêm Vào Giỏ Hàng";
            // 
            // listBox_AvailableMedicine
            // 
            this.listBox_AvailableMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_AvailableMedicine.Location = new System.Drawing.Point(13, 112);
            this.listBox_AvailableMedicine.Name = "listBox_AvailableMedicine";
            this.listBox_AvailableMedicine.Size = new System.Drawing.Size(212, 488);
            this.listBox_AvailableMedicine.TabIndex = 11;
            // 
            // group_MedicationInfo
            // 
            this.group_MedicationInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_MedicationInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.group_MedicationInfo.Appearance.Options.UseFont = true;
            this.group_MedicationInfo.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.group_MedicationInfo.AppearanceCaption.Options.UseFont = true;
            this.group_MedicationInfo.Controls.Add(this.splitContainerControl_MedicationInfo);
            this.group_MedicationInfo.Location = new System.Drawing.Point(242, 75);
            this.group_MedicationInfo.Name = "group_MedicationInfo";
            this.group_MedicationInfo.Size = new System.Drawing.Size(630, 222);
            this.group_MedicationInfo.TabIndex = 12;
            this.group_MedicationInfo.Text = "[Thông Tin Thuốc]";
            // 
            // splitContainerControl_MedicationInfo
            // 
            this.splitContainerControl_MedicationInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl_MedicationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl_MedicationInfo.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl_MedicationInfo.IsSplitterFixed = true;
            this.splitContainerControl_MedicationInfo.Location = new System.Drawing.Point(2, 26);
            this.splitContainerControl_MedicationInfo.Name = "splitContainerControl_MedicationInfo";
            // 
            // splitContainerControl_MedicationInfo.Panel1
            // 
            this.splitContainerControl_MedicationInfo.Panel1.Controls.Add(this.label_MedicineName);
            this.splitContainerControl_MedicationInfo.Panel1.Controls.Add(this.label_MedicineID);
            this.splitContainerControl_MedicationInfo.Panel1.Controls.Add(this.label_ExpirationDate);
            this.splitContainerControl_MedicationInfo.Panel1.Controls.Add(this.txt_ID);
            this.splitContainerControl_MedicationInfo.Panel1.Controls.Add(this.txt_Name);
            this.splitContainerControl_MedicationInfo.Panel1.Controls.Add(this.dateTimePicker_ExpirationDate);
            this.splitContainerControl_MedicationInfo.Panel1.Text = "Panel1";
            // 
            // splitContainerControl_MedicationInfo.Panel2
            // 
            this.splitContainerControl_MedicationInfo.Panel2.Controls.Add(this.label_TotalPrice);
            this.splitContainerControl_MedicationInfo.Panel2.Controls.Add(this.textBox2);
            this.splitContainerControl_MedicationInfo.Panel2.Controls.Add(this.labelControl3);
            this.splitContainerControl_MedicationInfo.Panel2.Controls.Add(this.bttn_AddToCart);
            this.splitContainerControl_MedicationInfo.Panel2.Controls.Add(this.label_BuyAmount);
            this.splitContainerControl_MedicationInfo.Panel2.Controls.Add(this.numUpDown_BuyAmount);
            this.splitContainerControl_MedicationInfo.Panel2.Controls.Add(this.textBox1);
            this.splitContainerControl_MedicationInfo.Panel2.Text = "Panel2";
            this.splitContainerControl_MedicationInfo.Size = new System.Drawing.Size(626, 194);
            this.splitContainerControl_MedicationInfo.SplitterPosition = 290;
            this.splitContainerControl_MedicationInfo.TabIndex = 0;
            // 
            // label_MedicineName
            // 
            this.label_MedicineName.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_MedicineName.Appearance.Options.UseFont = true;
            this.label_MedicineName.Location = new System.Drawing.Point(14, 74);
            this.label_MedicineName.Name = "label_MedicineName";
            this.label_MedicineName.Size = new System.Drawing.Size(99, 24);
            this.label_MedicineName.TabIndex = 22;
            this.label_MedicineName.Text = "Tên Thuốc:";
            // 
            // label_MedicineID
            // 
            this.label_MedicineID.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_MedicineID.Appearance.Options.UseFont = true;
            this.label_MedicineID.Location = new System.Drawing.Point(31, 20);
            this.label_MedicineID.Name = "label_MedicineID";
            this.label_MedicineID.Size = new System.Drawing.Size(82, 24);
            this.label_MedicineID.TabIndex = 21;
            this.label_MedicineID.Text = "ID Thuốc:";
            // 
            // label_ExpirationDate
            // 
            this.label_ExpirationDate.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ExpirationDate.Appearance.Options.UseFont = true;
            this.label_ExpirationDate.Location = new System.Drawing.Point(14, 126);
            this.label_ExpirationDate.Name = "label_ExpirationDate";
            this.label_ExpirationDate.Size = new System.Drawing.Size(123, 24);
            this.label_ExpirationDate.TabIndex = 19;
            this.label_ExpirationDate.Text = "Ngày Hết Hạn:";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.BackColor = System.Drawing.Color.White;
            this.txt_ID.Enabled = false;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ID.Location = new System.Drawing.Point(119, 20);
            this.txt_ID.MaximumSize = new System.Drawing.Size(300, 28);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(169, 28);
            this.txt_ID.TabIndex = 16;
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.BackColor = System.Drawing.Color.White;
            this.txt_Name.Enabled = false;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Name.Location = new System.Drawing.Point(119, 74);
            this.txt_Name.MaximumSize = new System.Drawing.Size(300, 28);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(169, 28);
            this.txt_Name.TabIndex = 17;
            // 
            // dateTimePicker_ExpirationDate
            // 
            this.dateTimePicker_ExpirationDate.CalendarFont = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_ExpirationDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_ExpirationDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker_ExpirationDate.Enabled = false;
            this.dateTimePicker_ExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker_ExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ExpirationDate.Location = new System.Drawing.Point(171, 126);
            this.dateTimePicker_ExpirationDate.MinDate = new System.DateTime(2024, 12, 15, 0, 0, 0, 0);
            this.dateTimePicker_ExpirationDate.Name = "dateTimePicker_ExpirationDate";
            this.dateTimePicker_ExpirationDate.Size = new System.Drawing.Size(117, 28);
            this.dateTimePicker_ExpirationDate.TabIndex = 25;
            // 
            // label_TotalPrice
            // 
            this.label_TotalPrice.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TotalPrice.Appearance.Options.UseFont = true;
            this.label_TotalPrice.Location = new System.Drawing.Point(54, 104);
            this.label_TotalPrice.Name = "label_TotalPrice";
            this.label_TotalPrice.Size = new System.Drawing.Size(80, 24);
            this.label_TotalPrice.TabIndex = 23;
            this.label_TotalPrice.Text = "Tổng giá:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox2.Location = new System.Drawing.Point(139, 16);
            this.textBox2.MaximumSize = new System.Drawing.Size(300, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(167, 28);
            this.textBox2.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(8, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 24);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Giá mỗi đơn vị:";
            // 
            // label_BuyAmount
            // 
            this.label_BuyAmount.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_BuyAmount.Appearance.Options.UseFont = true;
            this.label_BuyAmount.Location = new System.Drawing.Point(47, 62);
            this.label_BuyAmount.Name = "label_BuyAmount";
            this.label_BuyAmount.Size = new System.Drawing.Size(87, 24);
            this.label_BuyAmount.TabIndex = 20;
            this.label_BuyAmount.Text = "Số Lượng:";
            // 
            // numUpDown_BuyAmount
            // 
            this.numUpDown_BuyAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numUpDown_BuyAmount.Location = new System.Drawing.Point(140, 62);
            this.numUpDown_BuyAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_BuyAmount.Name = "numUpDown_BuyAmount";
            this.numUpDown_BuyAmount.Size = new System.Drawing.Size(75, 28);
            this.numUpDown_BuyAmount.TabIndex = 18;
            this.numUpDown_BuyAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDown_BuyAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(139, 104);
            this.textBox1.MaximumSize = new System.Drawing.Size(300, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(167, 28);
            this.textBox1.TabIndex = 14;
            // 
            // groupControl_SellCart
            // 
            this.groupControl_SellCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl_SellCart.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold);
            this.groupControl_SellCart.AppearanceCaption.Options.UseFont = true;
            this.groupControl_SellCart.Controls.Add(this.panelControl_BottomCartControls);
            this.groupControl_SellCart.Controls.Add(this.dgv_SellCart);
            this.groupControl_SellCart.Location = new System.Drawing.Point(244, 303);
            this.groupControl_SellCart.Name = "groupControl_SellCart";
            this.groupControl_SellCart.Size = new System.Drawing.Size(628, 297);
            this.groupControl_SellCart.TabIndex = 13;
            this.groupControl_SellCart.Text = "[Giỏ Hàng]";
            // 
            // panelControl_BottomCartControls
            // 
            this.panelControl_BottomCartControls.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl_BottomCartControls.Controls.Add(this.btn_Checkout);
            this.panelControl_BottomCartControls.Controls.Add(this.txt_TotalCartPrice);
            this.panelControl_BottomCartControls.Controls.Add(this.btn_Discard);
            this.panelControl_BottomCartControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl_BottomCartControls.Location = new System.Drawing.Point(2, 252);
            this.panelControl_BottomCartControls.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panelControl_BottomCartControls.Name = "panelControl_BottomCartControls";
            this.panelControl_BottomCartControls.Size = new System.Drawing.Size(624, 43);
            this.panelControl_BottomCartControls.TabIndex = 10;
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Checkout.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_Checkout.Appearance.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Checkout.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Checkout.Appearance.Options.UseBackColor = true;
            this.btn_Checkout.Appearance.Options.UseFont = true;
            this.btn_Checkout.Appearance.Options.UseForeColor = true;
            this.btn_Checkout.Location = new System.Drawing.Point(235, 3);
            this.btn_Checkout.MaximumSize = new System.Drawing.Size(400, 0);
            this.btn_Checkout.MinimumSize = new System.Drawing.Size(193, 38);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(227, 38);
            this.btn_Checkout.TabIndex = 12;
            this.btn_Checkout.Text = "Thanh Toán";
            // 
            // frm_SellMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 615);
            this.Controls.Add(this.groupControl_SellCart);
            this.Controls.Add(this.group_MedicationInfo);
            this.Controls.Add(this.listBox_AvailableMedicine);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.txt_SearchMediicine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ShowIcon = false;
            this.Name = "frm_SellMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Medicine";
            ((System.ComponentModel.ISupportInitialize)(this.panel_Title)).EndInit();
            this.panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SellCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox_AvailableMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_MedicationInfo)).EndInit();
            this.group_MedicationInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl_MedicationInfo.Panel1)).EndInit();
            this.splitContainerControl_MedicationInfo.Panel1.ResumeLayout(false);
            this.splitContainerControl_MedicationInfo.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl_MedicationInfo.Panel2)).EndInit();
            this.splitContainerControl_MedicationInfo.Panel2.ResumeLayout(false);
            this.splitContainerControl_MedicationInfo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl_MedicationInfo)).EndInit();
            this.splitContainerControl_MedicationInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_BuyAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_SellCart)).EndInit();
            this.groupControl_SellCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_BottomCartControls)).EndInit();
            this.panelControl_BottomCartControls.ResumeLayout(false);
            this.panelControl_BottomCartControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_SearchMediicine;
        private DevExpress.XtraEditors.PanelControl panel_Title;
        private System.Windows.Forms.Label label_Title;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dgv_SellCart;
        private System.Windows.Forms.TextBox txt_TotalCartPrice;
        private DevExpress.XtraEditors.SimpleButton btn_Discard;
        private DevExpress.XtraEditors.SimpleButton bttn_AddToCart;
        private DevExpress.XtraEditors.ListBoxControl listBox_AvailableMedicine;
        private DevExpress.XtraEditors.GroupControl group_MedicationInfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ExpirationDate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_ID;
        private DevExpress.XtraEditors.LabelControl label_ExpirationDate;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numUpDown_BuyAmount;
        private DevExpress.XtraEditors.LabelControl label_BuyAmount;
        private DevExpress.XtraEditors.LabelControl label_MedicineID;
        private DevExpress.XtraEditors.LabelControl label_MedicineName;
        private DevExpress.XtraEditors.LabelControl label_TotalPrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl_MedicationInfo;
        private DevExpress.XtraEditors.GroupControl groupControl_SellCart;
        private DevExpress.XtraEditors.PanelControl panelControl_BottomCartControls;
        private DevExpress.XtraEditors.SimpleButton btn_Checkout;
    }
}