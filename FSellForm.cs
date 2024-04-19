﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Guna.UI.WinForms;

namespace MilkTeaShop
{
    public partial class FSellForm : Form
    {
        readonly string conStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MilkTeaShop;Integrated Security=True";
        DBConnection dbConn = new DBConnection();
        string sqlQuery;
        public FSellForm()
        {
            InitializeComponent();

        }
        private void SellForm_Load(object sender, EventArgs e)
        {
            flp_ContainsItem.Controls.Clear();
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
            sqlQuery = "SELECT MaSP, TenSP, DonGia FROM SanPham sp WHERE sp.MaLoaiSP = @MaLoaiSP";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@MaLoaiSP", SqlDbType.VarChar) {Value = MaLoaiSP}
            };
            List<Dictionary<string, object>> keyValuePairs = dbConn.ExecuteReaderData(sqlQuery, lstParams);
            foreach (var keyValue in keyValuePairs)
            {
                UC_ItemSelled item = new UC_ItemSelled();
                item.MaSP = (string)keyValue["MaSP"];
                item.TenSP = (string)keyValue["TenSP"];
                item.DonGia = (decimal)keyValue["DonGia"];
                item.ThoiGianBan = DateTime.Now;
                item.ClickIntoItemSelling += itemSelling_Click;
                item.ClickIntoLineItemSelling += itemLineSelling_Click;
                flp_ContainsItem.Controls.Add(item);
            }
        }
        public void GetItemSelled(string MaLoaiSP, System.Drawing.Image icon)
        {
            sqlQuery = "SELECT MaSP, TenSP, DonGia FROM SanPham sp WHERE sp.MaLoaiSP = @MaLoaiSP";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@MaLoaiSP", SqlDbType.VarChar) {Value = MaLoaiSP}
            };
            List<Dictionary<string, object>> keyValuePairs = dbConn.ExecuteReaderData(sqlQuery, lstParams);
            foreach (var keyValue in keyValuePairs)
            {
                UC_ItemSelled item = new UC_ItemSelled();
                item.MaSP = (string)keyValue["MaSP"];
                item.TenSP = (string)keyValue["TenSP"];
                item.DonGia = (decimal)keyValue["DonGia"];
                item.ThoiGianBan = DateTime.Now;
                item.Icon = icon;
                item.ClickIntoItemSelling += itemSelling_Click;
                item.ClickIntoLineItemSelling += itemLineSelling_Click;
                flp_ContainsItem.Controls.Add(item);
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
                lbl_Pay.Text = (totalOrders - totalOrders*0, 2).ToString() + " VNĐ";
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
                lbl_Pay.Text = (totalOrders - totalOrders*0, 2).ToString() + " VNĐ";
            }
            else
            {
                lbl_Pay.Text = totalOrders.ToString() + " VNĐ";
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
            string keyword = txt_KeyWord.Text;
            sqlQuery = "SELECT * FROM func_timSanPhamTheoTen(@keyword)";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@keyword", SqlDbType.NVarChar) {Value = keyword},
            };
            List<Dictionary<string,object>> keyValuePairs = dbConn.ExecuteReaderData_Function(sqlQuery, lstParams);
            flp_ContainsItem.Controls.Clear();
            flp_ContainsOrder.Controls.Clear();
            foreach (var keyValue in keyValuePairs)
            {
                UC_ItemSelled item = new UC_ItemSelled();
                item.MaSP = (string)keyValue["MaSP"];
                item.TenSP = (string)keyValue["TenSP"];
                item.DonGia = (decimal)keyValue["DonGia"];
                item.MaLoaiSP = (string)keyValue["MaLoaiSP"];
                item.ThoiGianBan = DateTime.Now;
                item.ClickIntoItemSelling += itemSelling_Click;
                item.ClickIntoLineItemSelling += itemLineSelling_Click;
                if (item.MaLoaiSP == "LSP01")
                {
                    item.Icon = global::MilkTeaShop.Properties.Resources._6eafb191a7f1e895b1b9ae2c50c1d03d;
                }else if (item.MaLoaiSP == "LSP02")
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
        /*public Staff GetStaffByID(string MaNV)
        {
            sqlQuery = "SELECT * FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@MaNV", SqlDbType.VarChar) {Value = MaNV},
            };
            List<Dictionary<string,object>> keyValues = dbConn.ExecuteReaderData(sqlQuery, lstParams);
            Staff staff = new Staff();
            foreach (var value in keyValues)
            {
                staff.
            }
        }*/
        private void saveChiTietHoaDons()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sqlGetProducts = "SELECT TOP 1 MaHD"+
                                        " FROM HoaDon"+
                                        " ORDER BY MaHD Desc";
                SqlCommand cmdGetProducts = new SqlCommand(sqlGetProducts, conn);
                int MaHD = (int)cmdGetProducts.ExecuteScalar();
                MessageBox.Show(MaHD.ToString());
                foreach (Control control in flp_ContainsOrder.Controls)
                {
                    UC_ItemSelected selected = (UC_ItemSelected)control;
                    string sqlInsertCTHD = "INSERT INTO ChiTietHoaDon(MaHD, MaSP, SoLuong)"+
                                            " VALUES (@MaHD, @MaSP, @SoLuong)";
                    SqlCommand cmdInsertCTHD = new SqlCommand(sqlInsertCTHD, conn);
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
        }
        private void btn_printBill_Click(object sender, EventArgs e)
        {
            if (cbb_options.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn sđt khách hàng !");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("exec proc_CreateBill @SDT, @MaNV, @ThoiGianDat, @TriGiaHD", conn);
                        SqlParameter[] lstParams =
                        {
                                new SqlParameter("@SDT", SqlDbType.VarChar) {Value = cbb_options.SelectedItem.ToString()},
                                new SqlParameter("@MaNV", SqlDbType.VarChar) {Value = lbl_CurrentStaff.Text},
                                new SqlParameter("@ThoiGianDat", SqlDbType.DateTime) {Value = DateTime.Now},
                                new SqlParameter("@TriGiaHD", SqlDbType.Decimal) {Value = Convert.ToDecimal(lbl_Pay.Text.Substring(0, lbl_Pay.Text.Length - 4))},
                            };
                        cmd.Parameters.AddRange(lstParams);
                        if (cmd.ExecuteNonQuery() > 0)
                            MessageBox.Show("In hóa đơn thành công !");
                        saveChiTietHoaDons();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("In hóa đơn thất bại.\n"+ex.Message);
                    }
                }
            }
        }

        private void cbb_options_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_SDTKH.Text = cbb_options.SelectedItem.ToString();
        }

        private void btn_saveBill_Click(object sender, EventArgs e)
        {
            saveChiTietHoaDons();
        }
    }
}
