using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MilkTeaShop
{
    public partial class FIngredient : Form
    {
        My_DBConnection mydb = new My_DBConnection();
      
        UC_Ingredient uC_Ing = new UC_Ingredient();
        IngredientsDAO igDao = new IngredientsDAO();
        public Guna2TextBox Txt_MaNL { get => txt_MaNL; set => txt_MaNL = value; }
        public Guna2TextBox Txt_NameNL { get => txt_NameNL; set => txt_NameNL = value; }
        public Guna2TextBox Txt_SoLuong { get => txt_SoLuong; set => txt_SoLuong = value; }
        public Guna2TextBox Txt_DonVi { get => txt_DonVi; set => txt_DonVi = value; }

        public FIngredient()
        {
            InitializeComponent();
        }

        private void FIngredient_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM view_NguyenLieu";
            GeneratePanel(query);
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string query = "Select * from func_timNguyenLieu (N'"+txt_SearchNL.Text+"')";
            GeneratePanel(query);
            this.Refresh();
        }
        public void GeneratePanel(string query)
        {
            Panel_NL.Controls.Clear();
            DataTable dt = new DataTable();
            dt = LoadData(query);
            int x = 0;
            foreach (DataRow dr in dt.Rows)
            {
                Panel panel = new Panel
                {
                    Size = new Size(520, 58),
                    Location = new Point(0, x),
                    BorderStyle = BorderStyle.FixedSingle,
                };
                Ingredient ig = new Ingredient(dr);
                UC_Ingredient uC_Ingredient = new UC_Ingredient(ig,this);
                x += 58;
                panel.Controls.Add(uC_Ingredient);
                Panel_NL.Controls.Add(panel);
            }
        }
        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Ingredient ig = new Ingredient(txt_MaNL.Text, txt_NameNL.Text, Convert.ToInt32(txt_SoLuong.Text), txt_DonVi.Text, "Available");
            igDao.Them(ig);
            FIngredient_Load(sender, e);
            CleanTextBox();

        }

        private void btn_Fix_Click(object sender, EventArgs e)
        {
            Ingredient ig = new Ingredient(txt_MaNL.Text, txt_NameNL.Text, Convert.ToInt32(txt_SoLuong.Text), txt_DonVi.Text,"Available");
            igDao.Sua(ig);
            FIngredient_Load(sender,e);
            CleanTextBox();

        }

        private void cb_ConHang_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ConHang.Checked)
            {
                string query = "SELECT * FROM view_NL_Available";
                GeneratePanel(query);
                this.Refresh();
                cb_HetHang.Enabled = false;
            }
            else
            {
                cb_HetHang.Enabled = true;
                FIngredient_Load(sender, e);
            }
        }

        private void cb_HetHang_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_HetHang.Checked)
            {
                string query = "SELECT * FROM view_NL_Unavailable";
                GeneratePanel(query);
                this.Refresh();
                cb_ConHang.Enabled = false;
            }
            else
            {
                cb_ConHang.Enabled = true;
                FIngredient_Load(sender, e);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Ingredient ig = new Ingredient(txt_MaNL.Text, txt_NameNL.Text, Convert.ToInt32(txt_SoLuong.Text), txt_DonVi.Text, "Available");
            igDao.Xoa(ig);
            FIngredient_Load(sender, e);
            CleanTextBox();
        }
        public void CleanTextBox()
        {
            txt_MaNL.Text = "";
            txt_NameNL.Text = "";
            txt_SoLuong.Text = "";
            txt_DonVi.Text = "";
        }
        public DataTable LoadData(string query)
        {
            string sqlStr = string.Format(query);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, mydb.getConn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        
    }
}
