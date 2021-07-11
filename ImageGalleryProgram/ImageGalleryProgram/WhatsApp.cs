using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryProgram
{
    public class WhatsApp : IShareImage
    {
        public void Send()
        {
            Console.WriteLine("Sent through WhatsApp");
        }
    }
}
