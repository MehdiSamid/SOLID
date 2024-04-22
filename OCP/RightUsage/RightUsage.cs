using System;

public class FullTimeEmployee : Employee
{
    public override double CalculateWeeklySalary()
    {
        return HourlyRate * 40; // Assuming full-time employees work 40 hours per week
    }
}

public class PartTimeEmployee : Employee
{
    public override double CalculateWeeklySalary()
    {
        return HourlyRate * HoursWorked;
    }
}


