using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapDemo.Controllers
{
    public class TicketController : Controller
    {
        // GET: Ticket
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditTicket(int? id)
        {
            ViewBag.ControllerName = "Ticket";
            ViewBag.ActionMethod = "EditTicket";
            ViewBag.Id = id;
            return View();
        }
    }
}