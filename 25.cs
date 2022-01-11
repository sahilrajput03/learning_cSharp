#pragma warning disable 0219 
using static System.Console;
using static System.Array;
// using System; 

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            MyMethod(); // ! ERROR: 25.cs(9,13): error CS1501: No overload for method `MyMethod' takes `0' argumen
        }

        // Playing with optional parameters.
        static void MyMethod(string name, int age = 20){
            WriteLine(name + " " + age);
        }
    }
}