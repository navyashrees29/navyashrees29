using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCarEngineProgram
{
    public class RevorTron :IEngine
    {
        public void Start()
        {
            Console.Write("RevorTron start\n");
        }
        public void Stop()
        {
            Console.Write("RevorTron stop\n");
        }
    }
}
