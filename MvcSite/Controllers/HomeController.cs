using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc; 
 
namespace MvcMovie.Controllers 
{ 
    public class HomeController : Controller 
    { 
        // GET: /Home/
        public ActionResult Index(string language = "bg") 
        {
            if (language == "en")
                return View("en/Index");
            else
                return View();
        } 
 
        // GET: /Home/Bio/
        public ActionResult Bio(string language = "bg")
        {
            if (language == "en")
                return View("en/Bio");
            else
                return View();
        }

        public ActionResult Contact(string language = "bg")
        {
            if (language == "en")
                return View("en/Contact");
            else
                return View();
        }

        public void SendMail(string email, string descr, string text)
        {
            using (MailMessage message = new MailMessage())
            {
                message.From = new MailAddress(email);
                message.To.Add(new MailAddress("unfragablegaming@gmail.com"));
                message.Subject = "Message from My Site: " + descr;
                message.Body = text;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtpcorp.com";
                smtp.Port = 2525;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("ivanpop@abv.bg", "ipb123");
                try
                {
                    smtp.Send(message);
                }
                catch (SmtpFailedRecipientsException ex)
                {

                }
            }
        }
    } 
}