namespace Metacube.Net.ZooManagement.Console;

using Metacube.Net.ZooManagement;
using System;
class Program
{
    public static void addAnimal(Zoo zoo)
    {
        int animalType = animalTypeMenu();
        switch (animalType)
        {
            case 1: addMammal(zoo); break;
            case 2: addReptile(zoo); break;
            case 3: addBird(zoo); break;
            default: throw new Exception("Invalid Option!");
        }
    }
    public static void addMammal(Zoo zoo)
    {
        int animalNameOpt = mammalNameMenu();

        switch(animalNameOpt) {
            case 1: 
                Console.WriteLine("Fill the following details: ");
                Console.Write("Name: ");
                string? name = Console.ReadLine();
                Console.Write("Age: ");
                string? a = Console.ReadLine();
                if(a == null) throw new Exception("Invalid Input!");
                int age = Int32.Parse(a);
                Console.Write("Weight: ");
                string? w = Console.ReadLine();
                if(w == null) throw new Exception("Invalid Input!");
                float weight = float.Parse(w);
                Console.Write("Health: ");
                string? health = Console.ReadLine();
                Console.Write("Fur Color: ");
                string? furColor = Console.ReadLine();
                if(name == null || health == null || furColor == null) throw new Exception("Invalid Input!");

                Lion lion = new Lion(name, age, weight, health, furColor);
                Tuple<string, string>? zoneCage = zoo.addMammal(lion);
                if(zoneCage == null) {
                    Console.WriteLine("All zones occupied! creating new zone with occupancy 10....");
                    Zone<Mammal> newZone = new Zone<Mammal>(10, typeof(Mammal));
                    zoo.addMammalZone(newZone);
                    zoneCage = zoo.addMammal(lion);
                }
                Console.WriteLine($"{name} successfully added to zone:{zoneCage!.Item1} cage:{zoneCage!.Item2}");
                break;
            case 2: return;
            default: throw new Exception("Invalid Option!");
        }

    }
    public static void addReptile(Zoo zoo)
    {

        int animalNameOpt = reptileNameMenu();

        switch(animalNameOpt) {
            case 1: 
                Console.WriteLine("Fill the following details: ");
                Console.Write("Name: ");
                string? name = Console.ReadLine();
                Console.Write("Age: ");
                string? a = Console.ReadLine();
                if(a == null) throw new Exception("Invalid Input!");
                int age = Int32.Parse(a);
                Console.Write("Weight: ");
                string? w = Console.ReadLine();
                if(w == null) throw new Exception("Invalid Input!");
                float weight = float.Parse(w);
                Console.Write("Health: ");
                string? health = Console.ReadLine();
                Console.Write("Scale Color: ");
                string? scaleColor = Console.ReadLine();
                if(name == null || health == null || scaleColor == null) throw new Exception("Invalid Input!");

                Snake snake = new Snake(name, age, weight, health, scaleColor);
                Tuple<string, string>? zoneCage = zoo.addReptile(snake);
                if(zoneCage == null) {
                    Console.WriteLine("All zones occupied! creating new zone with occupancy 10....");
                    Zone<Reptile> newZone = new Zone<Reptile>(10, typeof(Snake));
                    zoo.addReptileZone(newZone);
                    zoneCage = zoo.addReptile(snake);
                }
                Console.WriteLine($"{name} successfully added to zone:{zoneCage!.Item1} cage:{zoneCage!.Item2}");
                break;
            case 2: return;
            default: throw new Exception("Invalid Option!");
        }
    }
    public static void addBird(Zoo zoo)
    {
        int animalName = birdNameMenu();
    }

    public static int mainMenu()
    {
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("Please Select An Option:");
        Console.WriteLine("1. Add an animal");
        Console.WriteLine("2. View all animals");
        Console.WriteLine("3. Exit");
        Console.Write(">> ");
        string? input = Console.ReadLine();
        if (input == null) throw new Exception("Invalid Option");
        return Int32.Parse(input);
    }

    public static int animalTypeMenu()
    {
        Console.WriteLine("*********************************************");
        Console.WriteLine("  Please Select An Option:");
        Console.WriteLine("  1. Mammal");
        Console.WriteLine("  2. Reptile");
        Console.WriteLine("  3. Bird");
        Console.WriteLine("  4. Exit");
        Console.WriteLine("  >> ");
        string? input = Console.ReadLine();
        if (input == null) throw new Exception("Invalid Option");
        return Int32.Parse(input);
    }

    public static int mammalNameMenu()
    {
        Console.WriteLine("______________________________________________________\n");
        Console.WriteLine("    Please Select An Option:");
        Console.WriteLine("    1. Lion");
        Console.WriteLine("    2. Exit");
        Console.WriteLine("    >> ");
        string? input = Console.ReadLine();
        if (input == null) throw new Exception("Invalid Option");
        return Int32.Parse(input);
    }

    public static int reptileNameMenu()
    {
        Console.WriteLine("______________________________________________________\n");
        Console.WriteLine("    Please Select An Option:");
        Console.WriteLine("    1. Snake");
        Console.WriteLine("    2. Exit");
        Console.WriteLine("    >> ");
        string? input = Console.ReadLine();
        if (input == null) throw new Exception("Invalid Option");
        return Int32.Parse(input);
    }

    public static int birdNameMenu()
    {
        Console.WriteLine("______________________________________________________\n");
        Console.WriteLine("    Please Select An Option:");
        Console.WriteLine("    1. Peacock");
        Console.WriteLine("    2. Exit");
        Console.WriteLine("    >> ");
        string? input = Console.ReadLine();
        if (input == null) throw new Exception("Invalid Option");
        return Int32.Parse(input);
    }

    public static void Main(string[] args)
    {
        // Cage<Mammal> cage = new Cage<Mammal>(5,typeof(Lion));
        // Console.Write(cage.ID);
        Zoo metaZoo = new Zoo("Metazoo");
        Console.WriteLine("Welcome To MetaZoo!");

        while (true)
        {
            try
            {
                int input = mainMenu();
                switch (input)
                {
                    case 1: addAnimal(metaZoo); break;
                    case 2: Console.WriteLine("view all animals"); break;
                    case 3: Console.WriteLine("Exiting...."); return;
                    default: throw new Exception("Invalid Option!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}