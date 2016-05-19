using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SmartHouseAspNet.Models;

namespace SmartHouseAspNet.Controllers
{
    public class HomeController : Controller
    {
        private DevicesContext dbDevices = new DevicesContext();

        public ActionResult Index()
        {
            return View(dbDevices.Cinemas);
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
    }
}