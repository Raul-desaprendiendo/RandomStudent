using System;

namespace SOLIDS
{
    class Program
    {
        static void Main(string[] args)
        {
            User angel = new User("agomez@gteam.es","password");
            UserService.Register(angel.Email, angel.Password);

        }
    }
}
