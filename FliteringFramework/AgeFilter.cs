namespace FilteringFramework
{
    public class AgeFilter : PersonFilter
    {
        private int Min;
        private int Max;

        public AgeFilter(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public override bool FilterPredicate(Person person)
        {
            return (person.Age >= Min && person.Age <= Max);
        }
    }
}