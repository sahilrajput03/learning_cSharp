#pragma warning disable 0219 // supress warning for unused variables
#pragma warning disable 0414 // supress warning for unused private members
#pragma warning disable 0169 // supress warning for unused variables
#pragma warning disable CS0108 // supress warning for ::FROM COMPILER WARNING:: `HelloWorld.Pig.animalSound()' hides inherited member `HelloWorld.Animal.animalSound()'. Use the new keyword if hiding was intended

using static System.Console;
/*src: https://www.w3schools.com/cs/cs_polymorphism.php
Polymorphism and Overriding Methods: 
( ~SAHIL: This is the awesome exaplanation for the override keywords we see anywhere in any language in computer programming, yikes, I love w3schools.com.)
Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.

Like we specified in the previous chapter; Inheritance lets us inherit fields and methods from another class. Polymorphism uses those methods to perform different tasks. This allows us to perform a single action in different ways.

For example, think of a base class called Animal that has a method called animalSound(). Derived classes of Animals could be Pigs, Cats, Dogs, Birds - And they also have their own implementation of an animal sound (the pig oinks, and the cat meows, etc.):
*/

namespace HelloWorld{
    class Animal{ // Base class (parent) 
        public void animalSound() {
            WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal{ // Derived class (child) 
        public void animalSound() {
            WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal{ // Derived class (child) 
        public void animalSound() {
            WriteLine("The dog says: bow wow");
        }
    }

    class Program {
        static void Main(string[] args) {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            /*
            Output:
            The animal makes a sound
            The animal makes a sound
            The animal makes a sound

            FYI: Not The Output I Was Looking For
            ? tldr; Base Class (parent class) overrides the derived class (child class) methods.
            
            The output from the example above was probably not what you expected. That is because the base class method overrides the derived class method, when they share the same name.
            However, C# provides an option to override the base class method, by adding the virtual keyword to the method inside the base class, and by using the override keyword for each derived class methods:
            */
        }
    }
}