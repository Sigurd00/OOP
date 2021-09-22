namespace OOP
{
    public class Manager : Employee
    {
        private int Bonus;
        public Manager(string name, string jobTitle, double salary, int seniority, int bonus) 
            : base(name, jobTitle, salary, seniority)
        {
            Bonus = bonus;
        }

        public override double CalculateYearlySalary()
        {
            return base.CalculateYearlySalary() + Bonus;
        }
    }
}