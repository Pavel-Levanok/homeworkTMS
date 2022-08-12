using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_medicines
{
    internal class Ointment : Medicine
    {
        public int Volume { get; set; }
        public Ointment(string name, int cost, int volume) : base (name, cost)
        {
            Volume = volume;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Объем {Volume} мл");
        }

        public override void TypeOfUse()
        {
            Console.WriteLine("Это же мазь. Намазать куда следует.");
        }
    }
}
