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
    public partial class UC_Customer : UserControl
    {
        private string maKH;

        public UC_Customer()
        {
            InitializeComponent();
        }

        public string MaKH { get => maKH; set => maKH = value; }

        private void button_Detail_Click(object sender, EventArgs e)
        {
            FCustomer_Detail fCustomer_Detail = new FCustomer_Detail();
            fCustomer_Detail.ShowDialog();
        }
    }
}
