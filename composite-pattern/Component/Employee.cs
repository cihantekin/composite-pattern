namespace composite_pattern.Component
{
    public abstract class Employee
    {
        protected string Name { get; set; }
        protected decimal Salary { get; set; }

        protected Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public abstract decimal CalculateExpense();
    }
}
