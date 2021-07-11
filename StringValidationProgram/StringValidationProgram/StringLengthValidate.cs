using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidationProgram
{
    public class StringLengthValidate : IStringValidate
    {
        public bool IsValidString(string data)
        {
            if (data.Length > 8)
            {
               return false;
            }
            return true;
        }
    }
}
