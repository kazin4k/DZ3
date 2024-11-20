using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Лабораторная 4 главы (4.1, 4.2, 4.3)
        try
        {
            Console.WriteLine("Введите год:");
            string yearInput = Console.ReadLine();
            int year;

            if (!int.TryParse(yearInput, out year))
            {
                Console.WriteLine("Пожалуйста, введите корректное число для года.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите номер дня в году (1-365{366}):");
            string dayInput = Console.ReadLine();
            int day;

            if (!int.TryParse(dayInput, out day) || day < 1 || day > (ProverkaVis(year) ? 366 : 365))
            {
                Console.WriteLine($"Номер дня должен быть в диапазоне от 1 до {(ProverkaVis(year) ? 366 : 365)}.");
                Console.ReadKey();
                return;
            }

            DateTime date = new DateTime(year, 1, 1).AddDays(day - 1);
            Console.WriteLine($"Дата: {date.ToString("d MMMM")}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
            Console.ReadKey();
        }
        Console.ReadKey();
    }

    public static bool ProverkaVis(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
