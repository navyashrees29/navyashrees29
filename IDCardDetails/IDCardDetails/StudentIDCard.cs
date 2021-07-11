using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardDetails
{
    public class StudentIDCard : CollegeIDCard
    {
        private string dob;
        private string course;
        private string idValidTill;

        public string GetDob()
        {
            return this.dob;
        }
        public string GetCourse()
        {
            return this.course;
        }
        public string GetIdValidTill()
        {
            return this.idValidTill;
        }
       
        public StudentIDCard(int id, string name, string address, string dob, string course, string idValidTill):base(id,name,address)
        {
            this.dob = dob;
            this.course = course;
            this.idValidTill = idValidTill;
        }
    }
}
