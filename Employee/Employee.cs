namespace OOP
{
    public class Employee
    {
        private string Name;
        private string JobTitle;
        private double Salary;
        private int Seniority;
        public Employee(string name, string jobTitle, double salary, int seniority)
        {
            Name = name;
            JobTitle = jobTitle;
            if (seniority > 0 && seniority < 10)
            {
                
                Seniority = seniority;
                Salary = salary * (1.0 + (0.1 * seniority));

            }
            else
            {
                Seniority = seniority;
                Salary = salary;
            }
        }

        public virtual double CalculateYearlySalary() { 
            return Salary * 12;
        }
    }
}