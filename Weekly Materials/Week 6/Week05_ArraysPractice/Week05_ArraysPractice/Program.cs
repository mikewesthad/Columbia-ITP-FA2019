using System;
using static System.Console;

namespace Week05_ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pulling from Oscar nominations for 2019:
            string[] movies; // Declaration
            movies = new string[6]; // Initialization, fills with null - the default value for strings
            movies[0] = "Black Panther";
            movies[1] = "BlacKkKlansman";
            movies[2] = "Bohemian Rhapsody";
            movies[3] = "Green Book";
            movies[4] = "Roma";
            movies[5] = "A Start is Born";

            WriteLine("--- Movies ---");
            WriteLine("The oscar nominees for 2019 are:");
            foreach (string movie in movies)
            {
                WriteLine("> {0}", movie);
            }

            WriteLine("\n--- Weather ---");
            // Unlike what we did with the movies example, you can also initialize all the values
            // in one line like this:
            int[] temperatures = { 71, 68, 69, 69, 68, 65, 58 };
            for (int i = 0; i < temperatures.Length; i++)
            {
                int temp = temperatures[i];
                string dayDescription;

                // If a condition only has one line of code, you can omit the curly braces:
                if (i == 0)
                    dayDescription = "today";
                else if (i == 1)
                    dayDescription = "yesterday";
                else
                    dayDescription = i + " days ago";

                WriteLine("It was {0} degrees {1}.", temp, dayDescription);
            }

            // Challenge: finding max and average. You could do this within the previous loop, but
            // I'm separating it out for clarity.
            int maxTemp = 0;
            double sumTemps = 0;
            for (int i = 0; i < temperatures.Length; i++)
            {
                int temp = temperatures[i];
                if (temp > maxTemp)
                {
                    maxTemp = temp;
                }

                sumTemps += temp;
            }
            double aveTemp = sumTemps / temperatures.Length;
            WriteLine("The average temperature for the last week was " + aveTemp.ToString("N2") + ".");
            WriteLine("The max temperature was " + maxTemp + ".");
        }
    }
}
