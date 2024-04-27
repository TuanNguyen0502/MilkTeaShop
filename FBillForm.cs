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
    public partial class FBillForm : Form
    {
        readonly string conStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True";
        DBConnection dbConn = new DBConnection();
        My_DBConnection db = new My_DBConnection();
        string sqlQuery;
        public FBillForm()
        {
            InitializeComponent();
        }

        private void btn_AllBill_Click(object sender, EventArgs e)
        {
            flp_ContainsBill.Controls.Clear();
            sqlQuery = "SELECT * FROM vie_XemHoaDon";
            List<Dictionary<string, object>> keyValues = dbConn.ExecuteReaderData(sqlQuery);
            SqlCommand cmd = new SqlCommand(sqlQuery, db.getConnRegular);
            db.OpenConnRegular();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    UC_BillInfomation hoaDon = new UC_BillInfomation();
                    hoaDon.MaHD = reader.GetInt32(reader.GetOrdinal("MaHD"));
                    hoaDon.TenNV = reader.GetString(reader.GetOrdinal("HoTen"));
                    hoaDon.TenKH = reader.GetString(reader.GetOrdinal("TenKH"));
                    hoaDon.ThoiGianDat = reader.GetDateTime(reader.GetOrdinal("ThoiGianDat"));
                    hoaDon.TriGiaDH = reader.GetDecimal(reader.GetOrdinal("TriGiaHoaDon"));
                    hoaDon.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? "Không có ghi chú thêm." : reader.GetString(reader.GetOrdinal("GhiChu"));
                    flp_ContainsBill.Controls.Add(hoaDon);
                    // Thêm đối tượng hoaDon vào danh sách hoặc làm điều gì đó khác ở đây
                }
            }
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM vie_XemHoaDon";
            List<Dictionary<string,object>> keyValues = dbConn.ExecuteReaderData(sqlQuery);
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UC_BillInfomation hoaDon = new UC_BillInfomation();
                        hoaDon.MaHD = reader.GetInt32(reader.GetOrdinal("MaHD"));
                        hoaDon.TenNV = reader.GetString(reader.GetOrdinal("HoTen"));
                        hoaDon.TenKH = reader.GetString(reader.GetOrdinal("TenKH"));
                        hoaDon.ThoiGianDat = reader.GetDateTime(reader.GetOrdinal("ThoiGianDat"));
                        hoaDon.TriGiaDH = reader.GetDecimal(reader.GetOrdinal("TriGiaHoaDon"));
                        hoaDon.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? "Không có ghi chú thêm." : reader.GetString(reader.GetOrdinal("GhiChu"));
                        flp_ContainsBill.Controls.Add(hoaDon);
                    }
                }
            }
        }

        private void btn_SeachForBill_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                // Mở kết nối
                connection.Open();

                // Tạo đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand("proc_FindBill", connection))
                {
                    // Đặt kiểu command type là StoredProcedure
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số
                    if (!string.IsNullOrEmpty(txt_KeyWord.Text))
                    {
                        command.Parameters.Add("@Keyword", SqlDbType.NVarChar, 100).Value = txt_KeyWord.Text;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            flp_ContainsBill.Controls.Clear();
                            while (reader.Read())
                            {
                                UC_BillInfomation hoaDon = new UC_BillInfomation();
                                hoaDon.MaHD = reader.GetInt32(reader.GetOrdinal("MaHD"));
                                hoaDon.TenNV = reader.GetString(reader.GetOrdinal("HoTen"));
                                hoaDon.TenKH = reader.GetString(reader.GetOrdinal("TenKH"));
                                hoaDon.ThoiGianDat = reader.GetDateTime(reader.GetOrdinal("ThoiGianDat"));
                                hoaDon.TriGiaDH = reader.GetDecimal(reader.GetOrdinal("TriGiaHoaDon"));
                                hoaDon.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? "Không có ghi chú thêm." : reader.GetString(reader.GetOrdinal("GhiChu"));
                                flp_ContainsBill.Controls.Add(hoaDon);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không có từ khóa được cung cấp");
                    }
                }
            }
        }

        private void btn_AllBillDetails_Click(object sender, EventArgs e)
        {
            flp_ContainsHeader.Controls.Clear();
            UC_BillDetails header_BillDetails = new UC_BillDetails();
            flp_ContainsHeader.Controls.Add(header_BillDetails);
            flp_ContainsBill.Controls.Clear();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                sqlQuery = "SELECT * FROM vie_XemCTHD";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UC_BillDetails item = new UC_BillDetails();
                        item.MaHD = reader.GetInt32(reader.GetOrdinal("MaHD"));
                        item.ListItem = reader.GetString(reader.GetOrdinal("Danh sách sản phẩm"));
                        item.OrderTime = reader.GetDateTime(reader.GetOrdinal("ThoiGianDat"));
                        item.TotalBill = reader.GetDecimal(reader.GetOrdinal("TriGiaHoaDon"));
                        flp_ContainsBill.Controls.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Không có chi tiết hóa đơn nào");
                }
            }
        }

        private void cbb_options_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_options.SelectedItem.ToString() == "Hóa đơn mới nhất")
            {
                flp_ContainsBill.Controls.Clear();
                sqlQuery = "exec proc_HoaDonGiamTheoOrderTime";
                List<Dictionary<string, object>> keyValues = dbConn.ExecuteReaderData(sqlQuery);
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UC_BillInfomation hoaDon = new UC_BillInfomation();
                            hoaDon.MaHD = reader.GetInt32(reader.GetOrdinal("MaHD"));
                            hoaDon.TenNV = reader.GetString(reader.GetOrdinal("HoTen"));
                            hoaDon.TenKH = reader.GetString(reader.GetOrdinal("TenKH"));
                            hoaDon.ThoiGianDat = reader.GetDateTime(reader.GetOrdinal("ThoiGianDat"));
                            hoaDon.TriGiaDH = reader.GetDecimal(reader.GetOrdinal("TriGiaHoaDon"));
                            hoaDon.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? "Không có ghi chú thêm." : reader.GetString(reader.GetOrdinal("GhiChu"));
                            flp_ContainsBill.Controls.Add(hoaDon);
                        }
                    }
                }
            }
            else if (cbb_options.SelectedItem.ToString() == "Hóa đơn cũ nhất")
            {
                flp_ContainsBill.Controls.Clear();
                sqlQuery = "exec proc_HoaDonTangTheoOrderTime";
                List<Dictionary<string, object>> keyValues = dbConn.ExecuteReaderData(sqlQuery);
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UC_BillInfomation hoaDon = new UC_BillInfomation();
                            hoaDon.MaHD = reader.GetInt32(reader.GetOrdinal("MaHD"));
                            hoaDon.TenNV = reader.GetString(reader.GetOrdinal("HoTen"));
                            hoaDon.TenKH = reader.GetString(reader.GetOrdinal("TenKH"));
                            hoaDon.ThoiGianDat = reader.GetDateTime(reader.GetOrdinal("ThoiGianDat"));
                            hoaDon.TriGiaDH = reader.GetDecimal(reader.GetOrdinal("TriGiaHoaDon"));
                            hoaDon.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? "Không có ghi chú thêm." : reader.GetString(reader.GetOrdinal("GhiChu"));
                            flp_ContainsBill.Controls.Add(hoaDon);
                        }
                    }
                }
            }
            else if (cbb_options.SelectedItem.ToString() == "Số tiền hóa đơn cao nhất")
            {
                flp_ContainsBill.Controls.Clear();
                sqlQuery = "exec proc_HoaDonGiamTheoTotalBill";
                List<Dictionary<string, object>> keyValues = dbConn.ExecuteReaderData(sqlQuery);
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UC_BillInfomation hoaDon = new UC_BillInfomation();
                            hoaDon.MaHD = reader.GetInt32(reader.GetOrdinal("MaHD"));
                            hoaDon.TenNV = reader.GetString(reader.GetOrdinal("HoTen"));
                            hoaDon.TenKH = reader.GetString(reader.GetOrdinal("TenKH"));
                            hoaDon.ThoiGianDat = reader.GetDateTime(reader.GetOrdinal("ThoiGianDat"));
                            hoaDon.TriGiaDH = reader.GetDecimal(reader.GetOrdinal("TriGiaHoaDon"));
                            hoaDon.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? "Không có ghi chú thêm." : reader.GetString(reader.GetOrdinal("GhiChu"));
                            flp_ContainsBill.Controls.Add(hoaDon);
                        }
                    }
                }
            }
            else if (cbb_options.SelectedItem.ToString() == "Số tiền hóa đơn thấp nhất")
            {
                flp_ContainsBill.Controls.Clear();
                sqlQuery = "exec proc_HoaDonTangTheoTotalBill";
                List<Dictionary<string, object>> keyValues = dbConn.ExecuteReaderData(sqlQuery);
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UC_BillInfomation hoaDon = new UC_BillInfomation();
                            hoaDon.MaHD = reader.GetInt32(reader.GetOrdinal("MaHD"));
                            hoaDon.TenNV = reader.GetString(reader.GetOrdinal("HoTen"));
                            hoaDon.TenKH = reader.GetString(reader.GetOrdinal("TenKH"));
                            hoaDon.ThoiGianDat = reader.GetDateTime(reader.GetOrdinal("ThoiGianDat"));
                            hoaDon.TriGiaDH = reader.GetDecimal(reader.GetOrdinal("TriGiaHoaDon"));
                            hoaDon.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? "Không có ghi chú thêm." : reader.GetString(reader.GetOrdinal("GhiChu"));
                            flp_ContainsBill.Controls.Add(hoaDon);
                        }
                    }
                }
            }
        }
    }
}
