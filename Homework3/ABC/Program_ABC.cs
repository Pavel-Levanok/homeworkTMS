﻿namespace ABC
{
    internal class Program_ABC
//        2. Пользователь вводит 3 целых числа A, B, C.
//Если каждое из чисел А и В больше 100 - вывести сообщение "Каждое из чисел А и В больше 100"
//Если только одно из чисел А и В четное  - вывести сообщение "Только одно из чисел А и В четное"
//Если бы одно из чисел А и В положительное  - вывести сообщение "Одно из чисел А и В положительное"
//Если каждое из чисел А, В, С кратно трем - вывести сообщение "Каждое из чисел А, В, С кратно трем"
//Если только одно из чисел А, В и С меньше 50 - вывести сообщение "Только одно из чисел А, В и С меньше 50"
//Если хотя бы одно из чисел А, В, С отрицательное - вывести сообщение "Одно из чисел А, В, С отрицательное"
//Например:
//-33 81 90:
//Одно из чисел А и В положительное
//Каждое из чисел А, В, С кратно трем
//Только одно из чисел А, В и С меньше 50
//Одно из чисел А, В, С отрицательное 

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 целых числа A, B, C");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > 100 && b > 100) 
                Console.WriteLine("Каждое из чисел А и В больше 100");
            if ((a % 2 == 0 && b % 2 == 1) || (a % 2 == 1 && b % 2 == 0)) 
                Console.WriteLine("Только одно из чисел А и В четное");
            if ((a > 0 && b < 0) || (a < 0 && b > 0)) 
                Console.WriteLine("Одно из чисел А и В положительное");
            if ((a % 3 == 0) && (b % 3 == 0) && (c % 3 == 0)) 
                Console.WriteLine("Каждое из чисел А, В, С кратно трем");
            if (((a < 50) && (b > 50) && (c > 50)) || ((a > 50) && (b < 50) && (c > 50)) || ((a > 50) && (b > 50) && (c < 50)))
                Console.WriteLine("Только одно из чисел А, В и С меньше 50");
            if (a < 0 || b < 0 || c < 0) 
                Console.WriteLine("Одно из чисел А, В, С отрицательное");


            Console.WriteLine("КОНЕЦ");
            Console.ReadKey();
        }
    }
}