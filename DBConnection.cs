using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        //SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        readonly string conStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True";
        readonly string strConn = @"Data Source=LAPTOP-VT7S57G2\SQLEXPRESS;Initial Catalog=QLCuaHangTraSua;Integrated Security=True";

        public void ExecuteProcedure(string sqlQuery)
        {
            using(SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = sqlQuery;
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
    }
}
