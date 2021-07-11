using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidationProgram
{
    public class StringValidator 
    {
        IStringValidate _stringValidate;

        public StringValidator(IStringValidate stringValidate)
        {
            this._stringValidate = stringValidate;
        }
        public bool ValidateString(string data)
        {
            return _stringValidate.IsValidString(data);
        }
   }
}
