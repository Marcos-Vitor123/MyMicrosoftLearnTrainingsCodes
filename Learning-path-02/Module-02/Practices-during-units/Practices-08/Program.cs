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
            
            Console.WriteLine("\nMétodo sem estado: " + minhaClasse.MetodoSemEstado());

            Console.WriteLine("\nMétodo com estado: " + minhaClasse.MetodoComEstado());
            Console.WriteLine("Método com estado: " + minhaClasse.MetodoComEstado());
            Console.WriteLine("Método com estado: " + minhaClasse.MetodoComEstado());

            Console.WriteLine("\nMétodo sem estado two: " + outraClasse.MetodoSemEstadoTwo());

            Console.WriteLine("\nMétodo com estado two: " + outraClasse.MetodoComEstadoTwo());
            Console.WriteLine("Método com estado two: " + outraClasse.MetodoComEstadoTwo());
            Console.WriteLine("Método com estado two: " + outraClasse.MetodoComEstadoTwo());

            Console.WriteLine($"\nTeste: {teste.MetodoComEstadoTwo()}");
        }
    }

    internal class MinhaClasse
    {
        private int contador = 0;

        public int MetodoSemEstado()
        {
            return 1;
        }

        public int MetodoComEstado()
        {
            contador++;
            return contador;
        }
    }

    internal class OutraClasse
    {
        public int numeros = 0;

        public int MetodoSemEstadoTwo()
        {
            return numeros;
        }

        public int MetodoComEstadoTwo()
        {
            Random sorteio = new();
            return numeros = sorteio.Next(1, 101);
        }
    }  
}
