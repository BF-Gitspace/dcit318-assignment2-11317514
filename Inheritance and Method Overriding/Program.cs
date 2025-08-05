// Assignment 2 (i): Inheritance and Method Overriding        ID: 11317514.

namespace Inheritance_and_Method_Overriding
{
    internal class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    internal class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Here we are going to demonstrate method overriding in inheritance
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            genericAnimal.MakeSound(); 
            dog.MakeSound();           
            cat.MakeSound();
            Console.ReadKey();
        }
         // Keep the console window open
    }
}