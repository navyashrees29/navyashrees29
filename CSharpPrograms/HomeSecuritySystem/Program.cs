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
            DoorSensorStatusHandler sensorSystem = new DoorSensorStatusHandler(securitySystem.Update);

            DoorSensor doorSensor = new DoorSensor();
            doorSensor.OnStatusChanged += sensorSystem;
            doorSensor.Open();
            doorSensor.Close();
        }
    }
}
