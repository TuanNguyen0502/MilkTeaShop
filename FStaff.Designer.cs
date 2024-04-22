﻿namespace MilkTeaShop
{
    partial class FStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStaff));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblFStaff = new Guna.UI.WinForms.GunaLabel();
            this.flpanelListStaff = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDOREC = new Guna.UI.WinForms.GunaLabel();
            this.lblJob = new Guna.UI.WinForms.GunaLabel();
            this.lblSalary = new Guna.UI.WinForms.GunaLabel();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.lblSex = new Guna.UI.WinForms.GunaLabel();
            this.lblPhone = new Guna.UI.WinForms.GunaLabel();
            this.lblDOB = new Guna.UI.WinForms.GunaLabel();
            this.lblAddress = new Guna.UI.WinForms.GunaLabel();
            this.cbbWorkStatus = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.flpanelListStaff.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.AutoSize = true;
            this.gunaPanel1.Controls.Add(this.cbbWorkStatus);
            this.gunaPanel1.Controls.Add(this.txtSearch);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.btnSearch);
            this.gunaPanel1.Controls.Add(this.btnAdd);
            this.gunaPanel1.Controls.Add(this.lblFStaff);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1635, 89);
            this.gunaPanel1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(288, 37);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(648, 46);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSearch.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedForeColor = System.Drawing.Color.White;
            this.btnSearch.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.CheckedImage")));
            this.btnSearch.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::MilkTeaShop.Properties.Resources.icons8_find_1001;
            this.btnSearch.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.Location = new System.Drawing.Point(961, 37);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Radius = 10;
            this.btnSearch.Size = new System.Drawing.Size(183, 46);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.CheckedImage")));
            this.btnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.Location = new System.Drawing.Point(15, 46);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(264, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm nhân viên";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFStaff
            // 
            this.lblFStaff.AutoSize = true;
            this.lblFStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFStaff.Location = new System.Drawing.Point(11, 7);
            this.lblFStaff.Name = "lblFStaff";
            this.lblFStaff.Size = new System.Drawing.Size(238, 37);
            this.lblFStaff.TabIndex = 0;
            this.lblFStaff.Text = "Quản lý nhân viên";
            // 
            // flpanelListStaff
            // 
            this.flpanelListStaff.AutoScroll = true;
            this.flpanelListStaff.AutoSize = true;
            this.flpanelListStaff.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpanelListStaff.Controls.Add(this.tableLayoutPanel1);
            this.flpanelListStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpanelListStaff.Location = new System.Drawing.Point(0, 89);
            this.flpanelListStaff.Name = "flpanelListStaff";
            this.flpanelListStaff.Size = new System.Drawing.Size(1635, 751);
            this.flpanelListStaff.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.201958F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.7572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.315144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.564684F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.19926F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.68899F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.31222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.498384F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.457069F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Controls.Add(this.lblDOREC, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblJob, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSalary, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSex, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPhone, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDOB, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1632, 51);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDOREC
            // 
            this.lblDOREC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDOREC.AutoSize = true;
            this.lblDOREC.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOREC.Location = new System.Drawing.Point(1111, 13);
            this.lblDOREC.Name = "lblDOREC";
            this.lblDOREC.Size = new System.Drawing.Size(150, 25);
            this.lblDOREC.TabIndex = 9;
            this.lblDOREC.Text = "Ngày tuyển dụng";
            this.lblDOREC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJob
            // 
            this.lblJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(1283, 13);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(90, 25);
            this.lblJob.TabIndex = 10;
            this.lblJob.Text = "Công việc";
            this.lblJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalary
            // 
            this.lblSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(1418, 13);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(63, 25);
            this.lblSalary.TabIndex = 8;
            this.lblSalary.Text = "Lương";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(7, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 25);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Mã NV";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(154, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Họ và tên";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSex
            // 
            this.lblSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(326, 13);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(78, 25);
            this.lblSex.TabIndex = 5;
            this.lblSex.Text = "Giới tính";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(464, 13);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(44, 25);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "SĐT";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDOB
            // 
            this.lblDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(974, 13);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(91, 25);
            this.lblDOB.TabIndex = 6;
            this.lblDOB.Text = "Ngày sinh";
            this.lblDOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(716, 13);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 25);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Địa chỉ";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbWorkStatus
            // 
            this.cbbWorkStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbbWorkStatus.BaseColor = System.Drawing.Color.White;
            this.cbbWorkStatus.BorderColor = System.Drawing.Color.Silver;
            this.cbbWorkStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbWorkStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWorkStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cbbWorkStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbWorkStatus.ForeColor = System.Drawing.Color.Black;
            this.cbbWorkStatus.Items.AddRange(new object[] {
            "Tất cả",
            "Đang làm việc",
            "Đã nghỉ việc"});
            this.cbbWorkStatus.Location = new System.Drawing.Point(1342, 48);
            this.cbbWorkStatus.Name = "cbbWorkStatus";
            this.cbbWorkStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbWorkStatus.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbWorkStatus.Size = new System.Drawing.Size(142, 31);
            this.cbbWorkStatus.TabIndex = 18;
            this.cbbWorkStatus.SelectedIndexChanged += new System.EventHandler(this.cbbWorkStatus_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(1160, 51);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(164, 23);
            this.gunaLabel1.TabIndex = 17;
            this.gunaLabel1.Text = "Trạng thái làm việc";
            // 
            // FStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 840);
            this.Controls.Add(this.flpanelListStaff);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStaff";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.flpanelListStaff.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        private Guna.UI.WinForms.GunaLabel lblFStaff;
        private System.Windows.Forms.FlowLayoutPanel flpanelListStaff;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel lblAddress;
        private Guna.UI.WinForms.GunaLabel lblSex;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaLabel lblID;
        private Guna.UI.WinForms.GunaLabel lblDOB;
        private Guna.UI.WinForms.GunaLabel lblSalary;
        private Guna.UI.WinForms.GunaLabel lblDOREC;
        private Guna.UI.WinForms.GunaLabel lblJob;
        private Guna.UI.WinForms.GunaLabel lblPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI.WinForms.GunaAdvenceButton btnSearch;
        private Guna.UI.WinForms.GunaComboBox cbbWorkStatus;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}