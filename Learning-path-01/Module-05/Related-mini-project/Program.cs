using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int mediaNotas = 4; // Regra de divisão das notas

        // Notas de cada aluno

        int marcos1 = 90, 
            marcos2 = 100, 
            marcos3 = 70, 
            marcos4 = 60;

        int ana1 = 100, 
            ana2 = 85, 
            ana3 = 80, 
            ana4 = 95;

        int joao1 = 95, 
            joao2 = 85, 
            joao3 = 100, 
            joao4 = 100;

        int pedro1 = 100, 
            pedro2 = 95, 
            pedro3 = 80, 
            pedro4 = 70;

        // Soma de todas as notas de cada aluno

        int marcos = marcos1 + marcos2 + marcos3 + marcos4,
            ana = ana1 + ana2 + ana3 + ana4,
            joao = joao1 + joao2 + joao3 + joao4,
            pedro = pedro1 + pedro2 + pedro3 + pedro4;

        // Divisão da soma das notas de cada aluno gerando a média

        decimal mediaNotasMarcos = (decimal)marcos / mediaNotas,
                mediaNotasAna = (decimal)ana / mediaNotas,
                mediaNotasJoao = (decimal)joao / mediaNotas,
                mediaNotasPedro = (decimal)pedro / mediaNotas;

        // Exibindo o resultado na tela

        Console.WriteLine("\nAlunos\t\tNotas\n");
        Console.WriteLine($"Marcos:\t\t{mediaNotasMarcos} \tB");
        Console.WriteLine($"Ana:\t\t{mediaNotasAna} \tA");
        Console.WriteLine($"João:\t\t{mediaNotasJoao} \tA");
        Console.WriteLine($"Pedro\t\t{mediaNotasPedro} \tB\n");
    }
}