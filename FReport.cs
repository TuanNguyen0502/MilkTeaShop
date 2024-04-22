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
                if (cbb_OptionMain.SelectedItem.ToString() == "Khoản chi")
                {
                    rdb_Day.Enabled = false;
                }
            }
        }

        private void rdb_Day_CheckedChanged(object sender, EventArgs e)
        {
            if (cbb_OptionMain.SelectedItem.ToString() == "Doanh thu")
            {
                flp_ContainsHeader.Controls.Clear();
                UC_Report report_Header = new UC_Report();
                report_Header.LblSale.Text = "DOANH THU THEO NGÀY";
                flp_ContainsHeader.Controls.Add(report_Header);
                flp_ContainsReport.Controls.Clear();
                DateTime timePicked = dtp_DMY.Value;
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    sqlQuery = "SELECT dbo.func_tinhDoanhThuTheoNgay(@ngay, @thang, @nam) AS 'Doanh thu theo ngay';";
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

        private void rdb_Month_CheckedChanged(object sender, EventArgs e)
        {
            if (cbb_OptionMain.SelectedItem.ToString() == "Doanh thu")
            {
                flp_ContainsHeader.Controls.Clear();
                UC_Report report_Header = new UC_Report();
                report_Header.LblSale.Text = "DOANH THU THEO THÁNG";
                flp_ContainsHeader.Controls.Add(report_Header);
                flp_ContainsReport.Controls.Clear();
                DateTime timePicked = dtp_DMY.Value;
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    sqlQuery = "SELECT dbo.func_tinhDoanhThuTheoThang(@thang, @nam) AS 'Doanh thu theo thang';";
                    SqlCommand command = new SqlCommand(sqlQuery, conn);

                    // Thêm các tham số và giá trị tương ứng
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
            else if (cbb_OptionMain.SelectedItem.ToString() == "Khoản chi")
            {
                flp_ContainsHeader.Controls.Clear();
                UC_Report report_Header = new UC_Report();
                report_Header.LblSale.Text = "KHOẢN CHI THEO THÁNG";
                flp_ContainsHeader.Controls.Add(report_Header);
                flp_ContainsReport.Controls.Clear();
                DateTime timePicked = dtp_DMY.Value;
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    sqlQuery = "SELECT dbo.func_ChiPhiTheoThang(@thang, @nam) AS 'Chi phi theo thang';";
                    SqlCommand command = new SqlCommand(sqlQuery, conn);

                    // Thêm các tham số và giá trị tương ứng
                    command.Parameters.AddWithValue("@thang", timePicked.Month);
                    command.Parameters.AddWithValue("@nam", timePicked.Year);

                    object result = command.ExecuteScalar();
                    decimal chiPhi = 0;
                    if (result != null && result != DBNull.Value)
                    {
                        chiPhi = Convert.ToDecimal(result);
                    }

                    // Lấy giá trị doanh thu từ parameter đầu ra
                    UC_Report report = new UC_Report();
                    report.Time = timePicked;
                    report.Sales = chiPhi;
                    flp_ContainsReport.Controls.Add(report);
                }
            }
        }

        private void rdb_Year_CheckedChanged(object sender, EventArgs e)
        {
            if (cbb_OptionMain.SelectedItem.ToString() == "Doanh thu")
            {
                flp_ContainsHeader.Controls.Clear();
                UC_Report report_Header = new UC_Report();
                report_Header.LblSale.Text = "DOANH THU THEO NĂM";
                flp_ContainsHeader.Controls.Add(report_Header);
                flp_ContainsReport.Controls.Clear();
                DateTime timePicked = dtp_DMY.Value;
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    sqlQuery = "SELECT dbo.func_tinhDoanhThuTheoNam(@nam) AS 'Doanh thu theo nam';";
                    SqlCommand command = new SqlCommand(sqlQuery, conn);

                    // Thêm các tham số và giá trị tương ứng
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
            else if (cbb_OptionMain.SelectedItem.ToString() == "Khoản chi")
            {
                flp_ContainsHeader.Controls.Clear();
                UC_Report report_Header = new UC_Report();
                report_Header.LblSale.Text = "KHOẢN CHI THEO NĂM";
                flp_ContainsHeader.Controls.Add(report_Header);
                flp_ContainsReport.Controls.Clear();
                DateTime timePicked = dtp_DMY.Value;
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    sqlQuery = "SELECT dbo.func_ChiPhiTheoNam(@nam) AS 'Chi phi theo nam';";
                    SqlCommand command = new SqlCommand(sqlQuery, conn);

                    // Thêm các tham số và giá trị tương ứng
                    command.Parameters.AddWithValue("@nam", timePicked.Year);

                    object result = command.ExecuteScalar();
                    decimal chiPhi = 0;
                    if (result != null && result != DBNull.Value)
                    {
                        chiPhi = Convert.ToDecimal(result);
                    }

                    // Lấy giá trị doanh thu từ parameter đầu ra
                    UC_Report report = new UC_Report();
                    report.Time = timePicked;
                    report.Sales = chiPhi;
                    flp_ContainsReport.Controls.Add(report);
                }
            }
        }
    }
}
