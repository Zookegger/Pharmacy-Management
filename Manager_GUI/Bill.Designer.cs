namespace Manager_GUI
{
    partial class frm_BillingAnalytics
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
            this.dgv_Bill = new System.Windows.Forms.DataGridView();
            this.col_BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NameMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_TitleAdd = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label_ID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Bill
            // 
            this.dgv_Bill.AllowUserToAddRows = false;
            this.dgv_Bill.AllowUserToDeleteRows = false;
            this.dgv_Bill.AllowUserToResizeColumns = false;
            this.dgv_Bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Bill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Bill.ColumnHeadersHeight = 50;
            this.dgv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_BillID,
            this.col_CustomerID,
            this.col_NameMedicine,
            this.col_Quantity,
            this.col_Date,
            this.col_TotalPrice});
            this.dgv_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Bill.Location = new System.Drawing.Point(2, 28);
            this.dgv_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Bill.Name = "dgv_Bill";
            this.dgv_Bill.ReadOnly = true;
            this.dgv_Bill.RowHeadersVisible = false;
            this.dgv_Bill.RowHeadersWidth = 47;
            this.dgv_Bill.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Bill.Size = new System.Drawing.Size(1349, 629);
            this.dgv_Bill.TabIndex = 105;
            this.dgv_Bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Bill_CellClick);
            this.dgv_Bill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Medicine_CellContentClick);
            // 
            // col_BillID
            // 
            this.col_BillID.HeaderText = "Mã hóa đơn";
            this.col_BillID.MinimumWidth = 6;
            this.col_BillID.Name = "col_BillID";
            this.col_BillID.ReadOnly = true;
            // 
            // col_CustomerID
            // 
            this.col_CustomerID.HeaderText = "Mã khách hàng";
            this.col_CustomerID.MinimumWidth = 6;
            this.col_CustomerID.Name = "col_CustomerID";
            this.col_CustomerID.ReadOnly = true;
            // 
            // col_NameMedicine
            // 
            this.col_NameMedicine.HeaderText = "Tên thuốc";
            this.col_NameMedicine.MinimumWidth = 6;
            this.col_NameMedicine.Name = "col_NameMedicine";
            this.col_NameMedicine.ReadOnly = true;
            // 
            // col_Quantity
            // 
            this.col_Quantity.HeaderText = "Số lượng";
            this.col_Quantity.MinimumWidth = 6;
            this.col_Quantity.Name = "col_Quantity";
            this.col_Quantity.ReadOnly = true;
            // 
            // col_Date
            // 
            this.col_Date.HeaderText = "Ngày";
            this.col_Date.MinimumWidth = 6;
            this.col_Date.Name = "col_Date";
            this.col_Date.ReadOnly = true;
            // 
            // col_TotalPrice
            // 
            this.col_TotalPrice.HeaderText = "Thành tiền";
            this.col_TotalPrice.MinimumWidth = 6;
            this.col_TotalPrice.Name = "col_TotalPrice";
            this.col_TotalPrice.ReadOnly = true;
            // 
            // label_TitleAdd
            // 
            this.label_TitleAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_TitleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TitleAdd.Location = new System.Drawing.Point(0, 0);
            this.label_TitleAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TitleAdd.Name = "label_TitleAdd";
            this.label_TitleAdd.Size = new System.Drawing.Size(1689, 90);
            this.label_TitleAdd.TabIndex = 106;
            this.label_TitleAdd.Text = "Hóa đơn";
            this.label_TitleAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Id
            // 
            this.txt_Id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Id.Location = new System.Drawing.Point(112, 0);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(559, 30);
            this.txt_Id.TabIndex = 107;
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Name.Location = new System.Drawing.Point(112, 58);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(559, 30);
            this.txt_Name.TabIndex = 109;
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Email.Location = new System.Drawing.Point(112, 103);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(559, 30);
            this.txt_Email.TabIndex = 111;
            // 
            // label_ID
            // 
            this.label_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ID.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ID.Appearance.Options.UseFont = true;
            this.label_ID.Location = new System.Drawing.Point(24, 10);
            this.label_ID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(58, 24);
            this.label_ID.TabIndex = 112;
            this.label_ID.Text = "Mã KH";
            this.label_ID.Click += new System.EventHandler(this.label_ID_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 58);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 24);
            this.labelControl1.TabIndex = 113;
            this.labelControl1.Text = "Tên KH";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 103);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 24);
            this.labelControl2.TabIndex = 114;
            this.labelControl2.Text = "Email";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(8, 10);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 24);
            this.labelControl3.TabIndex = 115;
            this.labelControl3.Text = "Địa chỉ";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(8, 63);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(117, 24);
            this.labelControl4.TabIndex = 116;
            this.labelControl4.Text = "Số điện thoại";
            // 
            // txt_number
            // 
            this.txt_number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_number.Location = new System.Drawing.Point(146, 63);
            this.txt_number.Margin = new System.Windows.Forms.Padding(0);
            this.txt_number.Name = "txt_number";
            this.txt_number.ReadOnly = true;
            this.txt_number.Size = new System.Drawing.Size(519, 30);
            this.txt_number.TabIndex = 117;
            this.txt_number.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Address
            // 
            this.txt_Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Address.Location = new System.Drawing.Point(146, 10);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.ReadOnly = true;
            this.txt_Address.Size = new System.Drawing.Size(519, 30);
            this.txt_Address.TabIndex = 118;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(8, 77);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.label_ID);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.txt_Id);
            this.splitContainerControl1.Panel1.Controls.Add(this.txt_Email);
            this.splitContainerControl1.Panel1.Controls.Add(this.txt_Name);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel2.Controls.Add(this.txt_Address);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel2.Controls.Add(this.txt_number);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1452, 141);
            this.splitContainerControl1.SplitterPosition = 661;
            this.splitContainerControl1.TabIndex = 119;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgv_Bill);
            this.groupControl1.Location = new System.Drawing.Point(13, 226);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1353, 659);
            this.groupControl1.TabIndex = 120;
            this.groupControl1.Text = "Bảng hóa đơn";
            // 
            // frm_BillingAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 898);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.label_TitleAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_BillingAnalytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.frm_BillingAnalytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            this.splitContainerControl1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NameMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TotalPrice;
        private System.Windows.Forms.Label label_TitleAdd;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Email;
        private DevExpress.XtraEditors.LabelControl label_ID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_Address;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}