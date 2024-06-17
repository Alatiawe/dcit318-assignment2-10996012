using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // Define the IMovable interface
    interface IMovable
    {
        void Move();
    }

    // Implement the IMovable interface in the Car class
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Implement the IMovable interface in the Bicycle class
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            // Call the Move method on each instance
            car.Move();       // Output: Car is moving
            bicycle.Move();   // Output: Bicycle is moving

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
