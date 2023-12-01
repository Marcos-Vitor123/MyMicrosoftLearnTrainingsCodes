internal class Program
{
    private static void Main(string[] args)
    {
        int first = 7;
        int second = 5;
        //int quotient = first / second; // Sem conversão de dados = resultado: 1
        decimal quotient = (decimal)first / (decimal)second; // Conversão de dados = resultado: 1,4
        Console.WriteLine(quotient);
    }
}