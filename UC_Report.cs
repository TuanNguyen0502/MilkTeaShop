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
    public partial class UC_Report : UserControl
    {
        private DateTime time;
        private decimal sales;
        public DateTime Time { get { return time; } set { time = value; lblTime.Text = $"Ngày {value.Day} Tháng {value.Month} Năm {value.Year}"; } }
        public decimal Sales { get { return sales; } set { sales = value; lbl_Sales.Text = value.ToString() + " VNĐ"; } }
        public UC_Report()
        {
            InitializeComponent();
        }
    }
}
