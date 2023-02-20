using composite_pattern.Component;
using composite_pattern.Leaf;

namespace composite_pattern.Leaf
{
    public class BusinessAnalyst : Employee
    {
        public BusinessAnalyst(string name, decimal salary) : base(name, salary)
        {
        }

        public override decimal CalculateExpense()
        {
            Console.WriteLine($"My name is {Name} and I am working as a {nameof(BusinessAnalyst).PutSpaceBetweenWords()} in this company. My salary is {Salary}");
            return Salary;
        }
    }
}
