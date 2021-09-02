using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDS
{
    public class UserService
    {
        public bool Register(string email, string password)
        {
            if (!ValidateEmail(email))
            {
                throw new Exception("Email is not an email");
            }
            else
                return true;
        }

        

        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
