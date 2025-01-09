namespace Login
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.label_Title = new DevExpress.XtraEditors.LabelControl();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.checkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.label_SignIn = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Appearance.Font = new System.Drawing.Font("Tahoma", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Title.Appearance.Options.UseFont = true;
            this.label_Title.Appearance.Options.UseForeColor = true;
            this.label_Title.Location = new System.Drawing.Point(35, 30);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(270, 29);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "QUẢN LÝ TIỆM THUỐC";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Username.Location = new System.Drawing.Point(504, 115);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(307, 28);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Login_KeyDown);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Password.Location = new System.Drawing.Point(504, 170);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(307, 28);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Login_KeyDown);
            // 
            // btn_Login
            // 
            this.btn_Login.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Login.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Login.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Appearance.Options.UseBackColor = true;
            this.btn_Login.Appearance.Options.UseFont = true;
            this.btn_Login.Appearance.Options.UseForeColor = true;
            this.btn_Login.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Login.ImageOptions.SvgImage")));
            this.btn_Login.Location = new System.Drawing.Point(422, 276);
            this.btn_Login.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Login.Size = new System.Drawing.Size(173, 59);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Đăng Nhập";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            this.btn_Login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Login_KeyDown);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Exit.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Exit.Appearance.Options.UseBackColor = true;
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Exit.ImageOptions.SvgImage")));
            this.btn_Exit.Location = new System.Drawing.Point(637, 276);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Exit.Size = new System.Drawing.Size(163, 59);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(373, 118);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 24);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tên tài khoản:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(373, 174);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 24);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Mật khẩu:";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(174)))), ((int)(((byte)(187)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.pictureBox_Logo);
            this.panelControl1.Controls.Add(this.label_Title);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.SkinName = "DevExpress Style";
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(341, 373);
            this.panelControl1.TabIndex = 5;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.Image")));
            this.pictureBox_Logo.Location = new System.Drawing.Point(67, 118);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(204, 199);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 1;
            this.pictureBox_Logo.TabStop = false;
            // 
            // checkBox_ShowPassword
            // 
            this.checkBox_ShowPassword.AutoSize = true;
            this.checkBox_ShowPassword.FlatAppearance.BorderSize = 3;
            this.checkBox_ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_ShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox_ShowPassword.Location = new System.Drawing.Point(373, 218);
            this.checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            this.checkBox_ShowPassword.Size = new System.Drawing.Size(134, 28);
            this.checkBox_ShowPassword.TabIndex = 3;
            this.checkBox_ShowPassword.Text = "Hiển thị ký tự";
            this.checkBox_ShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_ShowPassword.UseVisualStyleBackColor = false;
            this.checkBox_ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassword_CheckedChanged);
            // 
            // label_SignIn
            // 
            this.label_SignIn.Appearance.Font = new System.Drawing.Font("Tahoma", 24.21818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_SignIn.Appearance.Options.UseFont = true;
            this.label_SignIn.Location = new System.Drawing.Point(504, 30);
            this.label_SignIn.Name = "label_SignIn";
            this.label_SignIn.Size = new System.Drawing.Size(202, 45);
            this.label_SignIn.TabIndex = 6;
            this.label_SignIn.Text = "Đăng nhập";
            // 
            // frm_Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 373);
            this.Controls.Add(this.label_SignIn);
            this.Controls.Add(this.checkBox_ShowPassword);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_Login.IconOptions.Image")));
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private DevExpress.XtraEditors.SimpleButton btn_Login;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
        private DevExpress.XtraEditors.LabelControl label_Title;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.CheckBox checkBox_ShowPassword;
        private DevExpress.XtraEditors.LabelControl label_SignIn;
    }
}

