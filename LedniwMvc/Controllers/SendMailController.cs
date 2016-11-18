using LedniwMvc.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Configuration;
using System.Web.Http;

namespace LedniwMvc.Controllers
{
    public class SendMailController : ApiController
    {
        // POST: api/SendMail
        public HttpResponseMessage Post([FromBody] ContactForm info)
        {
            if (ModelState.IsValid)
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(WebConfigurationManager.AppSettings["SenderEmailFrom"]);
                message.To.Add(new MailAddress(WebConfigurationManager.AppSettings["SenderEmailTo"]));
                message.Bcc.Add( new MailAddress(WebConfigurationManager.AppSettings["SenderEmailBcc"] ));
                message.Subject = WebConfigurationManager.AppSettings["SenderEmailSubject"];
                message.Body = string.Format(
                    @"From: <b>{0}</b><br/> " +
                    @"Email: {1}<br/> " +
                    @"Phone: {2}<br/> " +
                    @"Phone: {3}<br/> ", info.FullName, info.Email, info.Phone, info.Message);

                SmtpClient client = new SmtpClient();
                client.Send(message);

                //SmtpClient client = new SmtpClient("email.secureserver.net", 25);
                //client.Credentials = new System.Net.NetworkCredential("support@drivenableotservices.com.au", "Driven11");
                //client.UseDefaultCredentials = true;
                //client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //client.EnableSsl = true;
                //client.Send(message);

                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }
    }
}
