using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_fraction
{
    internal class Fraction
    {
        //public int _nominator;
        //public int _denominator;

        public Fraction(int nominator, int denominator)
        {

            Nominator = nominator;
            Denominator = denominator;
        }

        public int Nominator { get; set; }
        public int Denominator { get; set; }

        internal static void Print(Fraction fraction)
        {
            Console.WriteLine($"{fraction.Nominator}/{fraction.Denominator}");

        }

        public int Nod(Fraction fraction)
        {
            int nominator = fraction.Nominator;
            int denominator = fraction.Denominator;
            nominator = Math.Abs(nominator);
            denominator = Math.Abs(denominator);
            while (denominator != 0 && nominator != 0)
            {
                if (nominator % denominator > 0)
                {
                    var temp = nominator;
                    nominator = denominator;
                    denominator = temp % denominator;
                }
                else break;
            }
            if (denominator != 0 && nominator != 0) return denominator;
            return 0;
        }

        internal static Fraction Sum(Fraction fraction1, Fraction fraction2)
        {
            Fraction result_Sum = new Fraction(fraction1.Nominator * fraction2.Denominator + fraction2.Nominator * fraction1.Denominator, fraction1.Denominator * fraction2.Denominator);
            return result_Sum;
        }

        internal static Fraction Subtraction(Fraction fraction1, Fraction fraction2)
        {
            Fraction result_Subtraction = new Fraction(fraction1.Nominator * fraction2.Denominator - fraction2.Nominator * fraction1.Denominator, fraction1.Denominator * fraction2.Denominator);
            return result_Subtraction;
        }



        internal static Fraction Multiplication(Fraction fraction1, Fraction fraction2)
        {
            Fraction result_Multiplication = new Fraction(fraction1.Nominator * fraction2.Nominator, fraction1.Denominator * fraction2.Denominator);
            if (result_Multiplication.Denominator < 0)
            {
                result_Multiplication.Denominator = -1 * result_Multiplication.Denominator;
                result_Multiplication.Nominator = -1 * result_Multiplication.Nominator;
            }
            return result_Multiplication;
        }


        internal static Fraction Division(Fraction fraction1, Fraction fraction2)
        {
            Fraction result_division = new Fraction(fraction1.Nominator * fraction2.Denominator, fraction1.Denominator * fraction2.Nominator);
            if (result_division.Denominator < 0)
            {
                result_division.Denominator = -1 * result_division.Denominator;
                result_division.Nominator = -1 * result_division.Nominator;
            }
            return result_division;
        }

        public double toDouble(Fraction fraction)
        {
            double result = (double)fraction.Nominator / (double)fraction.Denominator;
            return result;

        }




    }
}
