using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet.Models
{
    public interface IFactory
    {
        SwitchableDevice CreateHomeCinema(string name, int levelBass, int levelBrightness, int levelSelectChannel, int levelSoundHighs, int levelVolume);
        SwitchableDevice CreateLighting(string name, int levelBrightness);
        SwitchableDevice CreateMusicCenter(string name, int levelBass, int levelSelectChannel, int levelSoundHighs, int levelVolume);
    }
}