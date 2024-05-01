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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MilkTeaShop
{
    public partial class FSuppliers : Form
    {
        My_DBConnection db = new My_DBConnection();
        UC_Suppliers uC_sup = new UC_Suppliers();
        SuppliersDAO supDao = new SuppliersDAO();

        public Guna2TextBox Txt_MaNCC { get => txt_MaNCC; set => txt_MaNCC = value; }
        public Guna2TextBox Txt_SDT { get => txt_SDT; set => txt_SDT = value; }
        public Guna2TextBox Txt_NameNCC { get => txt_NameNCC; set => txt_NameNCC = value; }
        public Guna2TextBox Txt_DiaChi { get => txt_DiaChi; set => txt_DiaChi = value; }
        
        public FSuppliers()
        {
            InitializeComponent();
        }
        
        public void GeneratePanel(string query)
        {
            Panel_NCC.Controls.Clear();
            DataTable dt = new DataTable();
            dt = LoadData(query);
            int x = 0;
            foreach (DataRow dr in dt.Rows)
            {
                Panel panel = new Panel
                {
                    Size = new Size(567, 68),
                    Location = new Point(0, x),
                    BorderStyle = BorderStyle.FixedSingle,
                };
                Suppliers sup = new Suppliers(dr);
                UC_Suppliers uC_Suppliers = new UC_Suppliers(sup, this);
                x += 68;
                panel.Controls.Add(uC_Suppliers);
                Panel_NCC.Controls.Add(panel);
            }
        }

        private void FSuppliers_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM view_NhaCungCap";
            GeneratePanel(query);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Suppliers sup = new Suppliers(txt_MaNCC.Text, txt_NameNCC.Text, txt_SDT.Text, txt_DiaChi.Text);
            supDao.Them(sup);
            FSuppliers_Load(sender, e);
            CleanTextBox();
        }
        public void CleanTextBox()
        {
            txt_MaNCC.Text = "";
            txt_NameNCC.Text = "";
            txt_SDT.Text = "";
            txt_DiaChi.Text = "";
        }

        private void btn_Fix_Click(object sender, EventArgs e)
        {
            Suppliers sup = new Suppliers(txt_MaNCC.Text, txt_NameNCC.Text, txt_SDT.Text, txt_DiaChi.Text);
            supDao.Sua(sup);
            FSuppliers_Load(sender, e);
            CleanTextBox();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Suppliers sup = new Suppliers(txt_MaNCC.Text, txt_NameNCC.Text, txt_SDT.Text, txt_DiaChi.Text);
            supDao.Xoa(sup);
            FSuppliers_Load(sender, e);
            CleanTextBox();
        }

        private void btn_TimNCC_Click(object sender, EventArgs e)
        {
            string query = "Select * from func_timNhaCungCap (N'" + txt_SearchNCC.Text + "')";
            GeneratePanel(query);
            this.Refresh();
        }
        public DataTable LoadData(string query)
        {
            string sqlStr = string.Format(query);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, db.getConn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
