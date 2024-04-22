

using System;

namespace LSP
{
    public class Bird : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bird Sound ...");

        }
        public void Fly()
        {
            Console.WriteLine("Bird Flying ...");
        }
    }
}
