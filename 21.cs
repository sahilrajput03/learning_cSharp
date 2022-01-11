#pragma warning disable 0219
using static System.Console;
using static System.Array; // OTherwise Arry.Sort will work.
using System.Linq;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            // Other way fo of creating array:
            // If you are familiar with C#, you might have seen arrays created with the new keyword, and perhaps you have seen arrays with a specified size as well. In C#, there are different ways to create an array:

            // Create an array of four elements, and add values later
            string[] cars1 = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars2 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

            // Create an array of four elements without specifying the size 
            string[] cars3 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars4 = {"Volvo", "BMW", "Ford", "Mazda"};

            // It is up to you which option you choose. In our tutorial, we will often use the last option, as it is faster and easier to read.
            // However, you should note that if you declare an array and initialize it later, you have to use the new keyword:
            // E.g.,
            // Declare an array
            string[] cars5;

            // Add values, using new
            cars5 = new string[] {"Volvo", "BMW", "Ford"};
            // Add values without using new (this will cause an error)
            // cars5 = {"Volvo", "BMW", "Ford"};// ! THIS WOULD HAVE THROWN ERROR.
        }
    }
}