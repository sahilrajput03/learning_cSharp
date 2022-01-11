using static System.Console;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            for (int i = 0; i < 10; i++) {
                if (i == 4) { break;}
                WriteLine(i);
            }
            WriteLine("yoyo");

            for (int i = 0; i < 10; i++) {
                if (i == 4) { continue;}
                WriteLine(i);
            }
        }
    }
}