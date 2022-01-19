#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;

namespace HelloWorld{
    class Program{
        // You can also assign your own enum values, and the next items will update the number accordingly:
        enum Months{
            January,    // 0
            February,   // 1
            March=6,    // 6
            April,      // 7
            May,        // 8
            June,       // 9
            July        // 10
        }

        static void Main(string[] args){

            int myNum = (int) Months.April;
            WriteLine(myNum);
            // Output: 7
        }
    }
}