using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaShop
{
    public class Ingredient
    {
        public string MaNL;
        public string TenNL;
        public int SoLuong;
        public string DonVi;
        public string TrangThai;

        public Ingredient(string maNL, string tenNL, int soLuong, string donVi, string trangThai)
        {
            MaNL = maNL;
            TenNL = tenNL;
            SoLuong = soLuong;
            DonVi = donVi;
            TrangThai = trangThai;
        }
        public Ingredient(DataRow dr)
        {
            this.MaNL = dr[0].ToString();
            this.TenNL = dr[1].ToString();  
            this.SoLuong = Convert.ToInt32(dr[2].ToString());
            this.DonVi = dr[3].ToString();
            this.TrangThai = dr[4].ToString();  
        }


    }
}
