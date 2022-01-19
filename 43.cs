#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;
/*
C# Enums
An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
To create an enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma:

Enum Values:
By default, the first item of an enum has the value 0. The second has the value 1, and so on.
To get the integer value from an item, you must explicitly convert the item to an int:
*/
namespace HelloWorld{
    class Program{
        enum Level{ Low, Medium, High}
        enum Months{
            January,    // 0
            February,   // 1
            March,      // 2
            April,      // 3
            May,        // 4
            June,       // 5
            July        // 6
        }

        static void Main(string[] args){
            Level myVar = Level.Medium;
            WriteLine(myVar);
            // Ouput: Medium

            // ~Sahil explicitly converting the item to an int to get the integer value of the enum. (integer value of enum starts from 0 i.e., exactly like in any array.)
            int myNum = (int) Months.April;
            WriteLine(myNum);
            // Output: 3
        }
    }
}