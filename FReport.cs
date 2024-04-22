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
    public partial class FReport : Form
    {
        readonly string conStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True";
        string sqlQuery;
        public FReport()
        {
            InitializeComponent();
            cbb_OptionMain.SelectedIndex = 0;
        }
        private void FilterDataByDMY(DateTime timePicked)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                sqlQuery = "DECLARE @doanhThu DECIMAL;"
                          +"SELECT @doanhThu = dbo.func_tinhDoanhThuTheoNgay(28, 3, 2024);"
                          +"SELECT @doanhThu AS 'Doanh thu';";
                SqlCommand command = new SqlCommand(sqlQuery, conn);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số và giá trị tương ứng
                command.Parameters.AddWithValue("@ngay", timePicked.Day);
                command.Parameters.AddWithValue("@thang", timePicked.Month);
                command.Parameters.AddWithValue("@nam", timePicked.Year);

                decimal doanhThu = (decimal)command.ExecuteScalar();


                // Lấy giá trị doanh thu từ parameter đầu ra
                UC_Report report = new UC_Report();
                report.Time = timePicked;
                report.Sales = doanhThu;
                flp_ContainsReport.Controls.Add(report);
            }
        }
        private void cbb_OptionMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_OptionMain.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn thống kê doanh thu hoặc phí chi?");
            }
            else
            {
                if (cbb_OptionMain.SelectedItem.ToString() == "Doanh thu")
                {
                    flp_ContainsHeader.Controls.Clear();
                    UC_Report report_Header = new UC_Report();
                    flp_ContainsHeader.Controls.Add(report_Header);
                }
                else if (cbb_OptionMain.SelectedItem.ToString() == "Khoản chi")
                {

                }
            }
        }

        private void rdb_Day_CheckedChanged(object sender, EventArgs e)
        {
            
            flp_ContainsReport.Controls.Clear();
            DateTime timePicked = dtp_DMY.Value;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                sqlQuery = "SELECT dbo.func_tinhDoanhThuTheoNgay(@ngay, @thang, @nam) AS 'Doanh thu';";
                SqlCommand command = new SqlCommand(sqlQuery, conn);

                // Thêm các tham số và giá trị tương ứng
                command.Parameters.AddWithValue("@ngay", timePicked.Day);
                command.Parameters.AddWithValue("@thang", timePicked.Month);
                command.Parameters.AddWithValue("@nam", timePicked.Year);

                object result = command.ExecuteScalar();
                decimal doanhThu = 0;
                if (result != null && result != DBNull.Value)
                {
                    doanhThu = Convert.ToDecimal(result);
                }


                // Lấy giá trị doanh thu từ parameter đầu ra
                UC_Report report = new UC_Report();
                report.Time = timePicked;
                report.Sales = doanhThu;
                flp_ContainsReport.Controls.Add(report);
            }
        }
    }
}
