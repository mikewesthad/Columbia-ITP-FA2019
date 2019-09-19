using System;
using static System.Console;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Virtual Pet Simulator - Mike Hadley";

            ForegroundColor = ConsoleColor.DarkCyan;
            BackgroundColor = ConsoleColor.White;
            Clear();

            string titleArt = @"
 ,    /+.
((___/ __>           \    /\
/      }              )  ( ')
\ .++.(    ___       (  /  )
 \\   \\  /___\       \(__)+
";
            WriteLine(titleArt);
            WriteLine("Welcome to the pet simulator. There are a few pets already here:");
            
            ForegroundColor = ConsoleColor.Black;
            VirtualPet junior = new VirtualPet();
            junior.Name = "Junior";
            junior.AgeInDays = 7;
            junior.Greet();

            // Access a static method by using the class name, not an instance.
            WriteLine();
            VirtualPet.DisplayNumPetsCreated();
            WriteLine();

            VirtualPet ruffles = new VirtualPet();
            ruffles.Name = "Ruffles";
            ruffles.AgeInDays = 24;
            ruffles.Mood = "Playful";
            ruffles.Greet();

            WriteLine();
            VirtualPet.DisplayNumPetsCreated();
            WriteLine();

            ForegroundColor = ConsoleColor.DarkCyan;
            Write("Now it's time for your own pet. Please name your pet: ");
            string petName = ReadLine();
            Write("What mood should your pet have: ");
            string petMood = ReadLine();
            Write("How hungry is your pet (0 - 100): ");
            string petHungerResponse = ReadLine();

            // Convert.ToInt32() is a static method that allows us to take a string and turn it 
            // into an int. See: https://docs.microsoft.com/en-us/dotnet/api/system.convert.toint32
            int petHunger = Convert.ToInt32(petHungerResponse);

            VirtualPet playersPet = new VirtualPet(petName, petMood, 5, petHunger);
            ForegroundColor = ConsoleColor.Black;
            playersPet.Greet();

            WriteLine();
            VirtualPet.DisplayNumPetsCreated();
            WriteLine();

            // Art from https://www.asciiart.eu/animals
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine("Art Credits:");
            WriteLine("Dog with dog dish by Joan Stark");
            WriteLine("Sitting cat by Joan Stark");

            ReadKey();
        }
    }
}
