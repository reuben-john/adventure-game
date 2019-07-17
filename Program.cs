using System;

namespace adventure_game
{

    class Game
    {

        static int Scenarios = 3;

        static string[] PartOne = {
            "At the front of the imposing building you see a weathered old man with a cart.\nAs you near, you see the cart is filled with what looks like mostly junk and \nonly a few useful items. All you have on you is piece of a chalk.\nYou offer it to him, and he says he'll trade a flashlight or an umbrella for it.\nTo choose type either A for the flashlight, or B for the umbrella.",
            "The power in the building goes out - luckily you have a flashlight! \nYou move the light around and a large animal is frightened by the \nsudden brightness and takes off. As you move the light again, \nsomething glitters. You reach down and pick up a coin!",
            "The power in the building goes out! As you move down the hallway \nyou hear what sounds like a large animal nearby. You move the \numbrella in a widening arc in front of you to scare it, \nand the animal skitters off.",
            "The lights return and you move into a room at the end of the hall. \nThere is a vending machine.",
            "Luckily " + characterName + " you have that coin you found and you buy yourself a snack.",
            "Too bad you don't have a coin on you," + characterName + ",\nor you would have been able to get a snack.",
            "You begin to climb the stairs to the next floor."
        };
        static string[] PartTwo = {
            "Description of story part two ... and the choice A or B",
            "... part two - what happens if A is chosen...",
            "... part two - what happens if B is chosen...",
            "....more story.... .",
            "... part two, again - what happens if A is chosen...",
            "... part two again - what happens if B is chosen...",
            "You begin to climb the stairs to the next floor...."
        };
        static string[] PartThree = {
            "Description of story part three... and the choice A or B",
            "... part 3 - what happens if A is chosen...",
            "... part 3 - what happens if B is chosen...",
            "....more story.... .",
            "... part 3, again - what happens if A is chosen...",
            "... part 3 again - what happens if B is chosen...",
            "You begin to climb the stairs to the next floor...."
        };
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
            Console.ResetColor();
            Console.WriteLine("Let's Go Adventuring!");
            Console.WriteLine("Welcome to this gnarly adventure game. Which direction will you want to go?");
            NameCharacter();
            Choice();

        }
        public static void NameCharacter()
        {
            Console.Write("What name would you like to us? ");
            characterName = Console.ReadLine();
            Console.WriteLine($"Welcome {characterName}, please enjoy the game!");

        }
        static void Choice()
        {
            string input = "";
            Console.WriteLine($"Make a choice {characterName}; A or B?");
            input = Console.ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                Console.WriteLine("You've chosen path A!");
            }
            else
            {
                Console.WriteLine("You've chosen path B!");
            }
        }
        public static void EndGame()
        {
            //end of game text
            Console.WriteLine("End of story text here.....");

            Console.WriteLine("Press enter to exit.");
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
