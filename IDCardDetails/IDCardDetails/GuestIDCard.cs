using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardDetails
{
    public class GuestIDCard : CollegeIDCard
    {
        private string dateOfVisiting;

        public string GetDateOfVisiting()
        {
            return this.dateOfVisiting;
        }
        public GuestIDCard(string dateOfVisiting, int id, string name, string address):base(id,name,address)
        {
            this.dateOfVisiting = dateOfVisiting;
        }
        
    }
}
