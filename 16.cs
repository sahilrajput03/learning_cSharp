using static System.Console;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            int i = 0;
            while (i < 5) {
                WriteLine(i);
                i++;
            }
            
            WriteLine("Done!");

            do {
                WriteLine(i);
                i--;
            }
            while (i >= 0);
        }
    }
}