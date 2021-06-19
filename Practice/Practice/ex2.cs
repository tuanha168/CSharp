using System.Collections.Generic;
using System;
using System.Collections;

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
      int result = AllIndexesOf(aString, aWord);
      Console.WriteLine($"Word found {result} times in the string");
    }
    public static int AllIndexesOf(string str, string substr)
    {
      if (string.IsNullOrWhiteSpace(str) ||
          string.IsNullOrWhiteSpace(substr))
      {
        throw new ArgumentException("String or substring is not specified.");
      }
      int index = 0;
      int count = 0;
      while ((index = str.IndexOf(substr, index, StringComparison.OrdinalIgnoreCase)) != -1)
      {
        index++;
        count++;
      }
      return count;
    }
  }
}