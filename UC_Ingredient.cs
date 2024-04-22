using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;
namespace MilkTeaShop
{
    public partial class UC_Ingredient : UserControl
    {
        Ingredient ig;
        FIngredient fI;
        public UC_Ingredient()
        {
            InitializeComponent();
        }
        public Guna2HtmlLabel LBL_NAME => lbl_Name;
        public Guna2HtmlLabel LBL_MANL => lbl_MaNL;
        public Guna2HtmlLabel LBL_NUMBER => lbl_Number; 
        public Guna2HtmlLabel LBL_DONVI => lbl_DonVi;
        public UC_Ingredient(Ingredient IG, FIngredient FIG)
        {
            InitializeComponent();
            this.fI = FIG;
            this.Click += showinf;
            this.ig = IG;
            this.lbl_Name.Text = IG.TenNL;
            this.lbl_MaNL.Text = IG.MaNL;
            this.lbl_Number.Text = IG.SoLuong.ToString();
            this.lbl_DonVi.Text = IG.DonVi;
            string trangthai = IG.TrangThai;

            /*if (trangthai == "Available")
            {
                picture_TrangThai.Image = Image.FromFile("C:\\Users\\PC\\Downloads\\tick.png");
            }
            else if(trangthai == "Unavailable")
            {
                picture_TrangThai.Image = Image.FromFile("C:\\Users\\PC\\Downloads\\x.png");
            }*/

            if (Convert.ToInt32(lbl_Number.Text) > 2)
            {
                //picture_TrangThai.Image = Image.FromFile("C:\\Users\\PC\\Downloads\\tick.png");
                System.Drawing.Image image = Properties.Resources.tick; // Thay "TenAnh" bằng tên của ảnh trong Resource

                // Gán ảnh vào PictureBox
                picture_TrangThai.Image = image;
            }
            else
            {
                System.Drawing.Image image = Properties.Resources.x; // Thay "TenAnh" bằng tên của ảnh trong Resource

                // Gán ảnh vào PictureBox
                picture_TrangThai.Image = image; ;
            }
        }

        public void showinf (object sender, EventArgs e)
        {
            fI.Txt_DonVi.Text = this.lbl_DonVi.Text;
            fI.Txt_MaNL.Text=this.lbl_MaNL.Text;
            fI.Txt_NameNL.Text = this.lbl_Name.Text;
            fI.Txt_SoLuong.Text = this.lbl_Number.Text;
        }

        public void UC_Ingredient_Click(object sender, EventArgs e)
        {
            
        }
    }
}
