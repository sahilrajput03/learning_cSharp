#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;

namespace HelloWorld{
    class Car{
        public string model = "Mustang"; // public variables are accessible and modifiable directly.
    }

    class Program{
        static void Main(string[] args){
            Car myObj = new Car();
            WriteLine(myObj.model); // ? Runs successfully.
        }
    }
}