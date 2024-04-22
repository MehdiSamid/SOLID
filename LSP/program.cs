using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Animal bird = new Bird();

            dog.MakeSound();
            bird.MakeSound();
            Console.ReadLine();
        }
    }
}
