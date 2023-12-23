using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Project
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Sorteio sortear = new();
           
            Console.WriteLine("\nO número máximo de índices é até 99");

            Console.WriteLine($"\nDigite o número máximo de índices: ");
            int limite = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"\nDigite o número limite inicial do sorteio: ");
            sortear.iniciar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nDigite o número limite final do sorteio: ");
            sortear.finalizar = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\n");

            int contadorAbaixo0 = 1;
            int contadorAcima10 = 10;
            int numeroSorteado;

            do
            {
                numeroSorteado = sortear.MetodoSorteio();
                if(numeroSorteado < 10)
                {
                    Console.WriteLine($"0{contadorAbaixo0}° Número sorteado: 00{numeroSorteado}");
                } else if (numeroSorteado < 100)
                {
                    Console.WriteLine($"0{contadorAbaixo0}° Número sorteado: 0{numeroSorteado}");
                } else
                {
                    Console.WriteLine($"0{contadorAbaixo0}° Número sorteado: {numeroSorteado}");
                }
                contadorAbaixo0++;
            }
            while(contadorAbaixo0 <= 9);

            do
            {
                numeroSorteado = sortear.MetodoSorteio();
                if(numeroSorteado < 10)
                {
                    Console.WriteLine($"{contadorAcima10}° Número sorteado: 00{numeroSorteado}");
                } else if (numeroSorteado < 100)
                {
                    Console.WriteLine($"{contadorAcima10}° Número sorteado: 0{numeroSorteado}");
                } else
                {
                    Console.WriteLine($"{contadorAcima10}° Número sorteado: {numeroSorteado}");
                }
                contadorAcima10++;
            }
            while(contadorAcima10 <= limite);
        }
    }
    internal class Sorteio
    {       
        public int executa = 0;
        public int iniciar;
        public int finalizar;
        public int MetodoSorteio()
        {

            Random sorteio = new();

            executa = sorteio.Next(iniciar, finalizar);

            return executa;
        }
    }
}