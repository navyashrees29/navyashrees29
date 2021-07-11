using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardDetails
{
    public class TeacherIDCard : CollegeIDCard
    {
        private string designation;
        private string department;
        private string dateOfJoining;

        public string GetDesignation()
        {
            return this.designation;
        }
        public string GetDepartment()
        {
            return this.department;
        }
        public string GetDateOfJoining()
        {
            return this.dateOfJoining;
        }
        public TeacherIDCard(int id, string name, string address, string designation, string department, string dateOfJoining):base(id,name,address)
        {
            this.designation = designation;
            this.department = department;
            this.dateOfJoining = dateOfJoining;
        }
    }
}
