using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string data="Excelsoft";
            StringIsNullOrEmpty validateString = new StringIsNullOrEmpty();
            StringValidator validate = new StringValidator(validateString);
            Console.WriteLine(validate.ValidateString(data));

            StringValidator validateLength = new StringValidator(new StringLengthValidate());
            Console.WriteLine(validateLength.ValidateString(data));

            StringValidator validateStartsWith = new StringValidator(new StringStartsWith());
            Console.WriteLine(validateStartsWith.ValidateString(data));
        }
    }
}
