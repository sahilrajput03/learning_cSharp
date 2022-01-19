#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;
/*
## Interfaces
Another way to achieve abstraction in C#, is with interfaces.
IMPORTANT: An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies):

IMPORTANT: It is considered good practice to start with the letter "I" at the beginning of an interface, as it makes it easier for yourself and others to remember that it is an interface and not a class.
By default, members of an interface are abstract and public.
Note: Interfaces can contain properties and methods, but not fields.

IMPORTANT: To access the interface methods, the interface must be "implemented" (kinda like inherited) by another class. To implement an interface, use the : symbol (just like with inheritance). The body of the interface method is provided by the "implement" class. Note that you do not have to use the override keyword when implementing an interface:


*/

namespace HelloWorld{
    
    interface IAnimal{ // Interface
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal {
        public void animalSound() {
            // The body of animalSound() is provided here
            WriteLine("The pig says: wee wee");
        }
    }
    
    
    class Program{
        static void Main(string[] args){
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
        }
    }
}