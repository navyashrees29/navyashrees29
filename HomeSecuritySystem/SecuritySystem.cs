using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySystem
{
    class SecuritySystem
    {
        public void Update(string notification)
        {
            Console.WriteLine("Door is "+notification+ " at "+ DateTime.Now.ToString());
        }
    }
}
