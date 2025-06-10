using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppSample0250606.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Asset()
        {
            return View();
        }

        public ActionResult Record()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }


        public ActionResult addAsset()
        {
            return View();
        }

        public ActionResult getAsset()
        {
            return View();
        }

        public ActionResult updatePic()
        {
            return View();
        }

    }
}