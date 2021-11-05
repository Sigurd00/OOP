using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    class Program
    {
        delegate string StringJoin (string l, string r);
        delegate T Join<T>(T a);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string concatStrings(string l, string r)
            {
                return l + r;
            }

            string JoinThree(string a, string b, string c, StringJoin f) => f(a, f(b, c));
            Console.WriteLine(JoinThree("Hello", "From", "Delegates", concatStrings));

            string Join(List<string> l, StringJoin f, int index)
            {
                if (!l.Any())
                {
                    return default(string);
                }
                if (index == l.Count - 1)
                {
                    return l[index];
                }
                else
                {
                    return f(l[index], Join(l, f, index + 1));
                }
            }
            string JoinAllStrings(List<string> l, StringJoin f) => Join(l, f, 0);
            
            List<string> strings = new List<string> { "Hello", "From", "Delegates", "123", "this", "is", "fun" };
            Console.WriteLine(JoinAllStrings(strings, concatStrings));

        }
    }
}
