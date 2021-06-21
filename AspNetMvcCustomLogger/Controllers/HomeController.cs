using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcCustomLogger.Controllers
{
    public class HomeController : Controller
    {
        CustomTextWriterTraceListener customTextWriterTraceListener;
        public ActionResult Index()
        {
            customTextWriterTraceListener = new CustomTextWriterTraceListener();
            customTextWriterTraceListener.Write("Index" + DateTime.Now);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            customTextWriterTraceListener.Write("About" + DateTime.Now);
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            customTextWriterTraceListener.Write("Contact" + DateTime.Now);
            return View();
        }
    }
}