using static System.Console;
using static System.Convert;

// src: https://www.w3schools.com/cs/cs_user_input.php
public class Test {
    public static void Main(string[] args) {
        Write("Enter your age: ");
        // int age = ReadLine(); //! Throws error: 8.cs(7,19): error CS0029: Cannot implicitly convert type `string' to `int'
        // int age = (int) ReadLine() ;//! Throws error: 8.cs(8,25): error CS0030: Cannot convert type `string' to `int'

        int age = ToInt32(ReadLine()); // Using the Convert class to convert a string to an integer.

        WriteLine("Your age is: " + age);
    }
}