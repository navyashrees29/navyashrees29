using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Gmail gmail = new Gmail();
            WhatsApp whatsApp = new WhatsApp();
            Bluetooth bluetooth = new Bluetooth();

            ImageGallery imageGallery = new ImageGallery();
            imageGallery.Send(gmail);
            imageGallery.Send(whatsApp);
            imageGallery.Send(bluetooth);
        }
    }
}
