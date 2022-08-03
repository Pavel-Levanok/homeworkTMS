namespace Homework3
{
    internal class Calculator
        //Сделать консольный калькулятор.Пользователь вводит два целых числа и операцию(+,-,/,)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATOR");
            Console.WriteLine("PLease, Enter your 2 numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your operetion: +,-,/");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Your Result:{a + b}");
                    break;

                case "-":
                    Console.WriteLine($"Your Result:{a - b}");
                    break;

                case "/":
                    Console.WriteLine($"Your Result:{a / b}");
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
            Console.ReadKey();

        }
    }
}