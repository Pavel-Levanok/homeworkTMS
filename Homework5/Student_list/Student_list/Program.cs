namespace Student_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students_list = new Dictionary<string, int>()
            {
                {"Иванов",8 },
                {"Петров", 9 },
                {"Сидоров", 10 },
                {"Кузнецов",2 },
                {"Кулибин", 1 },
                {"Демченко", 5 }
            };

            Console.WriteLine("Существующий список учеников и его оценка:");
            foreach (KeyValuePair<string, int> mark in students_list)
            {
                Console.WriteLine($"{mark.Key}, {mark.Value}");
            }

            int response = 0;


            while (response != 9)
            {
                Console.WriteLine("Выберите действие (от 1 до 9):" + Environment.NewLine +
                "1. Ввести фамилию ученика для добавления" + Environment.NewLine +
                "2. Ввести фамилию ученика для изменения его оценки" + Environment.NewLine +
                "3. Ввести фамилию ученика для удаления его оценки" + Environment.NewLine +
                "4. Вывести список учеников и его оценку" + Environment.NewLine +
                "5. Вывести среднее арифметическое всех оценок" + Environment.NewLine +
                "6. Вывести фамилии учеников с максимальной оценкой" + Environment.NewLine +
                "7. Вывести фамилии учеников, которые имеют оценку большую или равную 8" + Environment.NewLine +
                "8. Фамилии учеников, которые имеют оценку меньшую или равную 4" + Environment.NewLine +
                "9. Выход");

                response = int.Parse(Console.ReadLine());

                Menu number_operation = (Menu)response;

                switch (number_operation)
                {
                    case Menu.Add:
                        {
                            //1) Добавить оценку ученика.Пользователь вводит строку с фамилией ученика и его оценку.Если такой ученик уже существует - вывести сообщение о том что такой ученик уже существует, если не существует -добавить ученика в словарь.
                            Console.WriteLine("1. Введите фамилию ученика для добавления");
                            string name = Console.ReadLine();
                            name = name.Trim();

                            if (students_list.ContainsKey(name))
                                Console.WriteLine("Такой ученик уже есть");
                            else
                            {
                                Console.WriteLine("Введите оценку");
                                int student_mark = int.Parse(Console.ReadLine());
                                students_list.Add(name, student_mark);
                            }
                            break;
                        }

                    case Menu.Change:
                        {


                            //2) Изменить оценку ученика.Пользователь вводит строку с фамилией ученика и его оценку.Если такой ученик не существует - вывести сообщение о том, что ученик не был найден, если существует -исправить оценку у ученика.

                            Console.WriteLine("2. Введите фамилию ученика для изменения его оценки");
                            string name = Console.ReadLine();
                            name = name.Trim();

                            if (students_list.ContainsKey(name))
                            {
                                Console.WriteLine("Введите новую оценку");
                                int mark_new = int.Parse(Console.ReadLine());
                                students_list[name] = mark_new;
                            }
                            else
                            {
                                Console.WriteLine("Такой ученик не найден");
                            }
                            break;
                        }

                    case Menu.Remove:
                        {
                            //3) Удалить оценку ученика.Пользователь вводит строку с фамилией ученика. Если ученик существует - удалить, если нет -вывести сообщение, что такой ученик не был найден.

                            Console.WriteLine("3. Введите фамилию ученика для удаления его оценки");
                            string name = Console.ReadLine();
                            name = name.Trim();

                            if (students_list.ContainsKey(name))
                            {
                                students_list.Remove(name);
                            }
                            else
                            {
                                Console.WriteLine("Такой ученик не найден");
                            }
                            break;
                        }

                    case Menu.List:
                        {
                            //4) Вывести всех учеников в виде: Фамилия - Оценка.
                            Console.WriteLine("Итоговый список учеников и его оценка:");
                            foreach (KeyValuePair<string, int> mark in students_list)
                            {
                                Console.WriteLine($"{mark.Key} - {mark.Value}");
                            }
                            break;
                        }

                    case Menu.Average:
                        {
                            //5) Вывести среднее арифметическое всех оценок.

                            int Sum = 0;
                            foreach (KeyValuePair<string, int> mark in students_list)
                            {
                                Sum += mark.Value;
                            }
                            Console.WriteLine($"5. Среднее арифметическое всех оценок = {Sum / students_list.Count}");
                            break;
                        }

                    case Menu.Best_mark:
                        {
                            //6) Вывести фамилии учеников, которые имеют самую высокую оценку среди одноклассников.
                            int max = 0;
                            foreach (KeyValuePair<string, int> mark in students_list)
                            {
                                if (mark.Value > max)
                                {
                                    max = mark.Value;
                                }
                            }
                            Console.WriteLine("6. Фамилии учеников с максимальной оценкой:");
                            foreach (KeyValuePair<string, int> mark in students_list)
                            {
                                if (mark.Value == max)
                                {
                                    Console.WriteLine(mark.Key);
                                }
                            }
                            break;

                        }

                    case Menu.Mark8:
                        {
                            //7) Вывести фамилии учеников, которые имеют оценку большую или равную 8.

                            Console.WriteLine("7. Фамилии учеников, которые имеют оценку большую или равную 8");
                            foreach (KeyValuePair<string, int> mark in students_list)
                            {
                                if (mark.Value >= 8)
                                {
                                    Console.WriteLine(mark.Key);
                                }
                            }
                            break;
                        }

                    case Menu.Mark4:
                        {
                            //8) Вывести фамилии учеников, которые имеют оценку меньшую или равную 4.

                            Console.WriteLine("8. Фамилии учеников, которые имеют оценку меньшую или равную 4");
                            foreach (KeyValuePair<string, int> mark in students_list)
                            {
                                if (mark.Value <= 4)
                                {
                                    Console.WriteLine(mark.Key);
                                }
                            }
                            break;
                        }

                    case Menu.Exit:
                        {
                            Console.WriteLine("Выход из программы");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Не верно. Введите от 1 до 9");
                            break;
                        }

                }






            }

            Console.ReadKey();
        }
    }
}