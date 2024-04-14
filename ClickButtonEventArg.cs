using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaShop
{
    public class ClickButtonEventArg : EventArgs
    {
        public string MaSP { get; }
        public string TenSP { get; }
        public decimal DonGia { get; }
        public DateTime ThoiGianBan { get; }
        public ClickButtonEventArg(string masp, string tensp, decimal dongia, DateTime thoigianban)
        {
            MaSP = masp;
            TenSP = tensp;
            DonGia = dongia;
            ThoiGianBan = thoigianban;
        }
    }
}
