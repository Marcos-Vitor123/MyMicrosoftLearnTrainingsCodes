using System;

namespace Practices
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MinhaClasse minhaClasse = new();
            OutraClasse outraClasse = new();
            OutraClasse teste = new();
            
            Console.WriteLine("\nMétodo sem estado: " + minhaClasse.metodoSemEstado());

            Console.WriteLine("\nMétodo com estado: " + minhaClasse.metodoComEstado());
            Console.WriteLine("Método com estado: " + minhaClasse.metodoComEstado());
            Console.WriteLine("Método com estado: " + minhaClasse.metodoComEstado());

            Console.WriteLine("\nMétodo sem estado two: " + outraClasse.metodoSemEstadoTwo());

            Console.WriteLine("\nMétodo com estado two: " + outraClasse.metodoComEstadoTwo());
            Console.WriteLine("Método com estado two: " + outraClasse.metodoComEstadoTwo());
            Console.WriteLine("Método com estado two: " + outraClasse.metodoComEstadoTwo());

            Console.WriteLine($"\nTeste: {teste.metodoComEstadoTwo()}");
        }
    }

    internal class MinhaClasse
    {
        private int contador = 0;

        public int metodoSemEstado()
        {
            return 1;
        }

        public int metodoComEstado()
        {
            contador++;
            return contador;
        }
    }

    internal class OutraClasse
    {
        public int numeros = 0;

        public int metodoSemEstadoTwo()
        {
            return numeros;
        }

        public int metodoComEstadoTwo()
        {
            Random sorteio = new();
            return numeros = sorteio.Next(1, 101);
        }
    }  
}
