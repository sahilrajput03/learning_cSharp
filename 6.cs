#pragma warning disable 0219  // This is to disalbe variale not used warning from the compiler. src: https://stackoverflow.com/a/3821035/10012446

using System; // This is required for using Convert class.
using static System.Console;
public class Test {
    public static void Main(string[] args) {
        WriteLine("Hello to C# world!");
        // Implicit casting (small to big data type): (implicit casting is automatic)
        int myInt = 9;
        double myDouble = myInt;       // Automatic casting: int to double

        // Explicit casting (big to small data type): (its done manually)
        double myDouble2 = 9.78;
        int myInt2 = (int) myDouble2;    // Explicit/Manual casting: double to int

        int myInt3 = 10;
        double myDouble3 = 5.25;
        bool myBool3 = true;

        // Convert is class imported from namespace System.
        WriteLine(Convert.ToString(myInt3));    // convert int to string
        WriteLine(Convert.ToDouble(myInt3));    // convert int to double
        WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
        WriteLine(Convert.ToString(myBool3));   // convert bool to string
    }
}