namespace Manager_GUI
{
    partial class frm_Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Accounts));
            this.label_Account = new System.Windows.Forms.Label();
            this.label_AccountID = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.groupControl_dgv = new DevExpress.XtraEditors.GroupControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView_AccountDetaiis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_AccountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_EmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_AccountStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_LastUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_AccountId = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.label_AccountStatus = new System.Windows.Forms.Label();
            this.cbb_AccountStatus = new System.Windows.Forms.ComboBox();
            this.btn_SearchForEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.label_EmployeeName = new System.Windows.Forms.Label();
            this.txt_EmployeeId = new System.Windows.Forms.TextBox();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label_ConfirmPassword = new System.Windows.Forms.Label();
            this.panelControl_Buttons = new DevExpress.XtraEditors.PanelControl();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.popupContainerControl_GetEmployee = new DevExpress.XtraEditors.PopupContainerControl();
            this.listBox_SearchEmployeeByName = new System.Windows.Forms.ListBox();
            this.panel_PopupButtons = new System.Windows.Forms.Panel();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Confirm = new DevExpress.XtraEditors.SimpleButton();
            this.panel_InputEmployee = new System.Windows.Forms.Panel();
            this.label_SearchEmployeeName = new System.Windows.Forms.Label();
            this.txt_SearchEmployeeByName = new System.Windows.Forms.TextBox();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_dgv)).BeginInit();
            this.groupControl_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_AccountDetaiis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_Buttons)).BeginInit();
            this.panelControl_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl_GetEmployee)).BeginInit();
            this.popupContainerControl_GetEmployee.SuspendLayout();
            this.panel_PopupButtons.SuspendLayout();
            this.panel_InputEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Account
            // 
            this.label_Account.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Account.Location = new System.Drawing.Point(0, 0);
            this.label_Account.Name = "label_Account";
            this.label_Account.Size = new System.Drawing.Size(1280, 73);
            this.label_Account.TabIndex = 106;
            this.label_Account.Text = "Tài Khoản ";
            this.label_Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_AccountID
            // 
            this.label_AccountID.AutoSize = true;
            this.label_AccountID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccountID.Location = new System.Drawing.Point(11, 18);
            this.label_AccountID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_AccountID.Name = "label_AccountID";
            this.label_AccountID.Size = new System.Drawing.Size(125, 23);
            this.label_AccountID.TabIndex = 0;
            this.label_AccountID.Text = "Mã Tài Khoản";
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.Location = new System.Drawing.Point(38, 13);
            this.label_UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(138, 23);
            this.label_UserName.TabIndex = 1;
            this.label_UserName.Text = "Tên Tài Khoản ";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(38, 71);
            this.label_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(90, 23);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Mật Khẩu";
            // 
            // groupControl_dgv
            // 
            this.groupControl_dgv.Controls.Add(this.gridControl);
            this.groupControl_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_dgv.Location = new System.Drawing.Point(0, 302);
            this.groupControl_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl_dgv.Name = "groupControl_dgv";
            this.groupControl_dgv.Size = new System.Drawing.Size(1280, 418);
            this.groupControl_dgv.TabIndex = 121;
            this.groupControl_dgv.Text = "Bảng Tài Khoản ";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = typeof(PharmacistManagement_DAL.Model.TAIKHOAN);
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 26);
            this.gridControl.MainView = this.gridView_AccountDetaiis;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1276, 390);
            this.gridControl.TabIndex = 110;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_AccountDetaiis});
            // 
            // gridView_AccountDetaiis
            // 
            this.gridView_AccountDetaiis.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView_AccountDetaiis.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView_AccountDetaiis.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView_AccountDetaiis.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_AccountDetaiis.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_AccountDetaiis.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_AccountDetaiis.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_AccountDetaiis.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView_AccountDetaiis.Appearance.Row.Options.UseFont = true;
            this.gridView_AccountDetaiis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_AccountID,
            this.col_UserName,
            this.col_EmployeeName,
            this.col_AccountStatus,
            this.col_LastUpdated});
            this.gridView_AccountDetaiis.GridControl = this.gridControl;
            this.gridView_AccountDetaiis.GroupPanelText = " ";
            this.gridView_AccountDetaiis.Name = "gridView_AccountDetaiis";
            this.gridView_AccountDetaiis.OptionsBehavior.Editable = false;
            this.gridView_AccountDetaiis.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_AccountDetaiis_RowCellClick);
            // 
            // col_AccountID
            // 
            this.col_AccountID.Caption = "Mã Tài Khoản";
            this.col_AccountID.FieldName = "col_AccountID";
            this.col_AccountID.MinWidth = 23;
            this.col_AccountID.Name = "col_AccountID";
            this.col_AccountID.Visible = true;
            this.col_AccountID.VisibleIndex = 0;
            this.col_AccountID.Width = 86;
            // 
            // col_UserName
            // 
            this.col_UserName.Caption = "Tên Tài Khoản";
            this.col_UserName.FieldName = "col_UserName";
            this.col_UserName.MinWidth = 23;
            this.col_UserName.Name = "col_UserName";
            this.col_UserName.Visible = true;
            this.col_UserName.VisibleIndex = 1;
            this.col_UserName.Width = 86;
            // 
            // col_EmployeeName
            // 
            this.col_EmployeeName.Caption = "Tên Nhân Viên";
            this.col_EmployeeName.FieldName = "col_EmployeeName";
            this.col_EmployeeName.MinWidth = 23;
            this.col_EmployeeName.Name = "col_EmployeeName";
            this.col_EmployeeName.Visible = true;
            this.col_EmployeeName.VisibleIndex = 2;
            this.col_EmployeeName.Width = 86;
            // 
            // col_AccountStatus
            // 
            this.col_AccountStatus.Caption = "Trạng Thái";
            this.col_AccountStatus.FieldName = "col_AccountStatus";
            this.col_AccountStatus.MinWidth = 23;
            this.col_AccountStatus.Name = "col_AccountStatus";
            this.col_AccountStatus.Visible = true;
            this.col_AccountStatus.VisibleIndex = 3;
            this.col_AccountStatus.Width = 86;
            // 
            // col_LastUpdated
            // 
            this.col_LastUpdated.Caption = "Lần Cuối Cập Nhật";
            this.col_LastUpdated.DisplayFormat.FormatString = "dd/MM/yyyy - hh-mm-ss";
            this.col_LastUpdated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.col_LastUpdated.FieldName = "col_LastUpdated";
            this.col_LastUpdated.MinWidth = 23;
            this.col_LastUpdated.Name = "col_LastUpdated";
            this.col_LastUpdated.Visible = true;
            this.col_LastUpdated.VisibleIndex = 4;
            this.col_LastUpdated.Width = 86;
            // 
            // txt_AccountId
            // 
            this.txt_AccountId.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_AccountId.Location = new System.Drawing.Point(160, 16);
            this.txt_AccountId.Margin = new System.Windows.Forms.Padding(2);
            this.txt_AccountId.Name = "txt_AccountId";
            this.txt_AccountId.Size = new System.Drawing.Size(322, 28);
            this.txt_AccountId.TabIndex = 3;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_UserName.Location = new System.Drawing.Point(252, 15);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(341, 29);
            this.txt_UserName.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Password.Location = new System.Drawing.Point(252, 68);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(341, 29);
            this.txt_Password.TabIndex = 5;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.DodgerBlue;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer.Location = new System.Drawing.Point(0, 73);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel1.Controls.Add(this.label_AccountStatus);
            this.splitContainer.Panel1.Controls.Add(this.cbb_AccountStatus);
            this.splitContainer.Panel1.Controls.Add(this.label_AccountID);
            this.splitContainer.Panel1.Controls.Add(this.btn_SearchForEmployee);
            this.splitContainer.Panel1.Controls.Add(this.label_EmployeeName);
            this.splitContainer.Panel1.Controls.Add(this.txt_AccountId);
            this.splitContainer.Panel1.Controls.Add(this.txt_EmployeeId);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel2.Controls.Add(this.txt_ConfirmPassword);
            this.splitContainer.Panel2.Controls.Add(this.label_ConfirmPassword);
            this.splitContainer.Panel2.Controls.Add(this.txt_Password);
            this.splitContainer.Panel2.Controls.Add(this.txt_UserName);
            this.splitContainer.Panel2.Controls.Add(this.label_UserName);
            this.splitContainer.Panel2.Controls.Add(this.label_Password);
            this.splitContainer.Size = new System.Drawing.Size(1280, 169);
            this.splitContainer.SplitterDistance = 635;
            this.splitContainer.SplitterWidth = 10;
            this.splitContainer.TabIndex = 122;
            // 
            // label_AccountStatus
            // 
            this.label_AccountStatus.AutoSize = true;
            this.label_AccountStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccountStatus.Location = new System.Drawing.Point(11, 125);
            this.label_AccountStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_AccountStatus.Name = "label_AccountStatus";
            this.label_AccountStatus.Size = new System.Drawing.Size(97, 23);
            this.label_AccountStatus.TabIndex = 117;
            this.label_AccountStatus.Text = "Trạng thái";
            // 
            // cbb_AccountStatus
            // 
            this.cbb_AccountStatus.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_AccountStatus.FormattingEnabled = true;
            this.cbb_AccountStatus.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.cbb_AccountStatus.Location = new System.Drawing.Point(160, 123);
            this.cbb_AccountStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_AccountStatus.Name = "cbb_AccountStatus";
            this.cbb_AccountStatus.Size = new System.Drawing.Size(256, 29);
            this.cbb_AccountStatus.TabIndex = 116;
            // 
            // btn_SearchForEmployee
            // 
            this.btn_SearchForEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SearchForEmployee.AutoSize = true;
            this.btn_SearchForEmployee.AutoWidthInLayoutControl = true;
            this.btn_SearchForEmployee.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_SearchForEmployee.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_SearchForEmployee.ImageOptions.SvgImage")));
            this.btn_SearchForEmployee.Location = new System.Drawing.Point(528, 57);
            this.btn_SearchForEmployee.MaximumSize = new System.Drawing.Size(40, 40);
            this.btn_SearchForEmployee.MinimumSize = new System.Drawing.Size(40, 40);
            this.btn_SearchForEmployee.Name = "btn_SearchForEmployee";
            this.btn_SearchForEmployee.Size = new System.Drawing.Size(40, 40);
            this.btn_SearchForEmployee.TabIndex = 115;
            this.btn_SearchForEmployee.Click += new System.EventHandler(this.btn_SearchForEmployee_Click);
            // 
            // label_EmployeeName
            // 
            this.label_EmployeeName.AutoSize = true;
            this.label_EmployeeName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EmployeeName.Location = new System.Drawing.Point(11, 71);
            this.label_EmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_EmployeeName.Name = "label_EmployeeName";
            this.label_EmployeeName.Size = new System.Drawing.Size(126, 23);
            this.label_EmployeeName.TabIndex = 6;
            this.label_EmployeeName.Text = "Mã Nhân viên";
            // 
            // txt_EmployeeId
            // 
            this.txt_EmployeeId.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_EmployeeId.Location = new System.Drawing.Point(160, 69);
            this.txt_EmployeeId.Margin = new System.Windows.Forms.Padding(2);
            this.txt_EmployeeId.Name = "txt_EmployeeId";
            this.txt_EmployeeId.Size = new System.Drawing.Size(322, 28);
            this.txt_EmployeeId.TabIndex = 8;
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(252, 123);
            this.txt_ConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(341, 29);
            this.txt_ConfirmPassword.TabIndex = 7;
            // 
            // label_ConfirmPassword
            // 
            this.label_ConfirmPassword.AutoSize = true;
            this.label_ConfirmPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConfirmPassword.Location = new System.Drawing.Point(38, 126);
            this.label_ConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ConfirmPassword.Name = "label_ConfirmPassword";
            this.label_ConfirmPassword.Size = new System.Drawing.Size(174, 23);
            this.label_ConfirmPassword.TabIndex = 6;
            this.label_ConfirmPassword.Text = "Xác nhận mật khẩu";
            // 
            // panelControl_Buttons
            // 
            this.panelControl_Buttons.Controls.Add(this.btn_Update);
            this.panelControl_Buttons.Controls.Add(this.btn_Add);
            this.panelControl_Buttons.Controls.Add(this.btn_Delete);
            this.panelControl_Buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl_Buttons.Location = new System.Drawing.Point(0, 242);
            this.panelControl_Buttons.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl_Buttons.Name = "panelControl_Buttons";
            this.panelControl_Buttons.Size = new System.Drawing.Size(1280, 60);
            this.panelControl_Buttons.TabIndex = 120;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(210)))));
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold);
            this.btn_Update.Appearance.Options.UseBackColor = true;
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Location = new System.Drawing.Point(1104, 4);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(165, 50);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btn_Add.Location = new System.Drawing.Point(656, 4);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(165, 50);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Appearance.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Appearance.Options.UseBackColor = true;
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Location = new System.Drawing.Point(884, 4);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(165, 50);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // popupContainerControl_GetEmployee
            // 
            this.popupContainerControl_GetEmployee.Controls.Add(this.listBox_SearchEmployeeByName);
            this.popupContainerControl_GetEmployee.Controls.Add(this.panel_PopupButtons);
            this.popupContainerControl_GetEmployee.Controls.Add(this.panel_InputEmployee);
            this.popupContainerControl_GetEmployee.Location = new System.Drawing.Point(212, 180);
            this.popupContainerControl_GetEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.popupContainerControl_GetEmployee.Name = "popupContainerControl_GetEmployee";
            this.popupContainerControl_GetEmployee.Size = new System.Drawing.Size(355, 341);
            this.popupContainerControl_GetEmployee.TabIndex = 118;
            // 
            // listBox_SearchEmployeeByName
            // 
            this.listBox_SearchEmployeeByName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_SearchEmployeeByName.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBox_SearchEmployeeByName.FormattingEnabled = true;
            this.listBox_SearchEmployeeByName.ItemHeight = 22;
            this.listBox_SearchEmployeeByName.Location = new System.Drawing.Point(0, 46);
            this.listBox_SearchEmployeeByName.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_SearchEmployeeByName.Name = "listBox_SearchEmployeeByName";
            this.listBox_SearchEmployeeByName.Size = new System.Drawing.Size(355, 229);
            this.listBox_SearchEmployeeByName.TabIndex = 4;
            // 
            // panel_PopupButtons
            // 
            this.panel_PopupButtons.Controls.Add(this.btn_Cancel);
            this.panel_PopupButtons.Controls.Add(this.btn_Confirm);
            this.panel_PopupButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_PopupButtons.Location = new System.Drawing.Point(0, 275);
            this.panel_PopupButtons.Margin = new System.Windows.Forms.Padding(2);
            this.panel_PopupButtons.Name = "panel_PopupButtons";
            this.panel_PopupButtons.Size = new System.Drawing.Size(355, 66);
            this.panel_PopupButtons.TabIndex = 3;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cancel.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Appearance.Options.UseBackColor = true;
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Appearance.Options.UseForeColor = true;
            this.btn_Cancel.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.AppearanceHovered.Options.UseFont = true;
            this.btn_Cancel.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.AppearancePressed.Options.UseFont = true;
            this.btn_Cancel.Location = new System.Drawing.Point(134, 15);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 37);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Confirm.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Confirm.Appearance.Font = new System.Drawing.Font("Tahoma", 13.74545F, System.Drawing.FontStyle.Bold);
            this.btn_Confirm.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Confirm.Appearance.Options.UseBackColor = true;
            this.btn_Confirm.Appearance.Options.UseFont = true;
            this.btn_Confirm.Appearance.Options.UseForeColor = true;
            this.btn_Confirm.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold);
            this.btn_Confirm.AppearanceHovered.Options.UseFont = true;
            this.btn_Confirm.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold);
            this.btn_Confirm.AppearancePressed.Options.UseFont = true;
            this.btn_Confirm.Location = new System.Drawing.Point(220, 15);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(123, 37);
            this.btn_Confirm.TabIndex = 1;
            this.btn_Confirm.Text = "Xác nhận";
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // panel_InputEmployee
            // 
            this.panel_InputEmployee.Controls.Add(this.label_SearchEmployeeName);
            this.panel_InputEmployee.Controls.Add(this.txt_SearchEmployeeByName);
            this.panel_InputEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_InputEmployee.Location = new System.Drawing.Point(0, 0);
            this.panel_InputEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.panel_InputEmployee.Name = "panel_InputEmployee";
            this.panel_InputEmployee.Size = new System.Drawing.Size(355, 46);
            this.panel_InputEmployee.TabIndex = 2;
            // 
            // label_SearchEmployeeName
            // 
            this.label_SearchEmployeeName.AutoSize = true;
            this.label_SearchEmployeeName.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_SearchEmployeeName.Location = new System.Drawing.Point(12, 13);
            this.label_SearchEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SearchEmployeeName.Name = "label_SearchEmployeeName";
            this.label_SearchEmployeeName.Size = new System.Drawing.Size(156, 18);
            this.label_SearchEmployeeName.TabIndex = 2;
            this.label_SearchEmployeeName.Text = "Nhập tên nhân viên:";
            // 
            // txt_SearchEmployeeByName
            // 
            this.txt_SearchEmployeeByName.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SearchEmployeeByName.Location = new System.Drawing.Point(172, 10);
            this.txt_SearchEmployeeByName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SearchEmployeeByName.Name = "txt_SearchEmployeeByName";
            this.txt_SearchEmployeeByName.Size = new System.Drawing.Size(171, 26);
            this.txt_SearchEmployeeByName.TabIndex = 1;
            this.txt_SearchEmployeeByName.TextChanged += new System.EventHandler(this.txt_SearchEmployeeByName_TextChanged);
            // 
            // frm_Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.popupContainerControl_GetEmployee);
            this.Controls.Add(this.groupControl_dgv);
            this.Controls.Add(this.panelControl_Buttons);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.label_Account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frm_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_dgv)).EndInit();
            this.groupControl_dgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_AccountDetaiis)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_Buttons)).EndInit();
            this.panelControl_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl_GetEmployee)).EndInit();
            this.popupContainerControl_GetEmployee.ResumeLayout(false);
            this.panel_PopupButtons.ResumeLayout(false);
            this.panel_InputEmployee.ResumeLayout(false);
            this.panel_InputEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Account;
        private System.Windows.Forms.Label label_AccountID;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_UserName;
        private DevExpress.XtraEditors.GroupControl groupControl_dgv;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_AccountId;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label label_EmployeeName;
        private System.Windows.Forms.TextBox txt_EmployeeId;
        private DevExpress.XtraEditors.PanelControl panelControl_Buttons;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_SearchForEmployee;
        private System.Windows.Forms.Label label_AccountStatus;
        private System.Windows.Forms.ComboBox cbb_AccountStatus;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl_GetEmployee;
        private System.Windows.Forms.Panel panel_PopupButtons;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Confirm;
        private System.Windows.Forms.Panel panel_InputEmployee;
        private System.Windows.Forms.Label label_SearchEmployeeName;
        private System.Windows.Forms.TextBox txt_SearchEmployeeByName;
        private System.Windows.Forms.ListBox listBox_SearchEmployeeByName;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Label label_ConfirmPassword;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_AccountDetaiis;
        private DevExpress.XtraGrid.Columns.GridColumn col_AccountID;
        private DevExpress.XtraGrid.Columns.GridColumn col_UserName;
        private DevExpress.XtraGrid.Columns.GridColumn col_EmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn col_AccountStatus;
        private DevExpress.XtraGrid.Columns.GridColumn col_LastUpdated;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
    }
}