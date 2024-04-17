using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaShop
{
    public class Customer
    {
        private string id;
        private string name;
        private string phone;
        private string gender;
        private string dob;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Dob { get => dob; set => dob = value; }

        public Customer(string name, string phone, string gender, string dob) 
        {
            this.name = name;
            this.phone = phone;
            this.gender = gender;
            this.dob = dob;
        }

        public bool CheckAllCondition()
        {
            if (CheckName() && CheckPhone() && CheckGender())
            {
                return true;
            }
            return false;
        }

        public bool CheckGender()
        {
            if (gender == null || gender == "")
            {
                MessageBox.Show("Gender cannot be null !");
                return false;
            }

            //if (sex != "Nam" || sex != "Nữ" || sex != "Male" || sex != "Female")
            //{
            //    MessageBox.Show("Gender is not correct !");
            //    MessageBox.Show(sex);
            //    return false;
            //}
            return true;
        }

        public bool CheckPhone()
        {
            if (phone == null || phone == "")
            {
                MessageBox.Show("Phone number cannot be null !");
                return false;
            }
            if (phone.StartsWith("0"))
            {
                if (phone.Length == 10)
                    return true;
            }
            else if (phone.StartsWith("+84"))
            {
                if (phone.Length == 12)
                    return true;
            }
            MessageBox.Show("Phone number is not in correct format !");
            return false;
        }

        public bool CheckName()
        {
            if (Name == null || Name == "")
            {
                MessageBox.Show("Name cannot be null !");
                return false;
            }
            return true;
        }
    }
}
