using System;


// Parent class
public class AnimalBadUsage
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

// Child class
public class Dog : AnimalBadUsage
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }

    public void Fetch()
    {
        Console.WriteLine("Dog fetches a stick.");
    }
}

// Another child class
public class Bird : AnimalBadUsage
{
    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps.");
    }

    public void Fly()
    {
        Console.WriteLine("Bird flies away.");
    }
}
/*
class Program
{
    static void Main(string[] args)
    {
        AnimalBadUsage dog = new Dog();
        AnimalBadUsage bird = new Bird();

        dog.MakeSound();
        ((Dog)dog).Fetch(); // This is problematic
        bird.MakeSound();
        ((Bird)bird).Fly(); // This is problematic
    }
}
*/