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
        public ActionResult Ryu(byte page = 1)
        {
            switch (page)
            {
                case 3: return View("Ryu3");
                case 2: return View("Ryu2");
                default: return View("Ryu");
            }   
        }

        // GET: CountdownTimer
        public ActionResult CountdownTimer(byte page = 1)
        {
            switch (page)
            {
                case 2: return View("CountdownTimer2");
                case 3: return View("CountdownTimer3");
                case 4: return View("CountdownTimer4");
                default: return View("CountdownTimer");
            }
        }

        // GET: C# for Dummies
        public ActionResult CSharpForDummies(byte page = 0)
        {
            switch (page)
            {
                case 1: return View("CSharpForDummies/CSharpForDummies1");
                case 2: return View("CSharpForDummies/CSharpForDummies2");
                case 3: return View("CSharpForDummies/CSharpForDummies3");
                case 4: return View("CSharpForDummies/CSharpForDummies4");
                case 5: return View("CSharpForDummies/CSharpForDummies5");
                case 6: return View("CSharpForDummies/CSharpForDummies6");
                case 7: return View("CSharpForDummies/CSharpForDummies7");
                case 8: return View("CSharpForDummies/CSharpForDummies8");
                case 9: return View("CSharpForDummies/CSharpForDummies9");
                case 10: return View("CSharpForDummies/CSharpForDummies10");
                case 11: return View("CSharpForDummies/CSharpForDummies11");
                default: return View("CSharpForDummies/CSharpForDummies");
            }
        }

        // GET: Converter
        public ActionResult Converter()
        {
            return View();   
        }
    }
}