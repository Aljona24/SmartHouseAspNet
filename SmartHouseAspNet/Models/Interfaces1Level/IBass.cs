﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet.Models
{
    public interface IBass
    {
        Scale Bass { get; set; }
        int Increase();
        int Decrease();

    }
}