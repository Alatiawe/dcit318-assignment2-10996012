using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    // Abstract class Shape
    abstract class Shape
    {
        // Abstract method GetArea
        public abstract double GetArea();
    }

    // Derived class Circle
    class Circle : Shape
    {
        // Radius of the circle
        private double radius;

        // Constructor to initialize the radius
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Override GetArea method to calculate the area of the circle
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Derived class Rectangle
    class Rectangle : Shape
    {
        // Width and height of the rectangle
        private double width;
        private double height;

        // Constructor to initialize the width and height
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Override GetArea method to calculate the area of the rectangle
        public override double GetArea()
        {
            return width * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            // Display the areas of the shapes
            Console.WriteLine("Area of Circle: " + circle.GetArea());
            Console.WriteLine("Area of Rectangle: " + rectangle.GetArea());

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
