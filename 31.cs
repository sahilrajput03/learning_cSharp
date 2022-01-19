#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;

namespace HelloWorld{
    class Car{
        private string model = "Mustang";
        // ? Note: By default, all members of a class are private if you don't specify an access modifier:
        string mode;
        string year;
    }

    class Program{
        static void Main(string[] args){
            Car myObj = new Car();
            WriteLine(myObj.model); // ! THROWS ERROR LIKE: 31.cs(15,29): error CS0122: `HelloWorld.Car.model' is inaccessible due to its protection level
        }
    }
}