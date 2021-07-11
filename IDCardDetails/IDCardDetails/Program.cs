using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentIDCard studentId = new StudentIDCard(9658, "Abhi", "Mysore", "25/06/1998", "BCA", "31/08/2021");
            TeacherIDCard teacherId = new TeacherIDCard(3545, "Arnav", "Mysore", "Lecturer", "MCA", "23/02/2020");
            StaffIDCard staffId = new StaffIDCard(7456, "Manu", "Mysore", "Security");
            GuestIDCard guestId = new GuestIDCard("27/06/2021", 8923, "Santhu", "Banglore");
        }
    }
}
