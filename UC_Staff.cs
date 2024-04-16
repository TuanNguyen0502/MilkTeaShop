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
    public partial class UC_Staff : UserControl
    {
        public UC_Staff()
        {
            InitializeComponent();
        }

        public GunaLabel LblID { get => lblID; set => lblID = value; }
        public GunaLabel LblName { get => lblName; set => lblName = value; }
        public GunaLabel LblSex { get => lblSex; set => lblSex = value; }
        public GunaLabel LblDob { get => lblDOB; set => lblDOB = value; }
        public GunaLabel LblAddress { get => lblAddress; set => lblAddress = value; }
        public GunaLabel LblPhone { get => lblPhone; set => lblPhone = value; }
        public GunaLabel LblNgayTuyenDung { get => lblDOREC; set => lblDOREC = value; }
        public GunaLabel LblJob { get => lblJob; set => lblJob = value; }
        public GunaLabel LblSalary { get => lblSalary; set => lblSalary = value; }

        private void button_Detail_Click(object sender, EventArgs e)
        {
            FStaff_Detail fStaff_Detail = new FStaff_Detail();
            fStaff_Detail.ShowDialog();
        }
    }
}
