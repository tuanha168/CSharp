using System;

namespace Practice
{
  public class ex1
  {
    public static void run()
    {
      People people = new People("Marry", "Female", "25");
      Console.WriteLine("Simple Properties Demo");
      people.display();
    }
  }
}