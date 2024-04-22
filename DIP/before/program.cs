using System;

namespace DIP.before
{

    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();
            userManager.RegisterUser("John");
            Console.ReadKey();
        }
    }

}
