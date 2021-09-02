using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDS
{
    public class Mail
    {
        string email;
        string Subject;
        private string sender;

        public Mail(string v, string email)
        {
            this.sender = v;
            this.email = email;
        }
    }
}
