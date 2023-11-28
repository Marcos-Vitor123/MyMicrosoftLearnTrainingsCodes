// Desafio: Armazenar e recuperar dados usando valores literais e variáveis em C#

internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Bob";
        int messages = 3;
        decimal temperature = 34.4m;

        Console.Write("Hello, ");
        Console.Write(name);
        Console.Write("! You have ");
        Console.Write(messages);
        Console.Write(" messages in your inbox. The temperature is ");
        Console.Write(temperature);
        Console.Write(" celsius.");
    }
}