using composite_pattern.Component;

namespace composite_pattern.Composite
{
    public class Company : Department, IOperations<Department>
    {
        protected decimal GeneralExpenses { get; set; }
        private readonly IList<Department> departments;

        public Company(string name, decimal generalExpenses) : base(name, generalExpenses)
        {
            GeneralExpenses = generalExpenses;
            departments = new List<Department>();
        }

        public void Add(Department obj)
        {
            departments.Add(obj);
        }

        public void Remove(Department obj)
        {
            departments.Remove(obj);
        }

        public override decimal CalculateExpense()
        {
            var totalExpenseForCompany = GeneralExpenses;

            if (departments.Count > 0)
            {
                foreach (var department in departments)
                {
                    totalExpenseForCompany += department.CalculateExpense();
                }
            }

            Console.WriteLine($"{Name} company total expenses (included General expenses for company and departmentexpenses :) {totalExpenseForCompany}");
            return totalExpenseForCompany;
        }
    }
}
