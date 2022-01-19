#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;
/*
src: https://www.w3schools.com/cs/cs_access_modifiers.php
The public keyword is an access modifier, which is used to set the access level/visibility for classes, fields, methods and properties.

C# has the following access modifiers:

Modifier	Description
public	    The code is accessible for all classes
private	    The code is only accessible within the same class
protected	The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
internal	The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter

? There's also two combinations: protected internal and private protected.

For now, lets focus on public and private modifiers.


*/

namespace HelloWorld{
    class Car {
        private string model = "Mustang";
        static void Main(string[] args){
            Car myObj = new Car();
            WriteLine(myObj.model);
        }
    }
}