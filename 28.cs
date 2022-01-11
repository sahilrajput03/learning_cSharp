#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables

using static System.Console;

class Car{
    // By default model, color and year are private memembers unless you specify public infront of it:
    string model; // private member
    string color; // private member
    int year; // private member

    static void Main(string[] args){
        Car Ford = new Car();
        Ford.model = "Mustang"; // we can assign values even if they are private coz we are using same class.
        Ford.color = "red"; // we can assign values even if they are private coz we are using same class.
        Ford.year = 1969; // we can assign values even if they are private coz we are using same class.

        Car Opel = new Car();
        Opel.model = "Astra";
        Opel.color = "white";
        Opel.year = 2005;

        WriteLine(Ford.model);
        WriteLine(Opel.model);



        C1 F1 = new C1();
        F1.model = "Mustang"; // we can assign value only bcoz its defined public in C1 class.
        F1.color = "red"; // we can assign value only bcoz its defined public in C1 class.
        F1.year = 1969; // we can assign value only bcoz its defined public in C1 class.

        C1 O1 = new C1();
        O1.model = "Astra";
        O1.color = "white";
        O1.year = 2005;

        WriteLine(F1.model);
        WriteLine(O1.model);

    }
}

class C1 {
    public string model; // public member
    public string color; // public member
    public int year; // public member
}