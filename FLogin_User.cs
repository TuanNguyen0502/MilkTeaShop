﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Wordprocessing;

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
        public string GetMaNVByAccount(string Username)
        {
            string sqlQuery = "SELECT dbo.func_GetMaNVByUsername(@Username)";
            SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
            cmd.Parameters.AddWithValue("@Username", Username);
            string MaNV = (string)cmd.ExecuteScalar();
            return MaNV;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            GLOBAL.Username = txtTaiKhoan.Text;
            GLOBAL.Password = txtMatKhau.Text;
            string sqlQuery = "SELECT dbo.func_CheckLogin(@Username, @Password);";
            SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
            SqlParameter[] lstParam =
            {
                new SqlParameter("@Username", SqlDbType.VarChar) {Value = txtTaiKhoan.Text},
                new SqlParameter("@Password", SqlDbType.VarChar) {Value = txtMatKhau.Text},
            };
            cmd.Parameters.AddRange(lstParam);
            db.OpenConn();
            bool success = (bool)cmd.ExecuteScalar();

            if (success)
            {
                MessageBox.Show("Đăng nhập thành công!");
                string MaNV = GetMaNVByAccount(txtTaiKhoan.Text);
                Program.MainFormManager.CurrentForm = new FMain(MaNV);
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Tài khoản hoặc mật khẩu không hợp lệ !");
            }
            db.CloseConn();
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
