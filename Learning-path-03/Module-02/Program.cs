using System;

public class Program
{
    public static void Main(string[] args)
    {
        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if (total > 14)
        {
            Console.WriteLine("You Win!");
        }

        if (total < 15)
        {
            Console.WriteLine("Sorry, you lose.");
        }

        string message = "The quick brown fox jumps over the lazy dog.";
        bool result = message.Contains("dog");

        Console.WriteLine(result);

        if (message.Contains("fox"))
        {
            Console.WriteLine("What does the fox say?");
        }
    }
}