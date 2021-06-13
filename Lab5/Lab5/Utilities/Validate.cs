using System.Text.RegularExpressions;
using System;

namespace Lab5
{
  public class Validate
  {
    public static DateTime BirthDate()
    {
      while (true)
      {
        try
        {
          DateTime day = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
          return day;
        }
        catch (FormatException)
        {
          Console.WriteLine("Please input format correctly (dd/MM/yyyy)");
          Console.Write("Birth Date: ");
        }
      }
    }
    public static string Phone()
    {
      while (true)
      {
        string phone = Console.ReadLine();
        Regex rg = new Regex(@"[0-9]{7,}");
        Match match = rg.Match(phone);
        if (match.Success)
        {
          return phone;
        }
        else
        {
          Console.WriteLine("Please input minimum 7 positive integers");
          Console.Write("Phone: ");
        }
      }
    }

    public static string Email()
    {
      while (true)
      {
        string email = Console.ReadLine();
        string pattern = @"(([^<>()[\]\\.,;:\s@\""]+(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))";
        Regex rg = new Regex(pattern);
        Match match = rg.Match(email);
        if (match.Success)
        {
          return email;
        }
        else
        {
          Console.WriteLine("Please input correct email format");
          Console.Write("Email: ");
        }
      }
    }

    public static double Double()
    {
      while (true)
      {

        try
        {
          return double.Parse(Console.ReadLine());
        }
        catch (FormatException e)
        {
          Console.WriteLine(e.Message);
        }
      }
    }
  }
}