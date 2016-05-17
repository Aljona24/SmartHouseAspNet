using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouseAspNet
{
    public interface IFactory
    {
        SwitchableDevice CreateHomeCinema(int levelBass, int levelBrightness, int levelSelectChannel, int levelSoundHighs, int levelVolume);
        SwitchableDevice CreateLighting(int levelBrightness);
        SwitchableDevice CreateMusicCenter(int levelBass, int levelSelectChannel, int levelSoundHighs, int levelVolume);
    }
}