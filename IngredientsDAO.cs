using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaShop
{
    public class IngredientsDAO
    {
        My_DBConnection db = new My_DBConnection();

        public void Them (Ingredient ig)
        {
            string them = "Execute proc_themNguyenLieu '" + ig.MaNL + "', N'" + ig.TenNL + "', '" + ig.SoLuong + "',N'" + ig.DonVi + "','" + ig.TrangThai + "'";
            db.ThucThi(them);
        }
        public void Sua(Ingredient ig)
        {
            string sua = string.Format("Execute proc_UpdateNL '{0}', N'{1}', N'{2}', '{3}'", ig.MaNL, ig.TenNL, ig.SoLuong, ig.DonVi);
            db.ThucThi(sua);
        }

        public void Xoa(Ingredient ig)
        {
            string xoa = string.Format("Execute proc_DeleteNL '{0}'", ig.MaNL);
            db.ThucThi(xoa);
        }
    }
}
