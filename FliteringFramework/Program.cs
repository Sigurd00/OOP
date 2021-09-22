using System;
using System.Collections.Generic;

namespace FilteringFramework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Sigurd", 21, false));
            people.Add(new Person("Martin", 22, true));
            people.Add(new Person("Jesper", 24, true));
            people.Add(new Person("Kasper", 26, false));
            people.Add(new Person("Sigurd", 26, true));

            //Name filter
            PersonFilter nameFilter = new NameFilter("Sigurd");
            PersonFilter ageFilter = new AgeFilter(26, 26);
            AndFilter andFilter = new AndFilter(ageFilter, nameFilter);
            List<Person> filteredByNotName = andFilter.Filter(people);
            filteredByNotName.ForEach(person => Console.WriteLine(person.Name));
        }
    }
}