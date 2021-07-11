using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneProgram
{
    class Person
    {
        public void Communicate(IPhone phone)
        {
            phone.Hangup();
            phone.Release();
        }
    }
}
