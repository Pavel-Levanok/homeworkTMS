namespace Homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Microwave microwave1 = new Microwave();
            microwave1.WarmUpCompleted += WarmUpCompletedHandler;
            microwave1.WarmUp("Хот Дог");
            microwave1.WarmUp("Пицца");
        }
        public static void WarmUpCompletedHandler(string dish)
        {
            Console.WriteLine($"Ваша еда готова: {dish}");
        }
    }
}