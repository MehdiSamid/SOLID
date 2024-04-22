using System;

namespace SRP
{
    public class program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Validator validator = new Validator();

            int userInput = 7;

            if (validator.ValidateInput(userInput))
            {
                int result = calculator.Square(userInput);
                Console.WriteLine($"Square of {userInput} is {result}");
                Console.ReadKey(); 
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                Console.ReadKey();
            }
        }
    }
}
