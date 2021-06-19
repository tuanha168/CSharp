using System;

namespace Practice
{
  public class People
  {
    public People(string name, string gender, string age)
    {
      Name = name;
      Gender = gender;
      Age = age;
    }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Age { get; set; }
    public void display()
    {
      Console.WriteLine("Person Details: Name = " + Name + ", Gender = " + Gender + ", Age = " + Age);
      Age = (Int32.Parse(Age) + 10).ToString();
      Console.WriteLine("Person Details: Name = " + Name + ", Gender = " + Gender + ", Age = " + Age);
    }
  }
}