using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet.Models
{
    public class Bass : Scale
    {
        public Bass(int level) : base(level)
        {
        }

        public int Id { get; set; }
        public int SwitchableDeviceId { get; set; }
    }
}
