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
    public partial class UCCTDNNL : UserControl
    {
        public UCCTDNNL()
        {
            InitializeComponent();
        }
        public GunaLabel LblTenNL { get => lblTenNL; set => lblTenNL = value; }
        public GunaLabel LblDonVi { get => lblDonVi; set => lblDonVi = value; }
        public GunaLabel LblSoLuong { get => lblSoLuong; set => lblSoLuong = value; }
        public GunaLabel LblDonGia { get => lblDonGia; set => lblDonGia = value; }

    }
}
