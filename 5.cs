/* C# Variables
Variables are containers for storing data values.

In C#, there are different types of variables (defined with different keywords), for example:

int - stores integers (whole numbers), without decimals, such as 123 or -123
double - stores floating point numbers, with decimals, such as 19.99 or -19.99
char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
string - stores text, such as "Hello World". String values are surrounded by double quotes
bool - stores values with two states: true or false

Usage:
type variableName = value;

Read about data types more @ https://www.w3schools.com/cs/cs_data_types.php

Data Type	    Size	                Description
int	            4 bytes	                Stores whole numbers from -2,147,483,648 to 2,147,483,647
long	        8 bytes	                Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

float	        4 bytes	                Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
double	        8 bytes	                Stores fractional numbers. Sufficient for storing 15 decimal digits

bool	        1 bit	                Stores true or false values
char	        2 bytes	                Stores a single character/letter, surrounded by single quotes
string	        2 bytes per character	Stores a sequence of characters, surrounded by double quotes

*/

#pragma warning disable 0219  // This is to disalbe variale not used warning from the compiler. src: https://stackoverflow.com/a/3821035/10012446
using static System.Console;
public class Test {
    public static void Main(string[] args) {
        int myNum = 5;
        double myDoubleNum = 5.99D; // D in end stands for double but its not required.
        float myFloatNum = 5.75F; // float value should end with capital F.
        char myLetter = 'D'; // The character must be surrounded by single quotes, like 'A' or 'c'
        bool myBool = true;
        string myText = "Hello";

        float f1 = 35e3F; // 35000, e or E stands for power of 10.
        double d1 = 12E4D; // 120000

        int x = 5, y = 6, z = 50;

        WriteLine(d1);
        const int c = 20; // Note: You cannot declare a constant variable without assigning the value. If you do, an error will occur: A const field requires a value to be provided.
        // c = 30; // ! This line should throw error.
    }
}