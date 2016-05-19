using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet.Models
{
    public class Lighting : SwitchableDevice, IBrightness
    {
        public Lighting(Scale brightness, string name)
        {
            Name = name;
            Brightness = brightness;
        }

        public int Id { get; set; }
        public string Name { get; set; }
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