using composite_pattern.Component;

namespace composite_pattern.Composite
{
    public class Department : Employee, IOperations<Employee> 
    {
        private readonly IList<Employee> employees;
        protected decimal MonthlyExpense { get; set; }

        public Department(string name, decimal monthlyExpense) : base(name, monthlyExpense)
        {
            MonthlyExpense = monthlyExpense;
            employees = new List<Employee>();
        }

        public override decimal CalculateExpense()
        {
            var totalExpenseForDepartment = MonthlyExpense;
            
            if (employees.Count > 0)
            {
                foreach (var employee in employees)
                {
                    totalExpenseForDepartment += employee.CalculateExpense();
                }
            }

            Console.WriteLine($"{Name} department total expenses (included Monthly expenses and employees salary:) {totalExpenseForDepartment}");
            return totalExpenseForDepartment;
        }

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public void Remove(Employee employee)
        {
            employees.Remove(employee);
        }
    }
}
