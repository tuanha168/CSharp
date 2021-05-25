using System;
namespace Lab1
{
    public class ex1
    {
        public static void run()
        {
            try
            {
                Console.Write($"Student ID: ");
                int studentID = int.Parse(Console.ReadLine());
                Console.Write($"Student Name: ");
                string studentName = Console.ReadLine();
                Console.Write($"Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write($"Gender: ");
                char gender = char.Parse(Console.ReadLine());
                Console.Write($"Percent: ");
                double percent = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}