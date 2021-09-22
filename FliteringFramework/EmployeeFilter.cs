namespace FilteringFramework
{
    public class EmployeeFilter : PersonFilter
    {
        public override bool FilterPredicate(Person person)
        {
            return person.IsEmployee;
        }
    }
}