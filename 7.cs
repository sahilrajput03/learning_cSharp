#pragma warning disable 0219  // This is to disalbe variale not used warning from the compiler. src: https://stackoverflow.com/a/3821035/10012446
using static System.Console;

public class Test {
    public static void Main(string[] args) {
        // Get User Input
        // Create a string variable and get user input from the keyboard and store it in the variable
        Write("Enter your name: ");
        string name = ReadLine();

        Write("Enter your age:");
        string age = ReadLine();

        WriteLine("\nName:  " + name + ", Age: " + age);
    }
}