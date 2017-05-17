using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppDemo.Web.Controllers
{
    public class SesstionController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Session["Test"] = "Hello Redis";
            TempData["Test"] = "Hello Redis";

            return View();
        }

        public ActionResult SessionTest()
        {
            return View();
        }
    }
}