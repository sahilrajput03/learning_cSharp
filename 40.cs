#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;

/*src: https://www.w3schools.com/cs/cs_abstract.php

## Abstract Classes and Methods
Data abstraction is the process of hiding certain details and showing only essential information to the user.
Abstraction can be achieved with either abstract classes or interfaces (which you will learn more about in the next chapter).

The abstract keyword is used for classes and methods:

Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).

Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
An abstract class can have both abstract and regular methods:

## Why And When To Use Abstract Classes and Methods?
To achieve security - hide certain details and only show the important details of an object.
Note: Abstraction can also be achieved with Interfaces, which you will learn more about in the next chapter.
*/

namespace HelloWorld{

    abstract class Animal{ //? Abstract class
        public abstract void animalSound(); //? Abstract method (does not have a body)
        // HENCE, we say that any class extending Animal class MUST IMPLEMENT animalSound method else compiler will throw error!
        public void sleep(){ // Regular method
            WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal{
        // ! // NOTE~SAHIL: IF YOU DON'T DEFINE BELOW METHOD THEN COMPILER WILL THROW ERROR LIKE:: 40.cs(35,11): error CS0534: `HelloWorld.Pig' does not implement inherited abstract member `HelloWorld.Animal.animalSound()'
        public override void animalSound(){
            //? The body of animalSound() is provided here
            WriteLine("The pig says: wee wee");
        }
    }
    
    class Program{
        static void Main(string[] args){
            Pig myPig = new Pig(); // Create a Pig object
            // myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method
        }
    }
}