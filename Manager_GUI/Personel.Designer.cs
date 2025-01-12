namespace Manager_GUI
{
    partial class frm_Personel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_TitleAdd = new System.Windows.Forms.Label();
            this.dgv_Personel = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dateborn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_firstday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_idwork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ckb_Female = new System.Windows.Forms.CheckBox();
            this.ckb_Male = new System.Windows.Forms.CheckBox();
            this.dtp_dateborn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.cmb_id = new System.Windows.Forms.ComboBox();
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.dtp_firstdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_TitleAdd
            // 
            this.label_TitleAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_TitleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TitleAdd.Location = new System.Drawing.Point(0, 0);
            this.label_TitleAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TitleAdd.Name = "label_TitleAdd";
            this.label_TitleAdd.Size = new System.Drawing.Size(1671, 90);
            this.label_TitleAdd.TabIndex = 107;
            this.label_TitleAdd.Text = "Quản lý nhân viên";
            this.label_TitleAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_Personel
            // 
            this.dgv_Personel.AllowUserToAddRows = false;
            this.dgv_Personel.AllowUserToDeleteRows = false;
            this.dgv_Personel.AllowUserToResizeColumns = false;
            this.dgv_Personel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Personel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Personel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Personel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Personel.ColumnHeadersHeight = 50;
            this.dgv_Personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Personel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_name,
            this.col_dateborn,
            this.col_sex,
            this.col_address,
            this.col_number,
            this.col_email,
            this.col_firstday,
            this.col_idwork,
            this.col_IDshop});
            this.dgv_Personel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Personel.Location = new System.Drawing.Point(2, 28);
            this.dgv_Personel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Personel.Name = "dgv_Personel";
            this.dgv_Personel.ReadOnly = true;
            this.dgv_Personel.RowHeadersVisible = false;
            this.dgv_Personel.RowHeadersWidth = 47;
            this.dgv_Personel.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Personel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Personel.Size = new System.Drawing.Size(1667, 449);
            this.dgv_Personel.TabIndex = 108;
            this.dgv_Personel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Personel_CellClick);
            this.dgv_Personel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Personel_CellContentClick);
            // 
            // col_id
            // 
            this.col_id.HeaderText = "Mã nhân viên";
            this.col_id.MinimumWidth = 6;
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // col_name
            // 
            this.col_name.HeaderText = "Họ tên";
            this.col_name.MinimumWidth = 6;
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            // 
            // col_dateborn
            // 
            this.col_dateborn.HeaderText = "Ngày sinh";
            this.col_dateborn.MinimumWidth = 6;
            this.col_dateborn.Name = "col_dateborn";
            this.col_dateborn.ReadOnly = true;
            // 
            // col_sex
            // 
            this.col_sex.HeaderText = "Giới tính";
            this.col_sex.MinimumWidth = 6;
            this.col_sex.Name = "col_sex";
            this.col_sex.ReadOnly = true;
            // 
            // col_address
            // 
            this.col_address.HeaderText = "Địa chỉ";
            this.col_address.MinimumWidth = 6;
            this.col_address.Name = "col_address";
            this.col_address.ReadOnly = true;
            // 
            // col_number
            // 
            this.col_number.HeaderText = "Số điện thoại";
            this.col_number.MinimumWidth = 6;
            this.col_number.Name = "col_number";
            this.col_number.ReadOnly = true;
            // 
            // col_email
            // 
            this.col_email.HeaderText = "Email";
            this.col_email.MinimumWidth = 6;
            this.col_email.Name = "col_email";
            this.col_email.ReadOnly = true;
            // 
            // col_firstday
            // 
            this.col_firstday.HeaderText = "Ngày vào làm";
            this.col_firstday.MinimumWidth = 6;
            this.col_firstday.Name = "col_firstday";
            this.col_firstday.ReadOnly = true;
            // 
            // col_idwork
            // 
            this.col_idwork.HeaderText = "Tên chức vụ";
            this.col_idwork.MinimumWidth = 6;
            this.col_idwork.Name = "col_idwork";
            this.col_idwork.ReadOnly = true;
            // 
            // col_IDshop
            // 
            this.col_IDshop.HeaderText = "Tên chi nhánh";
            this.col_IDshop.MinimumWidth = 6;
            this.col_IDshop.Name = "col_IDshop";
            this.col_IDshop.ReadOnly = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgv_Personel);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 371);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1671, 479);
            this.groupControl1.TabIndex = 109;
            this.groupControl1.Text = "bảng Nhân viên";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 90);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ckb_Female);
            this.splitContainer1.Panel1.Controls.Add(this.ckb_Male);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_dateborn);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_address);
            this.splitContainer1.Panel1.Controls.Add(this.txt_name);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Id);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.cmb_id);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_position);
            this.splitContainer1.Panel2.Controls.Add(this.dtp_firstdate);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txt_email);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txt_number);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Size = new System.Drawing.Size(1671, 210);
            this.splitContainer1.SplitterDistance = 801;
            this.splitContainer1.TabIndex = 110;
            // 
            // ckb_Female
            // 
            this.ckb_Female.AutoSize = true;
            this.ckb_Female.Location = new System.Drawing.Point(419, 142);
            this.ckb_Female.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckb_Female.Name = "ckb_Female";
            this.ckb_Female.Size = new System.Drawing.Size(46, 20);
            this.ckb_Female.TabIndex = 118;
            this.ckb_Female.Text = "Nữ";
            this.ckb_Female.UseVisualStyleBackColor = true;
            this.ckb_Female.CheckedChanged += new System.EventHandler(this.ckb_Female_CheckedChanged);
            // 
            // ckb_Male
            // 
            this.ckb_Male.AutoSize = true;
            this.ckb_Male.Location = new System.Drawing.Point(191, 142);
            this.ckb_Male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckb_Male.Name = "ckb_Male";
            this.ckb_Male.Size = new System.Drawing.Size(58, 20);
            this.ckb_Male.TabIndex = 117;
            this.ckb_Male.Text = "Nam";
            this.ckb_Male.UseVisualStyleBackColor = true;
            this.ckb_Male.CheckedChanged += new System.EventHandler(this.ckb_Male_CheckedChanged);
            // 
            // dtp_dateborn
            // 
            this.dtp_dateborn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dateborn.Location = new System.Drawing.Point(177, 89);
            this.dtp_dateborn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_dateborn.Name = "dtp_dateborn";
            this.dtp_dateborn.Size = new System.Drawing.Size(407, 22);
            this.dtp_dateborn.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 115;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 114;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 113;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 112;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 111;
            this.label1.Text = "Mã nhân viên";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(177, 172);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(407, 22);
            this.txt_address.TabIndex = 8;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(177, 48);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(407, 22);
            this.txt_name.TabIndex = 5;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(177, 2);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(407, 22);
            this.txt_Id.TabIndex = 4;
            // 
            // cmb_id
            // 
            this.cmb_id.FormattingEnabled = true;
            this.cmb_id.Location = new System.Drawing.Point(211, 174);
            this.cmb_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_id.Name = "cmb_id";
            this.cmb_id.Size = new System.Drawing.Size(407, 24);
            this.cmb_id.TabIndex = 122;
            // 
            // cmb_position
            // 
            this.cmb_position.FormattingEnabled = true;
            this.cmb_position.Location = new System.Drawing.Point(211, 129);
            this.cmb_position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(407, 24);
            this.cmb_position.TabIndex = 121;
            // 
            // dtp_firstdate
            // 
            this.dtp_firstdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_firstdate.Location = new System.Drawing.Point(211, 98);
            this.dtp_firstdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_firstdate.Name = "dtp_firstdate";
            this.dtp_firstdate.Size = new System.Drawing.Size(407, 22);
            this.dtp_firstdate.TabIndex = 117;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 120;
            this.label6.Text = "Chi nhánh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 119;
            this.label7.Text = "Chức vụ";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(211, 48);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(407, 22);
            this.txt_email.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 24);
            this.label8.TabIndex = 118;
            this.label8.Text = "Ngày vào làm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 24);
            this.label9.TabIndex = 117;
            this.label9.Text = "Email";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(211, 2);
            this.txt_number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(407, 22);
            this.txt_number.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 24);
            this.label10.TabIndex = 116;
            this.label10.Text = "Số điện thoại";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Update);
            this.panelControl1.Controls.Add(this.btn_Delete);
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 300);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1671, 71);
            this.panelControl1.TabIndex = 121;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Update.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold);
            this.btn_Update.Appearance.Options.UseBackColor = true;
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Location = new System.Drawing.Point(1155, 15);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(223, 43);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Delete.Appearance.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Appearance.Options.UseBackColor = true;
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Location = new System.Drawing.Point(693, 15);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(225, 43);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Xóa";
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
            this.btn_Add.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold);
            this.btn_Add.AppearanceHovered.Options.UseFont = true;
            this.btn_Add.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold);
            this.btn_Add.AppearancePressed.Options.UseFont = true;
            this.btn_Add.Location = new System.Drawing.Point(293, 15);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(225, 43);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // frm_Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 850);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label_TitleAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.frm_Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_TitleAdd;
        private System.Windows.Forms.DataGridView dgv_Personel;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ckb_Female;
        private System.Windows.Forms.CheckBox ckb_Male;
        private System.Windows.Forms.DateTimePicker dtp_dateborn;
        private System.Windows.Forms.DateTimePicker dtp_firstdate;
        private System.Windows.Forms.ComboBox cmb_id;
        private System.Windows.Forms.ComboBox cmb_position;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dateborn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_firstday;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_idwork;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDshop;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
    }
}