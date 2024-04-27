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
    public partial class FLogin_User : Form
    {
        My_DBConnection db = new My_DBConnection();
        public FLogin_User()
        {
            InitializeComponent();
        }

        private void FLogin_User_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            GLOBAL.Username = txtTaiKhoan.Text;
            GLOBAL.Password = txtMatKhau.Text;
            string sqlQuery = "SELECT dbo.func_CheckLogin(@Username, @Password);";
            SqlCommand cmd = new SqlCommand(sqlQuery, db.getConnAdmin);
            db.OpenConnAdmin();
            SqlParameter[] lstParam =
            {
                new SqlParameter("@Username", SqlDbType.VarChar) {Value = txtTaiKhoan.Text},
                new SqlParameter("@Password", SqlDbType.VarChar) {Value = txtMatKhau.Text},
            };
            cmd.Parameters.AddRange(lstParam);
            bool success = (bool)cmd.ExecuteScalar();

            if (success)
            {
                MessageBox.Show("Đăng nhập thành công!");
                FMain fMain = new FMain();
                fMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Tài khoản hoặc mật khẩu không hợp lệ !");
                db.CloseConnAdmin();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gckb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = gckb_ShowPass.Checked ? '\0' : '*';
        }
    }
}
