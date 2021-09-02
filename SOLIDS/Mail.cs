using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDS
{
    public class Mail
    {
        public string Email { get; set; }
        public string Sender { get; set; }

        public Mail(string v, string e)
        {
            Sender = v;
            Email = e;
        }
    }
}
