using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MilkTeaShop
{
    public partial class FSalesAtTheCounter : Form
    {
        readonly string conStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True";
        DBConnection dbConn = new DBConnection();
        string sqlQuery;
        private string manv;
        public FSalesAtTheCounter(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }
        public void GetSalesAtTheCounter()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                sqlQuery = "SELECT * FROM v_DoanhThuTaiQuayTrongNgay";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UC_AtCounter item = new UC_AtCounter();
                        item.ProductNamee = (string)reader["TenSP"];
                        item.ProductID = (string)reader["MaSP"];
                        item.Sales = (decimal)reader["Doanh thu tại quầy"];
                        item.Quantity = (int)reader["Số lượng tại quầy"];
                        flp_Contains.Controls.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa bán sản phẩm nào !");
                }
            }
        }

        private void FSalesAtTheCounter_Load(object sender, EventArgs e)
        {
            lbl_SalesCounter.Text = $"Doanh thu tại quầy [{DateTime.Now}]";
            GetSalesAtTheCounter();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
