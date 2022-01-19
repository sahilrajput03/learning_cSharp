#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;
using System; // This is required to access Exception keyword in the catch's argument. ~Sahil.
/*src: https://www.w3schools.com/cs/cs_exceptions.php
## C# Exceptions
When executing C# code, different errors can occur: coding errors made by the programmer, errors due to wrong input, or other unforeseeable things.
When an error occurs, C# will normally stop and generate an error message. The technical term for this is: C# will throw an exception (throw an error).

## C# try and catch
The try statement allows you to define a block of code to be tested for errors while it is being executed.
The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.
The try and catch keywords come in pairs:

*/

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            try{
                int[] myNumbers = {1, 2, 3};
                WriteLine(myNumbers[10]);
            // ! ^^^^^^^^^^^^^^^^^^ THROWS EXCEPTION LIKE: Unhandled Exception: System.IndexOutOfRangeException: Index was outside the bounds of the array. at HelloWorld.Program.Main
            } catch (Exception e){
                WriteLine("Something went wrong.. ~Sahil");
                WriteLine(e.Message);
                WriteLine("Bye buddy!");
            } finally{
                // The finally statement lets you execute code, after try...catch, regardless of the result:
                WriteLine("The try-catch is finished...");
            }
        }
    }
}