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

        My_DBConnection db = new My_DBConnection();
        private string ID;
        public FStaff_Detail(string id)
        {
            InitializeComponent();
            this.ID = id;
            LoadDetails();
        }
        private void LoadDetails()
        {
            try
            {
                string sqlQuery = "SELECT * FROM V_ThongTinNhanVien WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                cmd.Parameters.AddWithValue("@MaNV", ID);
                db.OpenConn();
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
                        cbbWorkStatus.SelectedItem = dataReader["TrangThaiLamViec"].ToString().Trim();
                    }
                }
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("proc_EditStaff", db.getConn);
                cmd.CommandType = CommandType.StoredProcedure;
                db.OpenConn();

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
                object selectedWorkStatus = cbbWorkStatus.SelectedValue;
                if (selectedWorkStatus == null)
                {
                    selectedWorkStatus = cbbWorkStatus.SelectedItem;
                }

                if (selectedJob != null)
                {
                    cmd.Parameters.Add(new SqlParameter("@trangthailamviec", SqlDbType.NVarChar, 30) { Value = selectedWorkStatus.ToString() });
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee details updated successfully!");
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("proc_DeleteStaff", db.getConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manv", lblID.Text);
                db.OpenConn();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff deleted successfully!");
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
