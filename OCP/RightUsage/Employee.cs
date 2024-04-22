public abstract class Employee
{
    public string Name { get; set; }
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public abstract double CalculateWeeklySalary();
}


