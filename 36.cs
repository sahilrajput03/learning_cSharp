#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;

/* src: https://www.w3schools.com/cs/cs_inheritance.php

The sealed Keyword
If you don't want other classes to inherit from a class, use the sealed keyword:
*/
namespace HelloWorld{
    sealed class Vehicle { // ? NOTE: the sealed keyword infront of the class decalaration.
    // ...
    }

    class Car : Vehicle { // ! THROWS ERROR: 36.cs(17,7): error CS0509: `HelloWorld.Car': cannot derive from sealed type `HelloWorld.Vehicle'
    // ...
    }
    
    class Program{
        static void Main(string[] args){
            WriteLine("Hello World!");    
        }
    }
}