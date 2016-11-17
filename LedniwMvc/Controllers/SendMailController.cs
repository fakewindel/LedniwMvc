using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Web.Http;

namespace LedniwMvc.Controllers
{
    public class SendMailController : ApiController
    {
        // GET: api/SendMail
        public IEnumerable<string> Get()
        {
            using (var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(@"serjiro@gmail.com", @"p@ssw@rd1"),
                UseDefaultCredentials = false,
                EnableSsl = true
            })
            {
                client.Send("serjiro@gmail.com", "windel@gmail.com", "subject", "asdfasdfasdf");
            }

            //SmtpClient smtpClient = new SmtpClient();
            //smtpClient.UseDefaultCredentials = true;
            //MailMessage mailMessage = new MailMessage();

            //mailMessage.To.Add(new MailAddress("sender@mail.com"));
            //mailMessage.Subject = "mailSubject";
            //mailMessage.Body = "mailBody";

            //smtpClient.Send(mailMessage);

            return new string[] { "value1", "value2" };
        }

        // GET: api/SendMail/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SendMail
        public void Post([FromBody]string value)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("support@drivenableotservices.com.au");
            message.To.Add(new MailAddress("windel@gmail.com"));
            message.Subject = "your subject";
            message.Body = "content of your email";

            SmtpClient client = new SmtpClient("email.secureserver.net", 25);
            client.Credentials = new System.Net.NetworkCredential("support@drivenableotservices.com.au", "Driven11");
            client.UseDefaultCredentials = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;

            client.Send(message);
        }

        // PUT: api/SendMail/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SendMail/5
        public void Delete(int id)
        {
        }
    }
}
