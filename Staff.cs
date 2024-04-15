using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaShop
{
    public class Staff
    {
		private string manv;
		private string hoten;
		private DateTime ngaysinh;
		private string diachi;
		private string sdt;
		private DateTime ngaytuyendung;
		private string gioitinh;
		private string macv;
		public Staff(string manv, string hoten, DateTime ngaysinh, string diachi, string sdt, DateTime ngaytuyendung, string gioitinh, string macv, string maNV)
        {
            this.manv=manv;
            this.hoten=hoten;
            this.ngaysinh=ngaysinh;
            this.diachi=diachi;
            this.sdt=sdt;
            this.ngaytuyendung=ngaytuyendung;
            this.gioitinh=gioitinh;
            this.macv=macv;
        }
		public Staff() { }
        public string MaNV
        {
            get { return manv; }
			set { manv = value; }
        }
		public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value;}
        }
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public DateTime NgayTuyenDung
        {
            get { return ngaytuyendung; }
            set { 
                ngaytuyendung = value;
            }
        }
        public string GioiTinh
        {
            get { return gioitinh; }
            set
            {
                gioitinh = value;
            }
        }
        public string MaCV
        {
            get { return macv; }
            set { macv = value; }
        }
	}
}
