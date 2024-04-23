using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaShop
{
    public class Suppliers
    {
        public string MaNCC;
        public string TenNCC;
        public string SdtNCC;
        public string DiaChiNCC;
        

        public Suppliers(string maNCC, string tenNCC, string sdtNCC, string diaChiNCC)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            SdtNCC = sdtNCC;
            DiaChiNCC = diaChiNCC;
        }
        public Suppliers(DataRow dr)
        {
            this.MaNCC = dr[0].ToString();
            this.TenNCC = dr[1].ToString();
            this.SdtNCC = dr[3].ToString();
            this.DiaChiNCC = dr[2].ToString();
          
        }
    }
}
