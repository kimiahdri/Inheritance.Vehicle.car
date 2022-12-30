using System;

namespace Inheritance.Vehicle.car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

            Console.ReadKey();
        }
    }
        class Vehicle
        {

            public int speed = 0;

            public void go()
            {
                Console.WriteLine("This vehice is moving...");
            }
        }
    class Car : Vehicle
    {
        public int wheels = 4;
    }
}
