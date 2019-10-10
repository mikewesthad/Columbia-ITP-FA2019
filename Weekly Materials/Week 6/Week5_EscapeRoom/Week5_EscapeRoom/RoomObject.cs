using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Week5_EscapeRoom
{
    class RoomObject
    {
        string Name;
        string Description;
        ConsoleColor Color;

        public RoomObject(string name, string description, ConsoleColor color)
        {
            Name = name;
            Description = description;
            Color = color;
        }

        public void DisplayInfo()
        {
            ForegroundColor = Color;
            WriteLine("You inspect the " + Name + ".");
            WriteLine(Description);
            Write("\n(press any key) ");
            ReadKey(true);
        }
    }
}
