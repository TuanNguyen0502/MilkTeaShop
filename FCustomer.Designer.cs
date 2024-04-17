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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_CustomerName = new Guna.UI.WinForms.GunaLabel();
            this.label_CustomerDOB = new Guna.UI.WinForms.GunaLabel();
            this.label_CustomerGender = new Guna.UI.WinForms.GunaLabel();
            this.label_CustomerPhone = new Guna.UI.WinForms.GunaLabel();
            this.textBox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_Search = new Guna.UI.WinForms.GunaAdvenceButton();
            this.button_AddCustomer = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.textBox_Search);
            this.gunaPanel1.Controls.Add(this.button_Search);
            this.gunaPanel1.Controls.Add(this.button_AddCustomer);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1568, 121);
            this.gunaPanel1.TabIndex = 0;
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
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 121);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1568, 588);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Controls.Add(this.label_CustomerName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_CustomerDOB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_CustomerGender, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_CustomerPhone, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1550, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_CustomerName
            // 
            this.label_CustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CustomerName.AutoSize = true;
            this.label_CustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerName.Location = new System.Drawing.Point(119, 10);
            this.label_CustomerName.Name = "label_CustomerName";
            this.label_CustomerName.Size = new System.Drawing.Size(118, 32);
            this.label_CustomerName.TabIndex = 1;
            this.label_CustomerName.Text = "Họ và tên";
            // 
            // label_CustomerDOB
            // 
            this.label_CustomerDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CustomerDOB.AutoSize = true;
            this.label_CustomerDOB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerDOB.Location = new System.Drawing.Point(1185, 10);
            this.label_CustomerDOB.Name = "label_CustomerDOB";
            this.label_CustomerDOB.Size = new System.Drawing.Size(121, 32);
            this.label_CustomerDOB.TabIndex = 4;
            this.label_CustomerDOB.Text = "Ngày sinh";
            // 
            // label_CustomerGender
            // 
            this.label_CustomerGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CustomerGender.AutoSize = true;
            this.label_CustomerGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerGender.Location = new System.Drawing.Point(837, 10);
            this.label_CustomerGender.Name = "label_CustomerGender";
            this.label_CustomerGender.Size = new System.Drawing.Size(105, 32);
            this.label_CustomerGender.TabIndex = 5;
            this.label_CustomerGender.Text = "Giới tính";
            // 
            // label_CustomerPhone
            // 
            this.label_CustomerPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CustomerPhone.AutoSize = true;
            this.label_CustomerPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerPhone.Location = new System.Drawing.Point(456, 10);
            this.label_CustomerPhone.Name = "label_CustomerPhone";
            this.label_CustomerPhone.Size = new System.Drawing.Size(156, 32);
            this.label_CustomerPhone.TabIndex = 3;
            this.label_CustomerPhone.Text = "Số điện thoại";
            // 
            // textBox_Search
            // 
            this.textBox_Search.BorderRadius = 20;
            this.textBox_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Search.DefaultText = "";
            this.textBox_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Search.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Search.Location = new System.Drawing.Point(348, 57);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.PasswordChar = '\0';
            this.textBox_Search.PlaceholderText = "";
            this.textBox_Search.SelectedText = "";
            this.textBox_Search.Size = new System.Drawing.Size(729, 57);
            this.textBox_Search.TabIndex = 2;
            // 
            // button_Search
            // 
            this.button_Search.AnimationHoverSpeed = 0.07F;
            this.button_Search.AnimationSpeed = 0.03F;
            this.button_Search.BackColor = System.Drawing.Color.Transparent;
            this.button_Search.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.button_Search.BorderColor = System.Drawing.Color.Black;
            this.button_Search.CheckedBaseColor = System.Drawing.Color.Gray;
            this.button_Search.CheckedBorderColor = System.Drawing.Color.Black;
            this.button_Search.CheckedForeColor = System.Drawing.Color.White;
            this.button_Search.CheckedImage = ((System.Drawing.Image)(resources.GetObject("button_Search.CheckedImage")));
            this.button_Search.CheckedLineColor = System.Drawing.Color.DimGray;
            this.button_Search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_Search.FocusedColor = System.Drawing.Color.Empty;
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Image = global::MilkTeaShop.Properties.Resources.icons8_find_1001;
            this.button_Search.ImageSize = new System.Drawing.Size(50, 50);
            this.button_Search.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.button_Search.Location = new System.Drawing.Point(1131, 46);
            this.button_Search.Name = "button_Search";
            this.button_Search.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button_Search.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_Search.OnHoverForeColor = System.Drawing.Color.White;
            this.button_Search.OnHoverImage = null;
            this.button_Search.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.button_Search.OnPressedColor = System.Drawing.Color.Black;
            this.button_Search.Radius = 10;
            this.button_Search.Size = new System.Drawing.Size(206, 63);
            this.button_Search.TabIndex = 1;
            this.button_Search.Text = "Search";
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
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
            this.button_AddCustomer.Location = new System.Drawing.Point(20, 57);
            this.button_AddCustomer.Name = "button_AddCustomer";
            this.button_AddCustomer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button_AddCustomer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_AddCustomer.OnHoverForeColor = System.Drawing.Color.White;
            this.button_AddCustomer.OnHoverImage = null;
            this.button_AddCustomer.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.button_AddCustomer.OnPressedColor = System.Drawing.Color.Black;
            this.button_AddCustomer.Radius = 10;
            this.button_AddCustomer.Size = new System.Drawing.Size(297, 52);
            this.button_AddCustomer.TabIndex = 1;
            this.button_AddCustomer.Text = "Thêm khách hàng";
            this.button_AddCustomer.Click += new System.EventHandler(this.button_AddCustomer_Click);
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
        private Guna.UI.WinForms.GunaLabel label_CustomerName;
        private Guna.UI.WinForms.GunaLabel label_CustomerDOB;
        private Guna.UI.WinForms.GunaLabel label_CustomerGender;
        private Guna.UI.WinForms.GunaLabel label_CustomerPhone;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Search;
        private Guna.UI.WinForms.GunaAdvenceButton button_Search;
    }
}