using System;

namespace Project
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random dados = new();
            int sortear = dados.Next(1, 100);
            Console.WriteLine(sortear);
        }
    } 
}
