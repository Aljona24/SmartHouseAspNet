﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet.Models
{
    public abstract class Scale
    {
        public Scale(int level)
        {
            Level = level;
        }
        private int level;//явно приват
        
        //int max; readonly+ конструктор
        //енум устройство и оставить его одного , каррент, мин, мах, стэп
        // buss volume убираются 
        public int Level
        {
            get { return level; }
            set
            {
                if (100 >= value && value >= 0)
                {
                    level = value;
                }
            }
        }       

        public int Decrease()
        {
            return --Level;
        }
        public int Increase()
        {
            return ++Level;
        }
        public override string ToString()
        {
            return "Level " + Level;
        }
    }
}