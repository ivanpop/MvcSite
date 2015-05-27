using System.Web;
using System.Web.Mvc; 
 
namespace MvcMovie.Controllers 
{ 
    public class HomeController : Controller 
    { 
        // GET: /Home/ 
 
        public ActionResult Index() 
        {
            return View(); 
        } 
 
        // GET: /Home/Bio/ 

        public ActionResult Bio()
        {
            return View();
        }
    } 
}