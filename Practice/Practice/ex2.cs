using System;

namespace Practice
{
  public class ex2
  {
    public static void run()
    {
      Console.WriteLine("Enter a String");
      string aString = Console.ReadLine();
      Console.WriteLine("Enter a word to search");
      string aWord = Console.ReadLine();
      int result = Search.AllIndexesOf(aString, aWord);
      Console.WriteLine($"Word found {result} times in the string");
    }
  }
}