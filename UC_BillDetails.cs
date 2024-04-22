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
    public partial class UC_BillDetails : UserControl
    {
        #region
        private int mahd;
        private string listItem;
        private DateTime orderTime;
        private decimal totalBill;
        public int MaHD { get { return mahd; } set { mahd = value; lbl_MaHD.Text = value.ToString(); } }
        public string ListItem { get { return listItem; } set { listItem = value; lbl_ListItem.Text = value; } }
        public DateTime OrderTime { get { return orderTime; } set { orderTime = value; lbl_ThoiGianDat.Text = value.ToLongDateString(); } }
        public decimal TotalBill { get { return totalBill; } set { totalBill = value; lbl_TotalBill.Text = value.ToString(); } }
        #endregion
        public UC_BillDetails()
        {
            InitializeComponent();
        }
    }
}
