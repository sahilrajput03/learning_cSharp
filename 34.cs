#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;
/*
## Why Encapsulation?
Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)
Flexible: the programmer can change one part of the code without affecting other parts
Increased security of data
*/
namespace HelloWorld{
    class Person{
        /*
            ? Encapsulation _continued...
            ## Automatic Properties (Short Hand):
            C# also provides a way to use short-hand / automatic properties, where you do not have to define the field for the property, and you only have to write get; and set; inside the property.
        */
        public string Name { // property
            get;  // get method
            set;  // set method
        }
    }
    /*
    The Name property is associated with the name field. It is a good practice to use the same name for both the property and the private field, but with an uppercase first letter.
    The get method returns the value of the variable name.
    The set method assigns a value to the name variable. The value keyword represents the value we assign to the property.
    */
    
    class Program{
        static void Main(string[] args){
            Person myObj = new Person();
            myObj.Name = "Liam"; // ~SAHIL : what the fuck is this in c# ?? :LOL:
            WriteLine(myObj.Name);
        }
    }
}