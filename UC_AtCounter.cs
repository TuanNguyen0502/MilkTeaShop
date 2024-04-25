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
    public partial class UC_AtCounter : UserControl
    {
        private string productName;
        private string productID;
        private int quantity;
        private decimal sales;
        public string ProductNamee { get => productName; set { productName = value; lbl_ProductName.Text = value; } }
        public string ProductID { get => productID; set { productID = value; lbl_ProductID.Text = value; } }
        public int Quantity { get => quantity; set { quantity = value; lbl_Quantity.Text = value.ToString(); } }
        public decimal Sales { get => sales; set { sales = value; lbl_Sales.Text = value.ToString(); } }
        public UC_AtCounter()
        {
            InitializeComponent();
        }
    }
}
