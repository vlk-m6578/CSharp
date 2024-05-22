using System;

namespace lab3._2
{
    internal class Check
    {
        public static string ContinuationAndTermination(string s)
        {

            while (true)
            {
                Console.Write("\nПродолжить(1)? Закончить(2)? ");
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

        public static double Double(string s)
        {
            double z;
            while (true)
            {
                Console.Write("Введите число z: ");
                s = Console.ReadLine();

                if (double.TryParse(s, out z))
                {
                    return z;
                }
                else
                {
                    Console.WriteLine("Неправильный ввод! ");
                }
            }
        }
    }
}
