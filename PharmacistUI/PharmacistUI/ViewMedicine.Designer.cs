namespace PharmacistUI
{
    partial class frm_ViewMedicine
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
            System.Windows.Forms.Label label_Title;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ViewMedicine));
            DevExpress.XtraEditors.PanelControl panelControl3;
            DevExpress.XtraEditors.PanelControl panelControl4;
            this.dgv_Medicine = new System.Windows.Forms.DataGridView();
            this.MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_DeleteRow = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txt_SearchBox = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label_ViewTitle = new System.Windows.Forms.Label();
            this.panel_SearchBar = new System.Windows.Forms.Panel();
            this.label_SearchTItle = new System.Windows.Forms.Label();
            label_Title = new System.Windows.Forms.Label();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            panelControl4 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(panelControl4)).BeginInit();
            this.panel_SearchBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            label_Title.BackColor = System.Drawing.Color.White;
            label_Title.Dock = System.Windows.Forms.DockStyle.Top;
            label_Title.Enabled = false;
            label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label_Title.Location = new System.Drawing.Point(50, 0);
            label_Title.Name = "label_Title";
            label_Title.Size = new System.Drawing.Size(1081, 109);
            label_Title.TabIndex = 0;
            label_Title.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dgv_Medicine
            // 
            this.dgv_Medicine.AllowUserToAddRows = false;
            this.dgv_Medicine.AllowUserToDeleteRows = false;
            this.dgv_Medicine.AllowUserToResizeColumns = false;
            this.dgv_Medicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Medicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Medicine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Medicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Medicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Medicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineID,
            this.MedicineName,
            this.Amount,
            this.PricePerUnit,
            this.ProductionDate,
            this.ExpirationDate});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Medicine.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Medicine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Medicine.Location = new System.Drawing.Point(2, 2);
            this.dgv_Medicine.Name = "dgv_Medicine";
            this.dgv_Medicine.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Medicine.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Medicine.RowHeadersVisible = false;
            this.dgv_Medicine.RowHeadersWidth = 47;
            this.dgv_Medicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Medicine.Size = new System.Drawing.Size(1077, 406);
            this.dgv_Medicine.TabIndex = 2;
            // 
            // MedicineID
            // 
            this.MedicineID.HeaderText = "ID Thuốc";
            this.MedicineID.MinimumWidth = 6;
            this.MedicineID.Name = "MedicineID";
            this.MedicineID.ReadOnly = true;
            // 
            // MedicineName
            // 
            this.MedicineName.HeaderText = "Tên Thuốc";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Số lượng";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.HeaderText = "Giá mỗi đơn vị";
            this.PricePerUnit.MinimumWidth = 6;
            this.PricePerUnit.Name = "PricePerUnit";
            this.PricePerUnit.ReadOnly = true;
            // 
            // ProductionDate
            // 
            this.ProductionDate.HeaderText = "Ngày sản xuất";
            this.ProductionDate.MinimumWidth = 6;
            this.ProductionDate.Name = "ProductionDate";
            this.ProductionDate.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.HeaderText = "Ngày hết hạn";
            this.ExpirationDate.MinimumWidth = 6;
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btn_DeleteRow);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(50, 519);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1081, 74);
            this.panelControl1.TabIndex = 4;
            // 
            // btn_DeleteRow
            // 
            this.btn_DeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteRow.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DeleteRow.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteRow.Appearance.Options.UseBackColor = true;
            this.btn_DeleteRow.Appearance.Options.UseFont = true;
            this.btn_DeleteRow.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_DeleteRow.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_DeleteRow.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_DeleteRow.ImageOptions.SvgImage")));
            this.btn_DeleteRow.Location = new System.Drawing.Point(921, 14);
            this.btn_DeleteRow.Name = "btn_DeleteRow";
            this.btn_DeleteRow.Size = new System.Drawing.Size(140, 50);
            this.btn_DeleteRow.TabIndex = 0;
            this.btn_DeleteRow.Text = "  Xóa";
            this.btn_DeleteRow.Click += new System.EventHandler(this.btn_DeleteRow_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgv_Medicine);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(50, 109);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1081, 410);
            this.panelControl2.TabIndex = 5;
            // 
            // txt_SearchBox
            // 
            this.txt_SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchBox.Location = new System.Drawing.Point(157, 6);
            this.txt_SearchBox.Name = "txt_SearchBox";
            this.txt_SearchBox.Size = new System.Drawing.Size(217, 21);
            this.txt_SearchBox.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(148, 23);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Nhập Tên Thuốc:";
            // 
            // panelControl3
            // 
            panelControl3.Appearance.BackColor = System.Drawing.Color.White;
            panelControl3.Appearance.Options.UseBackColor = true;
            panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            panelControl3.Enabled = false;
            panelControl3.Location = new System.Drawing.Point(0, 0);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new System.Drawing.Size(50, 593);
            panelControl3.TabIndex = 7;
            // 
            // panelControl4
            // 
            panelControl4.Appearance.BackColor = System.Drawing.Color.White;
            panelControl4.Appearance.Options.UseBackColor = true;
            panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            panelControl4.Enabled = false;
            panelControl4.Location = new System.Drawing.Point(1131, 0);
            panelControl4.Name = "panelControl4";
            panelControl4.Size = new System.Drawing.Size(50, 593);
            panelControl4.TabIndex = 8;
            // 
            // label_ViewTitle
            // 
            this.label_ViewTitle.AutoSize = true;
            this.label_ViewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.21818F, System.Drawing.FontStyle.Bold);
            this.label_ViewTitle.Location = new System.Drawing.Point(3, 26);
            this.label_ViewTitle.Name = "label_ViewTitle";
            this.label_ViewTitle.Size = new System.Drawing.Size(229, 42);
            this.label_ViewTitle.TabIndex = 9;
            this.label_ViewTitle.Text = " Xem Thuốc";
            // 
            // panel_SearchBar
            // 
            this.panel_SearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_SearchBar.Controls.Add(this.labelControl1);
            this.panel_SearchBar.Controls.Add(this.txt_SearchBox);
            this.panel_SearchBar.Location = new System.Drawing.Point(745, 73);
            this.panel_SearchBar.Name = "panel_SearchBar";
            this.panel_SearchBar.Size = new System.Drawing.Size(384, 30);
            this.panel_SearchBar.TabIndex = 10;
            // 
            // label_SearchTItle
            // 
            this.label_SearchTItle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SearchTItle.AutoSize = true;
            this.label_SearchTItle.Font = new System.Drawing.Font("Tahoma", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_SearchTItle.Location = new System.Drawing.Point(740, 37);
            this.label_SearchTItle.Name = "label_SearchTItle";
            this.label_SearchTItle.Size = new System.Drawing.Size(126, 29);
            this.label_SearchTItle.TabIndex = 11;
            this.label_SearchTItle.Text = "Tìm Kiếm";
            // 
            // frm_ViewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 593);
            this.Controls.Add(this.label_SearchTItle);
            this.Controls.Add(this.panel_SearchBar);
            this.Controls.Add(this.label_ViewTitle);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(label_Title);
            this.Controls.Add(panelControl4);
            this.Controls.Add(panelControl3);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ViewMedicine";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMedicine";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(panelControl4)).EndInit();
            this.panel_SearchBar.ResumeLayout(false);
            this.panel_SearchBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Medicine;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox txt_SearchBox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label_ViewTitle;
        private System.Windows.Forms.Panel panel_SearchBar;
        private System.Windows.Forms.Label label_SearchTItle;
    }
}