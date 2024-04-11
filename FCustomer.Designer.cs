namespace MilkTeaShop
{
    partial class FCustomer
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
            this.flowLayoutPanel_Top = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Top
            // 
            this.flowLayoutPanel_Top.Controls.Add(this.label1);
            this.flowLayoutPanel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel_Top.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_Top.Name = "flowLayoutPanel_Top";
            this.flowLayoutPanel_Top.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel_Top.Size = new System.Drawing.Size(1742, 100);
            this.flowLayoutPanel_Top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // FCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1742, 658);
            this.Controls.Add(this.flowLayoutPanel_Top);
            this.Name = "FCustomer";
            this.Text = "FCustomer";
            this.flowLayoutPanel_Top.ResumeLayout(false);
            this.flowLayoutPanel_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Top;
        private System.Windows.Forms.Label label1;
    }
}