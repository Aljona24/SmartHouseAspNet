using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SmartHouseAspNet.Models;

namespace SmartHouseAspNet.Controllers
{
    public class DevicesContext : DbContext
    {
        static DevicesContext() 
        {
            Database.SetInitializer<DevicesContext>(new DeviceContextInitializer());
        }
        public DbSet<HomeCinema> Cinemas { get; set; }
        public DbSet<Lighting> Lightings { get; set; }
        public DbSet<MusicCenter> MusicCenters { get; set; }


        public DbSet<Bass> BassModuls { get; set; }
        public DbSet<Brightness> BrightnessModuls { get; set; }
        public DbSet<SelectChannel> SelectChannelModuls { get; set; }
        public DbSet<SoundHighs> SoundHighsModuls { get; set; }
        public DbSet<Volume> VolumeModuls { get; set; }
    }
}