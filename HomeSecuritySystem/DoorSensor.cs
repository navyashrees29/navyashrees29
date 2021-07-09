using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySystem
{
    public delegate void DoorSensorStatusSystem(string status);
    class DoorSensor
    {
        string doorSensorStatus;
        public event DoorSensorStatusSystem StatusChanged;
        public void Open()
        {
            doorSensorStatus = "Opened";
            StatusChanged.Invoke(this.doorSensorStatus);
        }
        public void Close()
        {
            doorSensorStatus = "Closed";
            StatusChanged.Invoke(this.doorSensorStatus);
        }
    }
}
