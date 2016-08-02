using BootstrapDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace BootstrapDemo.Controllers
{
    public class DemoController : Controller
    {

        private List<TestModel> _item;

        public List<TestModel> Item
        {
            get
            {
                _item = new List<TestModel>
            {
                new TestModel {MyProperty1=1,MyProperty2="TestProperty11",MyProperty3="TestProperty12" },
                new TestModel {MyProperty1=2,MyProperty2="TestProperty21",MyProperty3="TestProperty22" },
                new TestModel {MyProperty1=3,MyProperty2="TestProperty31",MyProperty3="TestProperty32" }
            };
                return _item;
            }
        }

        [HandleError]
        public ActionResult Index()
        {

            var t = new List<TestModel>();

            var s = t.FirstOrDefault() == null ? "default value" : "";
            return View(Item);
        }

        protected override void HandleUnknownAction(string actionName)
        {
            if (this.ActionInvoker.InvokeAction(this.ControllerContext, "ReturnErrorForUnknownAction")) return;
        }

        public ActionResult ReturnErrorForUnknownAction()
        {
            return Task.Delay(2000).ContinueWith(t =>
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }).Result;
           
        }


        public ActionResult GetDetail(int id)
        {
            var model = Item.Where(x => x.MyProperty1 == id).FirstOrDefault();
            return PartialView("TestPartial", model);
        }

        [HttpPost]
        public ActionResult Save(TestModel model)
        {
            ModelState.AddModelError("MyProperty2", "MyProperty2 xxx");

            if (ModelState.IsValid)
            {
                return Json(new { Data = model, success = true }, JsonRequestBehavior.AllowGet);
            }
            return PartialView("TestPartial", model);
        }

        public ActionResult Devices(string ipAddress, string portId)
        {
            var result = "ipAddress=" + ipAddress + " portId=" + portId;
            return Content(result);
        }

        public ActionResult Download(string file)
        {
            string pfn = Server.MapPath("~/Documents/Stuff/" + file);
            if (!System.IO.File.Exists(pfn))
            {
                return HttpNotFound();
            }

            return File(pfn, System.Net.Mime.MediaTypeNames.Application.Octet);
        }

    }


}