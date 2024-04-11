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
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }

        private void btn_AllBill_Click(object sender, EventArgs e)
        {
            UC_BillInfomation billInfomation = new UC_BillInfomation();
            flp_Container.Controls.Add(billInfomation);
        }
    }
}
