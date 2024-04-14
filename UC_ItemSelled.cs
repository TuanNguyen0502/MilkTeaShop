using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
