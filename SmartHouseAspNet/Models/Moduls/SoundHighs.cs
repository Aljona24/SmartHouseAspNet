using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet.Models
{
    public class SoundHighs : Scale
    {
        public SoundHighs(int level) : base(level)
        {
        }
        public int Id { get; set; }
    }
}