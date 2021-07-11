using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BMICalculationProgram
{
    public class CheckSwitchCondition
    {
        public void ExcecuteSwitchCondition(Options choice)
        {
            switch (choice)
            {
                case Options.CONSOLEINPUT:
                    float height = ConsoleInputReaderLib.ConsoleInputReaderType.GetUserHeight();
                    float weight = ConsoleInputReaderLib.ConsoleInputReaderType.GetUserWeight();

                    float bmiValue = BMICalculateLib.CalculateBMIValueType.BmiCalculation(height, weight);

                    string message = BMIValueValidateLib.ValidateBMIValueType.ValidateBMIValue(bmiValue);

                    ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay(message);
                    break;

                case Options.FILEINPUT:
                    try
                    {
                        string path = @"C:\Users\navyashrees\Desktop\BMICalculation.txt";
                        //Console.WriteLine("Enter File Path");
                        //string path = Console.ReadLine();
                        ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Name\tHeight\tWeight\tBMI Value\tResult\t");
                   
                        PatientDataReaderLib.PatientDataReaderType patientDataReader = new PatientDataReaderLib.PatientDataReaderType();
                        List<ModelsLib.PatientDataInfo> patients = patientDataReader.GetAllPatientsDetails(path);
                        for(int i=0;i<patients.Count;i++)
                        {
                            ModelsLib.PatientDataInfo dataInfo = patients[i];
                            float getBmiValue = BMICalculateLib.CalculateBMIValueType.BmiCalculation(dataInfo.Height,dataInfo.Weight);
                            string getMessage = BMIValueValidateLib.ValidateBMIValueType.ValidateBMIValue(getBmiValue);
                            ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay(dataInfo.Name+"\t"+dataInfo.Height+"\t"+dataInfo.Weight+"\t"+getBmiValue+"\t"+ getMessage);
                        }
                    }

                    catch (FileNotFoundException e)
                    {
                        ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Invalid Path,Please Check");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    break;
            }
        }
    }
}
