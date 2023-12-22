using System;

namespace Practices
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int initial = 1;
            int end = 100;
            int sorted;

            sorted = Math.Max(initial, end);

            Console.WriteLine(sorted);
        }
    }
}
