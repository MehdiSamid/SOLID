using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee fullTimeEmployee = new FullTimeEmployee { Name = "Alice", HourlyRate = 20 };
            Employee partTimeEmployee = new PartTimeEmployee { Name = "Bob", HourlyRate = 15, HoursWorked = 20 };

            Console.WriteLine($"Weekly salary of {fullTimeEmployee.Name}: ${fullTimeEmployee.CalculateWeeklySalary()}");
            Console.WriteLine($"Weekly salary of {partTimeEmployee.Name}: ${partTimeEmployee.CalculateWeeklySalary()}");
            Console.ReadKey();
        }
    }
}
