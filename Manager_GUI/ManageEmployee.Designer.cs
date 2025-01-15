namespace Manager_GUI
{
    partial class frm_Employees
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
            this.label_Title = new System.Windows.Forms.Label();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ckb_Female = new System.Windows.Forms.CheckBox();
            this.ckb_Male = new System.Windows.Forms.CheckBox();
            this.dtp_dateborn = new System.Windows.Forms.DateTimePicker();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_DateOfBirth = new System.Windows.Forms.Label();
            this.label_Fullname = new System.Windows.Forms.Label();
            this.label_EmployeeId = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.cmb_Location = new System.Windows.Forms.ComboBox();
            this.cmb_Position = new System.Windows.Forms.ComboBox();
            this.dtp_firstdate = new System.Windows.Forms.DateTimePicker();
            this.label_Location = new System.Windows.Forms.Label();
            this.label_PositionName = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label_StartDate = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_dgv = new DevExpress.XtraGrid.GridControl();
            this.gridView_Employees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_StoreName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_EmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_JobName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_DateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Employees)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Title.Font = new System.Drawing.Font("Tahoma", 24.21818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(1253, 73);
            this.label_Title.TabIndex = 107;
            this.label_Title.Text = " Quản Lý Nhân Viên";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupControl
            // 
            this.groupControl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl.AppearanceCaption.Options.UseFont = true;
            this.groupControl.Controls.Add(this.gridControl_dgv);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl.Location = new System.Drawing.Point(0, 341);
            this.groupControl.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(1253, 350);
            this.groupControl.TabIndex = 109;
            this.groupControl.Text = "[ Bảng Nhân viên ]";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.DodgerBlue;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 73);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.ckb_Female);
            this.splitContainer1.Panel1.Controls.Add(this.ckb_Male);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_dateborn);
            this.splitContainer1.Panel1.Controls.Add(this.label_Address);
            this.splitContainer1.Panel1.Controls.Add(this.label_Gender);
            this.splitContainer1.Panel1.Controls.Add(this.label_DateOfBirth);
            this.splitContainer1.Panel1.Controls.Add(this.label_Fullname);
            this.splitContainer1.Panel1.Controls.Add(this.label_EmployeeId);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Address);
            this.splitContainer1.Panel1.Controls.Add(this.txt_name);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Id);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.cmb_Location);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_Position);
            this.splitContainer1.Panel2.Controls.Add(this.dtp_firstdate);
            this.splitContainer1.Panel2.Controls.Add(this.label_Location);
            this.splitContainer1.Panel2.Controls.Add(this.label_PositionName);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Email);
            this.splitContainer1.Panel2.Controls.Add(this.label_StartDate);
            this.splitContainer1.Panel2.Controls.Add(this.label_Email);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Number);
            this.splitContainer1.Panel2.Controls.Add(this.label_PhoneNumber);
            this.splitContainer1.Size = new System.Drawing.Size(1253, 210);
            this.splitContainer1.SplitterDistance = 621;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 110;
            // 
            // ckb_Female
            // 
            this.ckb_Female.AutoSize = true;
            this.ckb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckb_Female.Location = new System.Drawing.Point(296, 134);
            this.ckb_Female.Margin = new System.Windows.Forms.Padding(2);
            this.ckb_Female.Name = "ckb_Female";
            this.ckb_Female.Size = new System.Drawing.Size(52, 26);
            this.ckb_Female.TabIndex = 118;
            this.ckb_Female.Text = "Nữ";
            this.ckb_Female.UseVisualStyleBackColor = true;
            this.ckb_Female.CheckedChanged += new System.EventHandler(this.ckb_Female_CheckedChanged);
            // 
            // ckb_Male
            // 
            this.ckb_Male.AutoSize = true;
            this.ckb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckb_Male.Location = new System.Drawing.Point(215, 134);
            this.ckb_Male.Margin = new System.Windows.Forms.Padding(2);
            this.ckb_Male.Name = "ckb_Male";
            this.ckb_Male.Size = new System.Drawing.Size(66, 26);
            this.ckb_Male.TabIndex = 117;
            this.ckb_Male.Text = "Nam";
            this.ckb_Male.UseVisualStyleBackColor = true;
            this.ckb_Male.CheckedChanged += new System.EventHandler(this.ckb_Male_CheckedChanged);
            // 
            // dtp_dateborn
            // 
            this.dtp_dateborn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_dateborn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dateborn.Location = new System.Drawing.Point(213, 90);
            this.dtp_dateborn.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_dateborn.Name = "dtp_dateborn";
            this.dtp_dateborn.Size = new System.Drawing.Size(306, 27);
            this.dtp_dateborn.TabIndex = 116;
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Address.Location = new System.Drawing.Point(75, 175);
            this.label_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(67, 23);
            this.label_Address.TabIndex = 115;
            this.label_Address.Text = "Địa chỉ";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gender.Location = new System.Drawing.Point(75, 133);
            this.label_Gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(79, 23);
            this.label_Gender.TabIndex = 114;
            this.label_Gender.Text = "Giới tính";
            // 
            // label_DateOfBirth
            // 
            this.label_DateOfBirth.AutoSize = true;
            this.label_DateOfBirth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateOfBirth.Location = new System.Drawing.Point(75, 91);
            this.label_DateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DateOfBirth.Name = "label_DateOfBirth";
            this.label_DateOfBirth.Size = new System.Drawing.Size(93, 23);
            this.label_DateOfBirth.TabIndex = 113;
            this.label_DateOfBirth.Text = "Ngày sinh";
            // 
            // label_Fullname
            // 
            this.label_Fullname.AutoSize = true;
            this.label_Fullname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fullname.Location = new System.Drawing.Point(76, 51);
            this.label_Fullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Fullname.Name = "label_Fullname";
            this.label_Fullname.Size = new System.Drawing.Size(66, 23);
            this.label_Fullname.TabIndex = 112;
            this.label_Fullname.Text = "Họ tên";
            // 
            // label_EmployeeId
            // 
            this.label_EmployeeId.AutoSize = true;
            this.label_EmployeeId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EmployeeId.Location = new System.Drawing.Point(75, 5);
            this.label_EmployeeId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_EmployeeId.Name = "label_EmployeeId";
            this.label_EmployeeId.Size = new System.Drawing.Size(124, 23);
            this.label_EmployeeId.TabIndex = 111;
            this.label_EmployeeId.Text = "Mã nhân viên";
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Address.Location = new System.Drawing.Point(213, 174);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(306, 27);
            this.txt_Address.TabIndex = 8;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_name.Location = new System.Drawing.Point(215, 50);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(306, 27);
            this.txt_name.TabIndex = 5;
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Id.Location = new System.Drawing.Point(213, 8);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(306, 27);
            this.txt_Id.TabIndex = 4;
            // 
            // cmb_Location
            // 
            this.cmb_Location.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmb_Location.FormattingEnabled = true;
            this.cmb_Location.Location = new System.Drawing.Point(225, 172);
            this.cmb_Location.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Location.Name = "cmb_Location";
            this.cmb_Location.Size = new System.Drawing.Size(306, 30);
            this.cmb_Location.TabIndex = 122;
            // 
            // cmb_Position
            // 
            this.cmb_Position.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmb_Position.FormattingEnabled = true;
            this.cmb_Position.Location = new System.Drawing.Point(225, 130);
            this.cmb_Position.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Position.Name = "cmb_Position";
            this.cmb_Position.Size = new System.Drawing.Size(306, 30);
            this.cmb_Position.TabIndex = 121;
            // 
            // dtp_firstdate
            // 
            this.dtp_firstdate.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_firstdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_firstdate.Location = new System.Drawing.Point(225, 88);
            this.dtp_firstdate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_firstdate.Name = "dtp_firstdate";
            this.dtp_firstdate.Size = new System.Drawing.Size(306, 29);
            this.dtp_firstdate.TabIndex = 117;
            // 
            // label_Location
            // 
            this.label_Location.AutoSize = true;
            this.label_Location.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Location.Location = new System.Drawing.Point(76, 175);
            this.label_Location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Location.Name = "label_Location";
            this.label_Location.Size = new System.Drawing.Size(96, 23);
            this.label_Location.TabIndex = 120;
            this.label_Location.Text = "Chi nhánh";
            // 
            // label_PositionName
            // 
            this.label_PositionName.AutoSize = true;
            this.label_PositionName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PositionName.Location = new System.Drawing.Point(76, 133);
            this.label_PositionName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_PositionName.Name = "label_PositionName";
            this.label_PositionName.Size = new System.Drawing.Size(79, 23);
            this.label_PositionName.TabIndex = 119;
            this.label_PositionName.Text = "Chức vụ";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Email.Location = new System.Drawing.Point(225, 48);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(306, 29);
            this.txt_Email.TabIndex = 10;
            // 
            // label_StartDate
            // 
            this.label_StartDate.AutoSize = true;
            this.label_StartDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StartDate.Location = new System.Drawing.Point(76, 91);
            this.label_StartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StartDate.Name = "label_StartDate";
            this.label_StartDate.Size = new System.Drawing.Size(124, 23);
            this.label_StartDate.TabIndex = 118;
            this.label_StartDate.Text = "Ngày vào làm";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(76, 52);
            this.label_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(55, 23);
            this.label_Email.TabIndex = 117;
            this.label_Email.Text = "Email";
            // 
            // txt_Number
            // 
            this.txt_Number.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Number.Location = new System.Drawing.Point(225, 6);
            this.txt_Number.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(306, 29);
            this.txt_Number.TabIndex = 9;
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PhoneNumber.Location = new System.Drawing.Point(76, 12);
            this.label_PhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(120, 23);
            this.label_PhoneNumber.TabIndex = 116;
            this.label_PhoneNumber.Text = "Số điện thoại";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Update);
            this.panelControl1.Controls.Add(this.btn_Delete);
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 283);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1253, 58);
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
            this.btn_Update.Location = new System.Drawing.Point(1072, 13);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(167, 35);
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
            this.btn_Delete.Location = new System.Drawing.Point(856, 13);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(169, 35);
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
            this.btn_Add.Location = new System.Drawing.Point(643, 13);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(169, 35);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // gridControl_dgv
            // 
            this.gridControl_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_dgv.Location = new System.Drawing.Point(2, 26);
            this.gridControl_dgv.MainView = this.gridView_Employees;
            this.gridControl_dgv.Name = "gridControl_dgv";
            this.gridControl_dgv.Size = new System.Drawing.Size(1249, 322);
            this.gridControl_dgv.TabIndex = 0;
            this.gridControl_dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Employees});
            // 
            // gridView_Employees
            // 
            this.gridView_Employees.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView_Employees.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView_Employees.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView_Employees.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_Employees.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_Employees.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_Employees.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_Employees.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView_Employees.Appearance.Row.Options.UseFont = true;
            this.gridView_Employees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_StoreName,
            this.col_EmployeeName,
            this.col_DateOfBirth,
            this.col_JobName});
            this.gridView_Employees.GridControl = this.gridControl_dgv;
            this.gridView_Employees.GroupPanelText = " ";
            this.gridView_Employees.Name = "gridView_Employees";
            // 
            // col_StoreName
            // 
            this.col_StoreName.Caption = "Tên Chi Nhánh";
            this.col_StoreName.FieldName = "col_StoreName";
            this.col_StoreName.MinWidth = 23;
            this.col_StoreName.Name = "col_StoreName";
            this.col_StoreName.Visible = true;
            this.col_StoreName.VisibleIndex = 0;
            this.col_StoreName.Width = 86;
            // 
            // col_EmployeeName
            // 
            this.col_EmployeeName.Caption = "Tên Nhân Viên";
            this.col_EmployeeName.FieldName = "col_EmployeeName";
            this.col_EmployeeName.MinWidth = 23;
            this.col_EmployeeName.Name = "col_EmployeeName";
            this.col_EmployeeName.Visible = true;
            this.col_EmployeeName.VisibleIndex = 1;
            this.col_EmployeeName.Width = 86;
            // 
            // col_JobName
            // 
            this.col_JobName.Caption = "Chức Vụ";
            this.col_JobName.FieldName = "col_JobName";
            this.col_JobName.MinWidth = 23;
            this.col_JobName.Name = "col_JobName";
            this.col_JobName.Visible = true;
            this.col_JobName.VisibleIndex = 2;
            this.col_JobName.Width = 86;
            // 
            // col_DateOfBirth
            // 
            this.col_DateOfBirth.Caption = "Ngày Sinh";
            this.col_DateOfBirth.FieldName = "col_DateOfBirth";
            this.col_DateOfBirth.MinWidth = 23;
            this.col_DateOfBirth.Name = "col_DateOfBirth";
            this.col_DateOfBirth.Visible = true;
            this.col_DateOfBirth.VisibleIndex = 3;
            this.col_DateOfBirth.Width = 86;
            // 
            // frm_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 691);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.frm_Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Employees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_DateOfBirth;
        private System.Windows.Forms.Label label_Fullname;
        private System.Windows.Forms.Label label_EmployeeId;
        private System.Windows.Forms.Label label_Location;
        private System.Windows.Forms.Label label_PositionName;
        private System.Windows.Forms.Label label_StartDate;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.CheckBox ckb_Female;
        private System.Windows.Forms.CheckBox ckb_Male;
        private System.Windows.Forms.DateTimePicker dtp_dateborn;
        private System.Windows.Forms.DateTimePicker dtp_firstdate;
        private System.Windows.Forms.ComboBox cmb_Location;
        private System.Windows.Forms.ComboBox cmb_Position;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraGrid.GridControl gridControl_dgv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Employees;
        private DevExpress.XtraGrid.Columns.GridColumn col_StoreName;
        private DevExpress.XtraGrid.Columns.GridColumn col_EmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn col_JobName;
        private DevExpress.XtraGrid.Columns.GridColumn col_DateOfBirth;
    }
}