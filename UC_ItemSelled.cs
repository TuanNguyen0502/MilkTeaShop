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
    public partial class UC_ItemSelled : UserControl
    {
        public UC_ItemSelled()
        {
            InitializeComponent();
        }

        private void UC_ItemSelled_Click(object sender, EventArgs e)
        {
            if (btn_Valid.Visible == false)
            {
                btn_Valid.Visible = true;
                gunaLinePanel1_Valid.Visible = true;
            }
            else
            {
                btn_Valid.Visible = false;
                gunaLinePanel1_Valid.Visible = false;
            }
        }

        private void gunaLinePanel1_Valid_Click(object sender, EventArgs e)
        {
            if (btn_Valid.Visible == false)
            {
                btn_Valid.Visible = true;
                gunaLinePanel1_Valid.Visible = true;
            }
            else
            {
                btn_Valid.Visible = false;
                gunaLinePanel1_Valid.Visible = false;
            }
        }
    }
}
