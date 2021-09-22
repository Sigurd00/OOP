using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee Sigurd = new Employee("Sigurd", "Brogrammer", 10000, 3);
            Manager Jacob = new Manager("Jacob", "gigaChading", 12000, 7, 5000);
            Console.WriteLine(Sigurd.CalculateYearlySalary());
            Console.WriteLine(Jacob.CalculateYearlySalary());

            ParkingMeter parkingMeter = new ParkingMeter();

            parkingMeter.InsertCoins(10);
            parkingMeter.PayForParking(2, 2);
            parkingMeter.ShowCoins();
        }
    }
}