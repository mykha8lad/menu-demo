using System;

namespace MenuDemo
{
    class Program
    {
        delegate void MenuItem();

        static void Main(string[] args)
        {
            var menu = new MenuItem[]
            {
                NewGame,
                LoadGame,
                Rules,
                AboutAuthor,
                Exit
            };

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - New game");
                Console.WriteLine("2 - Load game");
                Console.WriteLine("3 - Rules");
                Console.WriteLine("4 - About author");
                Console.WriteLine("5 - Exit");

                Console.Write("Enter a number to select a menu item: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= menu.Length)
                {
                    menu[choice - 1]();
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }

                Console.WriteLine();
            }
        }

        static void NewGame()
        {
            Console.WriteLine("Starting new game...");
        }

        static void LoadGame()
        {
            Console.WriteLine("Loading game...");
        }

        static void Rules()
        {
            Console.WriteLine("These are the game rules...");
        }

        static void AboutAuthor()
        {
            Console.WriteLine("This game was created by Vlad Mykhailichenko.");
        }

        static void Exit()
        {
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        }
    }
}
