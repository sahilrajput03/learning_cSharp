#pragma warning disable 0219  // This is to disalbe variale not used warning from the compiler. src: https://stackoverflow.com/a/3821035/10012446 (FYI: 0129 is the code from the warning message in the terminal).
// Learn: static imports
using static System.Console;// This imports all static methods of class Console. src: https://stackoverflow.com/a/29831750/10012446

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            WriteLine("Hello World!");    
            Write("may be its sunday!");
        }
    }
}