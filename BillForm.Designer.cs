namespace MilkTeaShop
{
    partial class BillForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbb_options = new Guna.UI.WinForms.GunaComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.flp_Container = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_AllBill = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton4 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flp_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel1.Controls.Add(this.gunaAdvenceButton4, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.gunaAdvenceButton3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.gunaAdvenceButton2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gunaAdvenceButton1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_AllBill, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbb_options, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1394, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbb_options
            // 
            this.cbb_options.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_options.BackColor = System.Drawing.Color.Transparent;
            this.cbb_options.BaseColor = System.Drawing.Color.White;
            this.cbb_options.BorderColor = System.Drawing.Color.Silver;
            this.cbb_options.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_options.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_options.FocusedColor = System.Drawing.Color.Empty;
            this.cbb_options.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_options.ForeColor = System.Drawing.Color.Black;
            this.cbb_options.FormattingEnabled = true;
            this.cbb_options.Location = new System.Drawing.Point(863, 14);
            this.cbb_options.Name = "cbb_options";
            this.cbb_options.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbb_options.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbb_options.Radius = 6;
            this.cbb_options.Size = new System.Drawing.Size(199, 31);
            this.cbb_options.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1394, 60);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "HÓA ĐƠN";
            // 
            // flp_Container
            // 
            this.flp_Container.AutoScroll = true;
            this.flp_Container.Controls.Add(this.tableLayoutPanel1);
            this.flp_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Container.Location = new System.Drawing.Point(0, 60);
            this.flp_Container.Name = "flp_Container";
            this.flp_Container.Size = new System.Drawing.Size(1394, 763);
            this.flp_Container.TabIndex = 2;
            // 
            // btn_AllBill
            // 
            this.btn_AllBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AllBill.AnimationHoverSpeed = 0.07F;
            this.btn_AllBill.AnimationSpeed = 0.03F;
            this.btn_AllBill.BackColor = System.Drawing.Color.Transparent;
            this.btn_AllBill.BaseColor = System.Drawing.Color.CadetBlue;
            this.btn_AllBill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btn_AllBill.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_AllBill.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_AllBill.CheckedForeColor = System.Drawing.Color.White;
            this.btn_AllBill.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_AllBill.CheckedImage")));
            this.btn_AllBill.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_AllBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AllBill.FocusedColor = System.Drawing.Color.Empty;
            this.btn_AllBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_AllBill.ForeColor = System.Drawing.Color.MistyRose;
            this.btn_AllBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_AllBill.Image")));
            this.btn_AllBill.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_AllBill.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_AllBill.Location = new System.Drawing.Point(17, 8);
            this.btn_AllBill.Name = "btn_AllBill";
            this.btn_AllBill.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btn_AllBill.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_AllBill.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_AllBill.OnHoverImage = null;
            this.btn_AllBill.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_AllBill.OnPressedColor = System.Drawing.Color.Black;
            this.btn_AllBill.Radius = 4;
            this.btn_AllBill.Size = new System.Drawing.Size(180, 42);
            this.btn_AllBill.TabIndex = 1;
            this.btn_AllBill.Text = "Tất cả hóa đơn";
            this.btn_AllBill.Click += new System.EventHandler(this.btn_AllBill_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.CadetBlue;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.MistyRose;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(231, 8);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 4;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(180, 42);
            this.gunaAdvenceButton1.TabIndex = 9;
            this.gunaAdvenceButton1.Text = "Đã thanh toán";
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.CadetBlue;
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.MistyRose;
            this.gunaAdvenceButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.Image")));
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(445, 8);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Radius = 4;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(180, 42);
            this.gunaAdvenceButton2.TabIndex = 10;
            this.gunaAdvenceButton2.Text = "Chưa thanh toán";
            // 
            // gunaAdvenceButton3
            // 
            this.gunaAdvenceButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.BaseColor = System.Drawing.Color.CadetBlue;
            this.gunaAdvenceButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.CheckedImage")));
            this.gunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton3.ForeColor = System.Drawing.Color.MistyRose;
            this.gunaAdvenceButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.Image")));
            this.gunaAdvenceButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(659, 8);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.OnHoverImage = null;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.Radius = 4;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(180, 42);
            this.gunaAdvenceButton3.TabIndex = 11;
            this.gunaAdvenceButton3.Text = "Tất cả hóa đơn";
            // 
            // gunaAdvenceButton4
            // 
            this.gunaAdvenceButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton4.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton4.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton4.BaseColor = System.Drawing.Color.CadetBlue;
            this.gunaAdvenceButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton4.CheckedImage")));
            this.gunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton4.ForeColor = System.Drawing.Color.MistyRose;
            this.gunaAdvenceButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton4.Image")));
            this.gunaAdvenceButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.Location = new System.Drawing.Point(1105, 8);
            this.gunaAdvenceButton4.Name = "gunaAdvenceButton4";
            this.gunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.OnHoverImage = null;
            this.gunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.Radius = 4;
            this.gunaAdvenceButton4.Size = new System.Drawing.Size(254, 42);
            this.gunaAdvenceButton4.TabIndex = 12;
            this.gunaAdvenceButton4.Text = "Tùy chỉnh hiển thị";
            this.gunaAdvenceButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 823);
            this.Controls.Add(this.flp_Container);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillForm";
            this.Text = "BillForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flp_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaComboBox cbb_options;
        private System.Windows.Forms.FlowLayoutPanel flp_Container;
        private Guna.UI.WinForms.GunaAdvenceButton btn_AllBill;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton4;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}