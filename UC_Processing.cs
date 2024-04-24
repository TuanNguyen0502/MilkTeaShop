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
    public partial class UC_Processing : UserControl
    {
        private string productname;
        private int quantity;
        private string unit;
        public string ProducName { get => productname; set { productname = value; lbl_ProductName.Text = value; } }
        public string Unit { get => unit; set { unit = value; lbl_Unit.Text = value; } }
        public int Quantity { get => quantity; set { quantity = value; lbl_Quantity.Text = value.ToString(); } }
        public UC_Processing()
        {
            InitializeComponent();
        }
    }
}
