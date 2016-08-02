using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapDemo.Controllers
{
    public class FileDemoController : Controller
    {
        // GET: FileDemo
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(IEnumerable<HttpPostedFileBase> files)
        {
            var t = Request.Files[0].FileName;
            var t1 = Request.Files[1].FileName;
            var t2 = Request.Files[2].FileName;
            return View();
        }
    }
}