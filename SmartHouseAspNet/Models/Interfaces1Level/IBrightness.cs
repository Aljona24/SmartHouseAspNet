﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet.Models
{
    public interface IBrightness
    {
        Scale Brightness { get; set; }
        int Increase();
        int Decrease();
    }
}