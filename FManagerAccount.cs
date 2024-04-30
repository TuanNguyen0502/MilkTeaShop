using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MilkTeaShop
{
    public partial class FManagerAccount : Form
    {
        private Form currentFormChild;
        FlowLayoutPanel flp_ContainsAccount;
        My_DBConnection db = new My_DBConnection();
        public FManagerAccount()
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
            //childForm.Dock = DockStyle.Fill;
            pnlCenter.Controls.Add(childForm);
            pnlCenter.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void seeAccount_Click(object sender, AccountEventArg e)
        {
            FManager manager = new FManager();
            manager.Username = e.Username;
            manager.Passowrd = e.Password;
            manager.EmpID = e.EmpID;
            manager.ShowDialog();
        }

        public void LoadUserAccounts()
        {
            try
            {
                flp_ContainsAccount = new FlowLayoutPanel();
                flp_ContainsAccount.Size = new Size(920, 605);
                UC_Account acc = new UC_Account();
                flp_ContainsAccount.Controls.Add(acc);
                SqlCommand cmd = new SqlCommand("SELECT * FROM vie_SeeAccount", db.getConn);
                db.OpenConn();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UC_Account accn = new UC_Account();
                        accn.UserName = reader.GetString(0);
                        accn.Password = reader.GetString(1);
                        accn.EmpID = reader.GetString(2);
                        accn.SeeAccount_Click += seeAccount_Click;
                        flp_ContainsAccount.Controls.Add(accn);
                    }
                }
                pnlCenter.Controls.Add(flp_ContainsAccount);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                    MessageBox.Show("Bị hạn chế quyền\n"+ex.Message);
            }
            finally
            {
                db.CloseConn();
            }
        }
        private void FManagerAccount_Load(object sender, EventArgs e)
        {
            LoadUserAccounts();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            pnlCenter.Controls.Clear();
            pnlCenter.Dock = DockStyle.Fill;
            LoadUserAccounts();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FManager());
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            FManager manage = new FManager();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
