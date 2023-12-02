using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int value1 = 3 + 4 * 5;
        int value2 = (3 + 4) * 5; // Priorizando a 1° a soma entre parênteses
        Console.WriteLine(value1);
        Console.WriteLine(value2);
    }
}
