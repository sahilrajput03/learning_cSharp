using System;
// FYI: System is a namespace, Console is a class and Write/WriteLine is a method.
//Comment: If you omit the using System line, you would have to write System.Console.WriteLine() to print/output text.
// Note: Every C# statement ends with a semicolon ;.
// Hierarchy is like: namespace > class > methods > statements.

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
        Console.WriteLine("Hello World!");    
        Console.Write("I am still here. ");
        Console.Write("This won't create a new line.");
        // The difference is that WriteLine() prints the output on a new line each time, while Write() prints on the same line (note that you should remember to add spaces when needed, for better readability):
        }
    }
}