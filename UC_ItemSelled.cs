using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace MilkTeaShop
{
    public partial class UC_ItemSelled : UserControl
    {
        #region
        private string masp;
        private string tensp;
        private int soluong;
        private decimal dongia;
        private string maloaisp;
        private string trangthai;
        private Image icon;
        private DateTime thoigianban;
        public string MaSP
        {
            get { return masp; }
            set { masp = value; }
        }
        public string TenSP
        {
            get { return tensp; }
            set { tensp = value; lbl_NameItem.Text = tensp; }
        }
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public decimal DonGia
        {
            get { return dongia; }
            set { dongia = value; lbl_price.Text = $"{value} VNĐ"; }
        }
        public string MaLoaiSP
        {
            get { return maloaisp; }
            set
            {
                maloaisp = value;
            }
        }
        public string TrangThai
        {
            get { return trangthai; }
            set
            {
                trangthai = value;
            }
        }
        public DateTime ThoiGianBan
        {
            get { return thoigianban; }
            set { thoigianban = value; }
        }
        public Image Icon
        {
            get { return icon; }
            set { icon = value; this.BackgroundImage = value; }
        }
        #endregion
        Label label;
        GunaShadowPanel shadowPanel;
        public UC_ItemSelled()
        {
            InitializeComponent();
        }
        public event EventHandler<ClickButtonEventArg> ClickIntoItemSelling;
        private void UC_ItemSelled_Click(object sender, EventArgs e)
        {
            if (btn_Valid.Visible == false)
            {
                btn_Valid.Visible = true;
                gunaLinePanel1_Valid.Visible = true;
            }
            else
            {
                btn_Valid.Visible = false;
                gunaLinePanel1_Valid.Visible = false;
            }
            ClickIntoItemSelling?.Invoke(this, new ClickButtonEventArg(MaSP, TenSP, DonGia, ThoiGianBan));
        }
        public event EventHandler<ClickButtonEventArg> ClickIntoLineItemSelling;
        private void gunaLinePanel1_Valid_Click(object sender, EventArgs e)
        {
            ClickIntoLineItemSelling?.Invoke(this, new ClickButtonEventArg(MaSP, TenSP, DonGia, ThoiGianBan));
            if (btn_Valid.Visible == false)
            {
                btn_Valid.Visible = true;
                gunaLinePanel1_Valid.Visible = true;
            }
            else
            {
                btn_Valid.Visible = false;
                gunaLinePanel1_Valid.Visible = false;
            }
        }

        private void UC_ItemSelled_Load(object sender, EventArgs e)
        {
            label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI", 9F);
            label.Location = new System.Drawing.Point(14, 12);
            label.Name = "lbl_NameItem_Main";
            label.Size = new System.Drawing.Size(109, 20);
            label.TabIndex = 0;
            label.Text = TenSP;
            shadowPanel = new GunaShadowPanel();
            shadowPanel.Click += shadowpanel_CheBien_Click;
            shadowPanel.BackColor = System.Drawing.Color.Transparent;
            shadowPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            shadowPanel.Controls.Add(label);
            shadowPanel.Location = new System.Drawing.Point(17, 112);
            shadowPanel.Name = "gunaShadowPanel1";
            shadowPanel.ShadowColor = System.Drawing.Color.Black;
            shadowPanel.Size = new System.Drawing.Size(154, 42);
            shadowPanel.TabIndex = 3;

            this.Controls.Add(shadowPanel);
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public event EventHandler<ClickButtonEventArg> ShadowPanel_CheBien_Click;
        private void shadowpanel_CheBien_Click(object sender, EventArgs e)
        {
            ShadowPanel_CheBien_Click?.Invoke(this, new ClickButtonEventArg(MaSP, TenSP, DonGia, ThoiGianBan));
        }
    }
}
