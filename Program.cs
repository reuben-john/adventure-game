using System;

namespace adventure_game
{

    class Game
    {
        static string characterName = "John Doe";

        public static void StartGame()
        {
            // Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            string title = @"

             __    ____  ____  _ ____     ___   __              
            (  )  (  __)(_  _)(// ___)   / __) /  \             
            / (_/\ ) _)   )(    \___ \  ( (_ \(  O )            
            \____/(____) (__)   (____/   \___/ \__/             
  __   ____  _  _  ____  __ _  ____  _  _  ____  __  __ _   ___ 
 / _\ (    \/ )( \(  __)(  ( \(_  _)/ )( \(  _ \(  )(  ( \ / __)
/    \ ) D (\ \/ / ) _) /    /  )(  ) \/ ( )   / )( /    /( (_ \
\_/\_/(____/ \__/ (____)\_)__) (__) \____/(__\_)(__)\_)__) \___/

";
            Console.Write(title);
            Console.WriteLine("Let's Go Adventuring!");
            Console.WriteLine("Welcome to this gnarly adventure game. Which direction will you want to go?");
            NameCharacter();

        }
        public static void NameCharacter()
        {
            Console.Write("What name would you like to us? ");
            characterName = Console.ReadLine();
            Console.WriteLine($"Welcome {characterName}, please enjoy the game!");

        }
    }

    class Item { }
    class Program
    {
        static void Main(string[] args)
        {

            Game.StartGame();
        }
    }
}
