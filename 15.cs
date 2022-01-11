using static System.Console;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            int day = 1;
            switch (day) {
            case 1:
                WriteLine("Monday");
                break;
            case 2:
                WriteLine("Tuesday");
                break;
            case 3:
                WriteLine("Wednesday");
                break;
            case 4:
                WriteLine("Thursday");
                break;
            case 5:
                WriteLine("Friday");
                break;
            case 6:
                WriteLine("Saturday");
                break;
            case 7:
                WriteLine("Sunday");
                break;

            // The default keyword is optional and specifies some code to run if there is no case match:
            default:
                WriteLine("Day number must be between 1 and 7. Please fix!");
                break; //? This break is IMPORTANT.
            }
        }
    }
}