using System;

namespace Lab5
{
  public class Menu
  {
    public static void MainMenu()
    {
      Console.WriteLine($"========= Assignment 06 - EmployeeManagement =========");
      Console.WriteLine($"Please select the admin area you require:");
      Console.WriteLine($"1. Import Employee.");
      Console.WriteLine($"2. Display Employees Information.");
      Console.WriteLine($"3. Search Employee.");
      Console.WriteLine($"4. Exit.");
      Console.Write("Enter Menu Option Number: ");
    }

    public static void Import()
    {
      Console.WriteLine($"========= Import Employee =========");
      Console.WriteLine($"1. Salaried Employee.");
      Console.WriteLine($"2. Hourly Employee.");
      Console.WriteLine($"3. Main Menu.");
      Console.Write("Enter Menu Option Number: ");
    }
    public static void Search()
    {
      Console.WriteLine($"========= Search Employee =========");
      Console.WriteLine($"1. By Employee Type.");
      Console.WriteLine($"2. By Employee Name.");
      Console.WriteLine($"3. Main Menu.");
      Console.Write("Enter Menu Option Number: ");
    }

  }
}