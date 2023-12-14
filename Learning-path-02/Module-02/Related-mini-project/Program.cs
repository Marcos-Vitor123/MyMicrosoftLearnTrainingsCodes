using System;

namespace Project
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random dados = new Random();
            int sortearOne = dados.Next(0, 100);
            int sortearTwo = dados.Next(0, 100);
            int sortearThree = dados.Next(0, 100);
            int sortearFour = dados.Next(0, 100);
            int sortearFive = dados.Next(0, 100);
            
            Console.WriteLine($"\nNúmeros sorteados: {sortearOne}, {sortearTwo}, {sortearThree}, {sortearFour}, {sortearFive}\n");
        }
    } 
}
