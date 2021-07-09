using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            SecuritySystem securitySystem = new SecuritySystem();
            DoorSensorStatusSystem sensor = new DoorSensorStatusSystem(securitySystem.Update);

            DoorSensor doorSensor = new DoorSensor();
            doorSensor.StatusChanged += sensor;
            doorSensor.Open();
            doorSensor.Close();
        }
    }
}
