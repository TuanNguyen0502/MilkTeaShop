using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace MilkTeaShop
{
    public class My_DBConnection
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;
                                        User ID="+GLOBAL.Username+";Password="+GLOBAL.Password+";");
        public SqlConnection getConn
        {
            get { return conn; }
        }
        public void OpenConn()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void CloseConn()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        #region Các hàm thực hiện đọc dữ liệu từ dưới CSDL
        public List<Dictionary<string,object>> ExecuteReader(string sqlQuery, SqlParameter[] lstParams, string obj)
        {
            try
            {
                List<Dictionary<string,object>> lstKeyValue = new List<Dictionary<string, object>>();
                SqlCommand cmd = new SqlCommand(sqlQuery, getConn);
                cmd.Parameters.AddRange(lstParams);
                OpenConn();
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
                        lstKeyValue.Add(rowData);
                    }
                }
                return lstKeyValue;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show($"The EXECUTE permission was dinied on the object '{obj}', database 'MilkTeaShop', schema 'dbo'");
                }
                else
                {
                    MessageBox.Show("Lỗi: "+ex.Message);
                }
                return null;
            }
            finally
            {
                CloseConn();
            }
        }
        public List<Dictionary<string, object>> ExecuteReader(string sqlQuery, string obj)
        {
            try
            {
                List<Dictionary<string, object>> lstKeyValue = new List<Dictionary<string, object>>();
                SqlCommand cmd = new SqlCommand(sqlQuery, getConn);
                OpenConn();
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
                        lstKeyValue.Add(rowData);
                    }
                }
                return lstKeyValue;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Không có quyền sử dụng proc này!");
                }
                else
                {
                    MessageBox.Show($"The EXECUTE permission was dinied on the object '{obj}', database 'MilkTeaShop', schema 'dbo'");
                }
                return null;
            }
            finally
            {
                CloseConn();
            }
        }
        #endregion

        public void ThucThi(string thucthi)
        {
            try
            {
                conn.Open();
                string sqlStr = thucthi;
                SqlCommand command = new SqlCommand(sqlStr, conn);
                if (command.ExecuteNonQuery() > 0)
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
    }
}
