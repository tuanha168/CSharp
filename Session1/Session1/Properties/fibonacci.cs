using System;
namespace CSharp
{
    public class Fibonacci
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int n;
                try
                {
                    Console.Write($"Nhập số: ");
                    n = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Đấy còn không phải số");
                    continue;
                }
                if (n == -1) break;
                if (n == 0) continue;
                int prev = 0;
                int curr = 1;
                for (var i = 1; i < n + 1; i++)
                {
                    if (i == 1)
                    {
                        Console.Write($"{prev}");
                        continue;
                    }
                    if (i == 2)
                    {
                        Console.Write($", {curr}");
                        continue;
                    }
                    Console.Write($", {prev + curr}");
                    int temp = curr;
                    curr += prev;
                    prev = temp;
                }
                Console.WriteLine();


            }
        }
    }
}