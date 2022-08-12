using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_medicines
{
    internal class Syrup : Medicine
    {
        public string Taste { get; set; }

        public Syrup(string name, int cost, string taste) : base(name, cost)
        {
            Taste = taste;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Вкус {Taste}");
        }

        public override void TypeOfUse()
        {
            Console.WriteLine("Это же сироп. Выпей ложку после еды.");
        }

    }
}
