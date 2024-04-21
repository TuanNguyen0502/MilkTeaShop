using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaShop
{
    public class IngredientsDAO
    {
        DBConnection db = new DBConnection();

        public void Them (Ingredient ig)
        {
            string them = "Execute proc_themNguyenLieu '" + ig.MaNL + "', N'" + ig.TenNL + "', '" + ig.SoLuong + "',N'" + ig.DonVi + "','" + ig.TrangThai + "'";
            db.ThucThi(them);
        }
        public void Sua(Ingredient ig)
        {
            string sua = string.Format("UPDATE NGUYENLIEU SET TENNL = N'{0}', SoLuong = '{1}', DonVi = N'{2}' WHERE MANL = '{3}'", ig.TenNL, ig.SoLuong, ig.DonVi, ig.MaNL);
            db.ThucThi(sua);
        }

        public void Xoa(Ingredient ig)
        {
            string xoa = string.Format("DELETE FROM NGUYENLIEU WHERE MANL = '{0}'", ig.MaNL);
            db.ThucThi(xoa);
        }
    }
}
