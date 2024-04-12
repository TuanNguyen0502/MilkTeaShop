using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaShop
{
    public class DBConnection
    {
        //SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        readonly string conStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True";

        // Các phương thức để đọc và ghi dữ liệu từ cơ sở dữ liệu mysql server
        public void ExecuteDeleteData(string sqlStr, SqlParameter[] lstParam)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    // Ket noi
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddRange(lstParam);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Delete data successful !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !\n" + ex.Message);
                }
            }
        }
        public void ExecuteDeleteData(string sqlStr)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    // Ket noi
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Delete data Successful !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !\n" + ex.Message);
                }
            }
        }
        public void ExecuteWriteData(string sqlStr, SqlParameter[] lstParam)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    // Ket noi
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddRange(lstParam);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Write data successful !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !\n" + ex.Message);
                }
            }
        }
        public void ExecuteWriteData(string sqlStr)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    // Ket noi
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Write data Successful !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error !\n" + ex.Message);
                }
            }
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
        public object ExecuteScalar(string sqlStr, SqlParameter[] lstParam)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddRange(lstParam);
                    object obj = cmd.ExecuteScalar();
                    return obj;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Read error\n" + ex.Message);
                    return null;
                }
            }
        }
    }
}
