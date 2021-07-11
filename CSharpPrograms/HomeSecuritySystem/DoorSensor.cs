using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySystem
{
    public delegate void DoorSensorStatusHandler(string status);
    class DoorSensor
    {
        string doorSensorStatus;
        public event DoorSensorStatusHandler OnStatusChanged;
        public void Open()
        {
            doorSensorStatus = "Opened";
            this.Notify();
        }
        public void Close()
        {
            doorSensorStatus = "Closed";
            this.Notify();
        }
        void Notify()
        {
            string message =  $"{this.doorSensorStatus} and Time : {System.DateTime.Now.ToString()}";
            OnStatusChanged.Invoke(message);
        }
    }
}
