using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5
{
  public class Utils
  {
    public static void Import(ref List<Employee> emp)
    {
      Menu.Import();
      int import = Int32.Parse(Console.ReadLine());
      if (import < 1 || import > 2) return;
      Console.Write("SSN: ");
      string ssn = Console.ReadLine();
      Console.Write("First Name: ");
      string firstName = Console.ReadLine();
      Console.Write("Last Name: ");
      string lastName = Console.ReadLine();
      Console.Write("Birth Date (dd/MM/yyyy): ");
      DateTime birthDate = Validate.BirthDate();
      Console.Write("Phone: ");
      string phone = Validate.Phone();
      Console.Write("Email: ");
      string email = Validate.Email();
      if (import == 1)
      {
        Console.Write("Commision Rate: ");
        double commissionRate = Validate.Double();
        Console.Write("Gross Sales: ");
        double grossSales = Validate.Double();
        Console.Write("Basic Salary: ");
        double basicSalary = Validate.Double();
        SalariedEmployee newEmployee = new SalariedEmployee(ssn, firstName, lastName, birthDate, phone, email, commissionRate, grossSales, basicSalary);
        emp.Add(newEmployee);
      }
      else
      {
        Console.Write("Wage: ");
        double wage = Validate.Double();
        Console.Write("Working Hour: ");
        double workingHour = Validate.Double();
        HourlyEmployee newEmployee = new HourlyEmployee(ssn, firstName, lastName, birthDate, phone, email
        , wage, workingHour);
        emp.Add(newEmployee);
      }
    }
    public static void Display(List<Employee> emp)
    {
      Console.WriteLine("Ssn\t FirstName\t LastName\t BirthDate\t Phone\t\t Email\t\t\t CommissionRate\t GrossSales\t BasicSalary");
      foreach (var item in emp.OfType<SalariedEmployee>().ToList())
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("Ssn\t FirstName\t LastName\t BirthDate\t Phone\t\t Email\t\t\t Wage\t WorkingHour");
      foreach (var item in emp.OfType<HourlyEmployee>().ToList())
      {
        Console.WriteLine(item);
      }
      Console.ReadLine();
    }
    public static void Search(ref List<Employee> emp)
    {
      Menu.Search();
      int search = Int32.Parse(Console.ReadLine());
      if (search < 1 || search > 2) return;
      if (search == 1)
      {
        string type;
        Console.Write("Enter Employee Type: ");
        type = Console.ReadLine();
        if (type.ToLower().Contains("hourly"))
        {
          Console.WriteLine("Ssn\t FirstName\t LastName\t BirthDate\t Phone\t\t Email\t\t\t Wage\t WorkingHour");
          foreach (var item in emp.OfType<HourlyEmployee>().ToList())
          {
            Console.WriteLine(item);
          }
          Console.ReadLine();
          return;
        }
        if (type.ToLower().Contains("salaried"))
        {
          Console.WriteLine("Ssn\t FirstName\t LastName\t BirthDate\t Phone\t\t Email\t\t\t CommissionRate\t GrossSales\t BasicSalary");
          foreach (var item in emp.OfType<SalariedEmployee>().ToList())
          {
            Console.WriteLine(item);
          }
          Console.ReadLine();
          return;
        }
      }
      else
      {
        string name;
        Console.Write("Enter Employee Name: ");
        name = Console.ReadLine();
        foreach (var item in emp)
        {
          if (item.FirstName.Contains(name) || item.LastName.Contains(name))
          {
            Console.WriteLine(item.ToString());
          }
        }
        Console.ReadLine();
        return;
      }
    }
  }
}