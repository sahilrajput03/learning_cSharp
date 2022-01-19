#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;
using System;

namespace HelloWorld{
    class Program{
        static void checkAge(int age){
            if (age < 18){
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else{
                WriteLine("Access granted - You are old enough!");
            }
        }
        
        
        static void Main(string[] args){
            checkAge(18); // Rungs good enough.

            WriteLine("Checking for age 15 now...");
            checkAge(15);
            // ! ^^ THROWS EXCEPTION LIKE: System.ArithmeticException: Access denied - You must be at least 18 years old.
            // ! at HelloWorld.Program.checkAge

        }
    }
}