using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUtilityProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[2];
            numbers[0] = 10;
            numbers[1] = 20;
            ArrayUtility.Resize(ref numbers, numbers.Length + 2);
            numbers[2] = 30;
            numbers[3] = 40;
            ArrayUtility.Resize(ref numbers, numbers.Length + 2);
            numbers[4] = 50;
            numbers[5] = 60;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

    }
}
