using System;

namespace Lab6.Ex1
{
  public class ex1
  {
    public static void run()
    {
      Book book1 = new Book("Harry Porter", 123456789, "J.K.Rowling", "Kim Dong");
      Console.WriteLine("ISBN Number\tBook Name\tAuthor Name\tPublisher Name");
      Console.WriteLine(book1.GetBookInformation());
    }
  }
}