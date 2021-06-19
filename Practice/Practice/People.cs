using System;

namespace Practice
{
  public class People
  {
    public People(string name, Boolean gender, int age)
    {
      Name = name;
      Gender = gender;
      Age = age;
    }
    protected string Name { get; set; }
    protected Boolean Gender { get; set; }
    protected int Age { get; set; }
    public void display()
    {
      string genderString = Gender ? "Male" : "Female";
      Console.WriteLine($"Person Details: Name = {Name}, Gender = {genderString}, Age = {Age.ToString()}");
      Age += 10;
      Console.WriteLine($"Person Details: Name = {Name}, Gender = {genderString}, Age = {Age.ToString()}");
    }
  }
}