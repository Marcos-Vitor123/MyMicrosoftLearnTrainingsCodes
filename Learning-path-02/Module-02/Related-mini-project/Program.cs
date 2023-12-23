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

            int limite = 99;
            int contadorAbaixo0 = 1;
            int contadorAcima10 = 10;
            int numeroSorteado;

            do
            {
                numeroSorteado = sortear.metodoSorteio();
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
                numeroSorteado = sortear.metodoSorteio();
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

        public int metodoSorteio()
        {
            Random sorteio = new();
            executa = sorteio.Next(0, 1000);

            return executa;
        }
    }

}
