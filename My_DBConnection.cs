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
    }
}
