using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardDetails
{
    public abstract class CollegeIDCard
    {
        private int id ;
        private string name, address;

        public int GetId()
        {
            return this.id;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetAddress()
        {
            return this.address;
        }
        public CollegeIDCard(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public CollegeIDCard(int id, string name, string address) :this(id,name)
        {
            this.address = address;
        }   
    }
}
