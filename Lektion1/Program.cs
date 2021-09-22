using System;
using System.Collections.Generic;

namespace Lektion1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Opgave 2
            radiansConverter();
            //Opgave 3
            int pyramideLength = 5;
            pyramideTop(pyramideLength);
            //Opgave 4
            pyramideButton(pyramideLength);
            //Opgave 5
            SquareRoot();
            //Opgave 6
            ListGroupmembers();
        }

        public static void radiansConverter()
        {
            double d = 90;
            double r = 2;
            Console.WriteLine("{0} degrees is {1} radians. {2} radians is {3} degrees", d, ToRadians(d), r, ToDegrees(r));
        }
        public static double ToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        public static double ToDegrees(double radians)
        {
            return radians * (180 / Math.PI);
        }
        public static void pyramideTop(int length)
        {
            string s = "";
            for (int i = 0; i < length; i++)
            {
                s += "*";
                Console.WriteLine(s);
            }
        }
        public static void pyramideButton(int length)
        {
            string s = new string('*', length);
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(s);
                s = s.Remove(0, 1);
            }
        }
        public static void SquareRoot()
        {
            Console.WriteLine("Indtast et tal");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine("Kvadratroden af {0} er {1}", tal, Math.Sqrt(tal));
        }
        public static void ListGroupmembers()
        {
            List<string> gruppemedlemmer = new List<string>();
            int i = 0;
            string medlem = "";
            do
            {
                i++;
                Console.Write("Skriv navnet på medlem #{0}: ", i);
                medlem = Console.ReadLine();
                if (medlem != "")
                {
                    gruppemedlemmer.Add(medlem);
                }
            } while (medlem != "");
            Console.WriteLine("Du har skrevet disse medlemmer ind:");
            foreach (string gruppemedlem in gruppemedlemmer)
            {
                Console.WriteLine(gruppemedlem);
            }
        }
    }
}