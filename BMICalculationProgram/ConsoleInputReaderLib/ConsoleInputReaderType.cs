using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputReaderLib
{
    public class ConsoleInputReaderType
    {
        public static float GetUserHeight()
        {
            ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Enter your height in meter:");
            float height = float.Parse(Console.ReadLine());
            return height;
        }

        public static float GetUserWeight()
        {
            ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Enter your weight in KG:");
            float weight = float.Parse(Console.ReadLine());
            return weight;
        }
    }
}
