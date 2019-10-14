using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public int About(int? nr)
        {
            ViewBag.Message = "Your application description page.";

            return 1 + (nr.HasValue ? nr.Value : 0);//tem que ter mesmo tipo

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}