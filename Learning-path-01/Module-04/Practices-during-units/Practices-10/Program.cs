using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int value = 1;
        value++; // Adiciona + 1 passando p/ 2

        Console.WriteLine("First: " + value); // Exibe resultado linha 2
        Console.WriteLine($"Second: {value++}"); // Incremento posterior: Exibe o valor 2 e adiciona + 1 para exibir na próxima linha
        Console.WriteLine("Third: " + value); // Recebe o valor Atualizado da linha anterior p/ 3
        Console.WriteLine("Fourth: " + (++value)); // Incremento antes: Exibe o valor adicionado de + 1 com antecedência
    }
}