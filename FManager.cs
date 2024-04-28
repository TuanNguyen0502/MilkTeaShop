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
            try
            {
                string sqlQuery = "proc_CreateAccount";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = txtTaiKhoan.Text;
                cmd.Parameters.Add("@UserPassword", SqlDbType.VarChar, 100).Value = txtMatKhau.Text;
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar, 10).Value = txtMaNV.Text;
                db.OpenConn();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show($"Tạo tài khoản cho nhân viên {txtMaNV.Text} thành công");
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thất bại");
                }
            } 
            catch(SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Không có quyền admin!");
                }
                else
                {
                    MessageBox.Show("Lỗi: "+ex.Message);
                }
            }
            catch
            {
                db.CloseConn();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
