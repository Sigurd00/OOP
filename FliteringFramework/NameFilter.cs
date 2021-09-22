namespace FilteringFramework
{
    public class NameFilter : PersonFilter
    {
        private string Name;

        public NameFilter(string name)
        {
            Name = name;
        }

        public override bool FilterPredicate(Person person)
        {
            return person.Name == Name;
        }
    }
}