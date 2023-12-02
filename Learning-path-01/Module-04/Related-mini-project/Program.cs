using System;

internal class Program
{
    private static void Main(string[] args)
    {
        decimal real = 4.88m;
        decimal dolar = 2.00m;

        float convert = (float)real * (float)dolar;

        Console.WriteLine($"\n\tConvertendo 2 Dólares em Real\t\n\nValor em Real: {convert} R$\n");
    }
}