using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet
{
    public interface ISoundHighs
    {
        Scale SoundHighs { get; set; }
        int Increase();
        int Decrease();

    }
}