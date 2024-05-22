using System;



namespace lab2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2. Вариант 16. Дана точка на плоскости с координатами (х, у). Составить программу, \r\nкоторая выдает одно из сообщений \"Да\", \"Нет\", \"На границе\" в зависимости от \r\nтого, лежит ли точка внутри заштрихованной области, вне заштрихованной \r\nобласти или на ее границе. Выполнила Лебедева Милана, гр. 353504\n\n");

            bool Continue = false;

            do
            {
                double resX = CheckValue("\0");
                double resY = CheckValue("\0");

                if(((resX>=0&&resX<=10) && resY==0)||(resX==0 && (resY>=0&&resY<=5))||((resX>=0&&resX<=10) && resY==5)||((resY>=0&&resY<=5)&&resX==10))
                {
                    Console.WriteLine("Точка лежит на границе.");

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
                else if((resX>0&&resX<10)&&(resY>0&&resY<5))
                {
                    Console.WriteLine("Точка лежит внутри области. ");

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
                    Console.WriteLine("Точка не лежит внутри области. ");

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

            }while (Continue);
        }

        static double CheckValue(string s)
        {
            double value;
            while (true)
            {
                Console.Write("Введите координату: ");
                s = Console.ReadLine();

                if (double.TryParse(s, out value)) return value;
                else
                {
                    Console.Write("Неправильный ввод;(Попробуй еще раз!");
                }
            }
        }

        static string CheckString(string s)
        {

            while(true)
            {
                Console.WriteLine("Продолжить(1) или закончить(2): ");
                s = Console.ReadLine();

                if (s == "1" || s == "2") return s;
                else
                {
                    Console.Write("Введите 1 либо 2: ");
                }
            }


        }
    }
}
