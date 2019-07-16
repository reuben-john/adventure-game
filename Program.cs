using System;

namespace adventure_game
{
    class Program
    {
        static void Main(string[] args)
        {

            string characterName;
            Console.WriteLine("Let's Go Adventuring!");
            Console.Read();

            Console.WriteLine("Welcome to this gnarly adventure game. Which direction will you want to go?");
            Console.Write("What name would you like to us? ");
            characterName = Console.ReadLine();
            Console.WriteLine($"Welcome {characterName}, please enjoy the game!");
        }
    }
}
