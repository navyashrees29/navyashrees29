using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            float height = ConsoleInputReaderLib.ConsoleInputReaderType.GetUserHeight();
            float weight = ConsoleInputReaderLib.ConsoleInputReaderType.GetUserWeight();

            float bmiValue = BMICalculateLib.CalculateBMIValueType.BmiCalculation(height, weight);

            string message = BMIValueValidateLib.ValidateBMIValueType.ValidateBMIValue(bmiValue);

            ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay(message);
        }
    }
}
