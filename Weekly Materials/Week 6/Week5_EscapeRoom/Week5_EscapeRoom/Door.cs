using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Week5_EscapeRoom
{
    class Door
    {
        string Code;
        ConsoleColor Color;

        public Door(string code, ConsoleColor color)
        {
            Code = code;
            Color = color;
        }

        public bool AttemptEscape()
        {
            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = Color;
            WriteLine("You step up and try the door. It's locked and needs a code...");
            Write("Please enter the code: ");
            string playerAnswer = ReadLine().ToLower();
            if (playerAnswer == Code)
            {
                WriteLine("Click... you escaped!");
                ForegroundColor = previousColor;
                return true;
            }
            else
            {
                WriteLine("Nothing happened... guess the code was wrong");
                WriteLine("\n(press any key)");
                ReadKey(true);
                ForegroundColor = previousColor;
                return false;
            }
        }
    }

}
