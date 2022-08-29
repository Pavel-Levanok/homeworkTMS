using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    public delegate int Salary_delegate(Employee employee);
    public class Employee
    {
        private int _experience;
        public string Name { get; set; }
        public int Age { get; set; }
        public int Experience
        {
            get => _experience;
            set
            {
                if (value < 0)
                {
                    _experience = 0;
                    
                }
                else
                {
                    _experience = value;
                }
            }
        }
        //public int Experience { get; set; }
        public bool HighEducation { get; set; }
        public Employee(string name, int age, int experience, bool highEducation)
        {
            Name = name;
            Age = age;
            Experience = experience;
            HighEducation = highEducation;
        }

        public virtual void Print()
        {
            string educ = "нет";
            if (HighEducation)
            {
                educ = "да";
            }
            Console.WriteLine($" {Name}, возраст:{Age}, опыт: {Experience}, высшее образование: {educ}.");

        }

        public static void Salary(List<Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                int salary = 0;
                if (employee.HighEducation)
                {
                    salary = (employee.Experience + 1) * 1250;
                }
                else
                {
                    salary = (employee.Experience + 1) * 1000;
                }
                Console.WriteLine($" {employee.Name}, зарплата:{salary}");
            }


        }

        public static void Salary2(List<Employee> employeeList, Salary_delegate salary_Delegate)
        {
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($" {employee.Name}, зарплата:{salary_Delegate(employee)}");
            }

        }







    }
}
