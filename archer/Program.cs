using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace archer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Archer´s game!");
        Console.WriteLine("Choose name for the archer:");
        string name = Console.ReadLine();
        string archerName = LoadStringFromConsole(name ?? string.Empty);

        Random rnd = new Random();
        int randomNumOfArrows = rnd.Next(1, 10);

        Archer archer = new Archer(archerName, randomNumOfArrows);
        archer.ViewStatus();

        while (true)
        {
            Console.WriteLine("Choose from following options 1 or 2 or 3.");
            Console.WriteLine("1. Shoot arrow.");
            Console.WriteLine("2. Add arrow.");
            Console.WriteLine("3. Quit the game.");
            Console.WriteLine("Please enter your choice:");

            string input = Console.ReadLine();
            int option = LoadIntegerFromConsole(input);
            Console.WriteLine($"You have chosen option {option}.");

            switch (option)
            {
                case 1:
                    archer.ShootArrow();
                    archer.ViewStatus();
                    break;
                case 2:
                    Console.WriteLine("How many arrows would you like to add:");
                    input = Console.ReadLine();
                    int numberOfArrows = LoadIntegerFromConsole(input ?? "0");
                    archer.AddArrows(numberOfArrows);
                    break;
                case 3:
                    Console.WriteLine("You have finished the game!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong option. Please try again and choose valid option from menu.");
                    break;
            }
        }
    }
    public static int LoadIntegerFromConsole(string challenge)
    {
        int result;
        while (!int.TryParse(challenge, out result) || result < 0)
        {
            Console.WriteLine("Please enter a positive integer number greater than 0");
            challenge = Console.ReadLine();
        }
        return result;
    }
    public static string LoadStringFromConsole(string name)
    {
        while (string.IsNullOrWhiteSpace(name) || int.TryParse(name, out _))
        {
            Console.WriteLine("Please enter a valid name for the archer(not a number):");
            name = Console.ReadLine();
        }

        name = name.Trim();
        name = char.ToUpper(name[0]) + name.Substring(1).ToLower();

        return name;
    }
}

