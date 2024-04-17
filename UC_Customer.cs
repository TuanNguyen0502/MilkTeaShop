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
    public partial class UC_Customer : UserControl
    {
        private string sdt;
        public UC_Customer(string sdt)
        {
            InitializeComponent();
            this.sdt = sdt;
        }

        public GunaLabel Label_Name { get => label_Name; set => label_Name = value; }
        public GunaLabel Label_Phone { get => label_Phone; set => label_Phone = value; }
        public GunaLabel Label_Gender { get => label_Gender; set => label_Gender = value; }
        public GunaLabel Label_DOB { get => label_DOB; set => label_DOB = value; }

        private void button_Detail_Click(object sender, EventArgs e)
        {
            FCustomer_Detail fCustomer_Detail = new FCustomer_Detail(sdt);
            fCustomer_Detail.ShowDialog();
        }
    }
}
