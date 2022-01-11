using static System.Console;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            // eg.1
            if (20 > 18){
                WriteLine("20 is greater than 18");
            }

            // eg.2
            int time = 20;
            if (time < 18) {
                WriteLine("Good day.");
            } else {
                WriteLine("Good evening.");
            }


            // eg.3
            int time1 = 22;
            if (time1 < 10) {
                WriteLine("Good morning.");
            } 
            else if (time1 < 20) {
                WriteLine("Good day.");
            } 
            else {
                WriteLine("Good evening.");
            }


            // eg.4, Short Hand If...Else (Ternary Operator)
            int time3 = 20;
            string result = (time3 < 18) ? "Good day." : "Good evening.";
            WriteLine(result);

        }
    }
}