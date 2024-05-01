using System;
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
        My_DBConnection db = new My_DBConnection();
        public FStaff()
        {
            InitializeComponent();
            cbbWorkStatus.Text = "Đang làm việc";
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
        public void LoadStaff()
        {
            try
            {
                flpanelListStaff.Controls.Clear();
                string sqlQuery = "SELECT * FROM V_ThongTinNhanVien";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                db.OpenConn();
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
                foreach (Control control in flpanelListStaff.Controls)
                {
                    if (control is UC_Staff staffControl)
                    {
                        staffControl.OnDetailsUpdated += (s, e) => LoadStaff();
                    }
                }
            }
            catch ( SqlException ex )
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
        public void LoadStaff_Working()
        {
            try
            {
                flpanelListStaff.Controls.Clear();
                string sqlQuery = "SELECT * FROM V_ThongTinNhanVienDangLamViec";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                db.OpenConn();
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
                foreach (Control control in flpanelListStaff.Controls)
                {
                    if (control is UC_Staff staffControl)
                    {
                        staffControl.OnDetailsUpdated += (s, e) => LoadStaff_Working();
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
        public void LoadStaff_Layoff()
        {
            try
            {
                flpanelListStaff.Controls.Clear();
                string sqlQuery = "SELECT * FROM V_ThongTinNhanVienNghiViec";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                db.OpenConn();
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
                foreach (Control control in flpanelListStaff.Controls)
                {
                    if (control is UC_Staff staffControl)
                    {
                        staffControl.OnDetailsUpdated += (s, e) => LoadStaff_Layoff();
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
           FStaff_Add fStaff_Add = new FStaff_Add();
            if (fStaff_Add.ShowDialog() == DialogResult.OK)
            {
                LoadStaff_Working();
            }
        }
        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {
                flpanelListStaff.Controls.Clear();
                string keyword = txtSearch.Text.Trim();
                string sqlQuery = "SELECT * FROM func_FindStaff(@keyword)";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                cmd.Parameters.AddWithValue("@keyword", keyword);
                db.OpenConn();
                
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
