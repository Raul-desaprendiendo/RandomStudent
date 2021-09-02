using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDS
{
    public class UserService
    {
        public static void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new Exception("Email is not valid");
            var user = new User(email, password);

            SendEmail(new Mail("agomez@gteam.com", email));
        }

        private static void SendEmail(Mail mail)
        {
            Console.WriteLine(mail);
        }

        public static bool ValidateEmail(string email)
        {
            return email.Contains("@")&& email.Contains(".");
        }
    }
}
