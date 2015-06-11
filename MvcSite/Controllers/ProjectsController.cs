using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSite.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ryu
        public ActionResult Ryu()
        {
            return View();
        }

        // GET: CountdownTimer
        public ActionResult CountdownTimer()
        {
            return View();
        }

        // GET: C# for Dummies
        public ActionResult CSharpForDummies()
        {
            return View();
        }

        // GET: Converter
        public ActionResult Converter()
        {
            return View();
        }
    }
}