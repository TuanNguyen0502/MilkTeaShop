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
        My_DBConnection db = new My_DBConnection(); 
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
            try
            {
                SqlCommand cmd = new SqlCommand("proc_AddStaff", db.getConn);
                cmd.CommandType = CommandType.StoredProcedure;
                db.OpenConn();

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
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Bị hạn chế quyền\n" + ex.Message);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            finally
            {
                db.CloseConn();
            }
        }
    }
}

