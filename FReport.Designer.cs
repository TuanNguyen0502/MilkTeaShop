namespace MilkTeaShop
{
    partial class FReport
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_OptionMain = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdb_Year = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdb_Month = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_DMY = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rdb_Day = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_From = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_To = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.flp_ContainsHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_ContainsReport = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbb_OptionMain);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 60);
            this.panel1.TabIndex = 2;
            // 
            // cbb_OptionMain
            // 
            this.cbb_OptionMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_OptionMain.BackColor = System.Drawing.Color.Transparent;
            this.cbb_OptionMain.BaseColor = System.Drawing.Color.White;
            this.cbb_OptionMain.BorderColor = System.Drawing.Color.Silver;
            this.cbb_OptionMain.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_OptionMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_OptionMain.FocusedColor = System.Drawing.Color.Empty;
            this.cbb_OptionMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_OptionMain.ForeColor = System.Drawing.Color.Black;
            this.cbb_OptionMain.FormattingEnabled = true;
            this.cbb_OptionMain.Items.AddRange(new object[] {
            "Doanh thu",
            "Khoản chi"});
            this.cbb_OptionMain.Location = new System.Drawing.Point(707, 12);
            this.cbb_OptionMain.Name = "cbb_OptionMain";
            this.cbb_OptionMain.OnHoverItemBaseColor = System.Drawing.Color.Tomato;
            this.cbb_OptionMain.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbb_OptionMain.Radius = 6;
            this.cbb_OptionMain.Size = new System.Drawing.Size(237, 31);
            this.cbb_OptionMain.TabIndex = 9;
            this.cbb_OptionMain.SelectedIndexChanged += new System.EventHandler(this.cbb_OptionMain_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(531, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "BÁO CÁO DOANH THU VÀ KHOẢN CHI";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.16088F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163822F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.867165F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.867165F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.867165F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.72156F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.930389F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.24573F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.930389F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.24573F));
            this.tableLayoutPanel1.Controls.Add(this.rdb_Year, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdb_Month, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtp_DMY, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdb_Day, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtp_From, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtp_To, 9, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1447, 56);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // rdb_Year
            // 
            this.rdb_Year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_Year.AutoSize = true;
            this.rdb_Year.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdb_Year.CheckedState.BorderThickness = 0;
            this.rdb_Year.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdb_Year.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdb_Year.CheckedState.InnerOffset = -4;
            this.rdb_Year.ForeColor = System.Drawing.Color.Tomato;
            this.rdb_Year.Location = new System.Drawing.Point(576, 18);
            this.rdb_Year.Name = "rdb_Year";
            this.rdb_Year.Size = new System.Drawing.Size(57, 20);
            this.rdb_Year.TabIndex = 22;
            this.rdb_Year.Text = "Năm";
            this.rdb_Year.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdb_Year.UncheckedState.BorderThickness = 2;
            this.rdb_Year.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdb_Year.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdb_Year.CheckedChanged += new System.EventHandler(this.rdb_Year_CheckedChanged);
            // 
            // rdb_Month
            // 
            this.rdb_Month.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_Month.AutoSize = true;
            this.rdb_Month.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdb_Month.CheckedState.BorderThickness = 0;
            this.rdb_Month.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdb_Month.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdb_Month.CheckedState.InnerOffset = -4;
            this.rdb_Month.ForeColor = System.Drawing.Color.Tomato;
            this.rdb_Month.Location = new System.Drawing.Point(458, 18);
            this.rdb_Month.Name = "rdb_Month";
            this.rdb_Month.Size = new System.Drawing.Size(67, 20);
            this.rdb_Month.TabIndex = 21;
            this.rdb_Month.Text = "Tháng";
            this.rdb_Month.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdb_Month.UncheckedState.BorderThickness = 2;
            this.rdb_Month.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdb_Month.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdb_Month.CheckedChanged += new System.EventHandler(this.rdb_Month_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(685, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Doanh thu theo giai đoạn";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(964, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Từ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lọc theo :";
            // 
            // dtp_DMY
            // 
            this.dtp_DMY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_DMY.Checked = true;
            this.dtp_DMY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_DMY.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_DMY.Location = new System.Drawing.Point(4, 10);
            this.dtp_DMY.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_DMY.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_DMY.Name = "dtp_DMY";
            this.dtp_DMY.Size = new System.Drawing.Size(196, 36);
            this.dtp_DMY.TabIndex = 16;
            this.dtp_DMY.Value = new System.DateTime(2024, 4, 22, 11, 18, 53, 940);
            // 
            // rdb_Day
            // 
            this.rdb_Day.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_Day.AutoSize = true;
            this.rdb_Day.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdb_Day.CheckedState.BorderThickness = 0;
            this.rdb_Day.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdb_Day.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdb_Day.CheckedState.InnerOffset = -4;
            this.rdb_Day.ForeColor = System.Drawing.Color.Tomato;
            this.rdb_Day.Location = new System.Drawing.Point(348, 18);
            this.rdb_Day.Name = "rdb_Day";
            this.rdb_Day.Size = new System.Drawing.Size(61, 20);
            this.rdb_Day.TabIndex = 20;
            this.rdb_Day.Text = "Ngày";
            this.rdb_Day.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdb_Day.UncheckedState.BorderThickness = 2;
            this.rdb_Day.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdb_Day.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdb_Day.CheckedChanged += new System.EventHandler(this.rdb_Day_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1206, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Đến";
            // 
            // dtp_From
            // 
            this.dtp_From.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_From.Checked = true;
            this.dtp_From.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_From.Location = new System.Drawing.Point(1020, 10);
            this.dtp_From.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_From.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(171, 36);
            this.dtp_From.TabIndex = 24;
            this.dtp_From.Value = new System.DateTime(2024, 4, 22, 11, 18, 53, 940);
            // 
            // dtp_To
            // 
            this.dtp_To.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_To.Checked = true;
            this.dtp_To.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_To.Location = new System.Drawing.Point(1271, 10);
            this.dtp_To.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_To.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(170, 36);
            this.dtp_To.TabIndex = 25;
            this.dtp_To.Value = new System.DateTime(2024, 4, 22, 11, 18, 53, 940);
            // 
            // flp_ContainsHeader
            // 
            this.flp_ContainsHeader.Location = new System.Drawing.Point(0, 128);
            this.flp_ContainsHeader.Name = "flp_ContainsHeader";
            this.flp_ContainsHeader.Size = new System.Drawing.Size(1447, 57);
            this.flp_ContainsHeader.TabIndex = 6;
            // 
            // flp_ContainsReport
            // 
            this.flp_ContainsReport.Location = new System.Drawing.Point(0, 191);
            this.flp_ContainsReport.Name = "flp_ContainsReport";
            this.flp_ContainsReport.Size = new System.Drawing.Size(1470, 615);
            this.flp_ContainsReport.TabIndex = 7;
            // 
            // FReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 818);
            this.Controls.Add(this.flp_ContainsReport);
            this.Controls.Add(this.flp_ContainsHeader);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FReport";
            this.Text = "FReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaComboBox cbb_OptionMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flp_ContainsReport;
        private System.Windows.Forms.FlowLayoutPanel flp_ContainsHeader;
        private Guna.UI2.WinForms.Guna2RadioButton rdb_Year;
        private Guna.UI2.WinForms.Guna2RadioButton rdb_Month;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_DMY;
        private Guna.UI2.WinForms.Guna2RadioButton rdb_Day;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_From;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_To;
    }
}