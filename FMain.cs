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
        private string manv;
        public FMain(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }
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
            OpenChildForm(new FSellForm(manv));
        }

        private void button_Customer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCustomer());
        }

        private void button_Receipt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FBillForm());
        }

        private void button_Ingredient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FIngredient());
        }

        private void button_Employee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FStaff());
        }

        private void button_Report_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FReport());
        }

        private void button_Nhaphang_Click(object sender, EventArgs e)
        { if (button_nhapNL.Visible)
            {
                button_nhapSP.Visible = false;
                button_nhapNL.Visible = false;
            }
        else
            {
                button_nhapSP.Visible = true;
                button_nhapNL.Visible = true;
            }
        }

        private void button_nhapSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FImportProduct());
        }

        private void button_nhapNL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FImportIngredients());
        }

        private void button_App_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FSuppliers());
        }

        private void button_xuatNL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FExport_Ingredients());
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            Program.MainFormManager.CurrentForm = new FLogin_User();
        }

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            FManager manager = new FManager();
            manager.ShowDialog();
        }
    }
}
