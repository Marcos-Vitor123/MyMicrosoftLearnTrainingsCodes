internal class Program
{
    private static void Main(string[] args)
    {
        int value = 1; // Recebe o valor 1

        value = value + 1; // Adiciona + 1 passando p/ 2;
        Console.WriteLine("First increment: " + value);

        value += 1; // Adiciona + 1 passando p/ 3;
        Console.WriteLine("Second increment: " + value);

        value++; // Adiciona + 1 passando p/ 4;
        Console.WriteLine("Third increment: " + value);

        value = value -1; // Subtrai - 1 passando p/ 3;
        Console.WriteLine("First decrement: " + value);

        value -= 1; // Subtrai - 1 passando p/ 2;
        Console.WriteLine("Second decrement: " + value);

        value--; // Subtrai - 1 passando p/ 1;
        Console.WriteLine("Third decrement: " + value);
    }
}