using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerProgram
{
    class NanoLaserPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Nano Laser Printer in Action");
        }
    }
}
