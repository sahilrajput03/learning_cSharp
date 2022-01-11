using static System.Console;
using static System.Array;

using System; // This is required for #1 to work.

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            for (int i = 0; i < 5; i++) {
                WriteLine(i);
            }
            WriteLine("");

            // arrays in C# are like lists in Python. (from github copilot).
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            WriteLine("#0 --> A descent way:");
            foreach (string i in cars) {
                WriteLine(i);
            }

            WriteLine("\n#1 --> Using syntax sugar:");
            // A syntatic sugar to print each element from array.
            Array.ForEach(cars, Console.WriteLine); // This is fastest to print array though. src: https://stackoverflow.com/a/50372160/10012446

            WriteLine("\n#2--> Using syntax sugar along with imported static methods:");
            /* This is feasible coz I imported using static methods of Array and Console classes from System namespace:
            ```
            using static System.Array;
            using static System.Console;
            ```
            in the top of the program. */
            ForEach(cars, WriteLine); // This is fastest to print array though. src: https://stackoverflow.com/a/50372160/10012446
        }
    }
}