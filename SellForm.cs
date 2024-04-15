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

namespace MilkTeaShop
{
    public partial class SellForm : Form
    {
        DBConnection dbConn = new DBConnection();
        string sqlQuery;
        public SellForm()
        {
            InitializeComponent();

        }
        private void SellForm_Load(object sender, EventArgs e)
        {
            flp_ContainsItem.Controls.Clear();
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
        public void itemSelling_Click(object sender, ClickButtonEventArg e)
        {
            UC_ItemSelected selectted = new UC_ItemSelected();
            selectted.MaSP = e.MaSP;
            selectted.TenSP = e.TenSP;
            selectted.DonGia = e.DonGia;
            selectted.ThoiGianBan = e.ThoiGianBan;
            flp_ContainsOrder.Controls.Add(selectted);
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
            foreach (var keyValue in keyValuePairs)
            {
                UC_ItemSelled item = new UC_ItemSelled();
                item.MaSP = (string)keyValue["MaSP"];
                item.TenSP = (string)keyValue["TenSP"];
                item.DonGia = (decimal)keyValue["DonGia"];
                item.MaLoaiSP = (string)keyValue["MaLoaiSP"];
                item.ThoiGianBan = DateTime.Now;
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
    }
}
