using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneProgram
{
    class Camera : ICamera
    {
        public void Click()
        {
            Console.WriteLine("Capture by Camera");
        }
    }
}
