using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCarEngineProgram
{
    public class DiCorEngine : IEngine
    {
        public void Start()
        {
            Console.Write("DiCorEngine start\n");
        }
        public void Stop()
        {
            Console.Write("DiCorEngine stop\n");
        }
    }
}
