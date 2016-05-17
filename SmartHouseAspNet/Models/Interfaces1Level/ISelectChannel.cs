﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet
{
    public interface ISelectChannel
    {
        ISwitch SelectChannel { get; set; }
        int Next();
        int Prev();
        int Go(int whereToMove);
    }
}