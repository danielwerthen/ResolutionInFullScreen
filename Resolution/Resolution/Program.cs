using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create window on a secondary monitor
            var display = DisplayDevice.AvailableDisplays.First(row => !row.IsPrimary);
            FullscreenWindow window = new FullscreenWindow(display.Width, display.Height, display);
            //Open into fullscreen mode
            window.Open(display);
            window.RenderFrame();
        }
    }
}
