﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet.Models
{
    public class Volume : Scale
    {
        //name
        public Volume(int level) : base(level)
        {
        }
        public int Id { get; set; }
    }
}