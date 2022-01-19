#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;
using System.IO;  // include the System.IO namespace
// Usage: File.someFileMethod

/*src: https://www.w3schools.com/cs/cs_files.php

## Working With Files
The File class from the System.IO namespace, allows us to work with files:

he File class has many useful methods for creating and getting information about files. For example:

METHOD	        DESCRIPTION
AppendText()	Appends text at the end of an existing file
Copy()	        Copies a file
Create()	    Creates or overwrites a file
Delete()	    Deletes a file
Exists()	    Tests whether the file exists
ReadAllText()	Reads the contents of a file
Replace()	    Replaces the contents of a file with the contents of another file
WriteAllText()	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.
*/
namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            string textToWrite = "my text here...!";  // Create a text string
            string fileName = "filename.txt";
            
            File.WriteAllText(fileName, textToWrite);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText(fileName);  // Read the contents of the file
            WriteLine(readText);  // Output the content
        }
    }
}