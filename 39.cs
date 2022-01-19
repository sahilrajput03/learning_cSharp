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
*/

namespace HelloWorld{
    abstract class Animal {
        public abstract void animalSound();
        public void sleep() {
            WriteLine("Zzz");
        }
    }
    
    class Program{
        static void Main(string[] args){
            Animal myObj = new Animal(); //! Will generate an error (Cannot create an instance of the abstract class or interface 'Animal')
            // WriteLine("Hello World!");    
        }
    }
}