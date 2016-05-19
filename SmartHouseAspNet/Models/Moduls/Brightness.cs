using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet.Models
{
    public class Brightness : Scale
    {
        public Brightness(int level) : base(level)
        {
        }
        public int Id { get; set; }
    }
}