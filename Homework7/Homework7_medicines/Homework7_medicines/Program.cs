namespace Homework7_medicines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medicine[] medicinesArray = new Medicine[]
            {
                new Ointment("Демиксид", 20, 200),
                new Ointment("Фастум", 20, 200),
                new Tablet("Нолипрел", -20, 30),
                new Tablet("Эутирокс", 11, 100),
                new Syrup("Амбраксол", 45, "вишневый"),
                new Syrup("От простуды", 40, "малиновый"),
            };   

            foreach (var medicine in medicinesArray)
            {
                medicine.Print();
                medicine.TypeOfUse();
                Console.WriteLine("====================================");
            }

            
        }
    }
}