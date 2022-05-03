using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Amazon;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using Microsoft.AspNetCore.Http;
using System.IO;
using MimeKit;

namespace MVCCoreAWSEmailSES.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration config;
        public HomeController(IConfiguration config)
        {
            this.config = config;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SendEmailSMTP()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendEmailSMTP(String asunto,
            String message)
        {
            String user = config["SMTService:username"];
            String password = config["SMTService:pass"];
            String server = config["SMTService:SMTPServer"];

            NetworkCredential credentials = new NetworkCredential(user, password);
            SmtpClient smtpclient = new SmtpClient();
            smtpclient.Host = server;
            smtpclient.Port = 25;
            smtpclient.EnableSsl = true;
            smtpclient.UseDefaultCredentials = true;
            smtpclient.Credentials = credentials;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("carbajeron@gmail.com");
            mail.To.Add("raul.castro@tajamar365.com");
            mail.Subject = asunto;
            mail.Body = message;
            ViewBag.Enviado = "Enviado correctamente";
            smtpclient.Send(mail);

            return View();
        }
        public IActionResult SendEmailAWSSES()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendEmailAWSSES(String subject, 
            String data,String receiver)
        {
            String sender = "carbajeron@gmail.com";
            var client = new AmazonSimpleEmailServiceClient(RegionEndpoint.EUWest2);
            Destination destination = new Destination();
            destination.ToAddresses = new List<string> { receiver };
            Message mensaje = new Message();
            mensaje.Subject = new Content(subject);
            Body body = new Body();
            body.Text = new Content(data);
            body.Html = new Content(data);
            mensaje.Body = body;
            SendEmailRequest request = new SendEmailRequest();
            request.Source = sender;
            request.Destination = destination;
            request.Message = mensaje;

            SendEmailResponse response = await client.SendEmailAsync(request);
            ViewBag.Enviado = "Enviado";

            return View();
        }
        public IActionResult SendEmailFichero()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendEmailFichero(String subject,
            String data, String receiver)
        {
            String sender = "carbajeron@gmail.com";
            var client = new AmazonSimpleEmailServiceClient(RegionEndpoint.EUWest2);

            using(MemoryStream memory = new MemoryStream())
            {
                MimeMessage message = new MimeMessage();
                BodyBuilder body = new BodyBuilder() { TextBody = data};
                message.From.Add(MailboxAddress.Parse(sender));
                message.To.Add(MailboxAddress.Parse(receiver));
                message.Subject = subject;
                String path = @"C:\Users\AlumnoMCSD\Documents\batman.jpg";
                using (FileStream filestream = System.IO.File
                    .Open(path, FileMode.Open))
                {
                    body.Attachments.Add("batmanenviado.jpg", filestream);

                }
                message.Body = body.ToMessageBody();
                message.WriteTo(memory);
                SendRawEmailRequest request = new SendRawEmailRequest();
                request.RawMessage = new RawMessage() { Data = memory};
                await client.SendRawEmailAsync(request);
            }
            ViewBag.Enviado = "Enviado";

            return View();
        }
    }
}
