using System;
namespace Session1
{
    public class Factorial
    {
        public static void run()
        {
            while (true)
            {
                int mul = 1;
                int n = 0;
                try
                {
                    n = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Đấy còn không phải số");
                    continue;
                }
                if (n == -1) break;
                if (n > 1)
                {
                    for (var i = 1; i < n + 1; i++)
                    {
                        mul *= i;
                        if (i != n) Console.Write($"{i} * ");
                        else Console.Write($"{n} = ");
                    }
                }
                Console.WriteLine($"{mul}");
            }

        }
    }
}