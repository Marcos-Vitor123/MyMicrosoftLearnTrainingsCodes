using System;

namespace Practices
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random dice = new Random(); // Random é uma classe 
            int roll = dice.Next(1, 7); // Next é um método e o 1° parâmetro é o N° inicial e o 2° é o N° final de limite
            Console.WriteLine($"\n{roll}\n");

            Random dice2 = new Random();
            int roll2 = dice2.Next(8, 12);
            Console.WriteLine($"{roll2}\n");
        }
    } 
}

