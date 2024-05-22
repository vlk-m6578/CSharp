using System;

namespace lab3._1
{
    internal class Check
    {
        public static double Double(string s)
        {
            double x;
            while (true)
            {
                Console.Write("Введите вещественное число x: ");
                s = Console.ReadLine();

                if (double.TryParse(s, out x))
                {
                    return x;
                }
                else
                {
                    Console.Write("Неправильный ввод! ");
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
                    Console.WriteLine("Неправильный ввод! ");
                }
            }
        }

    }
}
