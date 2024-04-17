using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace MilkTeaShop
{
    public class DBConnection
    {
        //SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        readonly string conStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True";

        public void ExecuteProcedure(string sqlQuery, SqlParameter[] lstParams)
        {
            using(SqlConnection conn = new SqlConnection(conStr))
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
                    MessageBox.Show("Error\n"+ex.Message);
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
                    MessageBox.Show("Read error\n"+ex.Message);
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
                    MessageBox.Show("Read error\n"+ex.Message);
                }
            }
            return resultList;
        }
    }
}
