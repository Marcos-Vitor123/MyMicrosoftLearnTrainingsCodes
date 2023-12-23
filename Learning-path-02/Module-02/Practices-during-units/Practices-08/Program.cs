using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando uma instância da classe
        MinhaClasse minhaClasse = new MinhaClasse();

        // Chamando o método sem estado
        Console.WriteLine("Método sem estado: " + minhaClasse.MetodoSemEstado());

        // Chamando o método com estado
        Console.WriteLine("Método com estado: " + minhaClasse.MetodoComEstado());
        Console.WriteLine("Método com estado: " + minhaClasse.MetodoComEstado());
        Console.WriteLine("Método com estado: " + minhaClasse.MetodoComEstado());
    }
}

class MinhaClasse
{
    // Variável de estado
    private int contador = 0;

    // Método sem estado
    public int MetodoSemEstado()
    {
        return 1;
    }

    // Método com estado
    public int MetodoComEstado()
    {
        contador++;
        return contador;
    }
}

