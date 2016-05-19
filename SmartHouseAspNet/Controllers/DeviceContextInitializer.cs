using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SmartHouseAspNet.Models;

namespace SmartHouseAspNet.Controllers
{
    public class DeviceContextInitializer : CreateDatabaseIfNotExists<DevicesContext>
    {
        protected override void Seed(DevicesContext context)
        {
            Factory f = new Factory();
            context.Cinemas.Add((HomeCinema)f.CreateHomeCinema("hc",20,20,1,20,20));
            context.SaveChanges();
        }
    }
}