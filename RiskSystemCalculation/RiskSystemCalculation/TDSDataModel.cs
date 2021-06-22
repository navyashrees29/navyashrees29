using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskSystemCalculation
{
    class TDSDataModel
    {
        private int tradeId;
        private string tradeDate;
        private int currentTradeValue;
        private int counterPartyId;

        public  int getTradeId()
        {
            return this.tradeId;
        }
        public string getTradeDate()
        {
            return  this.tradeDate;
        }
        public int getcurrentTradeValue()
        {
            return this.currentTradeValue;
        }
        public int getcounterPartyId()
        {
            return this.counterPartyId;
        }

        public void setTradeId(int tradeId)
        {
            this.tradeId = tradeId;
        }
        public void setTradeDate(string tradeDate)
        {
            this.tradeDate = tradeDate;
        }
        public void setCurrentTradeValue(int currentTradeValue)
        {
            this.currentTradeValue = currentTradeValue;
        }
        public void setCounterPartyId(int counterPartyId)
        {
            this.counterPartyId = counterPartyId;
        }

    }
}
