using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    internal class Employee
    {
        private int _age;
        private string _name;
        private double _salary;

        
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 18)
                {
                    throw new ArgumentException("Ошибка! Ваш возраст менее 18 лет.");
                }

                else
                {
                    _age = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if ((value == null) || (value == ""))  
                {
                    throw new ArgumentNullException ("Ошибка! Имя не может быть пустым");
                }
                else
                {
                    if (value.Length >= 100)
                    {
                        throw new ArgumentException("Ошибка! Строка не может быть более 100 символов");
                    }
                    else
                    {
                        _name = value;
                    }                    
                }
            }
        }
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ошибка! Зарплата не может быть меньше или равной 0");
                }
                else
                {
                    _salary = value;
                }
            }
        }

    }
}
