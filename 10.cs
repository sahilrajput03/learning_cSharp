using static System.Console;
using static System.Math; // Otherwise Math.Max can be used.

public class Test {
    public static void Main(string[] args) {
        WriteLine("Hello to C# world!");

        WriteLine(Max(5, 10));
        WriteLine(Min(5, 10));
        WriteLine(Sqrt(64));
        WriteLine(Abs(-4.7));
        WriteLine(Round(9.99));

        // Below are generated from github co pilot:
        WriteLine(Ceiling(9.99));
        WriteLine(PI);
        WriteLine(Pow(2, 8));
        WriteLine("");
        WriteLine("");
        WriteLine("");
        WriteLine("Exp(2):" + Exp(2));
        WriteLine(Log(2));
        WriteLine(Log10(2));
        WriteLine(Sin(PI / 2));
        WriteLine(Cos(PI / 2));
        WriteLine(Tan(PI / 2));
    }
}