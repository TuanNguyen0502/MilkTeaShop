using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaShop
{
    public class SuppliersDAO
    {
        DBConnection db = new DBConnection();
        
        public void Them(Suppliers sup)
        {
            string them = "Execute proc_themNhaCungCap '" + sup.MaNCC + "', N'" + sup.TenNCC + "',N'" + sup.DiaChiNCC + "',N'" + sup.SdtNCC + "'";
            db.ThucThi(them);
        }
        public void Sua(Suppliers sup)
        {
            string sua = string.Format("UPDATE NhaCungCap SET TENNCC = N'{0}', SDT = '{1}', DiaChi = N'{2}' WHERE MANCC = '{3}'", sup.TenNCC, sup.SdtNCC, sup.DiaChiNCC, sup.MaNCC );
            db.ThucThi(sua);
        }

        public void Xoa(Suppliers sup)
        {
            string xoa = string.Format("DELETE NhaCungCap WHERE MANCC = '{0}'", sup.MaNCC);
            db.ThucThi(xoa);
        }
    }
}
