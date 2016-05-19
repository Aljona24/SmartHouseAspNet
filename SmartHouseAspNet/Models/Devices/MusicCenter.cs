﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet.Models
{
    public class MusicCenter : SwitchableDevice, IBass, IVolume, ISoundHighs, ISelectChannel
    {
        public MusicCenter(Scale bass,  Scale soundHighs, Scale volume, ISwitch _switch, string name)
        {
            Name = name;
            Bass = bass;
            SoundHighs = soundHighs;
            Volume = volume;
            SelectChannel = _switch;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Scale Bass { get; set; }
        public Scale SoundHighs { get; set; }
        public Scale Volume { get; set; }
        public ISwitch SelectChannel { get; set; }

        int IBass.Increase()
        {
            return Bass.Increase();
        }
        int IBass.Decrease()
        {
            return Bass.Decrease();
        }

        public int Next()
        {
            return SelectChannel.Next();
        }

        public int Prev()
        {
            return SelectChannel.Prev();
        }

        public int Go(int whereToMove)
        {
            return SelectChannel.Go(whereToMove);
        }

        int IVolume.Increase()
        {
            return Volume.Increase();
        }

        int IVolume.Decrease()
        {
            return Volume.Decrease();
        }

        int ISoundHighs.Increase()
        {
            return SoundHighs.Increase();
        }

        int ISoundHighs.Decrease()
        {
            return SoundHighs.Decrease();
        }
    }
}