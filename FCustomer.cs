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
    public partial class FCustomer : Form
    {
        public FCustomer()
        {
            InitializeComponent();
        }

        private void button_AddCustomer_Click(object sender, EventArgs e)
        {
            FCustomer_Detail fCustomer_Detail = new FCustomer_Detail();
            fCustomer_Detail.ShowDialog();
        }

        private void FCustomer_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {

        }
    }
}
