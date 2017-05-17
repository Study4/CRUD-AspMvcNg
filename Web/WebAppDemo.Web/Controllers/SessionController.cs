using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppDemo.Web.Controllers
{
    public class SessionController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Session["Test"] = "Hello Redis";

            return View();
        }

        public ActionResult SessionTest()
        {
            return View();
        }
    }
}