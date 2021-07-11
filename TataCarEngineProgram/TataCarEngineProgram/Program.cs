using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCarEngineProgram
{
    class Program
    {
             static void Main(string[] args)
            {
                 DiCorEngine diCor = new DiCorEngine();
                 TataCar car = new TataCar(diCor);
                 car.Drive();
                 car.Halt();
                 TataCar nexon = new TataCar(new VeriCorEngine());
                 nexon.Drive();
                 nexon.Halt();
                 TataCar hexa = new TataCar(new RevorTron());
                 hexa.Drive();
                 hexa.Halt();
             }
    }
}
