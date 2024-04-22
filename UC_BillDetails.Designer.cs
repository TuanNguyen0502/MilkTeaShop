namespace MilkTeaShop
{
    partial class UC_BillDetails
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_MaHD = new System.Windows.Forms.Label();
            this.lbl_TotalBill = new System.Windows.Forms.Label();
            this.lbl_ThoiGianDat = new System.Windows.Forms.Label();
            this.lbl_ListItem = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.6371F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.17931F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0982F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.08539F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_MaHD, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_TotalBill, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ThoiGianDat, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ListItem, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1493, 76);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbl_MaHD
            // 
            this.lbl_MaHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MaHD.AutoSize = true;
            this.lbl_MaHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHD.Location = new System.Drawing.Point(50, 24);
            this.lbl_MaHD.Name = "lbl_MaHD";
            this.lbl_MaHD.Size = new System.Drawing.Size(118, 28);
            this.lbl_MaHD.TabIndex = 6;
            this.lbl_MaHD.Text = "Mã hóa đơn";
            // 
            // lbl_TotalBill
            // 
            this.lbl_TotalBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TotalBill.AutoSize = true;
            this.lbl_TotalBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalBill.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_TotalBill.Location = new System.Drawing.Point(1250, 24);
            this.lbl_TotalBill.Name = "lbl_TotalBill";
            this.lbl_TotalBill.Size = new System.Drawing.Size(184, 28);
            this.lbl_TotalBill.TabIndex = 5;
            this.lbl_TotalBill.Text = "Tổng tiền đơn hàng";
            // 
            // lbl_ThoiGianDat
            // 
            this.lbl_ThoiGianDat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ThoiGianDat.AutoSize = true;
            this.lbl_ThoiGianDat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThoiGianDat.Location = new System.Drawing.Point(955, 24);
            this.lbl_ThoiGianDat.Name = "lbl_ThoiGianDat";
            this.lbl_ThoiGianDat.Size = new System.Drawing.Size(127, 28);
            this.lbl_ThoiGianDat.TabIndex = 9;
            this.lbl_ThoiGianDat.Text = "Thời gian đặt";
            // 
            // lbl_ListItem
            // 
            this.lbl_ListItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ListItem.AutoSize = true;
            this.lbl_ListItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListItem.Location = new System.Drawing.Point(437, 24);
            this.lbl_ListItem.Name = "lbl_ListItem";
            this.lbl_ListItem.Size = new System.Drawing.Size(190, 28);
            this.lbl_ListItem.TabIndex = 7;
            this.lbl_ListItem.Text = "Danh sách sản phẩm";
            // 
            // UC_BillDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_BillDetails";
            this.Size = new System.Drawing.Size(1508, 84);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_ThoiGianDat;
        private System.Windows.Forms.Label lbl_ListItem;
        private System.Windows.Forms.Label lbl_MaHD;
        private System.Windows.Forms.Label lbl_TotalBill;
    }
}
