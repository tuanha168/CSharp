using System;

namespace Lab2
{
    public class exA
    {
        public static void run()
        {
            while (true)
            {
                int n;
                try
                {
                    n = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    break;
                }
                int[] a;
                a = new int[n];

                Random rd = new Random();
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = rd.Next(0, 100);
                }
                foreach (var item in a)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                DateTime startTime = DateTime.Now;
                int[] bubbleSort = BubbleSort.sort(a);
                TimeSpan time = DateTime.Now - startTime;
                Console.WriteLine($"Bubble Sort ({time.TotalMilliseconds} ms)");
                foreach (var item in bubbleSort)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                startTime = DateTime.Now;
                int[] selectionSort = SelectionSort.sort(a);
                time = DateTime.Now - startTime;
                Console.WriteLine($"Selection Sort ({time.TotalMilliseconds} ms)");
                foreach (var item in selectionSort)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                startTime = DateTime.Now;
                int[] insertionSort = InsertionSort.sort(a);
                time = DateTime.Now - startTime;
                Console.WriteLine($"Insertion Sort ({time.TotalMilliseconds} ms)");
                foreach (var item in insertionSort)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                startTime = DateTime.Now;
                int[] quickSort = QuickSort.sort(a, 0, a.Length - 1);
                time = DateTime.Now - startTime;
                Console.WriteLine($"Quick Sort ({time.TotalMilliseconds} ms)");
                foreach (var item in quickSort)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                startTime = DateTime.Now;
                int[] mergeSort = MergeSort.sort(a, 0, a.Length - 1);
                time = DateTime.Now - startTime;
                Console.WriteLine($"Merge Sort ({time.TotalMilliseconds} ms)");
                foreach (var item in mergeSort)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}