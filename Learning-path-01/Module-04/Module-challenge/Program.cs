using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int fahrenheit = 94;
        decimal celsius = (fahrenheit - 32m) * (5m / 9m);
        Console.WriteLine("The temperature is " + celsius + " Celsius.");

    }
}