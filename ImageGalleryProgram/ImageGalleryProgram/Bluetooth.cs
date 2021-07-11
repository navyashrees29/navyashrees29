using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryProgram
{
    public class Bluetooth : IShareImage
    {
        public void Send()
        {
            Console.WriteLine("Sent through Bluetooth");
        }
    }
}
