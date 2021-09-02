using System;

namespace SOLIDS
{
    class Program
    {
        static void Main(string[] args)
        {
            var userSerive = new UserService();
            var emailService = new EmailService();
            userSerive.Register("hola@gmail.com", "1234", emailService);
        }
    }
}
