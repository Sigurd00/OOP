namespace FilteringFramework
{
    public class AndFilter : PersonFilter
    {
        private PersonFilter Filter1;
        private PersonFilter Filter2;

        public AndFilter(PersonFilter filter1, PersonFilter filter2)
        {
            Filter1 = filter1;
            Filter2 = filter2;
        }
        public override bool FilterPredicate(Person person)
        {
            return Filter1.FilterPredicate(person) && Filter2.FilterPredicate(person);
        }
    }
}