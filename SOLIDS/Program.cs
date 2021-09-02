using System;

namespace SOLIDS
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "pablo@blablalbla.com";
            string pass = "1234";

            UserService userService = new UserService();
            User pablo = new User(email, pass);

            if (userService.Register(pablo.Email, pablo.Password))
                pablo.SendEmail(new Mail("aaa@email.com", pablo.Email));

        }
    }
}
