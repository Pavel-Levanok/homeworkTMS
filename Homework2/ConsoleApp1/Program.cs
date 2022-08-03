namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
            //Вычислить факториал числа, которое ввел пользователь.
        {
            Console.WriteLine("Enter your number");
            int a = int.Parse(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= a; i++)
            {
                f = f * i;
            }
            Console.WriteLine($"Factorial is {f}");
            Console.ReadKey();
        }
    }
}