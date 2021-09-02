using System;

namespace SOLIDS
{
    class Program
    {
        static void Main(string[] args)
        {
            User alberto = new User("alberto@gmail.com", "HolaMundo");
            alberto.Register(alberto.Email,alberto.Password);
            Mail myMail = new Mail("raul@gmail.com","Segundo Programa");
            alberto.SendEmail(myMail);
        }
    }
}
