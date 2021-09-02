using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDS
{
    class User : IRegistrable, ISendeable
    {
        public string Email;
        public string Password;
        public User(string e, string p)
        {
            Email = e;
            Password = p;
        }
        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new Exception("Email is not an email");
            var user = new User(email, password);

            SendEmail(new Mail("mysite@nowhere.com", email));
        }

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
