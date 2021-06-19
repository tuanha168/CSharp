using System;
using System.Collections.Generic;

namespace Practice
{
  public class Search
  {
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