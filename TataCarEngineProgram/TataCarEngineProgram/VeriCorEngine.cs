using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCarEngineProgram
{
    public class VeriCorEngine : IEngine
    {
        public void Start()
        {
            Console.Write("VeriCorEngine start\n");
        }
        public void Stop()
        {
            Console.Write("VeriCorEngine stop\n");
        }
    }
}
