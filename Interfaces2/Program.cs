using System;
using System.Collections.Generic;
using System.Linq;

namespace Interfaces2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ITaxable> items = new List<ITaxable>();

            items.Add(new Bus(10, 1235151, 50000));
            items.Add(new House("Aalborg", true, 40, 5400000));

            foreach(ITaxable item in items)
            {
                Console.WriteLine(item.TaxValue());
            }
        }
    }
}