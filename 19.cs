#pragma warning disable 0219
using static System.Console;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            int[] myNum = {10, 20, 30, 40};
            WriteLine(cars[1]);
            WriteLine(myNum[1]);

            cars[0] = "Tesla";
            WriteLine("FYI: Car at index 0 is now: "  + cars[0]);

            WriteLine("FYI: Total cars in array is: " + cars.Length);
            WriteLine("");


            // iterating through array using TRADITIONAL for loop:
            WriteLine("Iterating through array using TRADITIONAL for loop:");
            for (int i = 0; i < cars.Length; i++) {
                WriteLine(cars[i]);
            }
            WriteLine("");

            // iterating through array without index (ALERT: Here in works like of javascript):
            WriteLine("Iterating using foreach..in loop:");
            foreach (string i in cars) {
                WriteLine(i);
            }
        }
    }
}