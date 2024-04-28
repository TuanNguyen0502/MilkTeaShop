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
    public partial class FManager : Form
    {
        My_DBConnection db = new My_DBConnection();
        public FManager()
        {
            InitializeComponent();
        }

        private void FManager_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string sqlQuery = "proc_CreateAccount";
            SqlCommand cmd = new SqlCommand(sqlQuery, db.getConnRegular);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = txtTaiKhoan.Text;
            cmd.Parameters.Add("@UserPassword", SqlDbType.VarChar, 100).Value = txtMatKhau.Text;
            cmd.Parameters.Add("@MaNV", SqlDbType.VarChar, 10).Value = txtMaNV.Text;
            db.OpenConnRegular();

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show($"Tạo tài khoản cho nhân viên {txtMaNV.Text} thành công");
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại");
                db.CloseConnRegular();
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
