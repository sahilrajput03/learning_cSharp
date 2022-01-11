using static System.Console;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            string str = "AbcD";
            WriteLine(str.ToUpper());    
            WriteLine(str.ToLower());    

            string firstName = "John ";
            string lastName = "Doe";
            string full_name = firstName + lastName;                            // Way 1
            string full_name2 = string.Concat(firstName, lastName);             // Way 2
            string full_name3 = $"Fullname: {firstName} {lastName}";     // Way 3
            // String Interpolation: Another option of string concatenation, is string interpolation, which substitutes values of variables into placeholders in a string. Note that you do not have to worry about spaces, like with concatenation:
            
            WriteLine(full_name);
            WriteLine(full_name2);
            WriteLine(full_name3);

            string myString = "Hello";
            WriteLine(myString[0]);  // Outputs "H"
        }
    }
}