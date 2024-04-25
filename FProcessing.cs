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
            UC_Processing p1 = new UC_Processing();
            flp_Processing.Controls.Add(p1);
            UC_Processing p2 = new UC_Processing();
            flp_MeterialLeft.Controls.Add(p2);
            GetProcessingByMaSP();
        }
        public void GetProcessingByMaSP()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                sqlQuery = "exec proc_LayCongThucCheBien @MaSP";
                string[] arrayNL = new string[4];
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@MaSP", masp);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UC_Processing p1 = new UC_Processing();
                        arrayNL[i] = (string)reader["TenNL"];
                        i++;
                        p1.ProducName = (string)reader["TenNL"];
                        p1.Quantity = (int)reader["LieuLuong"];
                        p1.Unit = (string)reader["Don vi che bien"];
                        flp_Processing.Controls.Add(p1);
                        UC_Processing p2 = new UC_Processing();
                        p2.ProducName = (string)reader["TenNL"];
                        p2.Quantity = (int)reader["SoLuong"];
                        p2.Unit = (string)reader["Don vi nguyen lieu"];
                        flp_MeterialLeft.Controls.Add(p2);
                    }
                    lbl_Title.Text = $"{tensp} [{arrayNL[0]} + {arrayNL[1]} + {arrayNL[2]} + {arrayNL[3]}]";
                }
                else
                {
                    MessageBox.Show($"Sản phẩm {masp} không được chế biến theo công thức");
                    this.Close();
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
