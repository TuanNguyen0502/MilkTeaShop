﻿namespace MilkTeaShop
{
    partial class FBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBillForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_PayYet = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Paid = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_AllBill = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cbb_options = new Guna.UI.WinForms.GunaComboBox();
            this.txt_KeyWord = new Guna.UI.WinForms.GunaTextBox();
            this.btn_SeachForBill = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.flp_Container = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ThoiGianDat = new System.Windows.Forms.Label();
            this.lbl_GhiChu = new System.Windows.Forms.Label();
            this.lbl_TenNV = new System.Windows.Forms.Label();
            this.lbl_MaHD = new System.Windows.Forms.Label();
            this.lbl_TenKH = new System.Windows.Forms.Label();
            this.lbl_TotalBill = new System.Windows.Forms.Label();
            this.flp_ContainsBill = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flp_Container.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.63589F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.63589F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.63589F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.63589F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.46399F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.99245F));
            this.tableLayoutPanel1.Controls.Add(this.btn_PayYet, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Paid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_AllBill, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbb_options, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_KeyWord, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_SeachForBill, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1394, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_PayYet
            // 
            this.btn_PayYet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_PayYet.AnimationHoverSpeed = 0.07F;
            this.btn_PayYet.AnimationSpeed = 0.03F;
            this.btn_PayYet.BackColor = System.Drawing.Color.Transparent;
            this.btn_PayYet.BaseColor = System.Drawing.Color.CadetBlue;
            this.btn_PayYet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btn_PayYet.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_PayYet.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_PayYet.CheckedForeColor = System.Drawing.Color.White;
            this.btn_PayYet.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_PayYet.CheckedImage")));
            this.btn_PayYet.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_PayYet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_PayYet.FocusedColor = System.Drawing.Color.Empty;
            this.btn_PayYet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_PayYet.ForeColor = System.Drawing.Color.MistyRose;
            this.btn_PayYet.Image = ((System.Drawing.Image)(resources.GetObject("btn_PayYet.Image")));
            this.btn_PayYet.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_PayYet.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_PayYet.Location = new System.Drawing.Point(487, 8);
            this.btn_PayYet.Name = "btn_PayYet";
            this.btn_PayYet.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btn_PayYet.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_PayYet.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_PayYet.OnHoverImage = null;
            this.btn_PayYet.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_PayYet.OnPressedColor = System.Drawing.Color.Black;
            this.btn_PayYet.Radius = 4;
            this.btn_PayYet.Size = new System.Drawing.Size(180, 42);
            this.btn_PayYet.TabIndex = 10;
            this.btn_PayYet.Text = "Chưa thanh toán";
            // 
            // btn_Paid
            // 
            this.btn_Paid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Paid.AnimationHoverSpeed = 0.07F;
            this.btn_Paid.AnimationSpeed = 0.03F;
            this.btn_Paid.BackColor = System.Drawing.Color.Transparent;
            this.btn_Paid.BaseColor = System.Drawing.Color.CadetBlue;
            this.btn_Paid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btn_Paid.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Paid.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Paid.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Paid.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Paid.CheckedImage")));
            this.btn_Paid.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Paid.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Paid.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Paid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Paid.ForeColor = System.Drawing.Color.MistyRose;
            this.btn_Paid.Image = ((System.Drawing.Image)(resources.GetObject("btn_Paid.Image")));
            this.btn_Paid.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Paid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Paid.Location = new System.Drawing.Point(256, 8);
            this.btn_Paid.Name = "btn_Paid";
            this.btn_Paid.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btn_Paid.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_Paid.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Paid.OnHoverImage = null;
            this.btn_Paid.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Paid.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Paid.Radius = 4;
            this.btn_Paid.Size = new System.Drawing.Size(180, 42);
            this.btn_Paid.TabIndex = 9;
            this.btn_Paid.Text = "Đã thanh toán";
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
            this.btn_AllBill.Location = new System.Drawing.Point(25, 8);
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
            this.cbb_options.Location = new System.Drawing.Point(709, 14);
            this.cbb_options.Name = "cbb_options";
            this.cbb_options.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbb_options.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbb_options.Radius = 6;
            this.cbb_options.Size = new System.Drawing.Size(199, 31);
            this.cbb_options.TabIndex = 8;
            // 
            // txt_KeyWord
            // 
            this.txt_KeyWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_KeyWord.BackColor = System.Drawing.Color.Transparent;
            this.txt_KeyWord.BaseColor = System.Drawing.Color.White;
            this.txt_KeyWord.BorderColor = System.Drawing.Color.Silver;
            this.txt_KeyWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_KeyWord.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_KeyWord.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_KeyWord.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_KeyWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_KeyWord.Location = new System.Drawing.Point(932, 9);
            this.txt_KeyWord.Name = "txt_KeyWord";
            this.txt_KeyWord.PasswordChar = '\0';
            this.txt_KeyWord.Radius = 6;
            this.txt_KeyWord.SelectedText = "";
            this.txt_KeyWord.Size = new System.Drawing.Size(255, 41);
            this.txt_KeyWord.TabIndex = 13;
            // 
            // btn_SeachForBill
            // 
            this.btn_SeachForBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SeachForBill.AnimationHoverSpeed = 0.07F;
            this.btn_SeachForBill.AnimationSpeed = 0.03F;
            this.btn_SeachForBill.BackColor = System.Drawing.Color.Transparent;
            this.btn_SeachForBill.BaseColor = System.Drawing.Color.CadetBlue;
            this.btn_SeachForBill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btn_SeachForBill.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_SeachForBill.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_SeachForBill.CheckedForeColor = System.Drawing.Color.White;
            this.btn_SeachForBill.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_SeachForBill.CheckedImage")));
            this.btn_SeachForBill.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_SeachForBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_SeachForBill.FocusedColor = System.Drawing.Color.Empty;
            this.btn_SeachForBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_SeachForBill.ForeColor = System.Drawing.Color.MistyRose;
            this.btn_SeachForBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_SeachForBill.Image")));
            this.btn_SeachForBill.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_SeachForBill.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_SeachForBill.Location = new System.Drawing.Point(1202, 8);
            this.btn_SeachForBill.Name = "btn_SeachForBill";
            this.btn_SeachForBill.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btn_SeachForBill.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_SeachForBill.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_SeachForBill.OnHoverImage = null;
            this.btn_SeachForBill.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_SeachForBill.OnPressedColor = System.Drawing.Color.Black;
            this.btn_SeachForBill.Radius = 4;
            this.btn_SeachForBill.Size = new System.Drawing.Size(184, 42);
            this.btn_SeachForBill.TabIndex = 12;
            this.btn_SeachForBill.Text = "Tìm kiếm hóa đơn";
            this.btn_SeachForBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_SeachForBill.Click += new System.EventHandler(this.btn_SeachForBill_Click);
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
            this.flp_Container.Controls.Add(this.tableLayoutPanel2);
            this.flp_Container.Controls.Add(this.flp_ContainsBill);
            this.flp_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Container.Location = new System.Drawing.Point(0, 60);
            this.flp_Container.Name = "flp_Container";
            this.flp_Container.Size = new System.Drawing.Size(1394, 763);
            this.flp_Container.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.71342F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.07014F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.07014F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.86281F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.1908F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0927F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_ThoiGianDat, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_GhiChu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_TenNV, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_MaHD, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_TenKH, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_TotalBill, 5, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 68);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1394, 59);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lbl_ThoiGianDat
            // 
            this.lbl_ThoiGianDat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ThoiGianDat.AutoSize = true;
            this.lbl_ThoiGianDat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThoiGianDat.Location = new System.Drawing.Point(651, 15);
            this.lbl_ThoiGianDat.Name = "lbl_ThoiGianDat";
            this.lbl_ThoiGianDat.Size = new System.Drawing.Size(127, 28);
            this.lbl_ThoiGianDat.TabIndex = 9;
            this.lbl_ThoiGianDat.Text = "Thời gian đặt";
            // 
            // lbl_GhiChu
            // 
            this.lbl_GhiChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GhiChu.AutoSize = true;
            this.lbl_GhiChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GhiChu.Location = new System.Drawing.Point(912, 15);
            this.lbl_GhiChu.Name = "lbl_GhiChu";
            this.lbl_GhiChu.Size = new System.Drawing.Size(78, 28);
            this.lbl_GhiChu.TabIndex = 8;
            this.lbl_GhiChu.Text = "Ghi chú";
            // 
            // lbl_TenNV
            // 
            this.lbl_TenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TenNV.AutoSize = true;
            this.lbl_TenNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNV.Location = new System.Drawing.Point(420, 15);
            this.lbl_TenNV.Name = "lbl_TenNV";
            this.lbl_TenNV.Size = new System.Drawing.Size(130, 28);
            this.lbl_TenNV.TabIndex = 7;
            this.lbl_TenNV.Text = "Tên nhân viên";
            // 
            // lbl_MaHD
            // 
            this.lbl_MaHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaHD.AutoSize = true;
            this.lbl_MaHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHD.Location = new System.Drawing.Point(15, 15);
            this.lbl_MaHD.Name = "lbl_MaHD";
            this.lbl_MaHD.Size = new System.Drawing.Size(118, 28);
            this.lbl_MaHD.TabIndex = 6;
            this.lbl_MaHD.Text = "Mã hóa đơn";
            // 
            // lbl_TenKH
            // 
            this.lbl_TenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TenKH.AutoSize = true;
            this.lbl_TenKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenKH.Location = new System.Drawing.Point(188, 15);
            this.lbl_TenKH.Name = "lbl_TenKH";
            this.lbl_TenKH.Size = new System.Drawing.Size(146, 28);
            this.lbl_TenKH.TabIndex = 3;
            this.lbl_TenKH.Text = "Tên khách hàng";
            // 
            // lbl_TotalBill
            // 
            this.lbl_TotalBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TotalBill.AutoSize = true;
            this.lbl_TotalBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalBill.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_TotalBill.Location = new System.Drawing.Point(1140, 15);
            this.lbl_TotalBill.Name = "lbl_TotalBill";
            this.lbl_TotalBill.Size = new System.Drawing.Size(184, 28);
            this.lbl_TotalBill.TabIndex = 5;
            this.lbl_TotalBill.Text = "Tổng tiền đơn hàng";
            // 
            // flp_ContainsBill
            // 
            this.flp_ContainsBill.AutoScroll = true;
            this.flp_ContainsBill.Location = new System.Drawing.Point(3, 133);
            this.flp_ContainsBill.Name = "flp_ContainsBill";
            this.flp_ContainsBill.Size = new System.Drawing.Size(1394, 681);
            this.flp_ContainsBill.TabIndex = 3;
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
            this.Load += new System.EventHandler(this.BillForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flp_Container.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private Guna.UI.WinForms.GunaAdvenceButton btn_SeachForBill;
        private Guna.UI.WinForms.GunaAdvenceButton btn_PayYet;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Paid;
        private Guna.UI.WinForms.GunaTextBox txt_KeyWord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_ThoiGianDat;
        private System.Windows.Forms.Label lbl_GhiChu;
        private System.Windows.Forms.Label lbl_TenNV;
        private System.Windows.Forms.Label lbl_MaHD;
        private System.Windows.Forms.Label lbl_TenKH;
        private System.Windows.Forms.Label lbl_TotalBill;
        private System.Windows.Forms.FlowLayoutPanel flp_ContainsBill;
    }
}