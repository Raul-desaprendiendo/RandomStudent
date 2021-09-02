using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDS
{
    public class EmailService
    {

        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public void SendEmail(Mail mail)
        {
            Console.WriteLine(String.Format("Email para {0}: {1}", mail.Sender, mail.Email));
        }
    }
}
