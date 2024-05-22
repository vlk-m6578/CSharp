using System;
using lab3._2.Services;

namespace lab3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №3. Задание 2. Вариант 16. Найти значение функции y = (sin(x))^2 + (cos(x^3))^5 + ln(x^2/5)\nВыполнила Лебедева Милана, 353504\n");

            bool Continue = false;
            do
            {
                string zString = "\0";
                double z = Check.Double(zString);

                //основное задание

                string vetka = Class.Vetka(z);
                double res = Class.Result(z);
                
                if(res==-1)
                {
                    Console.WriteLine("Число z = " + z + " не удовлетворяет области определения функции y.");
                }
                else
                {
                    Console.WriteLine("Значение функции y при z = " + z + " равен " + res);
                    Console.WriteLine("\n" + vetka);
                }

                //основное задание

                string str = "\0";
                str = Check.ContinuationAndTermination(str);
                
                switch(str)
                {
                    case "1":
                        Continue = true;
                        break;
                    case "2":
                        Continue = false;
                        break;
                }


            }while (Continue);
        }

    }
}
