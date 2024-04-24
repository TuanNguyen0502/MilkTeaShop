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
    public partial class FProcessing : Form
    {
        readonly string conStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True";
        string sqlQuery;
        private string masp;
        private string tensp;
        public FProcessing(string MaSP, string TenSP)
        {
            InitializeComponent();
            this.masp = MaSP;
            this.tensp = TenSP;
        }
        private void FProcessing_Load(object sender, EventArgs e)
        {

        }
        public void GetProcessingByMaSP()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                sqlQuery = "exec proc_LayCongThucCheBien @MaSP";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@MaSP", masp);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                    }
                }
                else
                {
                    MessageBox.Show($"Không có sản phẩm nào có mã {masp}");
                }
            }
        }

    }
}
