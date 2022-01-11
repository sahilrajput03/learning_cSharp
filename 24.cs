#pragma warning disable 0219 
using static System.Console;
using static System.Array;
// using System; 

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            MyMethod("Sahil Rajput");
            MyMethod();
            WriteLine(MyMethod2(2,3));
            WriteLine("");
            // MyMethod3({"Sahil", "Tinku"});
            string[] team = {"Sahil", "Tekena"};
            MyMethod3(team);
        }

        static void MyMethod(string name = "Elon Musk"){
            // Note: Default value for name is "Elon Musk", hece name is a optional parameter.
            WriteLine("Hello, " + name);
        }

        static int MyMethod2(int x, int y) {
            return x + y;
        }

        static void MyMethod3(string[] name){
            WriteLine("Team members are:");
            // Array.ForEach(name, Console.WriteLine); // This is fastest to print array though. src: https://stackoverflow.com/a/50372160/10012446

            ForEach(name, WriteLine); // This is fastest to print array though. src: https://stackoverflow.com/a/50372160/10012446

            // Traditional way:
            // foreach (string item in name){
            //     WriteLine(item);
            // }
        }
    }
}