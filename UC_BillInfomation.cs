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
    public partial class UC_BillInfomation : UserControl
    {
        #region
        private int mahd;
        private string sdt;
        private string tenkh;
        private string manv;
        private string tennv;
        private DateTime thoigiandat;
        private decimal trigiahd;
        private string ghichu;
        public int MaHD
        {
            get { return mahd; }
            set { mahd = value; lbl_MaHD.Text = value.ToString(); }
        }
        public string Sdt
        {
            get { return sdt; }
            set { sdt=value; }
        }
        public string TenKH
        {
            get { return tenkh; }
            set { tenkh=value; lbl_TenKH.Text = value.ToString(); }
        }
        public string MaNV
        {
            get { return manv; }
            set { manv=value; }
        }
        public string TenNV
        {
            get { return tennv; }
            set { tennv = value; lbl_TenNV.Text = value; }
        }
        public DateTime ThoiGianDat
        {
            get { return thoigiandat; }
            set { thoigiandat = value; lbl_ThoiGianDat.Text = value.ToLongDateString(); }
        }
        public decimal TriGiaDH
        {
            get { return trigiahd; }
            set { trigiahd = value; lbl_TotalBill.Text = value.ToString() + " VNĐ"; }
        }
        public string GhiChu
        {
            get { return ghichu; }
            set { ghichu = value; lbl_GhiChu.Text = value; }
        }
        #endregion
        public UC_BillInfomation()
        {
            InitializeComponent();
        }
    }
}
