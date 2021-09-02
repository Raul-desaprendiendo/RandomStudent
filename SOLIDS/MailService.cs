using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDS
{
    public class MailService
    {
        public void SendEmail(Mail mail)
        {
            Console.WriteLine(mail);
        }

        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
