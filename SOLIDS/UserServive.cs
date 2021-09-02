using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDS
{
    public class UserService
    {
        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new Exception("Email is not an email");
            var user = new User(email, password);

            //Aqui estaba  SendEmail(new Mail("mysite@nowhere.com", email));
        }

        private void SendEmail(Mail mail)
        {
            SendEmail(new Mail("mysite@nowhere.com", email));//Enviar el email esta mejor en enviar email.
            Console.WriteLine(mail);
        }

        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
