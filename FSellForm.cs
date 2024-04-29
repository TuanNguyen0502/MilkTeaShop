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
using Guna.UI.WinForms;

namespace MilkTeaShop
{
    public partial class FSellForm : Form
    {
        My_DBConnection db = new My_DBConnection();
        string sqlQuery;
        private string manv;
        public FSellForm(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }
        public FSellForm()
        {
            InitializeComponent();

        }
        private void SellForm_Load(object sender, EventArgs e)
        {
            flp_ContainsItem.Controls.Clear();
            lbl_CurrentStaff.Text = manv;
            lbl_TotalBill.Text = "0 VNĐ";
            lbl_Pay.Text = "0 VNĐ";
            lbl_SDTKH.Text = "";
            lbl_Sale.Text = "Sale 20%";
            GetItemSelled("LSP01");
            GetItemSelled("LSP05", global::MilkTeaShop.Properties.Resources.top_8_quan_sua_chua_tran_chau_ha_long_thom_ngon_kho_cuong_01_1641920517);
            GetItemSelled("LSP06", global::MilkTeaShop.Properties.Resources._435574413_966712192126145_2678475277908280524_n);
            GetItemSelled("LSP04", global::MilkTeaShop.Properties.Resources.nuoc_ep_dau);
            GetItemSelled("LSP03", global::MilkTeaShop.Properties.Resources.mo_hinh_kinh_doanh_nuoc_ep_trai_cay_dia);
            GetItemSelled("LSP02", global::MilkTeaShop.Properties.Resources._8_quan_sinh_to_ngon_o_sai_gon_giup_tran_day_nang_luong_202112221952077020);
        }
        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void GetItemSelled(string MaLoaiSP)
        {
            try
            {
                sqlQuery = "exec proc_GetProductByCategory @MaLoaiSP";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                cmd.Parameters.AddWithValue("@MaLoaiSP", MaLoaiSP);
                db.OpenConn();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UC_ItemSelled item = new UC_ItemSelled();
                        item.MaSP = reader.GetString(reader.GetOrdinal("MaSP"));
                        item.TenSP = reader.GetString(reader.GetOrdinal("TenSP"));
                        item.DonGia = reader.GetDecimal(reader.GetOrdinal("DonGia"));
                        item.ThoiGianBan = DateTime.Now;
                        item.ClickIntoItemSelling += itemSelling_Click;
                        item.ClickIntoLineItemSelling += itemLineSelling_Click;
                        item.ShadowPanel_CheBien_Click += shadowPanel_CheBien_Click;
                        item.NameItem_Click += nameItem_Click;
                        flp_ContainsItem.Controls.Add(item);
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
        public void GetItemSelled(string MaLoaiSP, System.Drawing.Image icon)
        {
            try
            {
                sqlQuery = "exec proc_GetProductByCategory @MaLoaiSP";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                cmd.Parameters.AddWithValue("@MaLoaiSP", MaLoaiSP);
                db.OpenConn();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UC_ItemSelled item = new UC_ItemSelled();
                        item.MaSP = reader.GetString(reader.GetOrdinal("MaSP"));
                        item.TenSP = reader.GetString(reader.GetOrdinal("TenSP"));
                        item.DonGia = reader.GetDecimal(reader.GetOrdinal("DonGia"));
                        item.ThoiGianBan = DateTime.Now;
                        item.Icon = icon;
                        item.ClickIntoItemSelling += itemSelling_Click;
                        item.ClickIntoLineItemSelling += itemLineSelling_Click;
                        item.ShadowPanel_CheBien_Click += shadowPanel_CheBien_Click;
                        item.NameItem_Click += nameItem_Click;
                        flp_ContainsItem.Controls.Add(item);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show(ex.Message);
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
        public void SetBill()
        {
            decimal totalOrders = 0;
            foreach (Control control in flp_ContainsOrder.Controls)
            {
                UC_ItemSelected item = (UC_ItemSelected)control;
                totalOrders = totalOrders + (item.Numeric_Quantities.Value * item.DonGia);
            }
            lbl_TotalBill.Text = totalOrders.ToString() + " VNĐ";
            if (ckb_Sale.Checked)
            {
                decimal totalPay = totalOrders - (totalOrders*2)/10;
                lbl_Pay.Text = totalPay.ToString() + " VNĐ";
            }
            else
            {
                lbl_Pay.Text = totalOrders.ToString() + " VNĐ";
            }
        }
        public void quantities_ValueChanged(object sender, EventArgs e)
        {

            decimal totalOrders = 0;
            foreach (Control control in flp_ContainsOrder.Controls)
            {
                UC_ItemSelected item = (UC_ItemSelected)control;
                totalOrders = totalOrders + (item.Numeric_Quantities.Value * item.DonGia);
            }
            lbl_TotalBill.Text = totalOrders.ToString() + " VNĐ";
            if (ckb_Sale.Checked)
            {
                decimal totalPay = totalOrders - (totalOrders*2)/10;
                lbl_Pay.Text = totalPay.ToString() + " VNĐ";
            }
            else
            {
                lbl_Pay.Text = totalOrders.ToString() + " VNĐ";
            }
        }
        private void ckb_Sale_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Sale.Checked)
            {
                decimal totalOrders = Convert.ToDecimal(lbl_TotalBill.Text.Substring(0, lbl_TotalBill.Text.Length - 4));
                decimal totalPay = totalOrders - (totalOrders*2)/10;
                lbl_Pay.Text = totalPay.ToString() + " VNĐ";
            }
            else
            {
                lbl_Pay.Text = lbl_TotalBill.Text;
            }
        }
        public void itemSelling_Click(object sender, ClickButtonEventArg e)
        {
            UC_ItemSelected selectted = new UC_ItemSelected();
            
            selectted.MaSP = e.MaSP;
            selectted.TenSP = e.TenSP;
            selectted.DonGia = e.DonGia;
            selectted.ThoiGianBan = e.ThoiGianBan;
            selectted.Numeric_Quantities.ValueChanged += new EventHandler(quantities_ValueChanged);
            flp_ContainsOrder.Controls.Add(selectted);
            SetBill();
        }
        public void itemLineSelling_Click(object sender, ClickButtonEventArg e)
        {
            foreach (Control c in flp_ContainsOrder.Controls)
            {
                if (c is UC_ItemSelected userControl && userControl.MaSP == e.MaSP)
                {
                    flp_ContainsOrder.Controls.Remove(userControl);
                }
            }
            SetBill();
        }
        public void shadowPanel_CheBien_Click(object sender, ClickButtonEventArg e)
        {
            FProcessing processing = new FProcessing(e.MaSP, e.TenSP);
            processing.ShowDialog();
        }
        public void nameItem_Click(object sender, ClickButtonEventArg e)
        {
            FProcessing processing = new FProcessing(e.MaSP, e.TenSP);
            processing.ShowDialog();
        }
        private void btn_TraSua_Click(object sender, EventArgs e)
        {
            flp_ContainsItem.Controls.Clear();
            GetItemSelled("LSP01");
        }

        private void btn_SuaChua_Click(object sender, EventArgs e)
        {
            flp_ContainsItem.Controls.Clear();
            GetItemSelled("LSP05", global::MilkTeaShop.Properties.Resources.top_8_quan_sua_chua_tran_chau_ha_long_thom_ngon_kho_cuong_01_1641920517);
        }

        private void btn_BanhNgot_Click(object sender, EventArgs e)
        {
            flp_ContainsItem.Controls.Clear();
            GetItemSelled("LSP06", global::MilkTeaShop.Properties.Resources._435574413_966712192126145_2678475277908280524_n);
        }

        private void btn_Hat_Click(object sender, EventArgs e)
        {
            flp_ContainsItem.Controls.Clear();
            GetItemSelled("LSP01");
            GetItemSelled("LSP05", global::MilkTeaShop.Properties.Resources.top_8_quan_sua_chua_tran_chau_ha_long_thom_ngon_kho_cuong_01_1641920517);
            GetItemSelled("LSP06", global::MilkTeaShop.Properties.Resources._435574413_966712192126145_2678475277908280524_n);
            GetItemSelled("LSP04", global::MilkTeaShop.Properties.Resources.nuoc_ep_dau);
            GetItemSelled("LSP03", global::MilkTeaShop.Properties.Resources.mo_hinh_kinh_doanh_nuoc_ep_trai_cay_dia);
            GetItemSelled("LSP02", global::MilkTeaShop.Properties.Resources._8_quan_sinh_to_ngon_o_sai_gon_giup_tran_day_nang_luong_202112221952077020);
        }

        private void btn_MonKho_Click(object sender, EventArgs e)
        {

        }

        private void btn_NuocEp_Click(object sender, EventArgs e)
        {
            flp_ContainsItem.Controls.Clear();
            GetItemSelled("LSP04", global::MilkTeaShop.Properties.Resources.nuoc_ep_dau);
        }

        private void btn_TraiCay_Click(object sender, EventArgs e)
        {
            flp_ContainsItem.Controls.Clear();
            GetItemSelled("LSP03", global::MilkTeaShop.Properties.Resources.mo_hinh_kinh_doanh_nuoc_ep_trai_cay_dia);
        }

        private void btn_SinhTo_Click(object sender, EventArgs e)
        {
            flp_ContainsItem.Controls.Clear();
            GetItemSelled("LSP02", global::MilkTeaShop.Properties.Resources._8_quan_sinh_to_ngon_o_sai_gon_giup_tran_day_nang_luong_202112221952077020);
        }

        private void btn_FindProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_KeyWord.Text;
                sqlQuery = "SELECT * FROM func_timSanPhamTheoTen(@keyword)";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.getConn);
                cmd.Parameters.AddWithValue("@keyword", keyword);
                SqlParameter[] lstParams =
                {
                new SqlParameter("@keyword", SqlDbType.NVarChar) {Value = keyword},
                };
                cmd.Parameters.AddRange(lstParams);
                db.OpenConn();
                flp_ContainsItem.Controls.Clear();
                flp_ContainsOrder.Controls.Clear();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UC_ItemSelled item = new UC_ItemSelled();
                        item.MaSP = reader.GetString(reader.GetOrdinal("MaSP"));
                        item.TenSP = reader.GetString(reader.GetOrdinal("TenSP"));
                        item.DonGia = reader.GetDecimal(reader.GetOrdinal("DonGia"));
                        item.MaLoaiSP = reader.GetString(reader.GetOrdinal("MaLoaiSP"));
                        item.ThoiGianBan = DateTime.Now;
                        item.ClickIntoItemSelling += itemSelling_Click;
                        item.ClickIntoLineItemSelling += itemLineSelling_Click;
                        item.ShadowPanel_CheBien_Click += shadowPanel_CheBien_Click;
                        item.NameItem_Click += nameItem_Click;
                        if (item.MaLoaiSP == "LSP01")
                        {
                            item.Icon = global::MilkTeaShop.Properties.Resources._6eafb191a7f1e895b1b9ae2c50c1d03d;
                        }
                        else if (item.MaLoaiSP == "LSP02")
                        {
                            item.Icon =global::MilkTeaShop.Properties.Resources._8_quan_sinh_to_ngon_o_sai_gon_giup_tran_day_nang_luong_202112221952077020;
                        }
                        else if (item.MaLoaiSP == "LSP03")
                        {
                            item.Icon =global::MilkTeaShop.Properties.Resources.mo_hinh_kinh_doanh_nuoc_ep_trai_cay_dia;
                        }
                        else if (item.MaLoaiSP == "LSP04")
                        {
                            item.Icon =global::MilkTeaShop.Properties.Resources.nuoc_ep_dau;
                        }
                        else if (item.MaLoaiSP == "LSP05")
                        {
                            item.Icon =global::MilkTeaShop.Properties.Resources.top_8_quan_sua_chua_tran_chau_ha_long_thom_ngon_kho_cuong_01_1641920517;
                        }
                        else if (item.MaLoaiSP == "LSP06")
                        {
                            item.Icon =global::MilkTeaShop.Properties.Resources._435574413_966712192126145_2678475277908280524_n;
                        }
                        flp_ContainsItem.Controls.Add(item);
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
                    MessageBox.Show("Lỗi"+ex.Message);
                }
            }
            finally
            {
                db.CloseConn();
            }
        }
        private void saveChiTietHoaDons()
        {
            try
            {
                db.OpenConn();
                string sqlGetProducts = "GetProductLastest";
                SqlCommand cmdGetProducts = new SqlCommand(sqlGetProducts, db.getConn);
                cmdGetProducts.CommandType = CommandType.StoredProcedure;
                int MaHD = (int)cmdGetProducts.ExecuteScalar();
                MessageBox.Show(MaHD.ToString());
                foreach (Control control in flp_ContainsOrder.Controls)
                {
                    UC_ItemSelected selected = (UC_ItemSelected)control;
                    string sqlInsertCTHD = "exec proc_CreateBillDetails @MaHD, @MaSP, @SoLuong";
                    SqlCommand cmdInsertCTHD = new SqlCommand(sqlInsertCTHD, db.getConn);
                    SqlParameter[] lstParams =
                    {
                            new SqlParameter("@MaHD", SqlDbType.Int) {Value = MaHD},
                            new SqlParameter("@MaSP", SqlDbType.NVarChar) {Value = selected.MaSP},
                            new SqlParameter("@SoLuong", SqlDbType.Int) {Value = selected.Numeric_Quantities.Value}
                        };
                    cmdInsertCTHD.Parameters.AddRange(lstParams);
                    cmdInsertCTHD.ExecuteNonQuery();
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
        private void btn_printBill_Click(object sender, EventArgs e)
        {
            if (cbb_options.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn sđt khách hàng !");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("exec proc_CreateBill @SDT, @MaNV, @ThoiGianDat, @TriGiaHD", db.getConn);
                SqlParameter[] lstParams =
                {
                                new SqlParameter("@SDT", SqlDbType.VarChar) {Value = cbb_options.SelectedItem.ToString()},
                                new SqlParameter("@MaNV", SqlDbType.VarChar) {Value = lbl_CurrentStaff.Text},
                                new SqlParameter("@ThoiGianDat", SqlDbType.DateTime) {Value = DateTime.Now},
                                new SqlParameter("@TriGiaHD", SqlDbType.Decimal) {Value = Convert.ToDecimal(lbl_Pay.Text.Substring(0, lbl_Pay.Text.Length - 4))},
                };
                cmd.Parameters.AddRange(lstParams);
                try
                {
                    db.OpenConn();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("In hóa đơn thành công !");
                        saveChiTietHoaDons();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 229)
                    {
                        MessageBox.Show("Bị hạn chế quyền\n"+ex.Message);
                    }
                    else
                        MessageBox.Show("Lỗi: "+ex.Message);
                }
                catch
                {
                    db.CloseConn();

                }
            }
        }

        private void cbb_options_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_SDTKH.Text = cbb_options.SelectedItem.ToString();
        }

        private void btn_saveBill_Click(object sender, EventArgs e)
        {
        }

        private void pnl_EmpDetails_Click(object sender, EventArgs e)
        {
            FSalesAtTheCounter counter = new FSalesAtTheCounter(lbl_CurrentStaff.Text);
            counter.ShowDialog();
        }
    }
}
