using System;

namespace Challenge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int firstValue = 500;
            int secondValue = 600;
            int largerValue;

            largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine(largerValue);
        }
    }
}
