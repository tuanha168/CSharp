namespace Lab6.Ex1
{
  public class Book
  {
    protected string name;
    protected int isbn;
    protected string author_name;
    protected string publisher_name;

    public Book(string name, int isbn, string author_name, string publisher_name)
    {
      this.name = name;
      this.isbn = isbn;
      this.author_name = author_name;
      this.publisher_name = publisher_name;
    }

    public string GetBookInformation()
    {
      return $"{this.isbn}\t{this.name}\t{this.author_name}\t{this.publisher_name}";
    }
  }
}