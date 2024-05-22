using System;

namespace lab3._3
{
    internal class Check
    {
        public static string Date(string date)
        {
            while (true)
            {
                DateTime dateNormal;
                Console.Write("Введите дату: ");
                date = Console.ReadLine();

                if (DateTime.TryParse(date, out dateNormal))
                {
                    return date;
                }
                else
                {
                    Console.WriteLine(" Неправильный ввод!");
                }
            }
        }

        public static string ContinuationAndTermination(string s)
        {
            while (true)
            {
                Console.Write("Продолжить(1)? Закончить(2)? ");
                s = Console.ReadLine();

                if (s == "1" || s == "2")
                {
                    return s;
                }
                else
                {
                    Console.WriteLine(" Неправильный ввод!");
                }
            }

        }
    }
}
