using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaShop
{
    public partial class FCustomer_Detail : Form
    {
        private string sdt;
        readonly string connStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True";
        DBConnection dBConnection = new DBConnection();

        public FCustomer_Detail(string sdt)
        {
            InitializeComponent();
            this.sdt = sdt;
            if (sdt != null)
            {
                textBox_Phone.ReadOnly = true;
            }
        }

        private void FCustomer_Detail_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (sdt != null)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sqlQuery = $"SELECT TenKH, SDT, GioiTinh, NgaySinh " +
                        $"FROM KhachHang WHERE SDT = '{sdt}'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            textBox_Name.Text = reader.GetString(0);
                            textBox_Phone.Text = reader.GetString(1);
                            string gender = reader.GetString(2);
                            if (gender == "Nam" || gender == "nam")
                            {
                                radioButton_Male.Checked = true;
                            }
                            else
                            {
                                radioButton_Female.Checked = true;
                            }
                            dateTimePicker_DOB.Value = reader.GetDateTime(3);
                        }
                    }
                    else
                        MessageBox.Show("No rows found");
                }
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string gender = radioButton_Male.Checked ? "Nam" : "Nữ";
            Customer customer = new Customer(textBox_Name.Text, textBox_Phone.Text, gender, dateTimePicker_DOB.Value.ToString());

            if (sdt == null)
            {
                //if (customer.CheckAllCondition())
                {
                    string sqlQuery = "exec proc_CreateCustomer @TenKhachHang, @SDT, @GioiTinh, @NgaySinh";
                    SqlParameter[] lstParams =
                    {
                        new SqlParameter("@TenKhachHang", SqlDbType.NVarChar) {Value = customer.Name},
                        new SqlParameter("@SDT", SqlDbType.NChar) {Value = customer.Phone},
                        new SqlParameter("@GioiTinh", SqlDbType.NVarChar) { Value = customer.Gender},
                        new SqlParameter("@NgaySinh", SqlDbType.Date) {Value = customer.Dob},
                    };
                    dBConnection.ExecuteProcedure(sqlQuery, lstParams);
                    this.Close();
                }
            }
            else
            {
                //if (customer.CheckAllCondition())
                {
                    string sqlQuery = "exec proc_UpdateCustomer @TenKhachHang, @SDT, @GioiTinh, @NgaySinh";
                    SqlParameter[] lstParams =
                    {
                        new SqlParameter("@TenKhachHang", SqlDbType.NVarChar) {Value = customer.Name},
                        new SqlParameter("@SDT", SqlDbType.NChar) {Value = customer.Phone},
                        new SqlParameter("@GioiTinh", SqlDbType.NVarChar) { Value = customer.Gender},
                        new SqlParameter("@NgaySinh", SqlDbType.Date) {Value = customer.Dob},
                    };
                    dBConnection.ExecuteProcedure(sqlQuery, lstParams);
                    this.Close();
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string sqlQuery = "exec proc_DeleteCustomer @SDT";
            SqlParameter[] lstParams =
            {
                        new SqlParameter("@SDT", SqlDbType.NChar) {Value = textBox_Phone.Text},
            };
            dBConnection.ExecuteProcedure(sqlQuery, lstParams);
            this.Close();
        }
    }
}
