using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapDemo.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        //public ActionResult Index(string page)
        //{
        //    ViewBag.Page = page;
        //    return View();
        //}

        public ActionResult Index(string id,string target)
        {
            return View();
        }
    }
}