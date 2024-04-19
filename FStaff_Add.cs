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

namespace MilkTeaShop
{
    public partial class FStaff_Add : Form
    {
        readonly string conStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True";
        public FStaff_Add()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("proc_AddStaff", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    string gender = rdobtnMale.Checked ? "Nam" : "Nữ";

                    cmd.Parameters.AddWithValue("@MaNV", txtID.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtName.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", gender);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DiaChi", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@NgayTuyenDung", dtpDOREC.Value.Date);
                    object selectedJob = cbbIDJOB.SelectedValue;
                    if (selectedJob == null)
                    {
                        selectedJob = cbbIDJOB.SelectedItem;
                    }

                    if (selectedJob != null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@MaCV", SqlDbType.NChar, 10) { Value = selectedJob.ToString() });
                    }
                    else
                    {
                        MessageBox.Show("Please select a job position.");
                        return;
                    }
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee added successfully!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to add employee. Error: " + ex.Message);
                    }
                }
            }
        }
    }
}

