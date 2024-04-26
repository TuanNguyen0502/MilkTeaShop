using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MilkTeaShop
{
    public class My_DBConnection
    {
        SqlConnection connRegular = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop; User ID = " + GLOBAL.Username + ";Password=" + GLOBAL.Password + ";");
        public SqlConnection getConnRegular
        {
            get { return connRegular; }
        }

        SqlConnection connAdmin = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True");
        public SqlConnection getConnAdmin
        {
            get { return connAdmin; }
        }
        public void OpenConnRegular()
        {
            if (connRegular.State == ConnectionState.Closed)
                connRegular.Open();
        }
        public void CloseConnRegular()
        {
            if (connRegular.State == ConnectionState.Open)
                connRegular.Close();
        }
        public void OpenConnAdmin()
        {
            if (connRegular.State == ConnectionState.Closed)
                connAdmin.Open();
        }
        public void CloseConnAdmin()
        {
            if (connRegular.State == ConnectionState.Open)
                connAdmin.Close();
        }
    }
}
