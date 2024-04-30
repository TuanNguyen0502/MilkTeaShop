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
    public partial class UC_Account : UserControl
    {
        private string username;
        private string pass;
        private string empid;

        public string UserName { get { return username; } set { username = value; lbl_Username.Text = value; } }
        public string Password { get { return pass; } set { pass=value; lblPassword.Text = value; } }
        public string EmpID { get { return empid; } set { empid=value; lbl_EmpID.Text = value; } }
        public UC_Account()
        {
            InitializeComponent();
        }

        private void UC_Account_Load(object sender, EventArgs e)
        {

        }
        public event EventHandler<AccountEventArg> SeeAccount_Click;
        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            SeeAccount_Click?.Invoke(this, new AccountEventArg(UserName, Password, EmpID));
        }
    }
}
