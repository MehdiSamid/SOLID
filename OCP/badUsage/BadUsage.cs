using System;

public class Employees
{
    public string Name { get; set; }
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }
    public bool IsFullTime { get; set; }


    public double CalculateWeeklySalary()
    {
        if (IsFullTime)
        {
            return HourlyRate * 40; // Assuming full-time employees work 40 hours per week
        }
        else
        {
            return HourlyRate * HoursWorked;
        }
    }
}