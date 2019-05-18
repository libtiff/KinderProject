using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindergartenManagementSystem
{
    class EmployeeClass
    {

        private string SocialInsNum { get; set; }
        private string Firstname { get; set; }
        private string Lastname { get; set; }
        private string Birthday { get; set; }
        private string Address { get; set; }
        private int HomeTelNum { get; set; }
        private int MobileTelNum { get; set; }
        private int Salary { get; set; }
        private string Sex { get; set; }
        private string Nationality { get; set; }
        private string IDNum { get; set; }

        public EmployeeClass(string firstname, string lastname , int IDNum , string insurancenum , string birthday , string address , int hometel , int mobiletel , int salary , string sex , string nationality , string socialnum , int idnum)
        {
            Firstname = firstname;
            Lastname = lastname;
            Birthday = birthday;
            Address = address;
            HomeTelNum = hometel;
            MobileTelNum = mobiletel;
            Salary = salary;
            Sex = sex;
            Nationality = nationality;
            SocialInsNum = socialnum;
            IDNum = idnum;
        } 
    }
}
