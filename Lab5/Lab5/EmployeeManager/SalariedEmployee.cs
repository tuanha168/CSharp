using System;

namespace Lab5
{
  public class SalariedEmployee : Employee
  {
    public double CommissionRate { get; set; }
    public double GrossSales { get; set; }
    public double BasicSalary { get; set; }
    public SalariedEmployee(string ssn, string firstName, string lastName, DateTime birthDate, string phone, string email, double commissionRate, double grossSales, double basicSalary) : base(ssn, firstName, lastName, birthDate, phone, email)
    {
      CommissionRate = commissionRate;
      GrossSales = grossSales;
      BasicSalary = basicSalary;
    }

    public override string ToString()
    {
      return $"{Ssn}\t {FirstName}\t\t {LastName}\t\t {BirthDate.ToString("dd/MM/yyyy")}\t {Phone}\t {Email}\t {CommissionRate}\t\t {GrossSales}\t {BasicSalary}";
    }
  }
}