using System.Net;
using System.Net.Mail;
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

        public ActionResult Contact()
        {
            using (MailMessage message = new MailMessage())
            {
                message.From = new MailAddress("ivanpop@abv.bg");
                message.To.Add(new MailAddress("unfragablegaming@gmail.com"));
                message.Subject = "Message from My Site";
                message.Body = "Body";
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtpcorp.com";
                smtp.Port = 2525;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("email", "pass");
                try
                {
                    smtp.Send(message);
                }
                catch (SmtpFailedRecipientsException ex)
                {

                }
            }

            return View();
        }
    } 
}