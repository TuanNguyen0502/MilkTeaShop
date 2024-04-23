using Guna.UI2.WinForms;

namespace MilkTeaShop
{
    partial class UC_Suppliers
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
            this.picture_TrangThai = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_NameNCC = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_SDT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_DiaChi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_MaNCC = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picture_TrangThai)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_TrangThai
            // 
            this.picture_TrangThai.Image = global::MilkTeaShop.Properties.Resources.icons8_company_64;
            this.picture_TrangThai.ImageRotate = 0F;
            this.picture_TrangThai.Location = new System.Drawing.Point(13, 14);
            this.picture_TrangThai.Name = "picture_TrangThai";
            this.picture_TrangThai.Size = new System.Drawing.Size(52, 52);
            this.picture_TrangThai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_TrangThai.TabIndex = 8;
            this.picture_TrangThai.TabStop = false;
            // 
            // lbl_NameNCC
            // 
            this.lbl_NameNCC.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NameNCC.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_NameNCC.Location = new System.Drawing.Point(88, 14);
            this.lbl_NameNCC.Name = "lbl_NameNCC";
            this.lbl_NameNCC.Size = new System.Drawing.Size(267, 29);
            this.lbl_NameNCC.TabIndex = 9;
            this.lbl_NameNCC.Text = "Công ty Cung Ứng Tiên Tiến";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SDT.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_SDT.Location = new System.Drawing.Point(618, 49);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(93, 25);
            this.lbl_SDT.TabIndex = 10;
            this.lbl_SDT.Text = "0934567890";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_DiaChi.Location = new System.Drawing.Point(88, 49);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(217, 25);
            this.lbl_DiaChi.TabIndex = 11;
            this.lbl_DiaChi.Text = "123 Lê Lợi, Quận 1, TP.HCM";
            // 
            // lbl_MaNCC
            // 
            this.lbl_MaNCC.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MaNCC.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNCC.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_MaNCC.Location = new System.Drawing.Point(618, 18);
            this.lbl_MaNCC.Name = "lbl_MaNCC";
            this.lbl_MaNCC.Size = new System.Drawing.Size(67, 25);
            this.lbl_MaNCC.TabIndex = 13;
            this.lbl_MaNCC.Text = "NCC001";
            // 
            // UC_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lbl_MaNCC);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_SDT);
            this.Controls.Add(this.lbl_NameNCC);
            this.Controls.Add(this.picture_TrangThai);
            this.Name = "UC_Suppliers";
            this.Size = new System.Drawing.Size(755, 91);
            ((System.ComponentModel.ISupportInitialize)(this.picture_TrangThai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picture_TrangThai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_NameNCC;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_SDT;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_DiaChi;
        private Guna2HtmlLabel lbl_MaNCC;
    }
}
