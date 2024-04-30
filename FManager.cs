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
using Guna.UI2.WinForms;
using Guna.UI.WinForms;

namespace MilkTeaShop
{
    public partial class FManager : Form
    {
        My_DBConnection db = new My_DBConnection();
        public FManager()
        {
            InitializeComponent();
        }
        public string Username { get { return txtTaiKhoan.Text; } set { txtTaiKhoan.Text = value; } }
        public string Passowrd { get { return txtMatKhau.Text; } set { txtMatKhau.Text = value; } }
        public string EmpID { get { return txtMaNV.Text; } set { txtMaNV.Text = value; } }

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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Chỉ xóa tài khoản nhân viên
            try
            {
                SqlCommand cmd = new SqlCommand("proc_DeleteUserAccountByUserName", db.getConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 200).Value = txtTaiKhoan.Text;
                db.OpenConn();
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show($"Xóa tài khoản {txtTaiKhoan.Text} thành công !");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                    MessageBox.Show("Không có quyền admin");
            }
            finally
            {
                db.CloseConn();
            }
        }

        private void btnRemoveEmpAcc_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("proc_DeleteEmpoyee", db.getConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 200).Value = txtTaiKhoan.Text;
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar, 10).Value = txtMaNV.Text;
                db.OpenConn();

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show($"Xóa nhân viên {txtMaNV.Text} và tài khoản {txtTaiKhoan.Text} thành công!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                    MessageBox.Show("Không có quyền admin");
            }
            finally
            {
                db.CloseConn();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("proc_UpdateAccount", db.getConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 200).Value = txtTaiKhoan.Text;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 200).Value = txtMatKhau.Text;
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar, 10).Value = txtMaNV.Text;
                db.OpenConn();

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show($"Sửa tài khoản cho nhân viên {txtMaNV.Text} thành công!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                    MessageBox.Show("Không có quyền admin");
            }
            finally
            {
                db.CloseConn();
            }
        }
    }
}
