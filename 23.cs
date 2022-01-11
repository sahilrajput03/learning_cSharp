#pragma warning disable 0219 
using static System.Console;
using static System.Array;
// using System; 

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            MyMethod("Anjali", 50);
            MyMethod("Rohan"); // Takes second argument as default.
            MyMethod();
            MyMethod(age: 50, name: "Rahu");// ? Named arguments. src: https://www.w3schools.com/cs/cs_method_parameters.php
        }

        // Playing with optional parameters.
        static void MyMethod(string name = "Sahil", int age = 20){
            WriteLine(name + " " + age);
        }
    }
}