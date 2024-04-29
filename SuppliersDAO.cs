using System;
using System.CodeDom.Compiler;
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
            string sua = string.Format("Execute proc_UpdateNCC '{0}', N'{1}', N'{2}', '{3}'", sup.MaNCC, sup.TenNCC, sup.DiaChiNCC, sup.SdtNCC);
            db.ThucThi(sua);       
        }

        public void Xoa(Suppliers sup)
        {
            string xoa = string.Format("Execute proc_DeleteNCC '{0}'", sup.MaNCC);
            db.ThucThi(xoa);
        }
    }
}
