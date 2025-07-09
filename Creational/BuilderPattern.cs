using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharpp.Creational
{
    //Builder Pattern
    public class Car // Product class - It will be built by the builder
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }
    }

    class CarBuilder // Builder class - It will build the Car object step by step
    {
        private readonly Car _car = new Car(); // Instance of the product being built
        public CarBuilder SetMake(string make) // This method sets the Make property of the Car object
        {
            _car.Make = make;
            return this;
        }

        public CarBuilder setModel(string model)
        {
            _car.Model = model;
            return this;
        }
        public CarBuilder SetYear(int year)
        {
            _car.Year = year;
            return this;
        }
        public Car Build() // This method returns the built Car object
        {
            return _car;
        }
    }

    internal class BuilderPattern
    {
        public static void Run()
        {
            Console.WriteLine("Running Builder Pattern Example:");
            // Using the builder to create a Car object
            Car tesla = new CarBuilder()
                .SetMake("Tesla")
                .setModel("Model S")
                .SetYear(2022)
                .Build(); // Build the car
            Console.WriteLine(tesla); // Output: 2022 Tesla Model S
        }
    }
}
