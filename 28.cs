#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;

class Car{
    // By default model, color and year are private memembers unless you specify public infront of it:
    // ? Note: By default, all members of a class are private if you don't specify an access modifier:
    string model; // private member
    string color; // private member
    int year; // private member
    private int age = 11; // private member

    static void Main(string[] args){
        Car Ford = new Car(); // main method of this new instance of Car class will not be called IMO ~Sahil.
        Ford.model = "Mustang"; // we can assign values even if they are private coz we are using same class.
        Ford.color = "red"; // we can assign values even if they are private coz we are using same class.
        Ford.year = 1969; // we can assign values even if they are private coz we are using same class.
        Ford.age = 33; // we can assign values even if they are private coz we are using same class.

        Car Opel = new Car();
        Opel.model = "Astra"; // same as above
        Opel.color = "white"; // same as above
        Opel.year = 2005; // same as above
        Opel.age = 44; // same as above

        WriteLine(Ford.model);
        WriteLine(Opel.model);

        WriteLine(Ford.age);
        WriteLine(Opel.age);
        WriteLine();
        WriteLine();


        C1 F1 = new C1();
        F1.model = "Mustang"; // we can assign value only bcoz its defined public in C1 class.
        F1.color = "red"; // we can assign value only bcoz its defined public in C1 class.
        F1.year = 1969; // we can assign value only bcoz its defined public in C1 class.
        // F1.age = 55; // ! THROWS ERROR LIKE: 28.cs(40,12): error CS0122: `C1.age' is inaccessible due to its protection level

        C1 O1 = new C1();
        O1.model = "Astra";
        O1.color = "white";
        O1.year = 2005;
        // O1.age = 55; // ! THROWS ERROR LIKE: 28.cs(46,12): error CS0122: `C1.age' is inaccessible due to its protection level

        WriteLine(F1.model);
        WriteLine(O1.model);
    }
}

class C1 {
    public string model; // public member
    public string color; // public member
    public int year; // public member
    private int age = 22; // private member
}