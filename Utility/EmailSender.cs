using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky2.Utility
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;

        public MailJetSettings _mailJetSettings { get; set; }

        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(email, subject, htmlMessage);
        }

        public async Task Execute(string email, string subject, string body)
        {
            try
            {

            _mailJetSettings = _configuration.GetSection("MailJet").Get<MailJetSettings>();

            MailjetClient client = new MailjetClient(_mailJetSettings.ApiKey, _mailJetSettings.SecretKey);
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
             .Property(Send.Messages, new JArray {
     new JObject {
      {
       "From",
       new JObject {
        {"Email", "ygnftbghri@gmail.com"},
        {"Name", "yegane"}
       }
      }, {
       "To",
       new JArray {
        new JObject {
         {
          "Email",
          email
         }, {
          "Name",
          "DotNet"
         }
        }
       }
      }, {
       "Subject",
       subject
      }, {
       "HTMLPart",
       body
      }
     }
             });
           var result= await client.PostAsync(request);
            var resultContent = result.Content;
            }
                catch(Exception ex)
            {

            }

        }
    }
}
