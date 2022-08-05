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
        public string _model;
        public double _weight;

        public Phone(string number, string model, double weight)
        {
            Number = number;
            Model = model;
            Weight = weight;
        }

        public string Number { get; private set; }
        public string Model { get; set; }
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (_weight < 0)
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
