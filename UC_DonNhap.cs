using Guna.UI.WinForms;
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
    public partial class UC_DonNhap : UserControl
    {
        public delegate void DetailButtonClickedHandler(string orderID);
        public event DetailButtonClickedHandler OnDetailButtonClicked;

        public UC_DonNhap()
        {
            InitializeComponent();
        }
        public GunaLabel LblMaDN { get => lblMaDN; set => lblMaDN = value; }
        public GunaLabel LblImportDate { get => lblNgayNhap; set => lblNgayNhap = value; }
        public GunaLabel LblTriGia { get => lblTongDon; set => lblTongDon = value; }
        public GunaLabel LblTenNCC { get => lblTenNCC; set => lblTenNCC = value; }

        private void button_Detail_Click(object sender, EventArgs e)
        {
            OnDetailButtonClicked?.Invoke(this.LblMaDN.Text);
        }
    }
}
