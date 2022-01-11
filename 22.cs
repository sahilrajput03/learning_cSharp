#pragma warning disable 0219 
using static System.Console;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            WriteLine("Hello World!");    
            MyMethod();
            MyMethod();
            MyMethod();
            MyMethod();
        }

        static void MyMethod(){
            WriteLine("MyMethod is executed..");
        }
    }
}