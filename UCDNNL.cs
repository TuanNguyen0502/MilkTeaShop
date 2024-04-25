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
    public partial class UCDNNL : UserControl
    {
        public delegate void DetailButtonClickedHandler(string orderID);
        public event DetailButtonClickedHandler OnDetailButtonClicked;

        public UCDNNL()
        {
            InitializeComponent();
        }
        public GunaLabel LblMaDNNL { get => lblMaDNNL; set => lblMaDNNL = value; }
        public GunaLabel LblImportDate { get => lblNgayNhap; set => lblNgayNhap = value; }
        public GunaLabel LblTriGia { get => lblTongDon; set => lblTongDon = value; }
        public GunaLabel LblTenNCC { get => lblTenNCC; set => lblTenNCC = value; }

        private void button_Detail_Click(object sender, EventArgs e)
        {
            OnDetailButtonClicked?.Invoke(this.LblMaDNNL.Text);

        }
    }
}
