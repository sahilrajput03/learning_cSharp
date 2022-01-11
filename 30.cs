#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;
using static System.Array;
using System.Collections.Generic;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            //List in C#, src: https://stackoverflow.com/a/202854/10012446
            List<int> termsList = new List<int>();
            for (int runs = 1; runs <= 15; runs++){
                termsList.Add(runs);
            }
            // ForEach(termsList, WriteLine); //! << This doesn't work though.


            // You can convert it back to an array if you would like to
            int[] terms = termsList.ToArray();
            // Printing array values:
            ForEach(terms, WriteLine);
        }
    }
}