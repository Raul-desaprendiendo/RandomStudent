using System;

namespace SOLIDS
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userFunc = new UserService();
            Boolean interruptor = false;
            String email, pass;
            email = "nacho@gteam.es";
            pass = "1234";

            interruptor = userFunc.Register(email, pass);

            if (interruptor)
            {
                Mail mail = new Mail("nacho", "prueba");
                mail.SendEmail();
            }
        }
    }
}
