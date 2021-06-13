using System;

namespace Lab5
{
  public class Employee
  {
    public string Ssn { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    protected Employee() { }

    protected Employee(string ssn, string firstName, string lastName, DateTime birthDate, string phone, string email)
    {
      Ssn = ssn;
      FirstName = firstName;
      LastName = lastName;
      BirthDate = birthDate;
      Phone = phone;
      Email = email;
    }

  }
}