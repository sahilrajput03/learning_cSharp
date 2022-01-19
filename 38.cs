#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables
#pragma warning disable CS0108 // supress warning for ::FROM COMPILER WARNING:: `HelloWorld.Pig.animalSound()' hides inherited member `HelloWorld.Animal.animalSound()'. Use the new keyword if hiding was intended

using static System.Console;
/*src: https://www.w3schools.com/cs/cs_polymorphism.php

## Why And When To Use "Inheritance" and "Polymorphism"?
- It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.
*/

namespace HelloWorld{
    class Animal{ // Base class (parent) 
        public virtual void animalSound() {
            WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal{ // Derived class (child) 
        public override void animalSound() {
            WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal{ // Derived class (child) 
        public override void animalSound() {
            WriteLine("The dog says: bow wow");
        }
    }

    class Program {
        static void Main(string[] args) {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            /*
            Output:
            The animal makes a sound
            The pig says: wee wee
            The dog says: bow wow

            ? tldr; We overrided methods of base class, thus are new methods in derived class workd superb!
            */
        }
    }
}