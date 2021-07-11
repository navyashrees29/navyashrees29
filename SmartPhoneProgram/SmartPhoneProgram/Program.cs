using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera camera = new Camera();
            GPS gps = new GPS();
            Phone phone = new Phone();

            SmartPhone smartPhone = new SmartPhone();
            //smartPhone.TakePicture();
            smartPhone.Click();
            smartPhone.Navigate();
            smartPhone.Hangup();
            smartPhone.Release();

            Photographer photographer = new Photographer();
    //        photographer.Capture(smartPhone);
            photographer.Capture(camera);

            Traveller traveller = new Traveller();
   //         traveller.Hike(smartPhone);
            traveller.Hike(gps);

            Person person = new Person();
      //      person.Communicate(smartPhone);
            person.Communicate(phone);
        }
    }
}
