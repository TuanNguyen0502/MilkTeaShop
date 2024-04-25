using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaShop
{
    public partial class FCustomer : Form
    {
        readonly string connStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True;Encrypt=False";

        public FCustomer()
        {
            InitializeComponent();
        }

        private void button_AddCustomer_Click(object sender, EventArgs e)
        {
            FCustomer_Detail fCustomer_Detail = new FCustomer_Detail(null);
            fCustomer_Detail.ShowDialog();
        }

        private void FCustomer_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }

        private void LoadInfor()
        {
            string sqlQuery = $"SELECT TenKH, SDT, GioiTinh, NgaySinh FROM v_ThongTinKhachHang";
            List<Dictionary<string, object>> resultList = new List<Dictionary<string, object>>();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> rowData = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowData.Add(reader.GetName(i), reader.GetValue(i));
                            }
                            resultList.Add(rowData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Read error\n" + ex.Message);
                }
            }

            List<UC_Customer> items = new List<UC_Customer>();
            foreach (var row in resultList)
            {
                UC_Customer item = new UC_Customer(row["SDT"].ToString());
                item.Label_Name.Text = row["TenKH"].ToString();
                item.Label_Phone.Text = row["SDT"].ToString();
                item.Label_Gender.Text = row["GioiTinh"].ToString();
                DateTime dob = (DateTime)row["NgaySinh"];
                string formattedPostTime = dob.ToString("yyyy-MM-dd");
                item.Label_DOB.Text = formattedPostTime;
                items.Add(item);
            }

            foreach (var item in items)
            {
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT * FROM func_FindCustomer(@keyword)";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@keyword", SqlDbType.NVarChar) {Value = textBox_Search.Text},
            };

            List<Dictionary<string, object>> resultList = new List<Dictionary<string, object>>();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddRange(lstParams);

                    DataTable resultTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }

                    foreach (DataRow row in resultTable.Rows)
                    {
                        Dictionary<string, object> rowData = new Dictionary<string, object>();
                        foreach (DataColumn col in resultTable.Columns)
                        {
                            rowData.Add(col.ColumnName, row[col]);
                        }
                        resultList.Add(rowData);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Read error\n" + ex.Message);
                }
            }
            flowLayoutPanel1.Controls.Clear();
            foreach (var keyValue in resultList)
            {
                UC_Customer item = new UC_Customer((string)keyValue["SDT"]);
                item.Label_Name.Text = (string)keyValue["TenKH"];
                item.Label_Phone.Text = (string)keyValue["SDT"];
                item.Label_Gender.Text = (string)keyValue["GioiTinh"];
                DateTime dob = (DateTime)keyValue["NgaySinh"];
                item.Label_DOB.Text = dob.ToString("yyyy-MM-d");

                flowLayoutPanel1.Controls.Add(item);
            }
        }
    }
}
