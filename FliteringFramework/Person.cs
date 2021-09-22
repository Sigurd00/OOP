namespace FilteringFramework
{
    public class Person
    {
        public Person(string name, int age, bool isEmployee)
        {
            Name = name;
            Age = age;
            IsEmployee = IsEmployee;
            
        }

        public string Name {  get; set; }
        public int Age {  get; set; }
        public bool IsEmployee {  get; set; }
    }
}