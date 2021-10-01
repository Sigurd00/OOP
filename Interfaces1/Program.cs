using System;
using System.Collections.Generic;
using System.Linq;

namespace Interfaces1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car("Skoda", "Fabia", 50000),
                new Car("Skoda", "Octavia", 60000),
                new Car("Mercedes", "F800", 150000),
                new Car("Ferrari", "f40", 1570000),
                new Car("Ferrari", "f40", 11570000),
                new Car("Ferrari", "g40", 1570000),
            };
            cars.Sort();
            foreach (Car car in cars)
            {
                Console.WriteLine("{0}, {1}, {2} ", car.Make, car.Model, car.Price);
            }
        }
    }
}