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
        My_DBConnection db = new My_DBConnection();
        string sqlQuery;
        public FReport()
        {
            InitializeComponent();
            cbb_OptionMain.SelectedIndex = 0;
        }
        private void FilterDataByDMY(DateTime timePicked)
        {
            sqlQuery = "DECLARE @doanhThu DECIMAL;"
                      +"SELECT @doanhThu = dbo.func_tinhDoanhThuTheoNgay(@ngay, @thang, @nam);"
                      +"SELECT @doanhThu AS 'Doanh thu';";
            SqlCommand command = new SqlCommand(sqlQuery, db.getConn);
            command.CommandType = CommandType.StoredProcedure;

            // Thêm các tham số và giá trị tương ứng
            command.Parameters.AddWithValue("@ngay", timePicked.Day);
            command.Parameters.AddWithValue("@thang", timePicked.Month);
            command.Parameters.AddWithValue("@nam", timePicked.Year);
            db.OpenConn();
            decimal doanhThu = (decimal)command.ExecuteScalar();


            // Lấy giá trị doanh thu từ parameter đầu ra
            UC_Report report = new UC_Report();
            report.Time = DateTime.Now;
            report.Sales = doanhThu;
            flp_ContainsReport.Controls.Add(report);
            
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
                else if (cbb_OptionMain.SelectedItem.ToString() == "Doanh thu")
                {
                    rdb_Day.Enabled = true;
                }
            }
        }

        private void rdb_Day_CheckedChanged(object sender, EventArgs e)
        {
            if (cbb_OptionMain.SelectedItem.ToString() == "Doanh thu")
            {
                try
                {
                    flp_ContainsHeader.Controls.Clear();
                    UC_Report report_Header = new UC_Report();
                    report_Header.LblSale.Text = $"DOANH THU CHO NGÀY {dtp_DMY.Value.Day}/{dtp_DMY.Value.Month}/{dtp_DMY.Value.Year}";
                    flp_ContainsHeader.Controls.Add(report_Header);
                    flp_ContainsReport.Controls.Clear();
                    DateTime timePicked = dtp_DMY.Value;
                    sqlQuery = "SELECT dbo.func_tinhDoanhThuTheoNgay(@ngay, @thang, @nam)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                    cmd.Parameters.AddWithValue("@ngay", timePicked.Day);
                    cmd.Parameters.AddWithValue("@thang", timePicked.Month);
                    cmd.Parameters.AddWithValue("@nam", timePicked.Year);
                    db.OpenConn();
                    object result = cmd.ExecuteScalar();
                    decimal doanhThu = 0;
                    if (result != null && result != DBNull.Value)
                    {
                        doanhThu = Convert.ToDecimal(result);
                    }

                    UC_Report report = new UC_Report();
                    report.Time = DateTime.Now;
                    report.Sales = doanhThu;
                    flp_ContainsReport.Controls.Add(report);

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 229)
                    {
                        MessageBox.Show("Bị hạn chế quyền\n"+ex.Message);
                    }
                }
                finally
                {
                    db.CloseConn();
                }
            }
        }

        private void rdb_Month_CheckedChanged(object sender, EventArgs e)
        {
            if (cbb_OptionMain.SelectedItem.ToString() == "Doanh thu")
            {
                try
                {
                    flp_ContainsHeader.Controls.Clear();
                    UC_Report report_Header = new UC_Report();
                    report_Header.LblSale.Text = $"DOANH THU CHO THÁNG {dtp_DMY.Value.Month}/{dtp_DMY.Value.Year}";
                    flp_ContainsHeader.Controls.Add(report_Header);
                    flp_ContainsReport.Controls.Clear();
                    DateTime timePicked = dtp_DMY.Value;
                    sqlQuery = "SELECT dbo.func_tinhDoanhThuTheoThang(@thang, @nam)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                    cmd.Parameters.AddWithValue("@thang", timePicked.Month);
                    cmd.Parameters.AddWithValue("@nam", timePicked.Year);
                    db.OpenConn();
                    object result = cmd.ExecuteScalar();
                    decimal doanhThu = 0;
                    if (result != null && result != DBNull.Value)
                    {
                        doanhThu = Convert.ToDecimal(result);
                    }

                    UC_Report report = new UC_Report();
                    report.Time = DateTime.Now;
                    report.Sales = doanhThu;
                    flp_ContainsReport.Controls.Add(report);

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 229)
                    {
                        MessageBox.Show("Bị hạn chế quyền\n"+ex.Message);
                    }
                }
                finally
                {
                    db.CloseConn();
                }
            }
            else if (cbb_OptionMain.SelectedItem.ToString() == "Khoản chi")
            {
                try
                {
                    flp_ContainsHeader.Controls.Clear();
                    UC_Report report_Header = new UC_Report();
                    report_Header.LblSale.Text = $"KHOẢN CHI CHO THÁNG {dtp_DMY.Value.Month}/{dtp_DMY.Value.Year}";
                    flp_ContainsHeader.Controls.Add(report_Header);
                    flp_ContainsReport.Controls.Clear();
                    DateTime timePicked = dtp_DMY.Value;
                    sqlQuery = "SELECT dbo.func_ChiPhiTheoThang(@thang, @nam)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                    cmd.Parameters.AddWithValue("@thang", timePicked.Month);
                    cmd.Parameters.AddWithValue("@nam", timePicked.Year);
                    db.OpenConn();
                    object result = cmd.ExecuteScalar();
                    decimal doanhThu = 0;
                    if (result != null && result != DBNull.Value)
                    {
                        doanhThu = Convert.ToDecimal(result);
                    }

                    UC_Report report = new UC_Report();
                    report.Time = DateTime.Now;
                    report.Sales = doanhThu;
                    flp_ContainsReport.Controls.Add(report);

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 229)
                    {
                        MessageBox.Show("Bị hạn chế quyền\n"+ex.Message);
                    }
                }
                finally
                {
                    db.CloseConn();
                }
            }
        }

        private void rdb_Year_CheckedChanged(object sender, EventArgs e)
        {
            if (cbb_OptionMain.SelectedItem.ToString() == "Doanh thu")
            {
                try
                {
                    flp_ContainsHeader.Controls.Clear();
                    UC_Report report_Header = new UC_Report();
                    report_Header.LblSale.Text = $"DOANH THU CHO NĂM {dtp_DMY.Value.Year}";
                    flp_ContainsHeader.Controls.Add(report_Header);
                    flp_ContainsReport.Controls.Clear();
                    DateTime timePicked = dtp_DMY.Value;
                    sqlQuery = "SELECT dbo.func_tinhDoanhThuTheoNam(@nam)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                    cmd.Parameters.AddWithValue("@nam", timePicked.Year);
                    db.OpenConn();
                    object result = cmd.ExecuteScalar();
                    decimal doanhThu = 0;
                    if (result != null && result != DBNull.Value)
                    {
                        doanhThu = Convert.ToDecimal(result);
                    }

                    UC_Report report = new UC_Report();
                    report.Time = DateTime.Now;
                    report.Sales = doanhThu;
                    flp_ContainsReport.Controls.Add(report);

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 229)
                    {
                        MessageBox.Show("Bị hạn chế quyền\n"+ex.Message);
                    }
                }
                finally
                {
                    db.CloseConn();
                }
            }
            else if (cbb_OptionMain.SelectedItem.ToString() == "Khoản chi")
            {
                try
                {
                    flp_ContainsHeader.Controls.Clear();
                    UC_Report report_Header = new UC_Report();
                    report_Header.LblSale.Text = $"KHOẢN CHI CHO NĂM {dtp_DMY.Value.Year}";
                    flp_ContainsHeader.Controls.Add(report_Header);
                    flp_ContainsReport.Controls.Clear();
                    DateTime timePicked = dtp_DMY.Value;
                    sqlQuery = "SELECT dbo.func_tinhDoanhThuTheoNam(@nam)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                    cmd.Parameters.AddWithValue("@nam", timePicked.Year);
                    db.OpenConn();
                    object result = cmd.ExecuteScalar();
                    decimal doanhThu = 0;
                    if (result != null && result != DBNull.Value)
                    {
                        doanhThu = Convert.ToDecimal(result);
                    }

                    UC_Report report = new UC_Report();
                    report.Time = DateTime.Now;
                    report.Sales = doanhThu;
                    flp_ContainsReport.Controls.Add(report);

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 229)
                    {
                        MessageBox.Show("Bị hạn chế quyền\n"+ex.Message);
                    }
                }
                finally
                {
                    db.CloseConn();
                }
            }
        }

        private void lbl_DoanhThuTheoGD_Click(object sender, EventArgs e)
        {
            if (cbb_OptionMain.SelectedItem.ToString() == "Doanh thu")
            {
                try
                {
                    flp_ContainsHeader.Controls.Clear();
                    UC_Report report_Header = new UC_Report();
                    report_Header.LblSale.Text = $"DOANH THU CHO GIAI ĐOẠN TỪ {dtp_From.Value.Day}/{dtp_From.Value.Month}/{dtp_From.Value.Year} ĐẾN {dtp_To.Value.Day}/{dtp_To.Value.Month}/{dtp_To.Value.Year}";
                    flp_ContainsHeader.Controls.Add(report_Header);
                    flp_ContainsReport.Controls.Clear();
                    DateTime startDate = dtp_From.Value;
                    DateTime endDate = dtp_To.Value;
                    sqlQuery = "SELECT dbo.func_DoanhThuTheoGiaiDoan(@startDate,@endDate)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    db.OpenConn();
                    object result = cmd.ExecuteScalar();
                    decimal doanhThu = 0;
                    if (result != null && result != DBNull.Value)
                    {
                        doanhThu = Convert.ToDecimal(result);
                    }

                    // Lấy giá trị doanh thu từ parameter đầu ra
                    UC_Report report = new UC_Report();
                    report.Time = DateTime.Now;
                    report.Sales = doanhThu;
                    flp_ContainsReport.Controls.Add(report);
                }
                catch(SqlException ex)
                {
                    if (ex.Number == 229)
                    {
                        MessageBox.Show("Bị hạn chế quyền\n"+ex.Message);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi:"+ex.Message);
                    }
                }
                finally
                {
                    db.CloseConn();
                }
            }
            else if (cbb_OptionMain.SelectedItem.ToString() == "Khoản chi")
            {
                try
                {
                    flp_ContainsHeader.Controls.Clear();
                    UC_Report report_Header = new UC_Report();
                    report_Header.LblSale.Text = $"CHI PHÍ CHO GIAI ĐOẠN TỪ {dtp_From.Value.Day}/{dtp_From.Value.Month}/{dtp_From.Value.Year} ĐẾN {dtp_To.Value.Day}/{dtp_To.Value.Month}/{dtp_To.Value.Year}";
                    flp_ContainsHeader.Controls.Add(report_Header);
                    flp_ContainsReport.Controls.Clear();
                    DateTime startDate = dtp_From.Value;
                    DateTime endDate = dtp_To.Value;
                    sqlQuery = "SELECT dbo.func_DoanhThuTheoGiaiDoan(@startDate,@endDate)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    db.OpenConn();
                    object result = cmd.ExecuteScalar();
                    decimal doanhThu = 0;
                    if (result != null && result != DBNull.Value)
                    {
                        doanhThu = Convert.ToDecimal(result);
                    }

                    // Lấy giá trị doanh thu từ parameter đầu ra
                    UC_Report report = new UC_Report();
                    report.Time = DateTime.Now;
                    report.Sales = doanhThu;
                    flp_ContainsReport.Controls.Add(report);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 229)
                    {
                        MessageBox.Show("Bị hạn chế quyền\n"+ex.Message);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi:"+ex.Message);
                    }
                }
                finally
                {
                    db.CloseConn();
                }
            }
        }
    }
}
