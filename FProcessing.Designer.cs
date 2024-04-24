namespace MilkTeaShop
{
    partial class FProcessing
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flp_Processing = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_MeterialLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.flp_Processing.SuspendLayout();
            this.flp_MeterialLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 69);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.lbl_Title.Location = new System.Drawing.Point(11, 18);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(345, 30);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Tên sản phẩm [Tên nguyên liệu cần]";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.label2.Size = new System.Drawing.Size(166, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Công thức chế biến";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.label3.Size = new System.Drawing.Size(163, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nguyên liệu còn lại";
            // 
            // flp_Processing
            // 
            this.flp_Processing.Controls.Add(this.label2);
            this.flp_Processing.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_Processing.Location = new System.Drawing.Point(0, 69);
            this.flp_Processing.Name = "flp_Processing";
            this.flp_Processing.Size = new System.Drawing.Size(403, 341);
            this.flp_Processing.TabIndex = 1;
            // 
            // flp_MeterialLeft
            // 
            this.flp_MeterialLeft.Controls.Add(this.label3);
            this.flp_MeterialLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_MeterialLeft.Location = new System.Drawing.Point(403, 69);
            this.flp_MeterialLeft.Name = "flp_MeterialLeft";
            this.flp_MeterialLeft.Size = new System.Drawing.Size(394, 341);
            this.flp_MeterialLeft.TabIndex = 2;
            // 
            // FProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.flp_MeterialLeft);
            this.Controls.Add(this.flp_Processing);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FProcessing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FProcessing";
            this.Load += new System.EventHandler(this.FProcessing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flp_Processing.ResumeLayout(false);
            this.flp_Processing.PerformLayout();
            this.flp_MeterialLeft.ResumeLayout(false);
            this.flp_MeterialLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.FlowLayoutPanel flp_MeterialLeft;
        private System.Windows.Forms.FlowLayoutPanel flp_Processing;
    }
}