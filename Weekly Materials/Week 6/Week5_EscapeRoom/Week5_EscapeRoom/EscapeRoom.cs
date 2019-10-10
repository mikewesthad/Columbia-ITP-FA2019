using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static System.Console;

namespace Week5_EscapeRoom
{
    class EscapeRoom
    {
        RoomObject Painting;
        RoomObject DeskDrawer;
        RoomObject Cane;
        Door LockedDoor;

        public EscapeRoom()
        {
            Painting = new RoomObject("painting", "It's, oddly enough, a giant painting of mice. You think \"mice\" might be a clue.", ConsoleColor.Red);
            DeskDrawer = new RoomObject("desk drawer", "It sticks slightly, but you manage to jiggle the drawer open. You find a post-it with the number \"three\" on it.", ConsoleColor.Blue);
            Cane = new RoomObject("cane", "You realize it is actually a walking stick that a \"blind\" person might use.", ConsoleColor.Yellow);
            LockedDoor = new Door("three blind mice", ConsoleColor.Green);

            Console.Title = "Escape!";
        }

        public void StartRoom()
        {
            Stopwatch escapeTimer = new Stopwatch();
            bool hasEscaped = false;

            WriteLine("You wake and groggily look around.");
            WriteLine("Looks like you are in some kind of escape room.");
            Write("\n(press any key) ");
            ReadKey();

            escapeTimer.Start();

            while (!hasEscaped)
            {
                string choice = Navigate();

                if (choice == "1")
                {
                    Painting.DisplayInfo();
                }
                else if (choice == "2")
                {
                    DeskDrawer.DisplayInfo();
                }
                else if (choice == "3")
                {
                    Cane.DisplayInfo();
                }
                else if (choice == "4")
                {
                    hasEscaped = LockedDoor.AttemptEscape();
                }
                else
                {
                    DisplayInvalidChoiceFeedback();
                }
            }

            escapeTimer.Stop();
            double elapsedSeconds = escapeTimer.ElapsedMilliseconds / 1000f;

            WriteLine("\nIt only took you " + elapsedSeconds + " seconds.");
            if (elapsedSeconds < 10)
            {
                WriteLine("Unbelievable, you did it in less than 10 seconds.");
            }
            else if (elapsedSeconds < 30)
            {
                WriteLine("Nice sleuthing, you managed it in under half a minute.");
            }
            else
            {
                WriteLine("You didn't do well enough for a top score this time.");
            }

            WriteLine("Thanks for playing.\nPress any key to exit...");
            ReadKey();
        }

        void DisplayInvalidChoiceFeedback()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine("That's not a valid choice. Try again.");
            Write("\n(press any key) ");
            ReadKey(true);
        }

        string Navigate()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine("\n\n----------------\n");
            WriteLine("Where would you like to look?");
            WriteLine("  1) a painting\n  2) a desk drawer\n  3) a cane\n  4) a door");
            string choice = ReadLine();
            WriteLine("\n----------------\n\n");
            return choice;
        }
    }
}
