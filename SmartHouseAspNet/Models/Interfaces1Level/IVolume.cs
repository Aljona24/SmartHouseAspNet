﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet
{
    public interface IVolume
    {
        Scale Volume { get; set; }
        int Increase();
        int Decrease();
    }
}