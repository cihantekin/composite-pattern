using composite_pattern.Component;

namespace composite_pattern.Leaf
{
    public class Developer : Employee
    {
        public Developer(string name, decimal salary) : base(name, salary) {}

        public override decimal CalculateExpense()
        {
            Console.WriteLine($"My name is {Name} and I am working as a {nameof(Developer)} in this company. My salary is {Salary}");
            return Salary;
        }
    }
}
