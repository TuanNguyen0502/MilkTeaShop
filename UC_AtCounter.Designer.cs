namespace MilkTeaShop
{
    partial class UC_AtCounter
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
            this.lbl_ProductID = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Sales = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.62887F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.34278F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.68557F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.34278F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Sales, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Quantity, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ProductName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ProductID, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(828, 66);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_ProductID
            // 
            this.lbl_ProductID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ProductID.AutoSize = true;
            this.lbl_ProductID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductID.Location = new System.Drawing.Point(423, 5);
            this.lbl_ProductID.Name = "lbl_ProductID";
            this.lbl_ProductID.Size = new System.Drawing.Size(93, 56);
            this.lbl_ProductID.TabIndex = 7;
            this.lbl_ProductID.Text = "IDProduct";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.Location = new System.Drawing.Point(144, 19);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(130, 28);
            this.lbl_ProductName.TabIndex = 8;
            this.lbl_ProductName.Text = "Tên sản phẩm";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(730, 19);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(92, 28);
            this.lbl_Quantity.TabIndex = 9;
            this.lbl_Quantity.Text = "Số lượng";
            // 
            // lbl_Sales
            // 
            this.lbl_Sales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Sales.AutoSize = true;
            this.lbl_Sales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales.Location = new System.Drawing.Point(568, 19);
            this.lbl_Sales.Name = "lbl_Sales";
            this.lbl_Sales.Size = new System.Drawing.Size(109, 28);
            this.lbl_Sales.TabIndex = 10;
            this.lbl_Sales.Text = "Doanh thu ";
            // 
            // UC_AtCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_AtCounter";
            this.Size = new System.Drawing.Size(834, 72);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Sales;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_ProductID;
    }
}
