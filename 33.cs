#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;
/*
## PROPERTIES ADN ENCAPSULATION:
src: https://www.w3schools.com/cs/cs_properties.php

Before we start to explain properties, you should have a basic understanding of "Encapsulation".

The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:

declare fields/variables as private
provide public get and set methods, through properties, to access and update the value of a private field



## Properties:
You learned from the previous chapter that private variables can only be accessed within the same class (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties.

A property is like a combination of a variable and a method, and it has two methods: a get and a set method:
*/

namespace HelloWorld{
    class Person{
        // ? Learn: field, property and methods in a class.
        private string name; // field

        public string Name { // property
            get { return name; }   // get method
            set { name = value; }  // set method
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