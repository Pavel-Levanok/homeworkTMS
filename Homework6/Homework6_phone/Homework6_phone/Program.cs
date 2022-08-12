namespace Homework6_phone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone("452685", "Samsung", 200d);
            Phone phone2 = new Phone("032432", "Nokia", 180d);
            Phone phone3 = new Phone("747775", "LG", -200d);
            Phone phone4 = new Phone("644654", "Sony", 170d);
            //Phone[] phones = new Phone[] { phone2, phone3, phone4 };
            //List<Phone> phones = new List<Phone>()
            //{
            //    new Phone("452685", "Samsung", 200d), phone2, phone3, phone4
            //};

            //foreach (Phone phone in phones)
            //{
            //    Console.WriteLine($"1. Номер:{phone.Number}, модель:{phone.Model}, вес: {phone.Weight} гр");
            //}
            Console.WriteLine($"1. Номер:{phone1.Number}, модель:{phone1.Model}, вес: {phone1.Weight} гр");
            Console.WriteLine($"2. Номер:{phone2.Number}, модель:{phone2.Model}, вес: {phone2.Weight} гр");
            Console.WriteLine($"3. Номер:{phone3.Number}, модель:{phone3.Model}, вес: {phone3.Weight} гр");
            Console.WriteLine($"4. Номер:{phone4.Number}, модель:{phone4.Model}, вес: {phone4.Weight} гр");
            
            phone1.RecieveCall("Вася");
            phone2.RecieveCall("Денис");
        }

        
    }
}