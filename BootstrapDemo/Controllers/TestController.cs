using BootstrapDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapDemo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var model = new List<UserEntities>();
            var s = model.DefaultIfEmpty().OrderBy(x => x.MyProperty);
            return View();
        }
    }
}