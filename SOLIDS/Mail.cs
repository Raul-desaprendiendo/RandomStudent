using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDS
{
    class Mail
    {
        private string email;
        private string Subject;
        private string sender;

        public Mail(string sender, string email)
        {
            this.sender = sender;
            this.email = email;
        }

        public void SendEmail()
        {
            Console.WriteLine(this.sender + " - " + this.email);
        }
    }
}
