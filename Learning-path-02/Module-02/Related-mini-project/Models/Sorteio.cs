using System;

namespace Sorteio.Models //Indicar referência externa
{
    internal class Sortear
    {
        public int executar = 0;
        public int iniciar;
        public int finalizar;
        public int MetodoSortear()
        {

            Random sortear = new();

            executar = sortear.Next(iniciar, finalizar);

            return executar;
        }
    }  
}