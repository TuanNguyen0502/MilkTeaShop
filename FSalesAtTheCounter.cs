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
        My_DBConnection db = new My_DBConnection();
        string sqlQuery;
        private string manv;
        public FSalesAtTheCounter(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }
        public void GetSalesAtTheCounter()
        {
            try
            {
                db.OpenConn();
                sqlQuery = "SELECT * FROM v_DoanhThuTaiQuayTrongNgay";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
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
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                    MessageBox.Show("Bị hạn chế quyền.\n"+ex.Message);
            }
            finally
            {
                db.CloseConn();
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
