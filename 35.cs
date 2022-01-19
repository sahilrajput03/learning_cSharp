#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;
/*src: https://www.w3schools.com/cs/cs_inheritance.php

    Inheritance (Derived and Base Class)
    In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:

    Derived Class (child) - the class that inherits from another class
    Base Class (parent) - the class being inherited from
    To inherit from a class, use the : symbol.

    In the example below, the Car class (child) inherits the fields and methods from the Vehicle class (parent):
*/

namespace HelloWorld{
    class Vehicle{ // base class (parent)
        public string brand = "Ford";  // Vehicle field
        public void honk(){ // Vehicle method 
            WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle { // derived class (child)
        public string modelName = "Mustang";  // Car field
    }
    
    class Program{
        static void Main(string[] args){
        // Create a myCar object
        Car myCar = new Car();

        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.honk();

        // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
        WriteLine("Brand (model name): " + myCar.brand + " " + myCar.modelName);        }
    }
}