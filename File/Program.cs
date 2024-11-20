using System;
using System.Collections.Generic;

namespace File
{
    internal class Program
    {
        public string Karta(int k)
        {
            switch (k)
            {
                case 6: return "Шестёрка";
                case 7: return "Семерка";
                case 8: return "Восьмерка";
                case 9: return "Девятка";
                case 10: return "Десятка";
                case 11: return "Валет";
                case 12: return "Дама";
                case 13: return "Король";
                case 14: return "Туз";
                default: throw new ArgumentOutOfRangeException("Число должно быть от 6 до 14\r\n");
            }
        }

        public enum DayOfWeek
        {
            Понедельник = 1,
            Вторник = 2,
            Среда = 3,
            Четверг = 4,
            Пятница = 5,
            Суббота = 6,
            Воскресенье = 7
        }
        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine("Задание 1");
            int[] array = new int[10];
            Console.WriteLine("Введите 10 чисел (в столбик)");
            for (int i = 0; i < array.Length; i++) 
            {
                string number = Console.ReadLine();
                if (int.TryParse(number, out int result))
                {
                    array[i] = result;
                }
            }

            bool flag = false;
            int nomer = 0;

            for (int i = 0;i < array.Length-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    flag = true;
                    nomer = i+2;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine($"Последовательность не возрастающая, порядковый номер первого числа, которое нарушает данную последовательность: {nomer}\r\n");
            }
            else
            {
                Console.WriteLine("Последовательность возрастающая\r\n");
            }



            //Задание 2
            Console.WriteLine("Задание 2");
            Program prog = new Program();
            try
            {
                Console.WriteLine("Введите номер карты (6-14)");
                string input = Console.ReadLine();
                int k;

                if (!int.TryParse (input, out k))
                {
                    throw new FormatException("Некорректный ввод\r\n");
                }

                if (k<6 || k>14)
                {
                    throw new ArgumentOutOfRangeException("Номер карты должен быть в диапазоне от 6 до 14\r\n");
                }

                string volume = prog.Karta(k);
                Console.WriteLine ($"Достоинство карты: {volume}\r\n");

            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}\r\n");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}\r\n");
            }

            //Задание 3
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите строку:");
            string stroka = Console.ReadLine();
            string reg = stroka.ToLower();

            string res;

            switch (reg)
            {
                case "jabroni":
                    res = "Patron Tequila";
                    break;
                case "school counselor":
                    res = "Anything with Alcohol";
                    break;
                case "programmer":
                    res = "Hipster Craft Beer";
                    break;
                case "bike gang member":
                    res = "Moonshine";
                    break;
                case "politician":
                    res = "Your tax dollars";
                    break;
                case "rapper":
                    res = "Cristal";
                    break;
                default:
                    res = "Beer";
                    break;
            }
            Console.WriteLine(res + "\r\n");

            //Задание 4
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите порядковый номер дня недели:");
            string num = Console.ReadLine();

            if (int.TryParse(num, out int day))
            {
                if (1 <= day && day <= 7)
                {
                    DayOfWeek result = (DayOfWeek)day;
                    Console.WriteLine($"{result}\r\n");
                }
                else
                {
                    Console.WriteLine("Ошибка: Число должно быть в пределах от 1 до 7\r\n");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введите целое число\r\n");
            }
            

            //Задание 5
            Console.WriteLine("Задание 5");

            string[] toys = new string[10]
            {
            "Optimus Prime",
            "Barbie Doll",
            "Sombrero",
            "C#",
            "Barbie Doll",
            "Barbie Doll",
            "Hello Kitty",
            "Kavasaki",
            "Barbie Doll",
            "Barbie Doll"
            };

            List<string> bag =new List<string>();

            foreach (string item in toys)
            {
                if (item == "Barbie Doll" || item == "Hello Kitty")
                {
                    bag.Add(item);
                }
            }
            Console.WriteLine($"Количество кукол в сумке: {bag.Count}");
            Console.ReadKey();
            
        }
    }
}
