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
        SqlConnection connRegular = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;
                                        User ID="+GLOBAL.Username+";Password="+GLOBAL.Password+";");
        public void ShowConnRegular()
        {
            MessageBox.Show(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;User ID="+GLOBAL.Username+";Password="+GLOBAL.Password+";");
        }
        public SqlConnection getConnRegular
        {
            get { return connRegular; }
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
    }
}
