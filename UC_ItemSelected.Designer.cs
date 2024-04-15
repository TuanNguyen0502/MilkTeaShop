namespace MilkTeaShop
{
    partial class UC_ItemSelected
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
            this.numeric_Quantities = new Guna.UI.WinForms.GunaNumeric();
            this.lbl_NameItem = new System.Windows.Forms.Label();
            this.lbl_BuyDate = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lbl_MaKH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeric_Quantities
            // 
            this.numeric_Quantities.BaseColor = System.Drawing.Color.White;
            this.numeric_Quantities.BorderColor = System.Drawing.Color.Tomato;
            this.numeric_Quantities.ButtonColor = System.Drawing.Color.Tomato;
            this.numeric_Quantities.ButtonForeColor = System.Drawing.Color.White;
            this.numeric_Quantities.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numeric_Quantities.ForeColor = System.Drawing.Color.Black;
            this.numeric_Quantities.Location = new System.Drawing.Point(341, 27);
            this.numeric_Quantities.Maximum = ((long)(9999999));
            this.numeric_Quantities.Minimum = ((long)(1));
            this.numeric_Quantities.Name = "numeric_Quantities";
            this.numeric_Quantities.Size = new System.Drawing.Size(75, 30);
            this.numeric_Quantities.TabIndex = 0;
            this.numeric_Quantities.Text = "gunaNumeric1";
            this.numeric_Quantities.Value = ((long)(1));
            // 
            // lbl_NameItem
            // 
            this.lbl_NameItem.AutoSize = true;
            this.lbl_NameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameItem.Location = new System.Drawing.Point(84, 15);
            this.lbl_NameItem.Name = "lbl_NameItem";
            this.lbl_NameItem.Size = new System.Drawing.Size(115, 20);
            this.lbl_NameItem.TabIndex = 1;
            this.lbl_NameItem.Text = "Tên sản phẩm";
            // 
            // lbl_BuyDate
            // 
            this.lbl_BuyDate.AutoSize = true;
            this.lbl_BuyDate.Location = new System.Drawing.Point(85, 49);
            this.lbl_BuyDate.Name = "lbl_BuyDate";
            this.lbl_BuyDate.Size = new System.Drawing.Size(69, 16);
            this.lbl_BuyDate.TabIndex = 2;
            this.lbl_BuyDate.Text = "Ngày mua";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(428, 35);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(45, 16);
            this.lbl_price.TabIndex = 3;
            this.lbl_price.Text = "25.000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MilkTeaShop.Properties.Resources.icons8_delete_trash_32;
            this.pictureBox1.Location = new System.Drawing.Point(19, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.lbl_MaKH);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Silver;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(516, 85);
            this.gunaLinePanel1.TabIndex = 5;
            // 
            // lbl_MaKH
            // 
            this.lbl_MaKH.AutoSize = true;
            this.lbl_MaKH.Location = new System.Drawing.Point(236, 49);
            this.lbl_MaKH.Name = "lbl_MaKH";
            this.lbl_MaKH.Size = new System.Drawing.Size(47, 16);
            this.lbl_MaKH.TabIndex = 3;
            this.lbl_MaKH.Text = "Mã KH";
            // 
            // UC_ItemSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_BuyDate);
            this.Controls.Add(this.lbl_NameItem);
            this.Controls.Add(this.numeric_Quantities);
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "UC_ItemSelected";
            this.Size = new System.Drawing.Size(516, 85);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaNumeric numeric_Quantities;
        private System.Windows.Forms.Label lbl_NameItem;
        private System.Windows.Forms.Label lbl_BuyDate;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.Label lbl_MaKH;
    }
}
