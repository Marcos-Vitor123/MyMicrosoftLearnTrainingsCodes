using System;

namespace Practices
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MinhaClasse minhaClasse = new();
            
            Console.WriteLine("Método sem estado: " + minhaClasse.metodoSemEstado());

            Console.WriteLine("Método Com estado: " + minhaClasse.metodoComEstado());
            Console.WriteLine("Método Com estado: " + minhaClasse.metodoComEstado());
            Console.WriteLine("Método Com estado: " + minhaClasse.metodoComEstado());
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
}
