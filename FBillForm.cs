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
        My_DBConnection db = new My_DBConnection();
        string sqlQuery;
        public FBillForm()
        {
            InitializeComponent();
        }

        private void SeeBill()
        {
            try
            {
                flp_ContainsBill.Controls.Clear();
                sqlQuery = "SELECT * FROM vie_XemHoaDon";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                db.OpenConn();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
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
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Bị hạn chế quyền\n"+ex.Message);
                }
                else
                {
                    MessageBox.Show("Lỗi: "+ex.Message);
                }
            }
            finally
            {
                db.CloseConn();
            }
        }

        private void btn_AllBill_Click(object sender, EventArgs e)
        {
            SeeBill();
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            SeeBill();
        }

        private void btn_SeachForBill_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("proc_FindBill", db.getConn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (!string.IsNullOrEmpty(txt_KeyWord.Text))
                {
                    cmd.Parameters.Add("@Keyword", SqlDbType.NVarChar, 100).Value = txt_KeyWord.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
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
            catch(SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Bị hạn chế quyền\n"+ex.Message);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            finally
            {
                db.CloseConn();
            }
        }

        private void btn_AllBillDetails_Click(object sender, EventArgs e)
        {
            try
            {
                flp_ContainsHeader.Controls.Clear();
                UC_BillDetails header_BillDetails = new UC_BillDetails();
                flp_ContainsHeader.Controls.Add(header_BillDetails);
                flp_ContainsBill.Controls.Clear();
                sqlQuery = "SELECT * FROM vie_XemCTHD";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                db.OpenConn();
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
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Không có quyền sử dụng proc này!");
                }
                else
                {
                    MessageBox.Show("Lỗi: "+ex.Message);
                }
            }
            finally
            {
                db.CloseConn();
            }
        }

        public void GetBillsLatest()
        {
            try
            {
                flp_ContainsBill.Controls.Clear();
                sqlQuery = "proc_HoaDonGiamTheoOrderTime";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                cmd.CommandType = CommandType.StoredProcedure;
                db.OpenConn();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
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
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Bị hạn chế quyền\n"+ex.Message);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            finally
            {
                db.CloseConn();
            }
        }
        public void GetBillsOldest()
        {
            try
            {
                flp_ContainsBill.Controls.Clear();
                sqlQuery = "proc_HoaDonTangTheoOrderTime";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                cmd.CommandType = CommandType.StoredProcedure;
                db.OpenConn();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
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
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Bị hạn chế quyền\n"+ex.Message);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            finally
            {
                db.CloseConn();
            }
        }
        public void GetBillsDescByPrice()
        {
            try
            {
                flp_ContainsBill.Controls.Clear();
                sqlQuery = "proc_HoaDonGiamTheoTotalBill";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                cmd.CommandType = CommandType.StoredProcedure;
                db.OpenConn();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
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
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Bị hạn chế quyền\n"+ex.Message);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            finally
            {
                db.CloseConn();
            }
        }
        public void GetBillsIncrementcByPrice()
        {
            try
            {
                flp_ContainsBill.Controls.Clear();
                sqlQuery = "proc_HoaDonTangTheoTotalBill";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                cmd.CommandType = CommandType.StoredProcedure;
                db.OpenConn();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
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
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("Bị hạn chế quyền\n"+ex.Message);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            finally
            {
                db.CloseConn();
            }
        }

        private void cbb_options_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_options.SelectedItem.ToString() == "Hóa đơn mới nhất")
            {
                GetBillsLatest();
            }
            else if (cbb_options.SelectedItem.ToString() == "Hóa đơn cũ nhất")
            {
                GetBillsOldest();
            }
            else if (cbb_options.SelectedItem.ToString() == "Số tiền hóa đơn cao nhất")
            {
                GetBillsDescByPrice();
               
            }
            else if (cbb_options.SelectedItem.ToString() == "Số tiền hóa đơn thấp nhất")
            {
                GetBillsIncrementcByPrice();
            }
        }
    }
}
