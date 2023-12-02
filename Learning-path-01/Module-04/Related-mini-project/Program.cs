using System;

internal class Program
{
    private static void Main(string[] args)
    {
        decimal real = 4.88m;
        decimal dolar = 1.00m;
        float convert = (float)real * (float)dolar;

        Console.WriteLine($"\tConverter Dólar para Real\t\nValor em Real: {convert} R$");
    }
}