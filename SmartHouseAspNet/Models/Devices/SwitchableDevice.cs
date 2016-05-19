using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace SmartHouseAspNet.Models
{ 
    public abstract class SwitchableDevice
    {
        public bool OnOff { get; set; }
        public virtual bool On()
        {
            return OnOff = true;
        }
        public virtual bool Off()
        {
            return OnOff = false;
        }
        public override string ToString()
        {
            return OnOff ? "On" : "Off";
        }
    }
}