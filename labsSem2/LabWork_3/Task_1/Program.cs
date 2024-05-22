using System;

namespace lab3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №3. Задание 1. Вариант 6. Выполинла Лебедева Милана, 353504\n");

            bool Continue = false;
            do
            {

                string xString = "\0";
                double x = Check.Double(xString);

                //основная программа

                double res = Class.f(2, x) + Class.f(4, x) + Class.f(6, x);
                Console.WriteLine("\t\t\tx^2/2+x^4/4+x^6/6 = "+res+"\n");

                //основная программа

                //продолжить или закончить?
                string str = "\0";
                str = Check.ContinuationAndTermination(str);

                switch (str)
                {
                    case "1":
                        Continue = true;
                        break;
                    case "2":
                        Continue = false;
                        break;
                }

            } while (Continue);
        }
    }
}
