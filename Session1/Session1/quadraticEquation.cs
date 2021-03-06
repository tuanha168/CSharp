using System;
namespace Session1
{
    public class Quadratic
    {
        public static void run()
        {
            Console.WriteLine($"Phương trình bậc 2:");
            float a = 0;
            float b = 0;
            float c = 0;
            try
            {
                a = float.Parse(Console.ReadLine());
                b = float.Parse(Console.ReadLine());
                c = float.Parse(Console.ReadLine());
                Console.Write($"{a}x^2 ");
                Console.Write((b >= 0 ? "+" : "") + $" {b}x ");
                Console.WriteLine((c >= 0 ? "+" : "") + $" {c} = 0");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Hãy nhập số thực");
            }
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Vô nghiệm");
                }
                else
                {
                    Console.WriteLine($"1 nghiệm:\nx = {-c / b}");
                }
                return;
            }
            float delta = b * b - 4 * a * c;
            float x1;
            float x2;
            if (delta > 0)
            {
                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine($"2 nghiệm:\nx1 = {x1}\nx2 = {x2}");
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine($"Nghiệm kép: x1 = x2 = {x1}");
            }
            else
            {
                Console.WriteLine("Vô nghiệm!");
            }
        }
    }
}