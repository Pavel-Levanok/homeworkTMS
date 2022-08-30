using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public delegate void NotifyWarmUpCompleted(string dish);
    internal class Microwave
    {
        public event NotifyWarmUpCompleted WarmUpCompleted;
        
        public void WarmUp(string dish)
        {
            Console.WriteLine($"Подогреваю {dish}");
            WarmUpCompleted?.Invoke(dish);
        }
    }
}
