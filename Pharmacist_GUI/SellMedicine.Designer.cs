namespace Pharmacist
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SellMedicine));
            this.txt_SearchMedicine = new System.Windows.Forms.TextBox();
            this.panel_Title = new DevExpress.XtraEditors.PanelControl();
            this.label_Title = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TotalCartPrice = new System.Windows.Forms.TextBox();
            this.btn_Discard = new DevExpress.XtraEditors.SimpleButton();
            this.btn_AddToCart = new DevExpress.XtraEditors.SimpleButton();
            this.listBox_AvailableMedicine = new DevExpress.XtraEditors.ListBoxControl();
            this.group_MedicationInfo = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl_MedicationInfo = new DevExpress.XtraEditors.SplitContainerControl();
            this.txt_ExpDate = new System.Windows.Forms.TextBox();
            this.cbb_ProductionDate = new System.Windows.Forms.ComboBox();
            this.label_MedicineName = new DevExpress.XtraEditors.LabelControl();
            this.label_MedicineID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label_ProductionDate = new DevExpress.XtraEditors.LabelControl();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label_TotalPrice = new DevExpress.XtraEditors.LabelControl();
            this.txt_PricePerUnit = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.label_BuyAmount = new DevExpress.XtraEditors.LabelControl();
            this.numUpDown_BuyAmount = new System.Windows.Forms.NumericUpDown();
            this.txt_TotalPrice = new System.Windows.Forms.TextBox();
            this.groupControl_SellCart = new DevExpress.XtraEditors.GroupControl();
            this.panelControl_BottomCartControls = new DevExpress.XtraEditors.PanelControl();
            this.check_SaveCustomerInfo = new System.Windows.Forms.CheckBox();
            this.btn_Checkout = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_SellCart = new System.Windows.Forms.DataGridView();
            this.col_MedicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popupContainerControl_Receipt = new DevExpress.XtraEditors.PopupContainerControl();
            this.panel_PopupTitle = new System.Windows.Forms.Panel();
            this.panel_MainReceipt = new System.Windows.Forms.Panel();
            this.groupControl_ReceiptContent = new DevExpress.XtraEditors.GroupControl();
            this.panel_ReceiptTotal = new System.Windows.Forms.Panel();
            this.label_Total = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.cHITIETDONTHUOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_ReceiptDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDonThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayHetHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl_CustomerInfo = new DevExpress.XtraEditors.GroupControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControl_Email = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_PhoneNumber = new DevExpress.XtraEditors.LabelControl();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label_CustomerName = new DevExpress.XtraEditors.LabelControl();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelControl_Address = new DevExpress.XtraEditors.LabelControl();
            this.panel_ReceiptInfo = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.label_Employee = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_ReceiptId = new DevExpress.XtraEditors.LabelControl();
            this.txt_ = new System.Windows.Forms.TextBox();
            this.txt_EmployeeMade = new System.Windows.Forms.TextBox();
            this.txt_ReceiptId = new System.Windows.Forms.TextBox();
            this.panel_ReceiptTitle = new System.Windows.Forms.Panel();
            this.label_Receipt = new DevExpress.XtraEditors.LabelControl();
            this.panel_ReceiptButton = new System.Windows.Forms.Panel();
            this.btn_SkipPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btn_PrintReceipt = new DevExpress.XtraEditors.SimpleButton();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.popupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
            this.panelControlPopUp_CustomerTitle = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txt_InputCusName = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_InputAddress = new System.Windows.Forms.TextBox();
            this.txt_InputEmail = new System.Windows.Forms.TextBox();
            this.labelControl_CustomerName = new DevExpress.XtraEditors.LabelControl();
            this.txt_InputPhone = new System.Windows.Forms.TextBox();
            this.labelControl_CustomerAddress = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_EnterCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Title)).BeginInit();
            this.panel_Title.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SellCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl_Receipt)).BeginInit();
            this.popupContainerControl_Receipt.SuspendLayout();
            this.panel_PopupTitle.SuspendLayout();
            this.panel_MainReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ReceiptContent)).BeginInit();
            this.groupControl_ReceiptContent.SuspendLayout();
            this.panel_ReceiptTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETDONTHUOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ReceiptDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_CustomerInfo)).BeginInit();
            this.groupControl_CustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_ReceiptInfo)).BeginInit();
            this.panel_ReceiptInfo.SuspendLayout();
            this.panel_ReceiptTitle.SuspendLayout();
            this.panel_ReceiptButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).BeginInit();
            this.popupContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlPopUp_CustomerTitle)).BeginInit();
            this.panelControlPopUp_CustomerTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_SearchMedicine
            // 
            this.txt_SearchMedicine.Location = new System.Drawing.Point(58, 75);
            this.txt_SearchMedicine.Name = "txt_SearchMedicine";
            this.txt_SearchMedicine.Size = new System.Drawing.Size(167, 21);
            this.txt_SearchMedicine.TabIndex = 1;
            this.txt_SearchMedicine.TextChanged += new System.EventHandler(this.txt_SearchMedicine_TextChanged);
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.label_Title);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1280, 60);
            this.panel_Title.TabIndex = 2;
            // 
            // label_Title
            // 
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Bold);
            this.label_Title.Location = new System.Drawing.Point(2, 2);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(1276, 56);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = " Bán Thuốc";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 75);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 22);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tìm:";
            // 
            // txt_TotalCartPrice
            // 
            this.txt_TotalCartPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TotalCartPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TotalCartPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TotalCartPrice.Enabled = false;
            this.txt_TotalCartPrice.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TotalCartPrice.Location = new System.Drawing.Point(787, 11);
            this.txt_TotalCartPrice.Name = "txt_TotalCartPrice";
            this.txt_TotalCartPrice.Size = new System.Drawing.Size(222, 22);
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
            this.btn_Discard.Click += new System.EventHandler(this.btn_Discard_Click);
            // 
            // btn_AddToCart
            // 
            this.btn_AddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddToCart.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_AddToCart.Appearance.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_AddToCart.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_AddToCart.Appearance.Options.UseBackColor = true;
            this.btn_AddToCart.Appearance.Options.UseFont = true;
            this.btn_AddToCart.Appearance.Options.UseForeColor = true;
            this.btn_AddToCart.Location = new System.Drawing.Point(166, 143);
            this.btn_AddToCart.Name = "btn_AddToCart";
            this.btn_AddToCart.Size = new System.Drawing.Size(287, 38);
            this.btn_AddToCart.TabIndex = 10;
            this.btn_AddToCart.Text = "Thêm Vào Giỏ Hàng";
            this.btn_AddToCart.Click += new System.EventHandler(this.btn_AddToCart_Click);
            // 
            // listBox_AvailableMedicine
            // 
            this.listBox_AvailableMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_AvailableMedicine.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBox_AvailableMedicine.Appearance.Options.UseFont = true;
            this.listBox_AvailableMedicine.AppearanceHighlight.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_AvailableMedicine.AppearanceHighlight.Options.UseFont = true;
            this.listBox_AvailableMedicine.AppearanceSelected.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBox_AvailableMedicine.AppearanceSelected.Options.UseFont = true;
            this.listBox_AvailableMedicine.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listBox_AvailableMedicine.Location = new System.Drawing.Point(13, 112);
            this.listBox_AvailableMedicine.Name = "listBox_AvailableMedicine";
            this.listBox_AvailableMedicine.Size = new System.Drawing.Size(212, 593);
            this.listBox_AvailableMedicine.TabIndex = 11;
            this.listBox_AvailableMedicine.Click += new System.EventHandler(this.listBox_AvailableMedicine_Click);
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
            this.group_MedicationInfo.Location = new System.Drawing.Point(244, 75);
            this.group_MedicationInfo.Name = "group_MedicationInfo";
            this.group_MedicationInfo.Size = new System.Drawing.Size(1016, 222);
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
            this.splitContainerControl_MedicationInfo.Panel1.Controls.Add(this.txt_ExpDate);
            this.splitContainerControl_MedicationInfo.Panel1.Controls.Add(this.cbb_ProductionDate);
            this.splitContainerControl_MedicationInfo.Panel1.Controls.Add(this.label_MedicineName);
            this.splitContainerControl_MedicationInfo.Panel1.Controls.Add(this.label_MedicineID);
            this.splitContainerControl_MedicationInfo.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl_MedicationInfo.Panel1.Controls.Add(this.label_ProductionDate);
            this.splitContainerControl_MedicationInfo.Panel1.Controls.Add(this.txt_ID);
            this.splitContainerControl_MedicationInfo.Panel1.Controls.Add(this.txt_Name);
            this.splitContainerControl_MedicationInfo.Panel1.Text = "Panel1";
            // 
            // splitContainerControl_MedicationInfo.Panel2
            // 
            this.splitContainerControl_MedicationInfo.Panel2.Controls.Add(this.label_TotalPrice);
            this.splitContainerControl_MedicationInfo.Panel2.Controls.Add(this.txt_PricePerUnit);
            this.splitContainerControl_MedicationInfo.Panel2.Controls.Add(this.labelControl3);
            this.splitContainerControl_MedicationInfo.Panel2.Controls.Add(this.btn_AddToCart);
            this.splitContainerControl_MedicationInfo.Panel2.Controls.Add(this.label_BuyAmount);
            this.splitContainerControl_MedicationInfo.Panel2.Controls.Add(this.numUpDown_BuyAmount);
            this.splitContainerControl_MedicationInfo.Panel2.Controls.Add(this.txt_TotalPrice);
            this.splitContainerControl_MedicationInfo.Panel2.Text = "Panel2";
            this.splitContainerControl_MedicationInfo.Size = new System.Drawing.Size(1012, 194);
            this.splitContainerControl_MedicationInfo.SplitterPosition = 470;
            this.splitContainerControl_MedicationInfo.TabIndex = 0;
            // 
            // txt_ExpDate
            // 
            this.txt_ExpDate.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ExpDate.Location = new System.Drawing.Point(171, 148);
            this.txt_ExpDate.Name = "txt_ExpDate";
            this.txt_ExpDate.Size = new System.Drawing.Size(250, 29);
            this.txt_ExpDate.TabIndex = 28;
            // 
            // cbb_ProductionDate
            // 
            this.cbb_ProductionDate.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_ProductionDate.FormattingEnabled = true;
            this.cbb_ProductionDate.Location = new System.Drawing.Point(171, 99);
            this.cbb_ProductionDate.Name = "cbb_ProductionDate";
            this.cbb_ProductionDate.Size = new System.Drawing.Size(250, 30);
            this.cbb_ProductionDate.TabIndex = 26;
            this.cbb_ProductionDate.SelectedIndexChanged += new System.EventHandler(this.cbb_ProductionDate_SelectedIndexChanged);
            // 
            // label_MedicineName
            // 
            this.label_MedicineName.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_MedicineName.Appearance.Options.UseFont = true;
            this.label_MedicineName.Location = new System.Drawing.Point(52, 54);
            this.label_MedicineName.Name = "label_MedicineName";
            this.label_MedicineName.Size = new System.Drawing.Size(99, 24);
            this.label_MedicineName.TabIndex = 22;
            this.label_MedicineName.Text = "Tên Thuốc:";
            // 
            // label_MedicineID
            // 
            this.label_MedicineID.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_MedicineID.Appearance.Options.UseFont = true;
            this.label_MedicineID.Location = new System.Drawing.Point(69, 9);
            this.label_MedicineID.Name = "label_MedicineID";
            this.label_MedicineID.Size = new System.Drawing.Size(82, 24);
            this.label_MedicineID.TabIndex = 21;
            this.label_MedicineID.Text = "ID Thuốc:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(35, 151);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(123, 24);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Ngày Hết Hạn:";
            // 
            // label_ProductionDate
            // 
            this.label_ProductionDate.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ProductionDate.Appearance.Options.UseFont = true;
            this.label_ProductionDate.Location = new System.Drawing.Point(35, 102);
            this.label_ProductionDate.Name = "label_ProductionDate";
            this.label_ProductionDate.Size = new System.Drawing.Size(119, 24);
            this.label_ProductionDate.TabIndex = 19;
            this.label_ProductionDate.Text = "Ngày sản xuất";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.BackColor = System.Drawing.Color.White;
            this.txt_ID.Enabled = false;
            this.txt_ID.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ID.Location = new System.Drawing.Point(171, 9);
            this.txt_ID.MaximumSize = new System.Drawing.Size(300, 28);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(250, 29);
            this.txt_ID.TabIndex = 16;
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.BackColor = System.Drawing.Color.White;
            this.txt_Name.Enabled = false;
            this.txt_Name.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Name.Location = new System.Drawing.Point(171, 51);
            this.txt_Name.MaximumSize = new System.Drawing.Size(300, 28);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(250, 29);
            this.txt_Name.TabIndex = 17;
            // 
            // label_TotalPrice
            // 
            this.label_TotalPrice.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TotalPrice.Appearance.Options.UseFont = true;
            this.label_TotalPrice.Location = new System.Drawing.Point(70, 94);
            this.label_TotalPrice.Name = "label_TotalPrice";
            this.label_TotalPrice.Size = new System.Drawing.Size(80, 24);
            this.label_TotalPrice.TabIndex = 23;
            this.label_TotalPrice.Text = "Tổng giá:";
            // 
            // txt_PricePerUnit
            // 
            this.txt_PricePerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PricePerUnit.BackColor = System.Drawing.Color.White;
            this.txt_PricePerUnit.Enabled = false;
            this.txt_PricePerUnit.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_PricePerUnit.Location = new System.Drawing.Point(168, 6);
            this.txt_PricePerUnit.MaximumSize = new System.Drawing.Size(300, 28);
            this.txt_PricePerUnit.Name = "txt_PricePerUnit";
            this.txt_PricePerUnit.ReadOnly = true;
            this.txt_PricePerUnit.Size = new System.Drawing.Size(285, 29);
            this.txt_PricePerUnit.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(24, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 24);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Giá mỗi đơn vị:";
            // 
            // label_BuyAmount
            // 
            this.label_BuyAmount.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_BuyAmount.Appearance.Options.UseFont = true;
            this.label_BuyAmount.Location = new System.Drawing.Point(63, 52);
            this.label_BuyAmount.Name = "label_BuyAmount";
            this.label_BuyAmount.Size = new System.Drawing.Size(87, 24);
            this.label_BuyAmount.TabIndex = 20;
            this.label_BuyAmount.Text = "Số Lượng:";
            // 
            // numUpDown_BuyAmount
            // 
            this.numUpDown_BuyAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numUpDown_BuyAmount.Location = new System.Drawing.Point(168, 52);
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
            this.numUpDown_BuyAmount.ValueChanged += new System.EventHandler(this.numUpDown_BuyAmount_ValueChanged);
            // 
            // txt_TotalPrice
            // 
            this.txt_TotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TotalPrice.BackColor = System.Drawing.Color.White;
            this.txt_TotalPrice.Enabled = false;
            this.txt_TotalPrice.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TotalPrice.Location = new System.Drawing.Point(168, 94);
            this.txt_TotalPrice.MaximumSize = new System.Drawing.Size(300, 28);
            this.txt_TotalPrice.Name = "txt_TotalPrice";
            this.txt_TotalPrice.ReadOnly = true;
            this.txt_TotalPrice.Size = new System.Drawing.Size(285, 29);
            this.txt_TotalPrice.TabIndex = 14;
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
            this.groupControl_SellCart.Size = new System.Drawing.Size(1016, 402);
            this.groupControl_SellCart.TabIndex = 13;
            this.groupControl_SellCart.Text = "[Giỏ Hàng]";
            // 
            // panelControl_BottomCartControls
            // 
            this.panelControl_BottomCartControls.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl_BottomCartControls.Controls.Add(this.check_SaveCustomerInfo);
            this.panelControl_BottomCartControls.Controls.Add(this.btn_Checkout);
            this.panelControl_BottomCartControls.Controls.Add(this.txt_TotalCartPrice);
            this.panelControl_BottomCartControls.Controls.Add(this.btn_Discard);
            this.panelControl_BottomCartControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl_BottomCartControls.Location = new System.Drawing.Point(2, 357);
            this.panelControl_BottomCartControls.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panelControl_BottomCartControls.Name = "panelControl_BottomCartControls";
            this.panelControl_BottomCartControls.Size = new System.Drawing.Size(1012, 43);
            this.panelControl_BottomCartControls.TabIndex = 10;
            // 
            // check_SaveCustomerInfo
            // 
            this.check_SaveCustomerInfo.AutoSize = true;
            this.check_SaveCustomerInfo.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.check_SaveCustomerInfo.Location = new System.Drawing.Point(505, 13);
            this.check_SaveCustomerInfo.Name = "check_SaveCustomerInfo";
            this.check_SaveCustomerInfo.Size = new System.Drawing.Size(193, 22);
            this.check_SaveCustomerInfo.TabIndex = 13;
            this.check_SaveCustomerInfo.Text = "Lưu thông tin khách hàng";
            this.check_SaveCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Checkout.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_Checkout.Appearance.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Checkout.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Checkout.Appearance.Options.UseBackColor = true;
            this.btn_Checkout.Appearance.Options.UseFont = true;
            this.btn_Checkout.Appearance.Options.UseForeColor = true;
            this.btn_Checkout.Location = new System.Drawing.Point(256, 3);
            this.btn_Checkout.MaximumSize = new System.Drawing.Size(400, 0);
            this.btn_Checkout.MinimumSize = new System.Drawing.Size(193, 38);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(227, 38);
            this.btn_Checkout.TabIndex = 12;
            this.btn_Checkout.Text = "Thanh Toán";
            this.btn_Checkout.Click += new System.EventHandler(this.btn_Checkout_Click);
            // 
            // dgv_SellCart
            // 
            this.dgv_SellCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SellCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 7.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SellCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_SellCart.ColumnHeadersHeight = 50;
            this.dgv_SellCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_SellCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MedicineId,
            this.col_MedicineName,
            this.col_ProdDate,
            this.col_ExpDate,
            this.col_Quantity,
            this.col_TotalPrice});
            this.dgv_SellCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SellCart.Location = new System.Drawing.Point(2, 26);
            this.dgv_SellCart.Name = "dgv_SellCart";
            this.dgv_SellCart.RowHeadersVisible = false;
            this.dgv_SellCart.RowHeadersWidth = 47;
            this.dgv_SellCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_SellCart.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_SellCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SellCart.Size = new System.Drawing.Size(1012, 374);
            this.dgv_SellCart.TabIndex = 6;
            // 
            // col_MedicineId
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.col_MedicineId.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_MedicineId.HeaderText = "ID Thuốc";
            this.col_MedicineId.MinimumWidth = 6;
            this.col_MedicineId.Name = "col_MedicineId";
            // 
            // col_MedicineName
            // 
            this.col_MedicineName.HeaderText = "Tên Thuốc";
            this.col_MedicineName.MinimumWidth = 6;
            this.col_MedicineName.Name = "col_MedicineName";
            // 
            // col_ProdDate
            // 
            this.col_ProdDate.HeaderText = "Ngày Sản Xuất";
            this.col_ProdDate.MinimumWidth = 6;
            this.col_ProdDate.Name = "col_ProdDate";
            // 
            // col_ExpDate
            // 
            this.col_ExpDate.HeaderText = "Hạn Sử Dụng";
            this.col_ExpDate.MinimumWidth = 6;
            this.col_ExpDate.Name = "col_ExpDate";
            // 
            // col_Quantity
            // 
            this.col_Quantity.HeaderText = "Số Lượng";
            this.col_Quantity.MinimumWidth = 6;
            this.col_Quantity.Name = "col_Quantity";
            // 
            // col_TotalPrice
            // 
            this.col_TotalPrice.HeaderText = "Tổng Giá";
            this.col_TotalPrice.MinimumWidth = 6;
            this.col_TotalPrice.Name = "col_TotalPrice";
            // 
            // popupContainerControl_Receipt
            // 
            this.popupContainerControl_Receipt.Controls.Add(this.panel_PopupTitle);
            this.popupContainerControl_Receipt.Controls.Add(this.panel_ReceiptButton);
            this.popupContainerControl_Receipt.Location = new System.Drawing.Point(370, 11);
            this.popupContainerControl_Receipt.Name = "popupContainerControl_Receipt";
            this.popupContainerControl_Receipt.Size = new System.Drawing.Size(668, 684);
            this.popupContainerControl_Receipt.TabIndex = 14;
            // 
            // panel_PopupTitle
            // 
            this.panel_PopupTitle.Controls.Add(this.panel_MainReceipt);
            this.panel_PopupTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_PopupTitle.Location = new System.Drawing.Point(0, 0);
            this.panel_PopupTitle.Name = "panel_PopupTitle";
            this.panel_PopupTitle.Size = new System.Drawing.Size(668, 635);
            this.panel_PopupTitle.TabIndex = 0;
            // 
            // panel_MainReceipt
            // 
            this.panel_MainReceipt.Controls.Add(this.groupControl_ReceiptContent);
            this.panel_MainReceipt.Controls.Add(this.groupControl_CustomerInfo);
            this.panel_MainReceipt.Controls.Add(this.panel_ReceiptInfo);
            this.panel_MainReceipt.Controls.Add(this.panel_ReceiptTitle);
            this.panel_MainReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MainReceipt.Location = new System.Drawing.Point(0, 0);
            this.panel_MainReceipt.Name = "panel_MainReceipt";
            this.panel_MainReceipt.Size = new System.Drawing.Size(668, 635);
            this.panel_MainReceipt.TabIndex = 0;
            // 
            // groupControl_ReceiptContent
            // 
            this.groupControl_ReceiptContent.Controls.Add(this.panel_ReceiptTotal);
            this.groupControl_ReceiptContent.Controls.Add(this.gridControl);
            this.groupControl_ReceiptContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_ReceiptContent.Location = new System.Drawing.Point(0, 180);
            this.groupControl_ReceiptContent.Name = "groupControl_ReceiptContent";
            this.groupControl_ReceiptContent.Size = new System.Drawing.Size(668, 455);
            this.groupControl_ReceiptContent.TabIndex = 7;
            this.groupControl_ReceiptContent.Text = "Thông tin đơn thuốc";
            // 
            // panel_ReceiptTotal
            // 
            this.panel_ReceiptTotal.Controls.Add(this.label_Total);
            this.panel_ReceiptTotal.Controls.Add(this.textBox3);
            this.panel_ReceiptTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ReceiptTotal.Location = new System.Drawing.Point(2, 424);
            this.panel_ReceiptTotal.Name = "panel_ReceiptTotal";
            this.panel_ReceiptTotal.Size = new System.Drawing.Size(664, 29);
            this.panel_ReceiptTotal.TabIndex = 1;
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Tahoma", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Total.Location = new System.Drawing.Point(410, 7);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(90, 16);
            this.label_Total.TabIndex = 1;
            this.label_Total.Text = "Tổng giá tiền";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(504, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 21);
            this.textBox3.TabIndex = 0;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.cHITIETDONTHUOCBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 26);
            this.gridControl.MainView = this.gridView_ReceiptDetail;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(664, 427);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ReceiptDetail});
            // 
            // cHITIETDONTHUOCBindingSource
            // 
            this.cHITIETDONTHUOCBindingSource.DataSource = typeof(PharmacistManagement_DAL.Model.CHITIETDONTHUOC);
            // 
            // gridView_ReceiptDetail
            // 
            this.gridView_ReceiptDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDonThuoc,
            this.colMaThuoc,
            this.colSoLuong,
            this.colNgayHetHan});
            this.gridView_ReceiptDetail.GridControl = this.gridControl;
            this.gridView_ReceiptDetail.Name = "gridView_ReceiptDetail";
            this.gridView_ReceiptDetail.OptionsView.ShowGroupPanel = false;
            // 
            // colMaDonThuoc
            // 
            this.colMaDonThuoc.Caption = "Mã Đơn Thuốc";
            this.colMaDonThuoc.FieldName = "ReceiptId";
            this.colMaDonThuoc.MinWidth = 23;
            this.colMaDonThuoc.Name = "colMaDonThuoc";
            this.colMaDonThuoc.Visible = true;
            this.colMaDonThuoc.VisibleIndex = 0;
            this.colMaDonThuoc.Width = 86;
            // 
            // colMaThuoc
            // 
            this.colMaThuoc.Caption = "Mã Thuốc";
            this.colMaThuoc.FieldName = "MedicineId";
            this.colMaThuoc.MinWidth = 23;
            this.colMaThuoc.Name = "colMaThuoc";
            this.colMaThuoc.Visible = true;
            this.colMaThuoc.VisibleIndex = 1;
            this.colMaThuoc.Width = 86;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.FieldName = "Quantity";
            this.colSoLuong.MinWidth = 23;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 2;
            this.colSoLuong.Width = 86;
            // 
            // colNgayHetHan
            // 
            this.colNgayHetHan.Caption = "Ngày hết hạn";
            this.colNgayHetHan.FieldName = "ExpDate";
            this.colNgayHetHan.MinWidth = 23;
            this.colNgayHetHan.Name = "colNgayHetHan";
            this.colNgayHetHan.Visible = true;
            this.colNgayHetHan.VisibleIndex = 3;
            this.colNgayHetHan.Width = 86;
            // 
            // groupControl_CustomerInfo
            // 
            this.groupControl_CustomerInfo.Controls.Add(this.textBox1);
            this.groupControl_CustomerInfo.Controls.Add(this.labelControl_Email);
            this.groupControl_CustomerInfo.Controls.Add(this.labelControl_PhoneNumber);
            this.groupControl_CustomerInfo.Controls.Add(this.textBox2);
            this.groupControl_CustomerInfo.Controls.Add(this.textBox5);
            this.groupControl_CustomerInfo.Controls.Add(this.label_CustomerName);
            this.groupControl_CustomerInfo.Controls.Add(this.textBox4);
            this.groupControl_CustomerInfo.Controls.Add(this.labelControl_Address);
            this.groupControl_CustomerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_CustomerInfo.Location = new System.Drawing.Point(0, 79);
            this.groupControl_CustomerInfo.Name = "groupControl_CustomerInfo";
            this.groupControl_CustomerInfo.Size = new System.Drawing.Size(668, 101);
            this.groupControl_CustomerInfo.TabIndex = 6;
            this.groupControl_CustomerInfo.Text = "Thông tin khách hàng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 21);
            this.textBox1.TabIndex = 2;
            // 
            // labelControl_Email
            // 
            this.labelControl_Email.Location = new System.Drawing.Point(349, 71);
            this.labelControl_Email.Name = "labelControl_Email";
            this.labelControl_Email.Size = new System.Drawing.Size(28, 13);
            this.labelControl_Email.TabIndex = 3;
            this.labelControl_Email.Text = "Email:";
            // 
            // labelControl_PhoneNumber
            // 
            this.labelControl_PhoneNumber.Location = new System.Drawing.Point(349, 39);
            this.labelControl_PhoneNumber.Name = "labelControl_PhoneNumber";
            this.labelControl_PhoneNumber.Size = new System.Drawing.Size(62, 13);
            this.labelControl_PhoneNumber.TabIndex = 3;
            this.labelControl_PhoneNumber.Text = "Số điện thoại";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 21);
            this.textBox2.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(422, 67);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(208, 21);
            this.textBox5.TabIndex = 2;
            // 
            // label_CustomerName
            // 
            this.label_CustomerName.Location = new System.Drawing.Point(30, 39);
            this.label_CustomerName.Name = "label_CustomerName";
            this.label_CustomerName.Size = new System.Drawing.Size(76, 13);
            this.label_CustomerName.TabIndex = 3;
            this.label_CustomerName.Text = "Tên khách hàng";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(422, 33);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(208, 21);
            this.textBox4.TabIndex = 2;
            // 
            // labelControl_Address
            // 
            this.labelControl_Address.Location = new System.Drawing.Point(30, 71);
            this.labelControl_Address.Name = "labelControl_Address";
            this.labelControl_Address.Size = new System.Drawing.Size(32, 13);
            this.labelControl_Address.TabIndex = 3;
            this.labelControl_Address.Text = "Địa chỉ";
            // 
            // panel_ReceiptInfo
            // 
            this.panel_ReceiptInfo.Appearance.BorderColor = System.Drawing.Color.Black;
            this.panel_ReceiptInfo.Appearance.Options.UseBorderColor = true;
            this.panel_ReceiptInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panel_ReceiptInfo.Controls.Add(this.labelControl5);
            this.panel_ReceiptInfo.Controls.Add(this.label_Employee);
            this.panel_ReceiptInfo.Controls.Add(this.labelControl_ReceiptId);
            this.panel_ReceiptInfo.Controls.Add(this.txt_);
            this.panel_ReceiptInfo.Controls.Add(this.txt_EmployeeMade);
            this.panel_ReceiptInfo.Controls.Add(this.txt_ReceiptId);
            this.panel_ReceiptInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ReceiptInfo.Location = new System.Drawing.Point(0, 47);
            this.panel_ReceiptInfo.Name = "panel_ReceiptInfo";
            this.panel_ReceiptInfo.Size = new System.Drawing.Size(668, 32);
            this.panel_ReceiptInfo.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(439, 9);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Ngày lập";
            // 
            // label_Employee
            // 
            this.label_Employee.Location = new System.Drawing.Point(202, 9);
            this.label_Employee.Name = "label_Employee";
            this.label_Employee.Size = new System.Drawing.Size(65, 13);
            this.label_Employee.TabIndex = 1;
            this.label_Employee.Text = "Nhân viên lập";
            // 
            // labelControl_ReceiptId
            // 
            this.labelControl_ReceiptId.Location = new System.Drawing.Point(10, 9);
            this.labelControl_ReceiptId.Name = "labelControl_ReceiptId";
            this.labelControl_ReceiptId.Size = new System.Drawing.Size(65, 13);
            this.labelControl_ReceiptId.TabIndex = 1;
            this.labelControl_ReceiptId.Text = "Mã đơn thuốc";
            // 
            // txt_
            // 
            this.txt_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_.Location = new System.Drawing.Point(487, 9);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(176, 14);
            this.txt_.TabIndex = 0;
            // 
            // txt_EmployeeMade
            // 
            this.txt_EmployeeMade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_EmployeeMade.Location = new System.Drawing.Point(273, 9);
            this.txt_EmployeeMade.Name = "txt_EmployeeMade";
            this.txt_EmployeeMade.Size = new System.Drawing.Size(139, 14);
            this.txt_EmployeeMade.TabIndex = 0;
            // 
            // txt_ReceiptId
            // 
            this.txt_ReceiptId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ReceiptId.Location = new System.Drawing.Point(81, 9);
            this.txt_ReceiptId.Name = "txt_ReceiptId";
            this.txt_ReceiptId.Size = new System.Drawing.Size(89, 14);
            this.txt_ReceiptId.TabIndex = 0;
            // 
            // panel_ReceiptTitle
            // 
            this.panel_ReceiptTitle.Controls.Add(this.label_Receipt);
            this.panel_ReceiptTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ReceiptTitle.Location = new System.Drawing.Point(0, 0);
            this.panel_ReceiptTitle.Name = "panel_ReceiptTitle";
            this.panel_ReceiptTitle.Size = new System.Drawing.Size(668, 47);
            this.panel_ReceiptTitle.TabIndex = 8;
            // 
            // label_Receipt
            // 
            this.label_Receipt.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Receipt.Appearance.Options.UseFont = true;
            this.label_Receipt.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.label_Receipt.LineColor = System.Drawing.Color.Black;
            this.label_Receipt.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.label_Receipt.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.label_Receipt.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.label_Receipt.LineVisible = true;
            this.label_Receipt.Location = new System.Drawing.Point(240, 12);
            this.label_Receipt.Name = "label_Receipt";
            this.label_Receipt.Size = new System.Drawing.Size(185, 28);
            this.label_Receipt.TabIndex = 0;
            this.label_Receipt.Text = "Chi tiết đơn thuốc";
            // 
            // panel_ReceiptButton
            // 
            this.panel_ReceiptButton.Controls.Add(this.btn_SkipPrint);
            this.panel_ReceiptButton.Controls.Add(this.btn_PrintReceipt);
            this.panel_ReceiptButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ReceiptButton.Location = new System.Drawing.Point(0, 635);
            this.panel_ReceiptButton.Name = "panel_ReceiptButton";
            this.panel_ReceiptButton.Size = new System.Drawing.Size(668, 49);
            this.panel_ReceiptButton.TabIndex = 1;
            // 
            // btn_SkipPrint
            // 
            this.btn_SkipPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SkipPrint.Appearance.Options.UseFont = true;
            this.btn_SkipPrint.Location = new System.Drawing.Point(461, 10);
            this.btn_SkipPrint.Name = "btn_SkipPrint";
            this.btn_SkipPrint.Size = new System.Drawing.Size(187, 30);
            this.btn_SkipPrint.TabIndex = 0;
            this.btn_SkipPrint.Text = "Bỏ qua";
            // 
            // btn_PrintReceipt
            // 
            this.btn_PrintReceipt.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_PrintReceipt.Appearance.Options.UseFont = true;
            this.btn_PrintReceipt.Location = new System.Drawing.Point(19, 10);
            this.btn_PrintReceipt.Name = "btn_PrintReceipt";
            this.btn_PrintReceipt.Size = new System.Drawing.Size(177, 30);
            this.btn_PrintReceipt.TabIndex = 0;
            this.btn_PrintReceipt.Text = "Xuất hóa đơn";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // popupContainerControl1
            // 
            this.popupContainerControl1.Controls.Add(this.txt_InputCusName);
            this.popupContainerControl1.Controls.Add(this.labelControl4);
            this.popupContainerControl1.Controls.Add(this.panelControl1);
            this.popupContainerControl1.Controls.Add(this.labelControl6);
            this.popupContainerControl1.Controls.Add(this.panelControlPopUp_CustomerTitle);
            this.popupContainerControl1.Controls.Add(this.txt_InputAddress);
            this.popupContainerControl1.Controls.Add(this.labelControl_CustomerAddress);
            this.popupContainerControl1.Controls.Add(this.txt_InputEmail);
            this.popupContainerControl1.Controls.Add(this.txt_InputPhone);
            this.popupContainerControl1.Controls.Add(this.labelControl_CustomerName);
            this.popupContainerControl1.Location = new System.Drawing.Point(279, 179);
            this.popupContainerControl1.Name = "popupContainerControl1";
            this.popupContainerControl1.Size = new System.Drawing.Size(608, 365);
            this.popupContainerControl1.TabIndex = 15;
            // 
            // panelControlPopUp_CustomerTitle
            // 
            this.panelControlPopUp_CustomerTitle.Controls.Add(this.labelControl7);
            this.panelControlPopUp_CustomerTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlPopUp_CustomerTitle.Location = new System.Drawing.Point(0, 0);
            this.panelControlPopUp_CustomerTitle.Name = "panelControlPopUp_CustomerTitle";
            this.panelControlPopUp_CustomerTitle.Size = new System.Drawing.Size(608, 53);
            this.panelControlPopUp_CustomerTitle.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton_Cancel);
            this.panelControl1.Controls.Add(this.simpleButton_EnterCustomer);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 303);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(608, 62);
            this.panelControl1.TabIndex = 1;
            // 
            // txt_InputCusName
            // 
            this.txt_InputCusName.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_InputCusName.Location = new System.Drawing.Point(273, 86);
            this.txt_InputCusName.Name = "txt_InputCusName";
            this.txt_InputCusName.Size = new System.Drawing.Size(208, 29);
            this.txt_InputCusName.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(134, 235);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 22);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Email:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(134, 184);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(104, 22);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Số điện thoại";
            // 
            // txt_InputAddress
            // 
            this.txt_InputAddress.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_InputAddress.Location = new System.Drawing.Point(273, 134);
            this.txt_InputAddress.Name = "txt_InputAddress";
            this.txt_InputAddress.Size = new System.Drawing.Size(208, 29);
            this.txt_InputAddress.TabIndex = 5;
            // 
            // txt_InputEmail
            // 
            this.txt_InputEmail.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_InputEmail.Location = new System.Drawing.Point(273, 232);
            this.txt_InputEmail.Name = "txt_InputEmail";
            this.txt_InputEmail.Size = new System.Drawing.Size(208, 29);
            this.txt_InputEmail.TabIndex = 6;
            // 
            // labelControl_CustomerName
            // 
            this.labelControl_CustomerName.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl_CustomerName.Appearance.Options.UseFont = true;
            this.labelControl_CustomerName.Location = new System.Drawing.Point(134, 89);
            this.labelControl_CustomerName.Name = "labelControl_CustomerName";
            this.labelControl_CustomerName.Size = new System.Drawing.Size(127, 22);
            this.labelControl_CustomerName.TabIndex = 10;
            this.labelControl_CustomerName.Text = "Tên khách hàng";
            // 
            // txt_InputPhone
            // 
            this.txt_InputPhone.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_InputPhone.Location = new System.Drawing.Point(273, 181);
            this.txt_InputPhone.Name = "txt_InputPhone";
            this.txt_InputPhone.Size = new System.Drawing.Size(208, 29);
            this.txt_InputPhone.TabIndex = 7;
            // 
            // labelControl_CustomerAddress
            // 
            this.labelControl_CustomerAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl_CustomerAddress.Appearance.Options.UseFont = true;
            this.labelControl_CustomerAddress.Location = new System.Drawing.Point(134, 137);
            this.labelControl_CustomerAddress.Name = "labelControl_CustomerAddress";
            this.labelControl_CustomerAddress.Size = new System.Drawing.Size(54, 22);
            this.labelControl_CustomerAddress.TabIndex = 11;
            this.labelControl_CustomerAddress.Text = "Địa chỉ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(157, 15);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(283, 25);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Nhập thông tin khách hàng";
            // 
            // simpleButton_EnterCustomer
            // 
            this.simpleButton_EnterCustomer.Location = new System.Drawing.Point(486, 20);
            this.simpleButton_EnterCustomer.Name = "simpleButton_EnterCustomer";
            this.simpleButton_EnterCustomer.Size = new System.Drawing.Size(86, 26);
            this.simpleButton_EnterCustomer.TabIndex = 0;
            this.simpleButton_EnterCustomer.Text = "Xác nhận";
            // 
            // simpleButton_Cancel
            // 
            this.simpleButton_Cancel.Location = new System.Drawing.Point(382, 20);
            this.simpleButton_Cancel.Name = "simpleButton_Cancel";
            this.simpleButton_Cancel.Size = new System.Drawing.Size(86, 26);
            this.simpleButton_Cancel.TabIndex = 1;
            this.simpleButton_Cancel.Text = "Hủy";
            this.simpleButton_Cancel.Click += new System.EventHandler(this.simpleButton_Cancel_Click);
            // 
            // frm_SellMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.popupContainerControl1);
            this.Controls.Add(this.popupContainerControl_Receipt);
            this.Controls.Add(this.groupControl_SellCart);
            this.Controls.Add(this.group_MedicationInfo);
            this.Controls.Add(this.listBox_AvailableMedicine);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.txt_SearchMedicine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ShowIcon = false;
            this.Name = "frm_SellMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Medicine";
            this.Load += new System.EventHandler(this.frm_SellMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel_Title)).EndInit();
            this.panel_Title.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SellCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl_Receipt)).EndInit();
            this.popupContainerControl_Receipt.ResumeLayout(false);
            this.panel_PopupTitle.ResumeLayout(false);
            this.panel_MainReceipt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ReceiptContent)).EndInit();
            this.groupControl_ReceiptContent.ResumeLayout(false);
            this.panel_ReceiptTotal.ResumeLayout(false);
            this.panel_ReceiptTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETDONTHUOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ReceiptDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_CustomerInfo)).EndInit();
            this.groupControl_CustomerInfo.ResumeLayout(false);
            this.groupControl_CustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_ReceiptInfo)).EndInit();
            this.panel_ReceiptInfo.ResumeLayout(false);
            this.panel_ReceiptInfo.PerformLayout();
            this.panel_ReceiptTitle.ResumeLayout(false);
            this.panel_ReceiptTitle.PerformLayout();
            this.panel_ReceiptButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).EndInit();
            this.popupContainerControl1.ResumeLayout(false);
            this.popupContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlPopUp_CustomerTitle)).EndInit();
            this.panelControlPopUp_CustomerTitle.ResumeLayout(false);
            this.panelControlPopUp_CustomerTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_SearchMedicine;
        private DevExpress.XtraEditors.PanelControl panel_Title;
        private System.Windows.Forms.Label label_Title;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txt_TotalCartPrice;
        private DevExpress.XtraEditors.SimpleButton btn_Discard;
        private DevExpress.XtraEditors.SimpleButton btn_AddToCart;
        private DevExpress.XtraEditors.ListBoxControl listBox_AvailableMedicine;
        private DevExpress.XtraEditors.GroupControl group_MedicationInfo;
        private System.Windows.Forms.TextBox txt_PricePerUnit;
        private System.Windows.Forms.TextBox txt_ID;
        private DevExpress.XtraEditors.LabelControl label_ProductionDate;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_TotalPrice;
        private System.Windows.Forms.NumericUpDown numUpDown_BuyAmount;
        private DevExpress.XtraEditors.LabelControl label_BuyAmount;
        private DevExpress.XtraEditors.LabelControl label_MedicineID;
        private DevExpress.XtraEditors.LabelControl label_MedicineName;
        private DevExpress.XtraEditors.LabelControl label_TotalPrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl_MedicationInfo;
        private DevExpress.XtraEditors.GroupControl groupControl_SellCart;
        private DevExpress.XtraEditors.PanelControl panelControl_BottomCartControls;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Checkout;
        private System.Windows.Forms.ComboBox cbb_ProductionDate;
        private System.Windows.Forms.TextBox txt_ExpDate;
        private System.Windows.Forms.DataGridView dgv_SellCart;
        private System.Windows.Forms.CheckBox check_SaveCustomerInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MedicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TotalPrice;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl_Receipt;
        private System.Windows.Forms.Panel panel_PopupTitle;
        private DevExpress.XtraEditors.LabelControl label_Receipt;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private DevExpress.XtraEditors.GroupControl groupControl_CustomerInfo;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl_Email;
        private DevExpress.XtraEditors.LabelControl labelControl_PhoneNumber;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private DevExpress.XtraEditors.LabelControl label_CustomerName;
        private System.Windows.Forms.TextBox textBox4;
        private DevExpress.XtraEditors.LabelControl labelControl_Address;
        private DevExpress.XtraEditors.PanelControl panel_ReceiptInfo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl label_Employee;
        private DevExpress.XtraEditors.LabelControl labelControl_ReceiptId;
        private System.Windows.Forms.TextBox txt_;
        private System.Windows.Forms.TextBox txt_EmployeeMade;
        private System.Windows.Forms.TextBox txt_ReceiptId;
        private System.Windows.Forms.Panel panel_MainReceipt;
        private DevExpress.XtraEditors.GroupControl groupControl_ReceiptContent;
        private System.Windows.Forms.Panel panel_ReceiptTitle;
        private System.Windows.Forms.Panel panel_ReceiptButton;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ReceiptDetail;
        private DevExpress.XtraEditors.SimpleButton btn_SkipPrint;
        private DevExpress.XtraEditors.SimpleButton btn_PrintReceipt;
        private System.Windows.Forms.BindingSource cHITIETDONTHUOCBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDonThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colMaThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayHetHan;
        private System.Windows.Forms.Panel panel_ReceiptTotal;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.TextBox textBox3;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl1;
        private System.Windows.Forms.TextBox txt_InputCusName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PanelControl panelControlPopUp_CustomerTitle;
        private System.Windows.Forms.TextBox txt_InputAddress;
        private DevExpress.XtraEditors.LabelControl labelControl_CustomerAddress;
        private System.Windows.Forms.TextBox txt_InputEmail;
        private System.Windows.Forms.TextBox txt_InputPhone;
        private DevExpress.XtraEditors.LabelControl labelControl_CustomerName;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Cancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton_EnterCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}