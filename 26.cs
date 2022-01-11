#pragma warning disable 0219 
using static System.Console;
using static System.Array;
// using System; 

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            MyMethod("Raju");
            MyMethod(21);
        }

        // Playing with optional parameters.
        static void MyMethod(string name = "Sahil"){
            WriteLine(name);
        }

        // overloading with different parameter signatures. 
        static void MyMethod(int age = 20){
            WriteLine("Age is: " + age);
        }

        // OTHER WAYS OF METHOD OVERLOADING {methods with same name but different signatures i.e, params or return type} (LIKE WITH DIFFERENT RETURN TYPES):
        // int MyMethod(int x)
        // float MyMethod(float x)
        // double MyMethod(double x, double y)
    }
}