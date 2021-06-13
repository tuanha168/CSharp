using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      List<Employee> emp = new List<Employee>();
      while (true)
      {
        int chose;
        Menu.MainMenu();
        try
        {
          chose = Int32.Parse(Console.ReadLine());
          switch (chose)
          {
            case 1:
              Utils.Import(ref emp);
              break;
            case 2:
              Utils.Display(emp);
              break;
            case 3:
              Utils.Search(ref emp);
              break;
            case 4:
              Environment.Exit(0);
              break;
            default:
              Console.WriteLine("Please input valid option");
              Console.ReadLine();
              break;
          }
        }

        catch (FormatException e)
        {
          Console.WriteLine(e.Message);
          Console.WriteLine("Press any key to continue");
          Console.ReadLine();
          continue;
        }
      }
    }
  }
}
