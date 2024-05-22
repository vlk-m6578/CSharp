using System;

namespace lab3._3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №3. Задание 3. В отдельном файле описать класс DateService.\r\nКласс должен предоставлять следующие методы:\r\nОпределять день недели произвольной даты, передаваемой методу в качестве \r\nстрокового параметра (например GetDay(string date)\r\nОпределять, сколько дней пройдет между текущей датой и датой,\r\nпередаваемой методу в качестве числовых параметров: день, месяц, год\r\n(например GetDaysSpan(int day, int month, int year);\r\nВыполнила Лебедева Милана, 353504\n");

            bool Continue = false;
            do
            {

                string date = "\0";
                date = Check.Date(date);

                int day = (date[0] - '0') * 10 + (date[1] - '0');
                int month = (date[3] - '0') * 10 + (date[4] - '0');
                int year = (date[6] - '0') * 1000 + (date[7] - '0') * 100 + (date[8] - '0') * 10 + (date[9] - '0');

                date = DateService.GetDay(date);
                Console.WriteLine("День недели числа введенной даты - " + DateService.DaysOfWeekInRussian(date) + ".");

                
                int days = DateService.GetDaysSpan(day, month, year);
                if(days>=0) Console.WriteLine("Между текущей датой и введенной датой пройдет " + days + " дней/дня.\n\n");
                else Console.WriteLine("Между текущей датой и введенной датой прошло "+(-days)+" дней/дня.\n\n");

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


            } while (Continue);

        }
       
    }

}
