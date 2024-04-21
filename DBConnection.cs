using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MilkTeaShop
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DIEMQUYNH;Initial Catalog=MilkTeaShop;Integrated Security=True;Encrypt=False");

        public DataTable LoadData (string query)
        {
            string sqlStr = string.Format(query);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conStr);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        //SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        readonly string conStr = @"Data Source=DIEMQUYNH;Initial Catalog=MilkTeaShop;Integrated Security=True;Encrypt=False";
        public void ThucThi(string thucthi)
        {
            try
            {
                conn.Open();
                string sqlStr = thucthi;
                SqlCommand command = new SqlCommand(sqlStr, conn);
                if(command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
            finally
            {
                conn.Close();
            }

        }
        public void ExecuteProcedure(string sqlQuery, SqlParameter[] lstParams)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                        cmd.Parameters.AddRange(lstParams);
                        if (cmd.ExecuteNonQuery() > 0)
                            MessageBox.Show("Execute procedure successful !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex.Message);
                }
            }
        }
        public List<Dictionary<string, object>> ExecuteReaderData_Function(string sqlQuery, SqlParameter[] lstParams)
        {
            List<Dictionary<string, object>> resultList = new List<Dictionary<string, object>>();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddRange(lstParams);

                    // Sử dụng SqlDataAdapter để điền dữ liệu từ hàm vào DataTable
                    DataTable resultTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }

                    // Duyệt qua từng dòng dữ liệu trong DataTable và thêm chúng vào danh sách kết quả
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
            return resultList;
        }

        public List<Dictionary<string, object>> ExecuteReaderData(string sqlStr)
        {
            List<Dictionary<string, object>> resultList = new List<Dictionary<string, object>>();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
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
            return resultList;
        }

        public List<Dictionary<string, object>> ExecuteReaderData(string sqlStr, SqlParameter[] lstParam)
        {
            List<Dictionary<string, object>> resultList = new List<Dictionary<string, object>>();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddRange(lstParam);
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
            return resultList;
        }
    }
}
