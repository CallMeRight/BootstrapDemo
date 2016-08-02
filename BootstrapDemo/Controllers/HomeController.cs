using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapDemo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {   
        public ActionResult Index(int? page)
        {
            ViewBag.Page = page;
            return View();
        }     

        //public ActionResult Index()
        //{
        //    return View();
        //}

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

        [Route("Home/Data/ViewData")]
        public ActionResult ViewData()
        {
            return View("Data/ViewData"); 
        }

    }
}