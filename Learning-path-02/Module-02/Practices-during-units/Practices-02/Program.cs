using System;

namespace Practices
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random dice = new(); // Nova forma de criar instância sem repetir método
            int roll = dice.Next(1, 10);
            Console.WriteLine($"\n{roll}\n");
        }
    }
}