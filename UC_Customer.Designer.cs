namespace MilkTeaShop
{
    partial class UC_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customer));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_ID = new Guna.UI.WinForms.GunaLabel();
            this.label_Name = new Guna.UI.WinForms.GunaLabel();
            this.label_Phone = new Guna.UI.WinForms.GunaLabel();
            this.label_Gender = new Guna.UI.WinForms.GunaLabel();
            this.label_DOB = new Guna.UI.WinForms.GunaLabel();
            this.button_Detail = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.label_DOB, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Gender, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Phone, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_ID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Detail, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1550, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_ID
            // 
            this.label_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(23, 10);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(170, 32);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "MaKhachHang";
            // 
            // label_Name
            // 
            this.label_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(369, 10);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(52, 32);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Ten";
            // 
            // label_Phone
            // 
            this.label_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Phone.Location = new System.Drawing.Point(688, 10);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(156, 32);
            this.label_Phone.TabIndex = 2;
            this.label_Phone.Text = "So dien thoai";
            // 
            // label_Gender
            // 
            this.label_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gender.Location = new System.Drawing.Point(1016, 10);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(105, 32);
            this.label_Gender.TabIndex = 3;
            this.label_Gender.Text = "Gioi tinh";
            // 
            // label_DOB
            // 
            this.label_DOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_DOB.AutoSize = true;
            this.label_DOB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DOB.Location = new System.Drawing.Point(1263, 10);
            this.label_DOB.Name = "label_DOB";
            this.label_DOB.Size = new System.Drawing.Size(121, 32);
            this.label_DOB.TabIndex = 4;
            this.label_DOB.Text = "Ngay sinh";
            // 
            // button_Detail
            // 
            this.button_Detail.AnimationHoverSpeed = 0.07F;
            this.button_Detail.AnimationSpeed = 0.03F;
            this.button_Detail.BackColor = System.Drawing.Color.Transparent;
            this.button_Detail.BaseColor = System.Drawing.Color.White;
            this.button_Detail.BorderColor = System.Drawing.Color.Black;
            this.button_Detail.CheckedBaseColor = System.Drawing.Color.Gray;
            this.button_Detail.CheckedBorderColor = System.Drawing.Color.Black;
            this.button_Detail.CheckedForeColor = System.Drawing.Color.White;
            this.button_Detail.CheckedImage = ((System.Drawing.Image)(resources.GetObject("button_Detail.CheckedImage")));
            this.button_Detail.CheckedLineColor = System.Drawing.Color.DimGray;
            this.button_Detail.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_Detail.FocusedColor = System.Drawing.Color.Empty;
            this.button_Detail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Detail.ForeColor = System.Drawing.Color.White;
            this.button_Detail.Image = global::MilkTeaShop.Properties.Resources.icons8_pencil_36;
            this.button_Detail.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_Detail.ImageSize = new System.Drawing.Size(20, 20);
            this.button_Detail.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.button_Detail.Location = new System.Drawing.Point(1474, 3);
            this.button_Detail.Name = "button_Detail";
            this.button_Detail.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button_Detail.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_Detail.OnHoverForeColor = System.Drawing.Color.White;
            this.button_Detail.OnHoverImage = null;
            this.button_Detail.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.button_Detail.OnPressedColor = System.Drawing.Color.Black;
            this.button_Detail.Radius = 10;
            this.button_Detail.Size = new System.Drawing.Size(69, 42);
            this.button_Detail.TabIndex = 5;
            this.button_Detail.Click += new System.EventHandler(this.button_Detail_Click);
            // 
            // UC_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(1550, 52);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel label_DOB;
        private Guna.UI.WinForms.GunaLabel label_Gender;
        private Guna.UI.WinForms.GunaLabel label_Phone;
        private Guna.UI.WinForms.GunaLabel label_Name;
        private Guna.UI.WinForms.GunaLabel label_ID;
        private Guna.UI.WinForms.GunaAdvenceButton button_Detail;
    }
}
