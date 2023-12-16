using System;

namespace Practices
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random dice = new Random();
            dice.Next(1 ,7);

            Console.WriteLine($"First roll: {dice}");
        }
    }
}
