using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int mediaNotas = 4; // Regra de divisão das notas

        // Notas de cada aluno

        int marcos1 = 90; 
        int marcos2 = 100; 
        int marcos3 = 70; 
        int marcos4 = 60;

        int ana1 = 100; 
        int ana2 = 85; 
        int ana3 = 80; 
        int ana4 = 95;

        int joao1 = 50; 
        int joao2 = 65; 
        int joao3 = 60; 
        int joao4 = 70;

        int pedro1 = 50; 
        int pedro2 = 40; 
        int pedro3 = 20; 
        int pedro4 = 30; 
        // Soma de todas as notas de cada aluno

        int marcos = marcos1 + marcos2 + marcos3 + marcos4;
        int ana = ana1 + ana2 + ana3 + ana4;
        int joao = joao1 + joao2 + joao3 + joao4;
        int pedro = pedro1 + pedro2 + pedro3 + pedro4;

        // Divisão da soma das notas de cada aluno gerando a média

        decimal mediaNotasMarcos = (decimal)marcos / mediaNotas;
        decimal mediaNotasAna = (decimal)ana / mediaNotas;
        decimal mediaNotasJoao = (decimal)joao / mediaNotas;
        decimal mediaNotasPedro = (decimal)pedro / mediaNotas;

        // Inicializando as variáveis letras das notas

        char notaLetraMarcos;
        char notaLetraAna;
        char notaLetraJoao;
        char notaLetraPedro;

        // Decidindo qual a letra referente a nota obtida de Marcos

        if(mediaNotasMarcos >= 90 && mediaNotasMarcos <= 100)
        {
            notaLetraMarcos = 'A';
        } else if (mediaNotasMarcos >= 80 && (float)mediaNotasMarcos <= 89.99) 
        {
            notaLetraMarcos = 'B';
        } else if (mediaNotasMarcos >= 70 && (float)mediaNotasMarcos <= 79.99) 
        {
            notaLetraMarcos = 'C';
        } else if (mediaNotasMarcos >= 60 && (float)mediaNotasMarcos <= 69.99) 
        {
            notaLetraMarcos = 'D';
        } else if (mediaNotasMarcos >= 50 && (float)mediaNotasMarcos <= 59.99) 
        {
            notaLetraMarcos = 'E';
        } else
        {
            notaLetraMarcos = 'F';
        }

        // Decidindo qual a letra referente a nota obtida de Ana

        if(mediaNotasAna >= 90 && mediaNotasAna <= 100)
        {
            notaLetraAna = 'A';
        } else if (mediaNotasAna >= 80 && (float)mediaNotasAna <= 89.99) 
        {
            notaLetraAna = 'B';
        } else if (mediaNotasAna >= 70 && (float)mediaNotasAna <= 79.99) 
        {
            notaLetraAna = 'C';
        } else if (mediaNotasAna >= 60 && (float)mediaNotasAna <= 69.99) 
        {
            notaLetraAna = 'D';
        } else if (mediaNotasAna >= 50 && (float)mediaNotasAna <= 59.99) 
        {
            notaLetraAna = 'E';
        } else
        {
            notaLetraAna = 'F';
        }

        // Decidindo qual a letra referente a nota obtida dJoão

        if(mediaNotasJoao >= 90 && mediaNotasJoao <= 100)
        {
            notaLetraJoao = 'A';
        } else if (mediaNotasJoao >= 80 && (float)mediaNotasJoao <= 89.99) 
        {
            notaLetraJoao = 'B';
        } else if (mediaNotasJoao >= 70 && (float)mediaNotasJoao <= 79.99) 
        {
            notaLetraJoao = 'C';
        } else if (mediaNotasJoao >= 60 && (float)mediaNotasJoao <= 69.99) 
        {
            notaLetraJoao = 'D';
        } else if (mediaNotasJoao >= 50 && (float)mediaNotasJoao <= 59.99) 
        {
            notaLetraJoao = 'E';
        } else
        {
            notaLetraJoao = 'F';
        }

        // Decidindo qual a letra referente a nota obtida de Pedro

        if(mediaNotasPedro >= 90 && mediaNotasPedro <= 100)
        {
            notaLetraPedro = 'A';
        } else if (mediaNotasPedro >= 80 && (float)mediaNotasPedro <= 89.99) 
        {
            notaLetraPedro = 'B';
        } else if (mediaNotasPedro >= 70 && (float)mediaNotasPedro <= 79.99) 
        {
            notaLetraPedro = 'C';
        } else if (mediaNotasPedro >= 60 && (float)mediaNotasPedro <= 69.99) 
        {
            notaLetraPedro = 'D';
        } else if (mediaNotasPedro >= 50 && (float)mediaNotasPedro <= 59.99) 
        {
            notaLetraPedro = 'E';
        } else
        {
            notaLetraPedro = 'F';
        }

        // Exibindo o resultado na tela

        Console.WriteLine("\nAlunos\t\tNotas\n");
        Console.WriteLine($"Marcos:\t\t{mediaNotasMarcos} \t{notaLetraMarcos}");
        Console.WriteLine($"Ana:\t\t{mediaNotasAna} \t{notaLetraAna}");
        Console.WriteLine($"João:\t\t{mediaNotasJoao} \t{notaLetraJoao}");
        Console.WriteLine($"Pedro\t\t{mediaNotasPedro} \t{notaLetraPedro}\n");
    }
}