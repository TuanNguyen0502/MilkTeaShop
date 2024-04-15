using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            LoadStaff();
        }
        public void LoadStaff()
        {
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
        }
    }
}
