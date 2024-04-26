namespace MilkTeaShop
{
    partial class UC_CTDN
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTen = new Guna.UI.WinForms.GunaLabel();
            this.lblDonVi = new Guna.UI.WinForms.GunaLabel();
            this.lblSoLuong = new Guna.UI.WinForms.GunaLabel();
            this.lblDonGia = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(3, 13);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(64, 23);
            this.lblTen.TabIndex = 15;
            this.lblTen.Text = "Tên NL";
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonVi.Location = new System.Drawing.Point(140, 13);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(59, 23);
            this.lblDonVi.TabIndex = 16;
            this.lblDonVi.Text = "Đơn vị";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(229, 13);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(78, 23);
            this.lblSoLuong.TabIndex = 17;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(309, 13);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(67, 23);
            this.lblDonGia.TabIndex = 18;
            this.lblDonGia.Text = "DonGia";
            // 
            // UCCTDNNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblDonVi);
            this.Controls.Add(this.lblTen);
            this.Name = "UCCTDNNL";
            this.Size = new System.Drawing.Size(382, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblTen;
        private Guna.UI.WinForms.GunaLabel lblDonVi;
        private Guna.UI.WinForms.GunaLabel lblSoLuong;
        private Guna.UI.WinForms.GunaLabel lblDonGia;
    }
}
