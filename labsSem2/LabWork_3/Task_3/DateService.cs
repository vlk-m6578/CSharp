using System;

namespace lab3._3
{
    internal class DateService
    {
        public static string GetDay(string date)
        {
            DateTime dateNormal;
            if(DateTime.TryParse(date, out dateNormal))
            {
                return dateNormal.DayOfWeek.ToString();
            }
            else
            {
                return dateNormal.DayOfWeek.ToString();
            }   
        }

        public static int GetDaysSpan(int day,int month,int year)
        {
            DateTime nowDate = DateTime.Now.Date;
            DateTime userDate = new DateTime(year, month, day);
            
            TimeSpan span = userDate - nowDate;
            return span.Days;
        }

        public static string DaysOfWeekInRussian(string date)
        {
            switch (date)
            {
                case "Monday":
                    date = "Понедельник";
                    break;
                case "Tuesday":
                    date = "Вторник";
                    break;
                case "Wednesday":
                    date = "Среда";
                    break;
                case "Thursday":
                    date = "Четверг";
                    break;
                case "Friday":
                    date = "Пятница";
                    break;
                case "Saturday":
                    date = "Суббота";
                    break;
                case "Sunday":
                    date = "Воскресенье";
                    break;
            }
            return date;
        }

    }
}
