namespace FilteringFramework
{
    public class NotFilter : PersonFilter
    {
        private new readonly PersonFilter Filter;
        public NotFilter(PersonFilter filter)
        {
            Filter = filter;
        }

        public override bool FilterPredicate(Person person)
        {
            return !Filter.FilterPredicate(person);
        }
    }
}