internal class Program
{
    private static void Main(string[] args)
    {
        string estudante1 = "Maria Clara";

        int notaA = 5;
        int notaB = 4;
        int notaC = 3;
        int notaD = 2;
        int notaE = 1;
        int notaF = 0;

        int horasCreditoPortugues = 4;
        int horasCreditoMatematica = 4;
        int horasCreditoCiencia = 3;
        int horasCreditoGeografia = 3;
        int horasCreditoHistoria = 4;

        Console.WriteLine($"\nEstudante: {estudante1}\n");
        Console.WriteLine("Disciplinas\t\tNotas\tCrédito em Horas\n");
        Console.WriteLine($"Português\t\t{notaA}\t{horasCreditoPortugues}");
        Console.WriteLine($"Matemática\t\t{notaB}\t{horasCreditoMatematica}");
        Console.WriteLine($"Ciência\t\t\t{notaB}\t{horasCreditoCiencia}");
        Console.WriteLine($"Geografia\t\t{notaD}\t{horasCreditoGeografia}");
        Console.WriteLine($"História\t\t{notaC}\t{horasCreditoHistoria}\n");
    }
}