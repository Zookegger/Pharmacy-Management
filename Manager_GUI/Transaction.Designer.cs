namespace Manager_GUI
{
    partial class frm_Transaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Transaction = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_Transaction = new System.Windows.Forms.DataGridView();
            this.col_IDtransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDmedicien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDsupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Quanlity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_TransactionType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_idsupply = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Transaction
            // 
            this.label_Transaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Transaction.Location = new System.Drawing.Point(0, 0);
            this.label_Transaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Transaction.Name = "label_Transaction";
            this.label_Transaction.Size = new System.Drawing.Size(1800, 90);
            this.label_Transaction.TabIndex = 107;
            this.label_Transaction.Text = "Giao Dịch";
            this.label_Transaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(178, 104);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(453, 22);
            this.txt_Email.TabIndex = 5;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(210, 56);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(453, 22);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(210, 10);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(453, 22);
            this.txt_Id.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhà cung cấp ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Giao Dịch";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(178, 23);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(453, 22);
            this.txt_Address.TabIndex = 7;
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(210, 145);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(453, 22);
            this.txt_number.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Địa Chỉ ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số Điện Thoại";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgv_Transaction);
            this.groupControl1.Location = new System.Drawing.Point(13, 318);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1770, 610);
            this.groupControl1.TabIndex = 122;
            this.groupControl1.Text = "Bảng Giao Dịch";
            // 
            // dgv_Transaction
            // 
            this.dgv_Transaction.AllowUserToAddRows = false;
            this.dgv_Transaction.AllowUserToDeleteRows = false;
            this.dgv_Transaction.AllowUserToResizeColumns = false;
            this.dgv_Transaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Transaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Transaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Transaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Transaction.ColumnHeadersHeight = 50;
            this.dgv_Transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Transaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_IDtransaction,
            this.col_IDmedicien,
            this.col_IDsupplier,
            this.col_kind,
            this.col_date,
            this.col_Quanlity,
            this.col_status});
            this.dgv_Transaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Transaction.Location = new System.Drawing.Point(2, 28);
            this.dgv_Transaction.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Transaction.Name = "dgv_Transaction";
            this.dgv_Transaction.ReadOnly = true;
            this.dgv_Transaction.RowHeadersVisible = false;
            this.dgv_Transaction.RowHeadersWidth = 47;
            this.dgv_Transaction.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Transaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Transaction.Size = new System.Drawing.Size(1766, 580);
            this.dgv_Transaction.TabIndex = 109;
            this.dgv_Transaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Transaction_CellClick);
            // 
            // col_IDtransaction
            // 
            this.col_IDtransaction.HeaderText = "Mã giao dịch";
            this.col_IDtransaction.MinimumWidth = 6;
            this.col_IDtransaction.Name = "col_IDtransaction";
            this.col_IDtransaction.ReadOnly = true;
            // 
            // col_IDmedicien
            // 
            this.col_IDmedicien.HeaderText = "Mã lô";
            this.col_IDmedicien.MinimumWidth = 6;
            this.col_IDmedicien.Name = "col_IDmedicien";
            this.col_IDmedicien.ReadOnly = true;
            // 
            // col_IDsupplier
            // 
            this.col_IDsupplier.HeaderText = "Mã nhà cung cấp";
            this.col_IDsupplier.MinimumWidth = 6;
            this.col_IDsupplier.Name = "col_IDsupplier";
            this.col_IDsupplier.ReadOnly = true;
            // 
            // col_kind
            // 
            this.col_kind.HeaderText = "Loại giao dịch";
            this.col_kind.MinimumWidth = 6;
            this.col_kind.Name = "col_kind";
            this.col_kind.ReadOnly = true;
            // 
            // col_date
            // 
            this.col_date.HeaderText = "Ngày thực hiện";
            this.col_date.MinimumWidth = 6;
            this.col_date.Name = "col_date";
            this.col_date.ReadOnly = true;
            // 
            // col_Quanlity
            // 
            this.col_Quanlity.HeaderText = "Số lượng tồn còn lại";
            this.col_Quanlity.MinimumWidth = 6;
            this.col_Quanlity.Name = "col_Quanlity";
            this.col_Quanlity.ReadOnly = true;
            // 
            // col_status
            // 
            this.col_status.HeaderText = "Tình trạng";
            this.col_status.MinimumWidth = 6;
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.DodgerBlue;
            this.splitContainer1.Location = new System.Drawing.Point(13, 80);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.txt_idsupply);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txt_number);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Name);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Id);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.txt_Email);
            this.splitContainer1.Panel2.Controls.Add(this.txt_TransactionType);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Address);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(1452, 232);
            this.splitContainer1.SplitterDistance = 725;
            this.splitContainer1.TabIndex = 123;
            // 
            // txt_TransactionType
            // 
            this.txt_TransactionType.Location = new System.Drawing.Point(178, 60);
            this.txt_TransactionType.Name = "txt_TransactionType";
            this.txt_TransactionType.Size = new System.Drawing.Size(453, 22);
            this.txt_TransactionType.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Loại Giao Dịch";
            // 
            // txt_idsupply
            // 
            this.txt_idsupply.Location = new System.Drawing.Point(210, 104);
            this.txt_idsupply.Name = "txt_idsupply";
            this.txt_idsupply.Size = new System.Drawing.Size(453, 22);
            this.txt_idsupply.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mã nhà cung cấp ";
            // 
            // frm_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1102);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label_Transaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transaction)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Transaction;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TransactionType;
        private System.Windows.Forms.DataGridView dgv_Transaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDtransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDmedicien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDsupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Quanlity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_idsupply;
    }
}