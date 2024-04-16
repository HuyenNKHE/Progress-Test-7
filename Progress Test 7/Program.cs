using Progress_Test_7;
using System;

class Program
{
    static Club<IPlayer> club = new Club<IPlayer>();

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create new Player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. Search player by Name");
            Console.WriteLine("4. Raise Attack Event");
            Console.WriteLine("5. Raise Defense Event");
            Console.WriteLine("6. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreatePlayer();
                    break;
                case "2":
                    ListAllPlayers();
                    break;
                case "3":
                    SearchPlayerByName();
                    break;
                case "4":
                    club.RaiseAttackEvent();
                    break;
                case "5":
                    club.RaiseDefenseEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static void CreatePlayer()
    {
        Console.WriteLine("Enter Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Attack:");
        int attack = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Defense:");
        int defense = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Stamina:");
        int stamina = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Speed:");
        int speed = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Power:");
        int power = int.Parse(Console.ReadLine());

        Player newPlayer = new Player(name, age, attack, defense, stamina, speed, power);
        club.Add(newPlayer);
    }

    static void ListAllPlayers()
    {
        Console.WriteLine("List of all players:");
        foreach (var player in club)
        {
            Console.WriteLine($"{player.Name}");
        }
    }

    static void SearchPlayerByName()
    {
        Console.WriteLine("Enter player's Name:");
        string name = Console.ReadLine();
        foreach (var player in club)
        {
            if (player.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                player.GetInfo();
                return;
            }
        }
        Console.WriteLine("Player not found.");
    }
}
