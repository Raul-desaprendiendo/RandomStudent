using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDS
{
    public class UserService
    {
        public void Register(string email, string password)
        {
            var mailService = new MailService();

            if (!mailService.ValidateEmail(email))
                throw new Exception("Email is not an email");
            var user = new User(email, password);

            mailService.SendEmail(new Mail("mysite@nowhere.com", email));
        }

       
    }
}
