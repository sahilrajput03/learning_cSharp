using static System.Console;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            int i = 0;
            // while loop:
            while (i < 5) {
                WriteLine(i);
                i++;
            }
            
            WriteLine("Done!");

            // do-while loop:
            do {
                WriteLine(i);
                i--;
            }
            while (i >= 0);
        }
    }
}