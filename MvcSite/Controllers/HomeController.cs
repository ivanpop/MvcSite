using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller 
    {
        [Route("robots.txt", Name = "GetRobotsText"), OutputCache(Duration = 86400)]
        public ContentResult RobotsText()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("user-agent: *");
            stringBuilder.AppendLine("disallow: /error/");
            stringBuilder.AppendLine("allow: /error/foo");
            stringBuilder.Append("sitemap: ");
            stringBuilder.AppendLine(this.Url.RouteUrl("GetSitemapXml", null, this.Request.Url.Scheme).TrimEnd('/'));

            return this.Content(stringBuilder.ToString(), "text/plain", Encoding.UTF8);
        }

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

        // GET: /Home/Contact/
        public ActionResult Contact(string language = "bg")
        {
            if (language == "en")
                return View("en/Contact");
            else
                return View();
        }

        public ActionResult SendMail(string email, string descr, string text, string language = "bg")
        {
            using (MailMessage message = new MailMessage())
            {
                message.From = new MailAddress(email);
                message.To.Add(new MailAddress("unfragablegaming@gmail.com"));
                message.Subject = descr;
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

                // GET: /Home/Sent/
                if (language == "en")
                    return View("en/Sent");
                else
                    return View("Sent");
            }
        }
    } 
}