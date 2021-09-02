using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDS
{
    public class UserService
    {
        public Boolean Register(string email, string password)
        {
            if (!ValidateEmail(email))
            {  
                throw new Exception("Email is not an email");
            }
            else
            {   
                return true;
            }
            return false;
        }


        private bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
