internal class Program
{
    private static void Main(string[] args)
    {
        string estudante1 = "Maria Clara";

        string disciplina1Nome = "Português"; 
        string disciplina2Nome = "Matemática";
        string disciplina3Nome = "Ciência";
        string disciplina4Nome = "Geografia";
        string disciplina5Nome = "História";

        int horasCreditoPortugues = 4;
        int horasCreditoMatematica = 4;
        int horasCreditoCiencia = 3;
        int horasCreditoGeografia = 3;
        int horasCreditoHistoria = 4;

        int notaA = 5;
        int notaB = 4;
        int notaC = 3;
        int notaD = 2;
        int notaE = 1;
        int notaF = 0;

        int disciplina1Pontos = notaA;
        int disciplina2Pontos = notaC;
        int disciplina3Pontos = notaE;
        int disciplina4Pontos = notaB;
        int disciplina5Pontos = notaD;

        int totalHorasCreditos = 0;

        totalHorasCreditos += horasCreditoPortugues;
        totalHorasCreditos += horasCreditoMatematica;
        totalHorasCreditos += horasCreditoCiencia;
        totalHorasCreditos += horasCreditoGeografia;
        totalHorasCreditos += horasCreditoHistoria;

        int totalPontosNotas = 0;

        totalPontosNotas += horasCreditoPortugues * disciplina1Pontos;
        totalPontosNotas += horasCreditoMatematica * disciplina2Pontos;
        totalPontosNotas += horasCreditoCiencia * disciplina3Pontos;
        totalPontosNotas += horasCreditoGeografia * disciplina4Pontos;
        totalPontosNotas += horasCreditoHistoria * disciplina5Pontos;            

        decimal GPA = (decimal)totalHorasCreditos / totalPontosNotas;

        Console.WriteLine($"\nEstudante: {estudante1}\n");
        Console.WriteLine("Disciplinas\t\tNotas\tCrédito em Horas\n");
        Console.WriteLine($"{disciplina1Nome}\t\t{disciplina1Pontos}\t{horasCreditoPortugues}");
        Console.WriteLine($"{disciplina2Nome}\t\t{disciplina2Pontos}\t{horasCreditoMatematica}");
        Console.WriteLine($"{disciplina3Nome}\t\t\t{disciplina3Pontos}\t{horasCreditoCiencia}");
        Console.WriteLine($"{disciplina4Nome}\t\t{disciplina4Pontos}\t{horasCreditoGeografia}");
        Console.WriteLine($"{disciplina5Nome}\t\t{disciplina5Pontos}\t{horasCreditoHistoria}\n");

        Console.WriteLine("Nota Final GPA: " + GPA + "\n");
    }
}