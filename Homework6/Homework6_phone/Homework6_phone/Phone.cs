using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_phone
{
    public class Phone
    {
        public string _number;
        public string _model;   // это можно не писать, т.к. автоствойство - только get; set;
        public double _weight; 

        public Phone(string number, string model, double weight)
        {
            Number = number;
            Model = model;
            Weight = weight;
        }

        public string Number { get; private set; }
        // если нет set, то это значит что только рид онли. нельзя поменять поле
        public string Model { get; set; } // автосвойство

        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value < 0)
                {
                    _weight = 0;
                }
                else
                {
                    _weight = value;
                }
            }
        }
         
        public void RecieveCall(string name)
        {
            Console.WriteLine($"Вам звонит {name}");
        }


    }
}
