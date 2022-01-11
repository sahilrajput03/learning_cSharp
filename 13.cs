using static System.Console;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            int x = 10;
            int y = 9;

            WriteLine(x > y); // returns True, because 10 is higher than 9
            WriteLine(x == 10); // returns True, because the value of x is equal to 10
            WriteLine(10 == 15); // returns False, because 10 is not equal to 15
        }
    }
}