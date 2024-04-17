using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MilkTeaShop
{
    public partial class FStaff_Detail : Form
    {
        readonly string conStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True";

        private string ID;
        public FStaff_Detail(string id)
        {
            InitializeComponent();
            this.ID = id;
            LoadDetails();
        }

        private void LoadDetails()
        {
            string sqlQuery = "SELECT * FROM NhanVien WHERE MaNV = @MaNV";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", ID);

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                                                       
                            lblID.Text = dataReader["MaNV"].ToString();
                            txtName.Text = dataReader["HoTen"].ToString();
                            if (dataReader["GioiTinh"].ToString() == "Nam")
                            {
                                rdobtnMale.Checked = true;
                            }
                            else if (dataReader["GioiTinh"].ToString() == "Nữ")
                            {
                                rdobtnFemale.Checked = true;
                            }
                            dtpDOB.Value = Convert.ToDateTime(dataReader["NgaySinh"]);
                            txtAddress.Text = dataReader["DiaChi"].ToString();
                            txtPhone.Text = dataReader["SDT"].ToString();
                            dtpDOREC.Value = Convert.ToDateTime(dataReader["NgayTuyenDung"]);                           
                            cbbIDJOB.SelectedItem = dataReader["MaCV"].ToString().Trim();
                        }
                    }
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("proc_EditStaff", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        string gender = rdobtnMale.Checked ? "Nam" : "Nữ";                        

                        cmd.Parameters.AddWithValue("@manv", lblID.Text);
                        cmd.Parameters.AddWithValue("@hoten", txtName.Text);
                        cmd.Parameters.AddWithValue("@gioitinh", gender);
                        cmd.Parameters.AddWithValue("@ngaysinh", dtpDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@diachi", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@sdt", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@ngaytuyendung", dtpDOREC.Value.Date);
                        object selectedJob = cbbIDJOB.SelectedValue;
                        if (selectedJob == null)
                        {
                            selectedJob = cbbIDJOB.SelectedItem;
                        }

                        if (selectedJob != null)
                        {
                            cmd.Parameters.Add(new SqlParameter("@MaCV", SqlDbType.NChar, 10) { Value = selectedJob.ToString() });
                        }
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee details updated successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update employee details. Error: " + ex.Message);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
