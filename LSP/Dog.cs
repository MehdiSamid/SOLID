using System;

namespace LSP
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog Sound ...");
        }
        public void Fetch()
        {
            Console.WriteLine("Dog fetches a stick.");
        }
    }
}
