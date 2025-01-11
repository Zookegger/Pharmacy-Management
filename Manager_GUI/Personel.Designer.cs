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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personel)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Personel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgv_Personel.Location = new System.Drawing.Point(0, 90);
            this.dgv_Personel.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Personel.Name = "dgv_Personel";
            this.dgv_Personel.ReadOnly = true;
            this.dgv_Personel.RowHeadersVisible = false;
            this.dgv_Personel.RowHeadersWidth = 47;
            this.dgv_Personel.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Personel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Personel.Size = new System.Drawing.Size(1671, 761);
            this.dgv_Personel.TabIndex = 108;
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
            this.col_idwork.HeaderText = "Mã chức vụ";
            this.col_idwork.MinimumWidth = 6;
            this.col_idwork.Name = "col_idwork";
            this.col_idwork.ReadOnly = true;
            // 
            // col_IDshop
            // 
            this.col_IDshop.HeaderText = "Mã tiệm ";
            this.col_IDshop.MinimumWidth = 6;
            this.col_IDshop.Name = "col_IDshop";
            this.col_IDshop.ReadOnly = true;
            // 
            // frm_Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 851);
            this.Controls.Add(this.dgv_Personel);
            this.Controls.Add(this.label_TitleAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.frm_Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_TitleAdd;
        private System.Windows.Forms.DataGridView dgv_Personel;
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
    }
}