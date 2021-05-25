using System;

namespace Session1
{
    class PrimeNumber
    {
        public static void run()
        {
            while (true)
            {
                int number;
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Đấy còn không phải số");
                    continue;
                }
                if (number == -1) break;
                if (number < 2)
                {
                    Console.WriteLine("Không phải số nguyên tố");
                    continue;
                }
                int count = 0;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0) count++;
                }
                if (count == 0) Console.WriteLine("Số nguyên tố");
                else Console.WriteLine("Không phải số nguyên tố");
            }
        }
    }
}
