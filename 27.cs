#pragma warning disable 0219 
#pragma warning disable 0414 

using static System.Console;

namespace HelloWorld{
    class Cow{

        // ? LEARN: color, height, Cow are class members.
        public string color = "brown";
        string height = "Daisy";

        // constructor overloading, src: https://www.geeksforgeeks.org/c-sharp-constructor-overloading/
        public Cow(){} // Commenting << this line will throw // ! error: 27.cs(22,24): error CS1729: The type `HelloWorld.Cow' does not contain a constructor that takes `0' argument
        // ? LEARN: You are not supposed to use ```void``` while defining the constructor coz there's no sensible way one can use returned value.

        public Cow(string clr){
            // ? LEARN: You are not supposed to use ```void``` while defining the constructor coz there's no sensible way one can use returned value from a constructor so no sense for defining return type for a constructor.
            // ? NOTE: If ^^^^^^ there, you do ```clr = ""``` i.e., use optional paramters in then only this constructor will be called even if you dont' pass argument to the class.
            color = clr;
        }

    }
    
    class Program{
        static void Main(string[] args){
            Cow Neil = new Cow(); // This references to classes in current namespace only.
            WriteLine("Neil's color: " + Neil.color);
            // WriteLine(Neil.height); // ! Throws Error: 27.cs(18,28): error CS0122: `HelloWorld.Cow.height' is inaccessible due to its protection level

            Cow Payal = new Cow("Red"); // This references to classes in current namespace only.
            WriteLine("Payal's color: " + Payal.color);


            // ? Using other namespaces: src: https://stackoverflow.com/a/740948/10012446
            ByeWorld.Cow Matty = new ByeWorld.Cow();
            WriteLine(Matty.color);
        }
    }
}

namespace ByeWorld{
    class Cow{
        public string color = "deeppink";
        string height = "200 metres"; 


        // ! UNCOMMENTING below defined ```main() method``` WILL THROW COMPILE TIME ERROR LIKE:
        // ! 27.cs(18,21): error CS0017: Program `binary' has more than one entry point defined: `HelloWorld.Program.Main(string[])'
        // ! 27.cs(35,21): error CS0017: Program `binary' has more than one entry point defined: `ByeWorld.Cow.Main(string[])'
        // static void Main(string[] args){
        //     WriteLine("This is main method of ByeWorld");
        // }
    }
}