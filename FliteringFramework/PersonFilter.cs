namespace FilteringFramework
{
    public abstract class PersonFilter
    {
        public abstract bool FilterPredicate(Person person);

        public virtual List<Person> Filter(List<Person> plist)
        {
            List<Person> result = new List<Person>();
            foreach (Person p in plist)
            {
                if(FilterPredicate(p))
                {
                    result.Add(p);
                }
            }
            return result;
        }
    }
}