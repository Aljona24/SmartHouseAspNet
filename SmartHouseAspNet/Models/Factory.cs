using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet.Models
{
    public class Factory : IFactory
    {
        public SwitchableDevice CreateHomeCinema(string name, int levelBass, int levelBrightness, int levelSelectChannel, int levelSoundHighs, int levelVolume)
        {
            Bass bass = new Bass(levelBass);
            Brightness brightness = new Brightness(levelBrightness);
            SelectChannel selectChannel = new SelectChannel(levelSelectChannel);
            SoundHighs soundHighs = new SoundHighs(levelSoundHighs);
            Volume volume = new Volume(levelVolume);
            return new HomeCinema(bass, brightness, soundHighs, volume, selectChannel, name);
        }
        public SwitchableDevice CreateLighting(string name, int levelBrightness)
        {
            Brightness brightness = new Brightness(levelBrightness);
            return new Lighting(brightness, name);

        }
        public SwitchableDevice CreateMusicCenter(string name, int levelBass, int levelSelectChannel, int levelSoundHighs, int levelVolume)
        {
            Bass bass = new Bass(levelBass);
            SelectChannel selectChannel = new SelectChannel(levelSelectChannel);
            SoundHighs soundHighs = new SoundHighs(levelSoundHighs);
            Volume volume = new Volume(levelVolume);
            return new MusicCenter(bass, soundHighs, volume, selectChannel, name);
        }
    }
}