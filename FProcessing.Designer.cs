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
            this.flp_Processing = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_MeterialLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
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
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 69);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 15.2F);
            this.lbl_Title.Location = new System.Drawing.Point(11, 18);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(425, 36);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Tên sản phẩm [Tên nguyên liệu cần]";
            // 
            // flp_Processing
            // 
            this.flp_Processing.AutoScroll = true;
            this.flp_Processing.Controls.Add(this.label1);
            this.flp_Processing.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_Processing.Location = new System.Drawing.Point(0, 69);
            this.flp_Processing.Name = "flp_Processing";
            this.flp_Processing.Size = new System.Drawing.Size(529, 428);
            this.flp_Processing.TabIndex = 1;
            // 
            // flp_MeterialLeft
            // 
            this.flp_MeterialLeft.AutoScroll = true;
            this.flp_MeterialLeft.Controls.Add(this.label2);
            this.flp_MeterialLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_MeterialLeft.Location = new System.Drawing.Point(529, 69);
            this.flp_MeterialLeft.Name = "flp_MeterialLeft";
            this.flp_MeterialLeft.Size = new System.Drawing.Size(539, 428);
            this.flp_MeterialLeft.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(158, 5, 5, 5);
            this.label1.Size = new System.Drawing.Size(357, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Công thức chế biến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(158, 5, 5, 5);
            this.label2.Size = new System.Drawing.Size(355, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nguyên liệu còn lại";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Tomato;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1014, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 1;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // FProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 497);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.FlowLayoutPanel flp_MeterialLeft;
        private System.Windows.Forms.FlowLayoutPanel flp_Processing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}