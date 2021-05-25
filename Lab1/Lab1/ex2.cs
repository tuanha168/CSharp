using System;
namespace Lab1
{
    public class ex2
    {
        /// <summary>
        /// <param name="something">a useless string</param>
        /// <returns>A text 'hello worlds'</returns>
        /// </summary>
        /// <remarks>this function can print a text</remarks>
        public static string run()
        {
            string something = "Hello Worlds";
            Console.WriteLine($"{something}");
            return something;
        }
    }
}