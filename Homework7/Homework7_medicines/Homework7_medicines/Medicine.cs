using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_medicines
{
    internal abstract class Medicine
    {
        public string _name;
        public int _cost;
        public Medicine(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }
        public int Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value < 0)
                {
                    _cost = 0;
                }
                else
                {
                    _cost = value;
                }
            }
        }
            

        public virtual void Print()
        {
            Console.WriteLine($"{Name}, Цена:{Cost} руб.");
            
        }

        public abstract void TypeOfUse();



    }
}
