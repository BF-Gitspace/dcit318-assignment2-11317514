// Abstract Classes and Methods Task       ID: 11317514.       

using System;

namespace Abstract_Classes_and_Methods
{
    // Abstract class Shape with abstract method GetArea()
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class Circle
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }
        // Constructor to initialize Width and Height
        // Properties for Width and Height
       

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Here we will use our own instances for the Circle and Rectangle
            Shape circle = new Circle(7.0);
            Shape rectangle = new Rectangle(5.0, 7.0);

            Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");


            Console.ReadKey();
        }
    }
}
