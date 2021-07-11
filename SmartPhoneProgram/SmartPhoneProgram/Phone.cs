using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneProgram
{
    class Phone : IPhone
    {
        public void Hangup()
        {
            Console.WriteLine("Call hangup");
        }
        public void Release()
        {
            Console.WriteLine("call release");
        }
    }
}
