using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MilkTeaShop
{
    public class SellBillDAO
    {
        My_DBConnection db = new My_DBConnection();
        string sqlQuery;
        public List<UC_ItemSelled> GetListItemsSelling(string MaLoaiSP)
        {
            sqlQuery = "exec proc_GetProductByCategory @MaLoaiSP";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@MaLoaiSP", SqlDbType.VarChar) {Value = MaLoaiSP}
            };
            string obj = "proc_GetProductByCategory";
            List<Dictionary<string, object>> lstKeyValue = db.ExecuteReader(sqlQuery, lstParams, obj);
            List<UC_ItemSelled> lstResult = new List<UC_ItemSelled>();
            foreach (var reader in lstKeyValue)
            {
                UC_ItemSelled item = new UC_ItemSelled();
                item.MaSP = (string)reader["MaSP"];
                item.TenSP = (string)reader["TenSP"];
                item.DonGia = (decimal)reader["DonGia"];
                item.ThoiGianBan = DateTime.Now;
                lstResult.Add(item);
            }
            return lstResult;
        } 
    }
}
