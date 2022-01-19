#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;

/*src: https://www.w3schools.com/cs/cs_enums.php
## Enum in a Switch Statement
Enums are often used in switch statements to check for corresponding values:

## Why And When To Use Enums?
Use enums when you have values that you know aren't going to change, like month days, days, colors, deck of cards, etc.
*/
namespace HelloWorld{
    class Program{
        enum Level { Low, Medium, High }

        static void Main(string[] args){

            Level myVar = Level.Medium;
            switch(myVar){
                case Level.Low:
                WriteLine("Low level");
                break;
                case Level.Medium:
                WriteLine("Medium level");
                break;
                case Level.High:
                WriteLine("High level");
                break;
            }
        }
    }
}