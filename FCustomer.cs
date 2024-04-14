﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaShop
{
    public partial class FCustomer : Form
    {
        DBConnection dbConnection = new DBConnection();

        public FCustomer()
        {
            InitializeComponent();
        }

        private void button_AddCustomer_Click(object sender, EventArgs e)
        {
            FCustomer_Detail fCustomer_Detail = new FCustomer_Detail();
            fCustomer_Detail.ShowDialog();
        }

        private void FCustomer_Load(object sender, EventArgs e)
        {
            //LoadInfor();
        }

        private void LoadInfor()
        {
            string sqlQuery = $"SELECT TenKH, SDT, GioiTinh, NgaySinh FROM KhachHang";

            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_Customer> items = new List<UC_Customer>();

            foreach (var row in resultList)
            {
                UC_Customer item = new UC_Customer();
                item.Label_Name.Text = row["TenKH"].ToString();
                item.Label_Phone.Text = row["SDT"].ToString();
                item.Label_Gender.Text = row["GioiTinh"].ToString();
                DateTime dob = (DateTime)row["NgaySinh"];
                string formattedPostTime = dob.ToString("yyyy-MM-dd");
                item.Label_DOB.Text = formattedPostTime;
                items.Add(item);
            }

            foreach (var item in items)
            {
                flowLayoutPanel1.Controls.Add(item);
            }
        }
    }
}
