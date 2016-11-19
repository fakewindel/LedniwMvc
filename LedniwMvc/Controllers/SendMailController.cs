using LedniwMvc.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;

namespace LedniwMvc.Controllers
{
    public class SendMailController : ApiController
    {
        public HttpResponseMessage Post(ContactForm frm)
        {
            if (ModelState.IsValid)
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(WebConfigurationManager.AppSettings["SenderEmailFrom"]);
                msg.To.Add(new MailAddress(WebConfigurationManager.AppSettings["SenderEmailTo"]));
                msg.Bcc.Add( new MailAddress(WebConfigurationManager.AppSettings["SenderEmailBcc"] ));
                msg.Subject = WebConfigurationManager.AppSettings["SenderEmailSubject"];
                msg.IsBodyHtml = true;
                msg.Body = string.Format(
                    @"From: <b>{0}</b><br/> " +
                    @"Email: {1}<br/> " +
                    @"Phone: {2}<br/> " +
                    @"Phone: {3}<br/> ", frm.Fullname, frm.Email, frm.Phone, frm.Message);

                bool isLocal = HttpContext.Current.Request.IsLocal;
                if (isLocal)
                    return Request.CreateErrorResponse(HttpStatusCode.ExpectationFailed, "Will not be able to send email from local machine");

                SmtpClient client = new SmtpClient();
                client.Send(msg);
                return Request.CreateResponse(HttpStatusCode.OK, string.Empty);
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }
    }
}
