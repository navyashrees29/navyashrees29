using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneProgram
{
    class SmartPhone : ICamera,IGPS,IPhone
    {
        ICamera _camera;
        IGPS _gps;
        IPhone _phone;
        //ICamera _takePicture;

        public void SetCamera(ICamera camera)
        {
            this._camera = camera;
        }
        public void SetGPS(IGPS gps)
        {
            this._gps = gps;
        }
        public void SetPhone(IPhone phone)
        {
            this._phone = phone;
        }
        //public void SetTakePicture(ICamera camera)
        //{
        //    this._takePicture = camera;
        //}
        public void Click()
        {
            this._camera.Click();
        }
        //public void TakePicture()
        //{
        //    this._takePicture.Click();
        //}
        public void Navigate()
        {
            this._gps.Navigate();
        }
        public void Hangup()
        {
            this._phone.Hangup();
        }
        public void Release()
        {
            this._phone.Release();
        }

    }
}
