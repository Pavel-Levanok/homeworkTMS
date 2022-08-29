namespace Homework9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>
            {
                new Employee("Иванов", 36, 5, true),
                new Employee("Демидов", 20, 1, false),
                new Employee("Пучков", 55, 30, true),
                new Employee("Демчук", 18, 0, false),
                new Employee("Пушкарева", 25, 5, true),
            };

            Console.WriteLine("Список работников:");
            foreach (Employee employee in employeeList)
            {
                employee.Print();
            }

            Employee.Salary(employeeList);

            Console.WriteLine("Зарплата, посчитанная с делегатом:");
            Employee.Salary2(employeeList, GetSalary);

            static int GetSalary(Employee employee)
            {
                return (employee.Experience + 1) * 1000;

            }

            Console.WriteLine("Зарплата, посчитанная через лямбда-функцию:");
            Employee.Salary2(employeeList, (Employee employee) =>
            {
                return (employee.Experience + 1) * 1500;
            });

            Console.ReadKey();


        }
    }
}