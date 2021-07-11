using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCarEngineProgram
{
    public class MultiJetEngine :IEngine
    {
        public void Start()
        {
            Console.Write("MultiJetEngine start\n");
        }
        public void Stop()
        {
            Console.Write("MultiJetEngine stop\n");
        }
    }
}
