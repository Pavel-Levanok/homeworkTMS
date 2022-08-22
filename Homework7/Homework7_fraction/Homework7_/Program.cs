namespace Homework7_fraction
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(3, -27);
            Fraction fraction2 = new Fraction(6, 24);

            Console.WriteLine("Есть две следующие дроби:");
            Fraction.Print(fraction1);
            Fraction.Print(fraction2);


            if ((fraction1.Denominator == 0) || (fraction2.Denominator == 0)) 
                    {
                Console.WriteLine("Ошибка! Знаменатель равен 0. Введите другие дроби");
            }

            if ((fraction1.Denominator < 0) && (fraction1.Nominator < 0))
            {
                fraction1.Denominator = -1 * fraction1.Denominator;
                fraction1.Nominator = -1 * fraction1.Nominator;
            }

            if ((fraction2.Denominator < 0) && (fraction2.Nominator < 0))
            {
                fraction2.Denominator = -1 * fraction2.Denominator;
                fraction2.Nominator = -1 * fraction2.Nominator;
            }

            if (fraction1.Denominator < 0) 
            {
                fraction1.Denominator = -1 * fraction1.Denominator;
                fraction1.Nominator = -1 * fraction1.Nominator;
            }

            if (fraction2.Denominator < 0)
            {
                fraction2.Denominator = -1 * fraction2.Denominator;
                fraction2.Nominator = -1 * fraction2.Nominator;
            }
            
            int nod1 = fraction1.Nod(fraction1);
            if (nod1 != 0)
            {
                fraction1.Nominator = fraction1.Nominator / nod1;
                fraction1.Denominator = fraction1.Denominator / nod1;
            }
            
            int nod2 = fraction2.Nod(fraction2);
            if (nod2 != 0)
            {
                fraction2.Nominator = fraction2.Nominator / nod2;
                fraction2.Denominator = fraction2.Denominator / nod2;
            }
            if ((nod1 != 0) || (nod2 != 0))
            {
                Console.WriteLine("Ваши дроби после сокращения и привидения их в нормальный вид:");
                Fraction.Print(fraction1);
                Fraction.Print(fraction2);
            }

            Fraction Sum = Fraction.Sum(fraction1, fraction2);
            int nod3 = Sum.Nod(Sum);
            if (nod3 != 0)
            {
                Sum.Nominator = Sum.Nominator / nod3;
                Sum.Denominator = Sum.Denominator / nod3;
            }
            Console.WriteLine("Результат СУММЫ дробей:");
            Fraction.Print(Sum);

            Fraction Subtraction = Fraction.Subtraction(fraction1, fraction2);
            int nod4 = Subtraction.Nod(Subtraction);
            if (nod4 != 0)
            {
                Subtraction.Nominator = Subtraction.Nominator / nod4;
                Subtraction.Denominator = Subtraction.Denominator / nod4;
            }
            Console.WriteLine("Результат ВЫЧИТАНИЯ дробей:");
            Fraction.Print(Subtraction);

            Console.WriteLine("Результат УМНОЖЕНИЯ дробей:");                   
            Fraction.Print(Fraction.Multiplication(fraction1, fraction2));
                      

            Console.WriteLine("Результат ДЕЛЕНИЯ дробей:");
            Fraction.Print(Fraction.Division(fraction1, fraction2));

            
            Console.WriteLine("Значения дробей в формате double:");
            Console.WriteLine(fraction1.toDouble(fraction1));
            Console.WriteLine(fraction2.toDouble(fraction2));






        }
    }
}