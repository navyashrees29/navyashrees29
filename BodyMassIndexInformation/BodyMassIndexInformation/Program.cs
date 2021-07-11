using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexInformation
{
    class Program
    {
        static void Main(string[] args)
        {

            ReadUserInputs userInput = new ReadUserInputs();
            int bmiHeight = userInput.GetUserHeight();
            int bmiWeight = userInput.GetUserWeight();

            BMICalculate bmi = new BMICalculate(bmiHeight, bmiWeight);
            float bmiValue = bmi.BmiCalculation();

            BMIValueValidate bmiValueValidate = new BMIValueValidate();
            string message = bmiValueValidate.BmiValidate(bmiValue);

            BMIConsoleDisplay display = new BMIConsoleDisplay();
            display.ConsoleDisplay(message);
        }
    }
}
