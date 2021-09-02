using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDS
{
    public class UserService
    {
        public void Register(string email, string password, EmailService emailService)
        {
            if (!emailService.ValidateEmail(email))
                throw new Exception("Email is not an email");
            var user = new User(email, password);
            emailService.SendEmail(new Mail("hola@gmail.com", "cuerpo"));
        }

    }
}
