using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryProgram
{
    public class ImageGallery
    {
        public void Send(IShareImage send)
        {
            send.Send();
        }
    }
}
  

