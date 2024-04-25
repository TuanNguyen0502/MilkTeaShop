namespace MilkTeaShop
{
    partial class FManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new Guna.UI.WinForms.GunaButton();
            this.btnCreateAccount = new Guna.UI.WinForms.GunaButton();
            this.txtMaNV = new Guna.UI.WinForms.GunaTextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new Guna.UI.WinForms.GunaTextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.txtMatKhau = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 494);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MilkTeaShop.Properties.Resources.LogoMilkTeaShop;
            this.pictureBox1.InitialImage = global::MilkTeaShop.Properties.Resources.icons8_tick_48;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 494);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MilkTeaShop.Properties.Resources.user_1144760;
            this.pictureBox2.Location = new System.Drawing.Point(563, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.AnimationHoverSpeed = 0.07F;
            this.btnThoat.AnimationSpeed = 0.03F;
            this.btnThoat.BaseColor = System.Drawing.SystemColors.Highlight;
            this.btnThoat.BorderColor = System.Drawing.Color.Black;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThoat.FocusedColor = System.Drawing.Color.Empty;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = null;
            this.btnThoat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThoat.Location = new System.Drawing.Point(678, 428);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.btnThoat.Size = new System.Drawing.Size(83, 42);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.Text = "Thoát ";
            this.btnThoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.AnimationHoverSpeed = 0.07F;
            this.btnCreateAccount.AnimationSpeed = 0.03F;
            this.btnCreateAccount.BaseColor = System.Drawing.SystemColors.Highlight;
            this.btnCreateAccount.BorderColor = System.Drawing.Color.Black;
            this.btnCreateAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreateAccount.FocusedColor = System.Drawing.Color.Empty;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Image = null;
            this.btnCreateAccount.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCreateAccount.Location = new System.Drawing.Point(539, 428);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCreateAccount.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCreateAccount.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.OnHoverImage = null;
            this.btnCreateAccount.OnPressedColor = System.Drawing.Color.Black;
            this.btnCreateAccount.Size = new System.Drawing.Size(114, 42);
            this.btnCreateAccount.TabIndex = 37;
            this.btnCreateAccount.Text = "Tạo account";
            this.btnCreateAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.BaseColor = System.Drawing.Color.White;
            this.txtMaNV.BorderColor = System.Drawing.Color.Silver;
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaNV.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaNV.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNV.Location = new System.Drawing.Point(538, 368);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PasswordChar = '\0';
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.Size = new System.Drawing.Size(223, 43);
            this.txtMaNV.TabIndex = 36;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(538, 339);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(63, 23);
            this.lblMaNV.TabIndex = 35;
            this.lblMaNV.Text = "Mã NV";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BaseColor = System.Drawing.Color.White;
            this.txtTaiKhoan.BorderColor = System.Drawing.Color.Silver;
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTaiKhoan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaiKhoan.Location = new System.Drawing.Point(538, 197);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.PasswordChar = '\0';
            this.txtTaiKhoan.SelectedText = "";
            this.txtTaiKhoan.Size = new System.Drawing.Size(223, 43);
            this.txtTaiKhoan.TabIndex = 34;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(538, 168);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(84, 23);
            this.lblTaiKhoan.TabIndex = 33;
            this.lblTaiKhoan.Text = "Tài khoản";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BaseColor = System.Drawing.Color.White;
            this.txtMatKhau.BorderColor = System.Drawing.Color.Silver;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMatKhau.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMatKhau.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatKhau.Location = new System.Drawing.Point(538, 281);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(223, 43);
            this.txtMatKhau.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mật khẩu";
            // 
            // FManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 494);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.panel1);
            this.Name = "FManager";
            this.Text = "FManager";
            this.Load += new System.EventHandler(this.FManager_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaButton btnThoat;
        private Guna.UI.WinForms.GunaButton btnCreateAccount;
        private Guna.UI.WinForms.GunaTextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private Guna.UI.WinForms.GunaTextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblTaiKhoan;
        private Guna.UI.WinForms.GunaTextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
    }
}