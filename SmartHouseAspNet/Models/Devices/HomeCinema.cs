using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace SmartHouseAspNet.Models
{
    public class HomeCinema : SwitchableDevice, IBrightness, IVolume, IBass, ISoundHighs, ISelectChannel
    {        
        public HomeCinema(Scale bass, Scale brightness, Scale soundHighs, Scale volume, ISwitch _switch, string name)
        {
            Name = name;
            Bass = bass;
            Brightness = brightness;
            SoundHighs = soundHighs;
            Volume = volume;
            SelectChannel = _switch;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Scale Bass { get; set; } //orders после конструктора
        public Scale Brightness { get; set; }
        public Scale SoundHighs { get; set; }
        public Scale Volume { get; set; }
        public ISwitch SelectChannel { get; set; }

        public int? BassId { get; set; }
        //public virtual Bass Bass { get; set; }


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
        int IBrightness.Increase()
        {
            return Brightness.Increase();
        }
        int IBrightness.Decrease()
        {
            return Brightness.Decrease();
        }

        int IVolume.Increase()
        {
            return Volume.Increase();
        }

        int IVolume.Decrease()
        {
            return Volume.Decrease();
        }

        int IBass.Increase()
        {
            return Bass.Increase();
        }

        int IBass.Decrease()
        {
            return Bass.Decrease();
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