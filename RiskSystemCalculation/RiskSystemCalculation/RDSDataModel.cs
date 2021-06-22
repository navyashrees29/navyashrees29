using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskSystemCalculation
{
    class RDSDataModel
    {
        private int counterPartyId;
        private string name;

        public int getCounterPartyId()
        {
            return this.counterPartyId;
        }
        public string getName()
        {
            return this.name;
        }

        public void setCounterPartyId(int counterPartyId)
        {
            this.counterPartyId = counterPartyId;
        }
        public void setName(string name)
        {
            this.name = name;
        }
    }
}
