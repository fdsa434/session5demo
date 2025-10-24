using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using session5demo.dl.Models.AuthModel;
using System.Net;
using System.Net.Mail;

namespace session5demo.pl.Helper
{
    public class Helper
    {
        public static void sendemail(Emails email)
        {
            var stmp = new SmtpClient("smtp.gmail.com", 587);
            stmp.EnableSsl = true;
            stmp.Credentials = new NetworkCredential("mohamedaramadan130@gmail.com", "uaamhpbaufzlufyh");
            stmp.Send("mo40580944@gmail.com", email.To, email.Subject, email.body);
        }
    }
}
