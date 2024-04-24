using Guna.UI2.WinForms;
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
    public partial class UC_Suppliers : UserControl
    {
        Suppliers sup;
        FSuppliers fSup;
        public UC_Suppliers()
        {
            InitializeComponent();
        }
        public Guna2HtmlLabel Lbl_NameNCC { get => lbl_NameNCC; set => lbl_NameNCC = value; }
        public Guna2HtmlLabel Lbl_SDT { get => lbl_SDT; set => lbl_SDT = value; }
        public Guna2HtmlLabel Lbl_DiaChi { get => lbl_DiaChi; set => lbl_DiaChi = value; }
        public Guna2HtmlLabel Lbl_MaNCC { get => lbl_MaNCC; set => lbl_MaNCC = value; }

        public UC_Suppliers(Suppliers SUP, FSuppliers FSUP)
        {
            InitializeComponent();
            this.fSup = FSUP;
            this.Click += showinf;
            this.sup = SUP;
            this.lbl_MaNCC.Text = SUP.MaNCC;
            this.lbl_NameNCC.Text = SUP.TenNCC;
            this.lbl_SDT.Text = SUP.SdtNCC;
            this.lbl_DiaChi.Text = SUP.DiaChiNCC;
        }

        public void showinf(object sender, EventArgs e)
        {
            fSup.Txt_MaNCC.Text = this.lbl_MaNCC.Text;
            fSup.Txt_NameNCC.Text = this.lbl_NameNCC.Text;
            fSup.Txt_SDT.Text = this.lbl_SDT.Text;
            fSup.Txt_DiaChi.Text = this.lbl_DiaChi.Text;
        }

        private void lbl_MaNCC_Click(object sender, EventArgs e)
        {

        }
    }
}
