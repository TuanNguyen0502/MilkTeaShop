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
        string sqlQuery;
        public FBillForm()
        {
            InitializeComponent();
        }

        private void btn_AllBill_Click(object sender, EventArgs e)
        {
            sqlQuery = "SELECT hd.MaHD, nv.HoTen, kh.TenKH, hd.ThoiGianDat, hd.GhiChu, hd.TriGiaHoaDon"
                       +" FROM HoaDon hd"
                       +" JOIN NhanVien nv ON hd.MaNV = nv.MaNV"
                       +" JOIN KhachHang kh ON hd.SDT = kh.SDT";
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
                        flp_Container.Controls.Add(hoaDon);
                        // Thêm đối tượng hoaDon vào danh sách hoặc làm điều gì đó khác ở đây
                    }
                }
            }
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT hd.MaHD, nv.HoTen, kh.TenKH, hd.ThoiGianDat, hd.GhiChu, hd.TriGiaHoaDon"
                       +" FROM HoaDon hd"
                       +" JOIN NhanVien nv ON hd.MaNV = nv.MaNV"
                       +" JOIN KhachHang kh ON hd.SDT = kh.SDT";
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
                    }
                    else
                    {
                        MessageBox.Show("Không có từ khóa được cung cấp");
                    }

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
            }
        }
    }
}
