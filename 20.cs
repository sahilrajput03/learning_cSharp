using static System.Console;
using static System.Array; // OTherwise Arry.Sort will work.
using System.Linq;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            // Sort a string
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            Sort(cars);
            foreach (string i in cars){
                WriteLine(i);
            }
            
            // Sort an int
            int[] myNumbers = {5, 1, 8, 9};
            Sort(myNumbers);
            foreach (int i in myNumbers){
                WriteLine(i);
            }

            WriteLine(""); // Max, Min and Sum metods are available bcoz of System.Linq class.
            WriteLine("Max: " + myNumbers.Max());  // returns the largest value from the array.
            WriteLine("Min: " + myNumbers.Min());  // returns the smallest value from the array.
            WriteLine("Sum: " + myNumbers.Sum());  // returns the sum of elements of the array.
        }
    }
}