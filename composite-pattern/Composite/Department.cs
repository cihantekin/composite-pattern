using composite_pattern.Component;

namespace composite_pattern.Composite
{
    public class Department : Employee
    {
        private List<Employee> employees;
        protected decimal MonthlyExpense { get; set; }
        public Department(string name, decimal monthlyExpense) : base(name, monthlyExpense)
        {
            MonthlyExpense = monthlyExpense;
        }

        public override decimal CalculateExpense()
        {
        }
    }
}
