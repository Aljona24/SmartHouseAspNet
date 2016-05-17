using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet
{
    public class Lighting : SwitchableDevice, IBrightness
    {
        public Lighting(Scale scale)
        {
            this.Brightness = scale;
        }

        public Scale Brightness { get; set; }

        public int Decrease()
        {
            return Brightness.Increase();
        }
        public int Increase()
        {
            return Brightness.Decrease();
        }
    }
}