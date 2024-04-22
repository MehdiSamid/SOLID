using System;

namespace DIP.after
{

    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
            UserManager userManager = new UserManager(logger);
            userManager.RegisterUser("John");
            Console.ReadKey();  
        }
    }

}
