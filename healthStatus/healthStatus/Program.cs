using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healthStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your height in meters");
            float bmiHeight = float.Parse(Console.ReadLine());
          

            System.Console.WriteLine("Enter your weight in kilograms");
            float bmiWeight = float.Parse(Console.ReadLine());
           

            float bmiValue = bmiWeight / bmiHeight;

            if(bmiValue<18.5)
            {
                System.Console.Write("Your weight is " + bmiValue + " UnderWeight");
            } 
            else if(bmiValue>=25)
            {
                System.Console.Write("Your weight is " + bmiValue + " overweight ");
            }
            else
            {
                System.Console.WriteLine("Your weight is " + bmiValue + " healthy");
            } 
        } 
    }
}
