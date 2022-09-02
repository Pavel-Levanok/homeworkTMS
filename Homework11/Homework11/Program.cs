namespace Homework11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Employee employee = new Employee();

                Console.WriteLine("Введите имя:");
                employee.Name = Console.ReadLine();
                Console.WriteLine("Введите возраст:");
                employee.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите зарплату:");
                employee.Salary = double.Parse(Console.ReadLine());
                
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            finally
            {
                Console.WriteLine("finally");
                
            }

        }
    }
}