#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;
/*src: https://www.w3schools.com/cs/cs_interface.php

IMPORATNT:: ~SAHIL::
## Notes on Interfaces:
- Like abstract classes, interfaces cannot be used to create objects (in the example above, it is not possible to create an "IAnimal" object in the Program class)
- Interface methods do not have a body - the body is provided by the "implement" class
- On implementation of an interface, you must override all of its methods
- Interfaces can contain properties and methods, but not fields/variables
- Interface members are by default abstract and public
- An interface cannot contain a constructor (as it cannot be used to create objects)

## Why And When To Use Interfaces?
1) To achieve security - hide certain details and only show the important details of an object (interface).
(IMPORANT:~SAHIL:)2) C# does not support "multiple inheritance" (a class can only inherit from one base class). However, it can be achieved with interfaces, because the class can implement multiple interfaces. Note: To implement multiple interfaces, separate them with a comma (see example below).
*/

namespace HelloWorld{
    
    interface IFirstInterface {
        void myMethod(); // interface method
    }

    interface ISecondInterface {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface {
        public void myMethod(){
            WriteLine("Some text..");
        }
        // ! IF WE COMMENT BELOW METHOD THEN ERROR WILL BE THROWN LIKE:: 42.cs(33,11): error CS0535: `HelloWorld.DemoClass' does not implement interface member `HelloWorld.ISecondInterface.myOtherMethod()'
        // public void myOtherMethod() {
        //     WriteLine("Some other text...");
        // }
    }
        
    
    class Program{
        static void Main(string[] args){
            DemoClass myClass = new DemoClass();
            myClass.myMethod();
            // myClass.myOtherMethod();
        }
    }
}