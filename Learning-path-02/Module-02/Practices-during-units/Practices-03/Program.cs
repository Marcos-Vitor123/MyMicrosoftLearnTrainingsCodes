using System;

namespace Practices
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random dice = new(); // dice é o "Objeto" criado do tipo "Random" criado pelo operador "new"
            int result = dice.Next(); // "result" recebe o endereço de memória armazenado na linha anterior no "Objeto" "dice" e alterar ou adciona valores através do "Método" "Next"
            Console.WriteLine(result);
        }
    }
}
