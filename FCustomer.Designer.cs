namespace MilkTeaShop
{
    partial class FCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCustomer));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.button_AddCustomer = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_CustomerGender = new Guna.UI.WinForms.GunaLabel();
            this.label_CustomerDOB = new Guna.UI.WinForms.GunaLabel();
            this.label_CustomerPhone = new Guna.UI.WinForms.GunaLabel();
            this.label_CustomerID = new Guna.UI.WinForms.GunaLabel();
            this.label_CustomerName = new Guna.UI.WinForms.GunaLabel();
            this.uC_Customer1 = new MilkTeaShop.UC_Customer();
            this.gunaPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.button_AddCustomer);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1568, 121);
            this.gunaPanel1.TabIndex = 0;
            // 
            // button_AddCustomer
            // 
            this.button_AddCustomer.AnimationHoverSpeed = 0.07F;
            this.button_AddCustomer.AnimationSpeed = 0.03F;
            this.button_AddCustomer.BackColor = System.Drawing.Color.Transparent;
            this.button_AddCustomer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.button_AddCustomer.BorderColor = System.Drawing.Color.Black;
            this.button_AddCustomer.CheckedBaseColor = System.Drawing.Color.Gray;
            this.button_AddCustomer.CheckedBorderColor = System.Drawing.Color.Black;
            this.button_AddCustomer.CheckedForeColor = System.Drawing.Color.White;
            this.button_AddCustomer.CheckedImage = ((System.Drawing.Image)(resources.GetObject("button_AddCustomer.CheckedImage")));
            this.button_AddCustomer.CheckedLineColor = System.Drawing.Color.DimGray;
            this.button_AddCustomer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_AddCustomer.FocusedColor = System.Drawing.Color.Empty;
            this.button_AddCustomer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddCustomer.ForeColor = System.Drawing.Color.White;
            this.button_AddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("button_AddCustomer.Image")));
            this.button_AddCustomer.ImageSize = new System.Drawing.Size(20, 20);
            this.button_AddCustomer.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.button_AddCustomer.Location = new System.Drawing.Point(20, 67);
            this.button_AddCustomer.Name = "button_AddCustomer";
            this.button_AddCustomer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button_AddCustomer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_AddCustomer.OnHoverForeColor = System.Drawing.Color.White;
            this.button_AddCustomer.OnHoverImage = null;
            this.button_AddCustomer.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.button_AddCustomer.OnPressedColor = System.Drawing.Color.Black;
            this.button_AddCustomer.Radius = 10;
            this.button_AddCustomer.Size = new System.Drawing.Size(297, 42);
            this.button_AddCustomer.TabIndex = 1;
            this.button_AddCustomer.Text = "Thêm khách hàng";
            this.button_AddCustomer.Click += new System.EventHandler(this.button_AddCustomer_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(311, 45);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Quản lý khách hàng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.uC_Customer1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 121);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1568, 588);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.label_CustomerGender, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_CustomerDOB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_CustomerPhone, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_CustomerID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_CustomerName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1550, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_CustomerGender
            // 
            this.label_CustomerGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CustomerGender.AutoSize = true;
            this.label_CustomerGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerGender.Location = new System.Drawing.Point(1016, 10);
            this.label_CustomerGender.Name = "label_CustomerGender";
            this.label_CustomerGender.Size = new System.Drawing.Size(105, 32);
            this.label_CustomerGender.TabIndex = 5;
            this.label_CustomerGender.Text = "Gioi tinh";
            // 
            // label_CustomerDOB
            // 
            this.label_CustomerDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CustomerDOB.AutoSize = true;
            this.label_CustomerDOB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerDOB.Location = new System.Drawing.Point(1263, 10);
            this.label_CustomerDOB.Name = "label_CustomerDOB";
            this.label_CustomerDOB.Size = new System.Drawing.Size(121, 32);
            this.label_CustomerDOB.TabIndex = 4;
            this.label_CustomerDOB.Text = "Ngay sinh";
            // 
            // label_CustomerPhone
            // 
            this.label_CustomerPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CustomerPhone.AutoSize = true;
            this.label_CustomerPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerPhone.Location = new System.Drawing.Point(688, 10);
            this.label_CustomerPhone.Name = "label_CustomerPhone";
            this.label_CustomerPhone.Size = new System.Drawing.Size(156, 32);
            this.label_CustomerPhone.TabIndex = 3;
            this.label_CustomerPhone.Text = "So dien thoai";
            // 
            // label_CustomerID
            // 
            this.label_CustomerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CustomerID.AutoSize = true;
            this.label_CustomerID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerID.Location = new System.Drawing.Point(19, 10);
            this.label_CustomerID.Name = "label_CustomerID";
            this.label_CustomerID.Size = new System.Drawing.Size(179, 32);
            this.label_CustomerID.TabIndex = 2;
            this.label_CustomerID.Text = "Ma khach hang";
            // 
            // label_CustomerName
            // 
            this.label_CustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CustomerName.AutoSize = true;
            this.label_CustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerName.Location = new System.Drawing.Point(336, 10);
            this.label_CustomerName.Name = "label_CustomerName";
            this.label_CustomerName.Size = new System.Drawing.Size(118, 32);
            this.label_CustomerName.TabIndex = 1;
            this.label_CustomerName.Text = "Ho va ten";
            // 
            // uC_Customer1
            // 
            this.uC_Customer1.Location = new System.Drawing.Point(3, 61);
            this.uC_Customer1.MaKH = null;
            this.uC_Customer1.Name = "uC_Customer1";
            this.uC_Customer1.Size = new System.Drawing.Size(1550, 52);
            this.uC_Customer1.TabIndex = 1;
            // 
            // FCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 709);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCustomer";
            this.Text = "FCustomer";
            this.Load += new System.EventHandler(this.FCustomer_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton button_AddCustomer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel label_CustomerGender;
        private Guna.UI.WinForms.GunaLabel label_CustomerDOB;
        private Guna.UI.WinForms.GunaLabel label_CustomerPhone;
        private Guna.UI.WinForms.GunaLabel label_CustomerID;
        private Guna.UI.WinForms.GunaLabel label_CustomerName;
        private UC_Customer uC_Customer1;
    }
}