using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskSystemCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            TDSDataModel tds = new TDSDataModel();
            tds.setTradeId(101);
            tds.setTradeDate("20/06/2021");
            tds.setCurrentTradeValue(2310);
            tds.setCounterPartyId(100);

            System.Console.WriteLine("Trade id is " + tds.getTradeId());
            System.Console.WriteLine("Trade date is " + tds.getTradeDate());
            System.Console.WriteLine("Trade current trade value is " + tds.getcurrentTradeValue());
            System.Console.WriteLine("Trade counter party id is " + tds.getcounterPartyId());

            RDSDataModel rds = new RDSDataModel();
            rds.setCounterPartyId(200);
            rds.setName("Arun");
            System.Console.WriteLine("Counter party id is " + rds.getCounterPartyId());
            System.Console.WriteLine("Name is " + rds.getName());

        }
    }
}
