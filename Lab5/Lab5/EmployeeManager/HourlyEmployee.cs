using System;

namespace Lab5
{
  public class HourlyEmployee : Employee
  {
    public double Wage { get; set; }
    public double WorkingHour { get; set; }
    public HourlyEmployee(string ssn, string firstName, string lastName, DateTime birthDate, string phone, string email, double wage, double workingHour) : base(ssn, firstName, lastName, birthDate, phone, email)
    {
      Wage = wage;
      WorkingHour = workingHour;
    }

    public override string ToString()
    {
      return $"{Ssn}\t {FirstName}\t\t {LastName}\t\t {BirthDate.ToString("dd/MM/yyyy")}\t {Phone}\t {Email}\t {Wage}\t {WorkingHour}";
    }
  }
}