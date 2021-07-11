using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardDetails
{
    public class StaffIDCard : CollegeIDCard
    {
        private string typeOfWork;
       
        public string GetTypeOfWork()
        {
            return this.typeOfWork;
        }
        public StaffIDCard(int id, string name, string address, string typeOfWork) :base(id,name,address)
        {
            this.typeOfWork = typeOfWork;
        }
    }
}
