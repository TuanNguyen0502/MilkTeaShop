using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaShop
{
    public partial class BillForm : Form
    {
        DBConnection dbConn = new DBConnection();
        string sqlQuery;
        public BillForm()
        {
            InitializeComponent();
        }

        private void btn_AllBill_Click(object sender, EventArgs e)
        {
            UC_BillInfomation billInfomation = new UC_BillInfomation();
            flp_Container.Controls.Add(billInfomation);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            UC_BillInfomation billInfomation = new UC_BillInfomation();
            flp_Container.Controls.Add(billInfomation);
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT hd.MaHD, nv.HoTen, kh.TenKH, hd.ThoiGianDat, hd.GhiChu, hd.TriGiaHoaDon"
                       +" FROM HoaDon hd"
                       +" JOIN NhanVien nv ON hd.MaNV = nv.MaNV"
                       +" JOIN KhachHang kh ON hd.SDT = kh.SDT";
            List<Dictionary<string,object>> keyValues = dbConn.ExecuteReaderData(sqlQuery);
            foreach (var value in keyValues)
            {
                UC_BillInfomation item = new UC_BillInfomation();
                item.MaHD = (int)value["MaHD"];
                item.TenNV = (string)value["HoTen"];
                item.TenKH = (string)value["TenKH"];
                item.ThoiGianDat = (DateTime)value["ThoiGianDat"];
                if (value["GhiChu"] == null)
                {
                    item.GhiChu = "Không có ghi chú";
                }
                /*else
                {
                    item.GhiChu = (string)value["GhiChu"];
                }*/
                item.TriGiaDH = (decimal)value["TriGiaHoaDon"];
                flp_Container.Controls.Add(item);
            }
        }
    }
}
