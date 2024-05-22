using System;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1. Вариант 16. Написать программу, которая определяет: существует ли треугольник с длинами сторон a, b, c; Выполнила Лебедева Милана, гр. 353504\n\n");

            bool Continue = false;

            do
            {

                string a = "\0", b = "\0", c = "\0";
                double resA = CheckValue(a);
                double resB = CheckValue(b);
                double resC = CheckValue(c);

                if (resA + resB > resC && resB + resC > resA && resA + resC > resB)
                {
                    Console.WriteLine("\nТреугольник с вашими сторонами существует!\n");

                    string str = CheckString("\0");

                    switch (str)
                    {
                        case "1":
                            Continue = true;
                            break;

                        case "2":
                            Console.WriteLine("Программа завершена.");
                            Continue = false;
                            break;

                    }

                }
                else
                {
                    Console.WriteLine("\nТреугольник с вашими сторонами не существует!;((\n");

                    string str = CheckString("\0");

                    switch (str)
                    {
                        case "1":
                            Continue = true;
                            break;

                        case "2":
                            Console.WriteLine("Программа завершена.");
                            Continue = false;
                            break;

                    }
                }

                

            } while(Continue);

        }
        static double CheckValue(string s)
        {
            double value = 0;

            while (true)
            {
                Console.Write("Введите сторону треугольника: ");
                s = Console.ReadLine();

                if(IsHex(s))
                {
                    value = ConvertHexToDecimal(s);
                    return value;
                }

                if (double.TryParse(s, out value) && double.Parse(s) > 0) return value;
                
                else
                {
                    Console.Write("Неправильный ввод! Попробуй еще раз: ");
                }
            }
        }
        static string CheckString(string s)
        {
            while (true)
            {
                Console.WriteLine("Продолжить(1) или закончить(2):");
                s= Console.ReadLine();

                if (s == "1" || s == "2") return s;

                else
                {
                    Console.Write("Введите 1 либо 2: ");
                }
            }

        }

        static bool IsHex(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c) && !IsHexDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsHexDigit(char c)
        {
            return (c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f');
        }

        static double ConvertHexToDecimal(string s)
        {
            return Convert.ToInt32(s, 16);
        }
    }
}
