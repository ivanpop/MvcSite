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
        public ActionResult Index(string language = "bg")
        {
            if (language == "en")
                return View("en/Index");
            else
                return View();
        }

        // GET: Ryu
        public ActionResult Ryu(string id = "1", string language = "bg")
        {
            if (language == "en")
                switch (id)
                {
                    case "3": return View("en/Ryu3");
                    case "2": return View("en/Ryu2");
                    default: return View("en/Ryu");
                }

            else
                switch (id)
                {
                    case "3": return View("Ryu3");
                    case "2": return View("Ryu2");
                    default: return View("Ryu");
                }  
        }

        // GET: CountdownTimer
        public ActionResult CountdownTimer(string id = "1", string language = "bg")
        {
            if (language == "en")
                switch (id)
                {
                    case "2": return View("en/CountdownTimer2");
                    default: return View("en/CountdownTimer");
                }

            else
            switch (id)
            {
                case "2": return View("CountdownTimer2");
                default: return View("CountdownTimer");
            }
        }

        // GET: C# for Dummies
        public ActionResult CSharpForDummies(string id = "0", string language = "bg")
        {
            if (language == "en")
            {
                switch (id)
                {
                    case "1": return View("en/CSharpForDummies/CSharpForDummies1");
                    case "2": return View("en/CSharpForDummies/CSharpForDummies2");
                    case "3": return View("en/CSharpForDummies/CSharpForDummies3");
                    case "4": return View("en/CSharpForDummies/CSharpForDummies4");
                    case "5": return View("en/CSharpForDummies/CSharpForDummies5");
                    case "6": return View("en/CSharpForDummies/CSharpForDummies6");
                    case "7": return View("en/CSharpForDummies/CSharpForDummies7");
                    case "8": return View("en/CSharpForDummies/CSharpForDummies8");
                    case "9": return View("en/CSharpForDummies/CSharpForDummies9");
                    case "10": return View("en/CSharpForDummies/CSharpForDummies10");
                    case "11": return View("en/CSharpForDummies/CSharpForDummies11");
                    case "12": return View("en/CSharpForDummies/CSharpForDummies12");
                    default: return View("en/CSharpForDummies/CSharpForDummies");
                }
            }
            else
            {
                switch (id)
                {
                    case "1": return View("CSharpForDummies/CSharpForDummies1");
                    case "2": return View("CSharpForDummies/CSharpForDummies2");
                    case "3": return View("CSharpForDummies/CSharpForDummies3");
                    case "4": return View("CSharpForDummies/CSharpForDummies4");
                    case "5": return View("CSharpForDummies/CSharpForDummies5");
                    case "6": return View("CSharpForDummies/CSharpForDummies6");
                    case "7": return View("CSharpForDummies/CSharpForDummies7");
                    case "8": return View("CSharpForDummies/CSharpForDummies8");
                    case "9": return View("CSharpForDummies/CSharpForDummies9");
                    case "10": return View("CSharpForDummies/CSharpForDummies10");
                    case "11": return View("CSharpForDummies/CSharpForDummies11");
                    case "12": return View("CSharpForDummies/CSharpForDummies12");
                    default: return View("CSharpForDummies/CSharpForDummies");
                }
            }
        }

        // GET: Converter
        public ActionResult Converter(string language = "bg")
        {
            if (language == "en")
                return View("en/Converter");
            else
                return View();  
        }

        // GET: MVCSite
        public ActionResult MVCSite(string language = "bg")
        {
            if (language == "en")
                return View("en/MVCSite");
            else
                return View();
        }

        // GET: PPWCalculator
        public ActionResult PPWCalculator(string language = "bg")
        {
            if (language == "en")
                return View("en/PPWCalculator");
            else
                return View();
        }
    }
}