using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcCustomLogger.Controllers
{
    public class HomeController : Controller
    {

        TraceSource obj = new TraceSource("Trace", SourceLevels.All);
        public ActionResult Index()
        {
           
            obj.TraceEvent(TraceEventType.Information, 0, "info message Index" + DateTime.Now);


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            obj.TraceEvent(TraceEventType.Information, 0, "info message About" + DateTime.Now);
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            obj.TraceEvent(TraceEventType.Information, 0, "info message Contact" + DateTime.Now);
            return View();
        }
    }
}