using System;

namespace Lektion1Klasser
{
    class Person
    {
        private int _alder;
        private string _fornavn;
        private string _efternavn;
        private Person _far;
        private Person _mor;
        public string Fornavn 
        { 
            get 
            {
                return _fornavn;
            } 
            set
            {
                _fornavn = value;
            }
        }
        public string Efternavn
        {
            get
            {
                return _efternavn;
            }
            set
            {
                _efternavn = value;
            }
        }
        public int Alder 
        { 
            get 
            {
                return _alder;
            } 
            set
            {
                if( value > 0 && value < 150)
                {
                    _alder = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public Person Far
        {
            get
            {
                return _far;
            }
            set
            {
                if(value != null)
                {
                    _far = value;
                } 
                else
                {
                    throw new Exception();
                }
            }
        }
        public Person Mor
        {
            get
            {
                return _mor;
            }
            set
            {
                if (value != null)
                {
                    _mor = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

    }
    class PersonPrinter
    {
        public void PrintPerson(Person person)
        {
            //Fornavn Efternavn, Alder
            Console.WriteLine("{0} {1}, {2}", person.Fornavn, person.Efternavn, person.Alder);
        }
        public void PrintFamilytree(Person person)
        {
            if(person != null)
            {
                PrintPerson(person);
                PrintFamilytree(person.Far);
                PrintFamilytree(person.Mor);
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Person Sigurd = new Person();
            Sigurd.Fornavn = "Jacob";
            Sigurd.Efternavn = "Skadborg";
            Sigurd.Alder = 21;

            Person Joergen = new Person();
            Joergen.Fornavn = "Joergen";
            Joergen.Efternavn = "Skadborg";
            Joergen.Alder = 50;

            Person Anette = new Person();

            Anette.Fornavn = "Anette";
            Anette.Efternavn = "Skovgaard";
            Anette.Alder = 50;

            Sigurd.Far = Joergen;
            Sigurd.Mor = Anette;

            PersonPrinter personPrinter = new PersonPrinter();
            personPrinter.PrintFamilytree(Sigurd);

        }
    }
}