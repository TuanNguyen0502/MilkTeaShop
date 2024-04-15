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
    public partial class UC_ItemSelected : UserControl
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
        private string makh;
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
            set { thoigianban = value; lbl_BuyDate.Text = value.ToShortDateString(); }
        }
        public Image Icon
        {
            get { return icon; }
            set { icon = value; this.BackgroundImage = value; }
        }
        public string MaKH
        {
            get { return makh; }
            set { makh = value; lbl_MaKH.Text = value; }
        }
        #endregion
        public GunaNumeric Numeric_Quantities
        {
            get { return numeric_Quantities; }
            set { numeric_Quantities = value; }
        }
        public UC_ItemSelected()
        {
            InitializeComponent();
        }
    }
}
