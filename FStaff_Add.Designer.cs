﻿namespace MilkTeaShop
{
    partial class FStaff_Add
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
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.cbbIDJOB = new Guna.UI.WinForms.GunaComboBox();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.txtAddress = new Guna.UI.WinForms.GunaTextBox();
            this.dtpDOREC = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpDOB = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblContext = new Guna.UI.WinForms.GunaLabel();
            this.lblJob = new Guna.UI.WinForms.GunaLabel();
            this.lblDOB = new Guna.UI.WinForms.GunaLabel();
            this.lblAddress = new Guna.UI.WinForms.GunaLabel();
            this.lblPhone = new Guna.UI.WinForms.GunaLabel();
            this.lblSex = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.lblMaNV = new Guna.UI.WinForms.GunaLabel();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.lblDOREC = new Guna.UI.WinForms.GunaLabel();
            this.panelInfo = new Guna.UI.WinForms.GunaPanel();
            this.txtID = new Guna.UI.WinForms.GunaTextBox();
            this.rdobtnFemale = new Guna.UI.WinForms.GunaRadioButton();
            this.rdobtnMale = new Guna.UI.WinForms.GunaRadioButton();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = null;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(438, 509);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(83, 42);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbbIDJOB
            // 
            this.cbbIDJOB.BackColor = System.Drawing.Color.Transparent;
            this.cbbIDJOB.BaseColor = System.Drawing.Color.White;
            this.cbbIDJOB.BorderColor = System.Drawing.Color.Silver;
            this.cbbIDJOB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbIDJOB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIDJOB.FocusedColor = System.Drawing.Color.Empty;
            this.cbbIDJOB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbIDJOB.ForeColor = System.Drawing.Color.Black;
            this.cbbIDJOB.Items.AddRange(new object[] {
            "CV001",
            "CV002",
            "CV003",
            "CV004",
            "CV005",
            "CV006"});
            this.cbbIDJOB.Location = new System.Drawing.Point(539, 367);
            this.cbbIDJOB.Name = "cbbIDJOB";
            this.cbbIDJOB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbIDJOB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbIDJOB.Size = new System.Drawing.Size(142, 31);
            this.cbbIDJOB.TabIndex = 16;
            // 
            // txtPhone
            // 
            this.txtPhone.BaseColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(178, 223);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(223, 43);
            this.txtPhone.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(178, 87);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(554, 43);
            this.txtName.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.BaseColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.Location = new System.Drawing.Point(178, 152);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(554, 43);
            this.txtAddress.TabIndex = 11;
            // 
            // dtpDOREC
            // 
            this.dtpDOREC.BaseColor = System.Drawing.Color.White;
            this.dtpDOREC.BorderColor = System.Drawing.Color.Silver;
            this.dtpDOREC.CustomFormat = null;
            this.dtpDOREC.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDOREC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDOREC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDOREC.ForeColor = System.Drawing.Color.Black;
            this.dtpDOREC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOREC.Location = new System.Drawing.Point(178, 362);
            this.dtpDOREC.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDOREC.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDOREC.Name = "dtpDOREC";
            this.dtpDOREC.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDOREC.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDOREC.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDOREC.OnPressedColor = System.Drawing.Color.Black;
            this.dtpDOREC.Size = new System.Drawing.Size(223, 43);
            this.dtpDOREC.TabIndex = 10;
            this.dtpDOREC.Text = "4/17/2024";
            this.dtpDOREC.Value = new System.DateTime(2024, 4, 17, 0, 0, 0, 0);
            // 
            // dtpDOB
            // 
            this.dtpDOB.BaseColor = System.Drawing.Color.White;
            this.dtpDOB.BorderColor = System.Drawing.Color.Silver;
            this.dtpDOB.CustomFormat = null;
            this.dtpDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDOB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDOB.ForeColor = System.Drawing.Color.Black;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(178, 292);
            this.dtpDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDOB.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDOB.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDOB.OnPressedColor = System.Drawing.Color.Black;
            this.dtpDOB.Size = new System.Drawing.Size(223, 43);
            this.dtpDOB.TabIndex = 9;
            this.dtpDOB.Text = "4/17/2024";
            this.dtpDOB.Value = new System.DateTime(2024, 4, 17, 0, 0, 0, 0);
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContext.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblContext.Location = new System.Drawing.Point(280, 8);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(241, 31);
            this.lblContext.TabIndex = 5;
            this.lblContext.Text = "Thêm Nhân Viên Mới";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(445, 370);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(88, 23);
            this.lblJob.TabIndex = 7;
            this.lblJob.Text = "Công việc";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(63, 301);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(89, 23);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "Ngày sinh";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(87, 163);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 23);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(109, 232);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 23);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "SĐT";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(445, 301);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(80, 23);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "Giới tính";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(65, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Họ và tên";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(88, 25);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(64, 23);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã NV";
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BaseColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(277, 509);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(83, 42);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDOREC
            // 
            this.lblDOREC.AutoSize = true;
            this.lblDOREC.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOREC.Location = new System.Drawing.Point(3, 370);
            this.lblDOREC.Name = "lblDOREC";
            this.lblDOREC.Size = new System.Drawing.Size(149, 23);
            this.lblDOREC.TabIndex = 6;
            this.lblDOREC.Text = "Ngày tuyển dụng";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelInfo.Controls.Add(this.rdobtnFemale);
            this.panelInfo.Controls.Add(this.rdobtnMale);
            this.panelInfo.Controls.Add(this.txtID);
            this.panelInfo.Controls.Add(this.cbbIDJOB);
            this.panelInfo.Controls.Add(this.txtPhone);
            this.panelInfo.Controls.Add(this.txtName);
            this.panelInfo.Controls.Add(this.txtAddress);
            this.panelInfo.Controls.Add(this.dtpDOREC);
            this.panelInfo.Controls.Add(this.dtpDOB);
            this.panelInfo.Controls.Add(this.lblJob);
            this.panelInfo.Controls.Add(this.lblDOREC);
            this.panelInfo.Controls.Add(this.lblDOB);
            this.panelInfo.Controls.Add(this.lblAddress);
            this.panelInfo.Controls.Add(this.lblPhone);
            this.panelInfo.Controls.Add(this.lblSex);
            this.panelInfo.Controls.Add(this.lblName);
            this.panelInfo.Controls.Add(this.lblMaNV);
            this.panelInfo.Location = new System.Drawing.Point(20, 49);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(758, 454);
            this.panelInfo.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.BaseColor = System.Drawing.Color.White;
            this.txtID.BorderColor = System.Drawing.Color.Silver;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.Location = new System.Drawing.Point(178, 15);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(223, 43);
            this.txtID.TabIndex = 17;
            // 
            // rdobtnFemale
            // 
            this.rdobtnFemale.BaseColor = System.Drawing.SystemColors.Control;
            this.rdobtnFemale.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdobtnFemale.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdobtnFemale.FillColor = System.Drawing.Color.White;
            this.rdobtnFemale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdobtnFemale.Location = new System.Drawing.Point(616, 301);
            this.rdobtnFemale.Name = "rdobtnFemale";
            this.rdobtnFemale.Size = new System.Drawing.Size(52, 24);
            this.rdobtnFemale.TabIndex = 19;
            this.rdobtnFemale.Text = "Nữ";
            // 
            // rdobtnMale
            // 
            this.rdobtnMale.BaseColor = System.Drawing.SystemColors.Control;
            this.rdobtnMale.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdobtnMale.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdobtnMale.FillColor = System.Drawing.Color.White;
            this.rdobtnMale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdobtnMale.Location = new System.Drawing.Point(534, 301);
            this.rdobtnMale.Name = "rdobtnMale";
            this.rdobtnMale.Size = new System.Drawing.Size(64, 24);
            this.rdobtnMale.TabIndex = 18;
            this.rdobtnMale.Text = "Nam";
            // 
            // FStaff_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(798, 559);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblContext);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FStaff_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStaff_Add";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaComboBox cbbIDJOB;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private Guna.UI.WinForms.GunaTextBox txtAddress;
        private Guna.UI.WinForms.GunaDateTimePicker dtpDOREC;
        private Guna.UI.WinForms.GunaDateTimePicker dtpDOB;
        private Guna.UI.WinForms.GunaLabel lblContext;
        private Guna.UI.WinForms.GunaLabel lblJob;
        private Guna.UI.WinForms.GunaLabel lblDOB;
        private Guna.UI.WinForms.GunaLabel lblAddress;
        private Guna.UI.WinForms.GunaLabel lblPhone;
        private Guna.UI.WinForms.GunaLabel lblSex;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaLabel lblMaNV;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaLabel lblDOREC;
        private Guna.UI.WinForms.GunaPanel panelInfo;
        private Guna.UI.WinForms.GunaTextBox txtID;
        private Guna.UI.WinForms.GunaRadioButton rdobtnFemale;
        private Guna.UI.WinForms.GunaRadioButton rdobtnMale;
    }
}