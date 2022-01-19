#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            int[] myNumbers = {1, 2, 3};
            WriteLine(myNumbers[10]);
            // ! ^^^^^^^^^^^^^^^^^^ THROWS EXCEPTION LIKE: Unhandled Exception: System.IndexOutOfRangeException: Index was outside the bounds of the array. at HelloWorld.Program.Main
            //~sahil:: See example 48.cs to know how try catch can be applied here.
        }
    }
}