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
    public partial class FMain : Form
    {
        private Form currentFormChild;

        public FMain()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Center.Controls.Add(childForm);
            panel_Center.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_Sell_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SellForm());
        }
    }
}
