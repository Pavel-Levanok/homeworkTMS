using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_medicines
{
    internal class Tablet : Medicine
    {
        public int Amount { get; set; }

        public Tablet(string name, int cost, int amount) : base(name, cost)
        {
            Amount = amount;

        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Количество в упаковке {Amount} шт");
        }

        public override void TypeOfUse()
        {
            
            Console.WriteLine("Это же таблетки. Просто съешь утром.");
        }

    }
}
