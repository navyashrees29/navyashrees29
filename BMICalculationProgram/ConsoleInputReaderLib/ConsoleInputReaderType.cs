using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputReaderLib
{
    public class ConsoleInputReaderType
    {
        public static int GetUserHeight()
        {
            ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Enter your height in meter:");
            string heightInMeter = Console.ReadLine();
            int height = int.Parse(heightInMeter);
            return height;
        }

        public static int GetUserWeight()
        {
            ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Enter your weight in meter:");
            string weightInKG = Console.ReadLine();
            int weight = int.Parse(weightInKG);
            return weight;
        }
    }
}
