internal class Program
{
    private static void Main(string[] args)
    {
        int mediaNotas = 4;

        int marcos1 = 90, marcos2 = 100, marcos3 = 70, marcos4 = 60;
        int ana1 = 100, ana2 = 85, ana3 = 80, ana4 = 95;
        int joao1 = 95, joao2 = 85, joao3 = 100, joao4 = 100;
        int pedro1 = 100, pedro2 = 95, pedro3 = 80, pedro4 = 70;

        int marcos = marcos1 + marcos2 + marcos3 + marcos4;
        int ana = ana1 + ana2 + ana3 + ana4;
        int joao = joao1 + joao2 + joao3 + joao4;
        int pedro = pedro1 + pedro2 + pedro3 + pedro4;

        decimal mediaNotasMarcos = (decimal)marcos / mediaNotas;
        decimal mediaNotasAna = (decimal)ana / mediaNotas;
        decimal mediaNotasJoao = (decimal)joao / mediaNotas;
        decimal mediaNotasPedro = (decimal)pedro / mediaNotas;

        Console.WriteLine("\nAlunos\t\tNotas\n");
        Console.WriteLine($"Marcos:\t\t{mediaNotasMarcos}");
        Console.WriteLine($"Ana:\t\t{mediaNotasAna}");
        Console.WriteLine($"João:\t\t{mediaNotasJoao}");
        Console.WriteLine($"Pedro\t\t{mediaNotasPedro}\n");
    }
}