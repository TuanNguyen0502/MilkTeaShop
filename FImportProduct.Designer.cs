namespace MilkTeaShop
{
    partial class FImportProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTongDon = new Guna.UI.WinForms.GunaLabel();
            this.lblNgayNhap = new Guna.UI.WinForms.GunaLabel();
            this.lblMaDNSP = new Guna.UI.WinForms.GunaLabel();
            this.lblTenNCC = new Guna.UI.WinForms.GunaLabel();
            this.btnLuuDon = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnThemSP = new Guna.UI.WinForms.GunaButton();
            this.btnTaoDon = new Guna.UI.WinForms.GunaButton();
            this.txtMaSP = new Guna.UI.WinForms.GunaTextBox();
            this.lblMaSP = new Guna.UI.WinForms.GunaLabel();
            this.txtDonGia = new Guna.UI.WinForms.GunaTextBox();
            this.lblDonGia = new Guna.UI.WinForms.GunaLabel();
            this.txtSoLuong = new Guna.UI.WinForms.GunaTextBox();
            this.lblSoLuong = new Guna.UI.WinForms.GunaLabel();
            this.txtDonVi = new Guna.UI.WinForms.GunaTextBox();
            this.lblDonVi = new Guna.UI.WinForms.GunaLabel();
            this.groupBoxDNSP = new System.Windows.Forms.GroupBox();
            this.flpDSDNSP = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMaNCC = new Guna.UI.WinForms.GunaTextBox();
            this.dgvProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblMaNCC = new Guna.UI.WinForms.GunaLabel();
            this.groupBoxNhapSP = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxDNSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBoxNhapSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(964, 55);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.1875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.60417F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.79167F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.52083F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.532424F));
            this.tableLayoutPanel1.Controls.Add(this.lblTongDon, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNgayNhap, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMaDNSP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTenNCC, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(961, 46);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblTongDon
            // 
            this.lblTongDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTongDon.AutoSize = true;
            this.lblTongDon.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDon.Location = new System.Drawing.Point(357, 11);
            this.lblTongDon.Name = "lblTongDon";
            this.lblTongDon.Size = new System.Drawing.Size(144, 23);
            this.lblTongDon.TabIndex = 33;
            this.lblTongDon.Text = "Trị giá đơn nhập";
            this.lblTongDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.Location = new System.Drawing.Point(177, 11);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(97, 23);
            this.lblNgayNhap.TabIndex = 32;
            this.lblNgayNhap.Text = "Ngày nhập";
            this.lblNgayNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaDNSP
            // 
            this.lblMaDNSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaDNSP.AutoSize = true;
            this.lblMaDNSP.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDNSP.Location = new System.Drawing.Point(16, 11);
            this.lblMaDNSP.Name = "lblMaDNSP";
            this.lblMaDNSP.Size = new System.Drawing.Size(86, 23);
            this.lblMaDNSP.TabIndex = 31;
            this.lblMaDNSP.Text = "Mã ĐNSP";
            this.lblMaDNSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNCC.Location = new System.Drawing.Point(644, 11);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(150, 23);
            this.lblTenNCC.TabIndex = 34;
            this.lblTenNCC.Text = "Tên nhà cung cấp";
            this.lblTenNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLuuDon
            // 
            this.btnLuuDon.AnimationHoverSpeed = 0.07F;
            this.btnLuuDon.AnimationSpeed = 0.03F;
            this.btnLuuDon.BaseColor = System.Drawing.SystemColors.Highlight;
            this.btnLuuDon.BorderColor = System.Drawing.Color.Black;
            this.btnLuuDon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLuuDon.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuuDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuuDon.ForeColor = System.Drawing.Color.White;
            this.btnLuuDon.Image = null;
            this.btnLuuDon.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuuDon.Location = new System.Drawing.Point(1233, 205);
            this.btnLuuDon.Name = "btnLuuDon";
            this.btnLuuDon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLuuDon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuuDon.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuuDon.OnHoverImage = null;
            this.btnLuuDon.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuuDon.Size = new System.Drawing.Size(83, 42);
            this.btnLuuDon.TabIndex = 29;
            this.btnLuuDon.Text = "Lưu đơn";
            this.btnLuuDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLuuDon.Click += new System.EventHandler(this.btnLuuDon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BaseColor = System.Drawing.SystemColors.Highlight;
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = null;
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(1233, 275);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(83, 42);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.AnimationHoverSpeed = 0.07F;
            this.btnThemSP.AnimationSpeed = 0.03F;
            this.btnThemSP.BaseColor = System.Drawing.SystemColors.Highlight;
            this.btnThemSP.BorderColor = System.Drawing.Color.Black;
            this.btnThemSP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemSP.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Image = null;
            this.btnThemSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThemSP.Location = new System.Drawing.Point(1233, 343);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThemSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemSP.OnHoverImage = null;
            this.btnThemSP.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemSP.Size = new System.Drawing.Size(83, 42);
            this.btnThemSP.TabIndex = 30;
            this.btnThemSP.Text = "Thêm ";
            this.btnThemSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnTaoDon
            // 
            this.btnTaoDon.AnimationHoverSpeed = 0.07F;
            this.btnTaoDon.AnimationSpeed = 0.03F;
            this.btnTaoDon.BaseColor = System.Drawing.SystemColors.Highlight;
            this.btnTaoDon.BorderColor = System.Drawing.Color.Black;
            this.btnTaoDon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTaoDon.FocusedColor = System.Drawing.Color.Empty;
            this.btnTaoDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTaoDon.ForeColor = System.Drawing.Color.White;
            this.btnTaoDon.Image = null;
            this.btnTaoDon.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTaoDon.Location = new System.Drawing.Point(1233, 50);
            this.btnTaoDon.Name = "btnTaoDon";
            this.btnTaoDon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTaoDon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTaoDon.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTaoDon.OnHoverImage = null;
            this.btnTaoDon.OnPressedColor = System.Drawing.Color.Black;
            this.btnTaoDon.Size = new System.Drawing.Size(83, 42);
            this.btnTaoDon.TabIndex = 28;
            this.btnTaoDon.Text = "Tạo đơn";
            this.btnTaoDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTaoDon.Click += new System.EventHandler(this.btnTaoDon_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.BaseColor = System.Drawing.Color.White;
            this.txtMaSP.BorderColor = System.Drawing.Color.Silver;
            this.txtMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSP.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaSP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaSP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaSP.Location = new System.Drawing.Point(975, 172);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.PasswordChar = '\0';
            this.txtMaSP.SelectedText = "";
            this.txtMaSP.Size = new System.Drawing.Size(223, 43);
            this.txtMaSP.TabIndex = 27;
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.Location = new System.Drawing.Point(886, 183);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(60, 23);
            this.lblMaSP.TabIndex = 26;
            this.lblMaSP.Text = "Mã SP";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BaseColor = System.Drawing.Color.White;
            this.txtDonGia.BorderColor = System.Drawing.Color.Silver;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDonGia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDonGia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDonGia.Location = new System.Drawing.Point(975, 365);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.Size = new System.Drawing.Size(223, 43);
            this.txtDonGia.TabIndex = 25;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(886, 375);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(74, 23);
            this.lblDonGia.TabIndex = 24;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BaseColor = System.Drawing.Color.White;
            this.txtSoLuong.BorderColor = System.Drawing.Color.Silver;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSoLuong.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSoLuong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuong.Location = new System.Drawing.Point(975, 301);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(223, 43);
            this.txtSoLuong.TabIndex = 23;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(886, 310);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(83, 23);
            this.lblSoLuong.TabIndex = 22;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // txtDonVi
            // 
            this.txtDonVi.BaseColor = System.Drawing.Color.White;
            this.txtDonVi.BorderColor = System.Drawing.Color.Silver;
            this.txtDonVi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonVi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDonVi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDonVi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDonVi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDonVi.Location = new System.Drawing.Point(975, 239);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.PasswordChar = '\0';
            this.txtDonVi.SelectedText = "";
            this.txtDonVi.Size = new System.Drawing.Size(223, 43);
            this.txtDonVi.TabIndex = 21;
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonVi.Location = new System.Drawing.Point(886, 250);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(63, 23);
            this.lblDonVi.TabIndex = 20;
            this.lblDonVi.Text = "Đơn vị";
            // 
            // groupBoxDNSP
            // 
            this.groupBoxDNSP.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBoxDNSP.Controls.Add(this.flpDSDNSP);
            this.groupBoxDNSP.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxDNSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDNSP.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDNSP.Location = new System.Drawing.Point(0, 441);
            this.groupBoxDNSP.Name = "groupBoxDNSP";
            this.groupBoxDNSP.Size = new System.Drawing.Size(1399, 495);
            this.groupBoxDNSP.TabIndex = 3;
            this.groupBoxDNSP.TabStop = false;
            this.groupBoxDNSP.Text = "Đơn nhập sản phẩm";
            // 
            // flpDSDNSP
            // 
            this.flpDSDNSP.AutoScroll = true;
            this.flpDSDNSP.BackColor = System.Drawing.Color.White;
            this.flpDSDNSP.Location = new System.Drawing.Point(15, 95);
            this.flpDSDNSP.Name = "flpDSDNSP";
            this.flpDSDNSP.Size = new System.Drawing.Size(962, 432);
            this.flpDSDNSP.TabIndex = 1;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.BaseColor = System.Drawing.Color.White;
            this.txtMaNCC.BorderColor = System.Drawing.Color.Silver;
            this.txtMaNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNCC.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaNCC.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaNCC.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaNCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNCC.Location = new System.Drawing.Point(975, 49);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.PasswordChar = '\0';
            this.txtMaNCC.SelectedText = "";
            this.txtMaNCC.Size = new System.Drawing.Size(223, 43);
            this.txtMaNCC.TabIndex = 19;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeight = 4;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.Location = new System.Drawing.Point(12, 51);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(801, 375);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProducts.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvProducts.ThemeStyle.ReadOnly = false;
            this.dgvProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProducts.ThemeStyle.RowsStyle.Height = 24;
            this.dgvProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.Location = new System.Drawing.Point(886, 60);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(75, 23);
            this.lblMaNCC.TabIndex = 18;
            this.lblMaNCC.Text = "Mã NCC";
            // 
            // groupBoxNhapSP
            // 
            this.groupBoxNhapSP.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBoxNhapSP.Controls.Add(this.btnLuuDon);
            this.groupBoxNhapSP.Controls.Add(this.btnXoa);
            this.groupBoxNhapSP.Controls.Add(this.btnThemSP);
            this.groupBoxNhapSP.Controls.Add(this.btnTaoDon);
            this.groupBoxNhapSP.Controls.Add(this.txtMaSP);
            this.groupBoxNhapSP.Controls.Add(this.lblMaSP);
            this.groupBoxNhapSP.Controls.Add(this.txtDonGia);
            this.groupBoxNhapSP.Controls.Add(this.lblDonGia);
            this.groupBoxNhapSP.Controls.Add(this.txtSoLuong);
            this.groupBoxNhapSP.Controls.Add(this.lblSoLuong);
            this.groupBoxNhapSP.Controls.Add(this.txtDonVi);
            this.groupBoxNhapSP.Controls.Add(this.lblDonVi);
            this.groupBoxNhapSP.Controls.Add(this.txtMaNCC);
            this.groupBoxNhapSP.Controls.Add(this.dgvProducts);
            this.groupBoxNhapSP.Controls.Add(this.lblMaNCC);
            this.groupBoxNhapSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxNhapSP.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNhapSP.Location = new System.Drawing.Point(0, 0);
            this.groupBoxNhapSP.Name = "groupBoxNhapSP";
            this.groupBoxNhapSP.Size = new System.Drawing.Size(1399, 441);
            this.groupBoxNhapSP.TabIndex = 2;
            this.groupBoxNhapSP.TabStop = false;
            this.groupBoxNhapSP.Text = "Nhập sản phẩm";
            // 
            // FImportProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 936);
            this.Controls.Add(this.groupBoxDNSP);
            this.Controls.Add(this.groupBoxNhapSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FImportProduct";
            this.Text = "FImportProduct";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxDNSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBoxNhapSP.ResumeLayout(false);
            this.groupBoxNhapSP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel lblTongDon;
        private Guna.UI.WinForms.GunaLabel lblNgayNhap;
        private Guna.UI.WinForms.GunaLabel lblMaDNSP;
        private Guna.UI.WinForms.GunaLabel lblTenNCC;
        private Guna.UI.WinForms.GunaButton btnLuuDon;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnThemSP;
        private Guna.UI.WinForms.GunaButton btnTaoDon;
        private Guna.UI.WinForms.GunaTextBox txtMaSP;
        private Guna.UI.WinForms.GunaLabel lblMaSP;
        private Guna.UI.WinForms.GunaTextBox txtDonGia;
        private Guna.UI.WinForms.GunaLabel lblDonGia;
        private Guna.UI.WinForms.GunaTextBox txtSoLuong;
        private Guna.UI.WinForms.GunaLabel lblSoLuong;
        private Guna.UI.WinForms.GunaTextBox txtDonVi;
        private Guna.UI.WinForms.GunaLabel lblDonVi;
        private System.Windows.Forms.GroupBox groupBoxDNSP;
        private System.Windows.Forms.FlowLayoutPanel flpDSDNSP;
        private Guna.UI.WinForms.GunaTextBox txtMaNCC;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProducts;
        private Guna.UI.WinForms.GunaLabel lblMaNCC;
        private System.Windows.Forms.GroupBox groupBoxNhapSP;
    }
}