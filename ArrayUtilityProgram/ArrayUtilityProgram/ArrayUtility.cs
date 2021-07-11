using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUtilityProgram
{
    class ArrayUtility
    {
        public static void Resize(ref int[] array, int newSize)
        {

            int[] temp = new int[newSize];

            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }
            array = temp;

        }
    }
}
