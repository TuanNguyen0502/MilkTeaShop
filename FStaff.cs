﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MilkTeaShop
{
    public partial class FStaff : Form
    {
        readonly string conStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True";
        public FStaff()
        {
            InitializeComponent();
            LoadStaff_Working();
            cbbWorkStatus.Text = "Đang làm việc";
        }
        public void LoadStaff()
        {
            flpanelListStaff.Controls.Clear();
            string sqlQuery = "SELECT * FROM V_ThongTinNhanVien";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            UC_Staff staff = new UC_Staff();
                            staff.LblID.Text = dataReader["MaNV"].ToString();
                            staff.LblName.Text = dataReader["HoTen"].ToString();
                            staff.LblSex.Text = dataReader["GioiTinh"].ToString();
                            DateTime dob = dataReader.GetDateTime(dataReader.GetOrdinal("NgaySinh"));
                            staff.LblDob.Text = dob.ToString("yyyy-MM-dd");
                            staff.LblAddress.Text = dataReader["DiaChi"].ToString();
                            staff.LblPhone.Text = dataReader["SDT"].ToString();
                            DateTime ngayTuyenDung = dataReader.GetDateTime(dataReader.GetOrdinal("NgayTuyenDung"));
                            staff.LblNgayTuyenDung.Text = ngayTuyenDung.ToString("yyyy-MM-dd");
                            staff.LblJob.Text = dataReader["TenCV"].ToString();
                            staff.LblSalary.Text = dataReader["Luong"].ToString();

                            flpanelListStaff.Controls.Add(staff);
                        }
                    }
                }
            }
            foreach (Control control in flpanelListStaff.Controls)
            {
                if (control is UC_Staff staffControl)
                {
                    staffControl.OnDetailsUpdated += (s, e) => LoadStaff();
                }
            }
        }

        public void LoadStaff_Working()
        {
            string sqlQuery = "SELECT * FROM V_ThongTinNhanVienDangLamViec";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            UC_Staff staff = new UC_Staff();
                            staff.LblID.Text = dataReader["MaNV"].ToString();
                            staff.LblName.Text = dataReader["HoTen"].ToString();
                            staff.LblSex.Text = dataReader["GioiTinh"].ToString();
                            DateTime dob = dataReader.GetDateTime(dataReader.GetOrdinal("NgaySinh"));
                            staff.LblDob.Text = dob.ToString("yyyy-MM-dd");
                            staff.LblAddress.Text = dataReader["DiaChi"].ToString();
                            staff.LblPhone.Text = dataReader["SDT"].ToString();
                            DateTime ngayTuyenDung = dataReader.GetDateTime(dataReader.GetOrdinal("NgayTuyenDung"));
                            staff.LblNgayTuyenDung.Text = ngayTuyenDung.ToString("yyyy-MM-dd");
                            staff.LblJob.Text = dataReader["TenCV"].ToString();
                            staff.LblSalary.Text = dataReader["Luong"].ToString();

                            flpanelListStaff.Controls.Add(staff);
                        }
                    }
                }
            }
            foreach (Control control in flpanelListStaff.Controls)
            {
                if (control is UC_Staff staffControl)
                {
                    staffControl.OnDetailsUpdated += (s, e) => LoadStaff_Working();
                }
            }
        }

        public void LoadStaff_Layoff()
        {
            flpanelListStaff.Controls.Clear();
            string sqlQuery = "SELECT * FROM V_ThongTinNhanVienNghiViec";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            UC_Staff staff = new UC_Staff();
                            staff.LblID.Text = dataReader["MaNV"].ToString();
                            staff.LblName.Text = dataReader["HoTen"].ToString();
                            staff.LblSex.Text = dataReader["GioiTinh"].ToString();
                            DateTime dob = dataReader.GetDateTime(dataReader.GetOrdinal("NgaySinh"));
                            staff.LblDob.Text = dob.ToString("yyyy-MM-dd");
                            staff.LblAddress.Text = dataReader["DiaChi"].ToString();
                            staff.LblPhone.Text = dataReader["SDT"].ToString();
                            DateTime ngayTuyenDung = dataReader.GetDateTime(dataReader.GetOrdinal("NgayTuyenDung"));
                            staff.LblNgayTuyenDung.Text = ngayTuyenDung.ToString("yyyy-MM-dd");
                            staff.LblJob.Text = dataReader["TenCV"].ToString();
                            staff.LblSalary.Text = dataReader["Luong"].ToString();

                            flpanelListStaff.Controls.Add(staff);
                        }
                    }
                }
            }
            foreach (Control control in flpanelListStaff.Controls)
            {
                if (control is UC_Staff staffControl)
                {
                    staffControl.OnDetailsUpdated += (s, e) => LoadStaff_Layoff();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           FStaff_Add fStaff_Add = new FStaff_Add();
            if (fStaff_Add.ShowDialog() == DialogResult.OK)
            {
                LoadStaff_Working();
            }
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            flpanelListStaff.Controls.Clear();
            string keyword = txtSearch.Text.Trim();
            string sqlQuery = "SELECT * FROM func_FindStaff(@keyword)";

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", keyword);

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            UC_Staff staff = new UC_Staff();
                            staff.LblID.Text = dataReader["MaNV"].ToString();
                            staff.LblName.Text = dataReader["HoTen"].ToString();
                            staff.LblSex.Text = dataReader["GioiTinh"].ToString();
                            DateTime dob = dataReader.GetDateTime(dataReader.GetOrdinal("NgaySinh"));
                            staff.LblDob.Text = dob.ToString("yyyy-MM-dd");
                            staff.LblAddress.Text = dataReader["DiaChi"].ToString();
                            staff.LblPhone.Text = dataReader["SDT"].ToString();
                            DateTime hiringDate = dataReader.GetDateTime(dataReader.GetOrdinal("NgayTuyenDung"));
                            staff.LblNgayTuyenDung.Text = hiringDate.ToString("yyyy-MM-dd");
                            staff.LblJob.Text = dataReader["TenCV"].ToString();
                            staff.LblSalary.Text = dataReader["Luong"].ToString();

                            flpanelListStaff.Controls.Add(staff);
                        }
                    }
                }
            }
        }

        private void cbbWorkStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbWorkStatus.SelectedIndex == 0)
            {
                LoadStaff();
            }
            else if (cbbWorkStatus.SelectedIndex == 1) 
            {
                LoadStaff_Working(); 
            }
            else
            {
                LoadStaff_Layoff();
            }
        }
    }
}
