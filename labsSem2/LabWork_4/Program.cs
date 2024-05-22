using System;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №4 Индивидульное задание вариант 6. Отдел кадров - Норма выработки. В классе \r\nхранить информацию о наименовании предприятия, числе работников, норму \r\nвыработки часов в месяц (одинаковая для всех работников - класс Норма \r\nвыработки), оплату за час, подоходный налог. Реализовать метод для подсчета \r\nобщей выплаты по подоходному налогу. Реализовать возможность изменения \r\n(увеличения и уменьшения) нормы выработки.\n\n");
            bool continueTheProgram = false;
            do
            {
                HRDepartment department = HRDepartment.GetInstance();

                Console.Write("Введите наименование предприятия: ");
                department.SetNameCompany(Console.ReadLine());

                Console.Write("Введите число работников: ");
                department.SetEmployees(CheckingForInput.Int(Conversion.IntToString(department.GetCountEmployees())));

                Console.Write("Введите норму выработки часов в месяц: ");
                department.SetProdictionRate(CheckingForInput.Int(Conversion.IntToString(department.GetProductionRate())));
                
                Console.Write("Введите оплату за час: ");
                department.SetPayForHour(CheckingForInput.Double(Conversion.DoubleToString(department.GetPayForHour())));

                Console.Write("Введите подоходный налог(%): ");
                department.SetTax(CheckingForInput.Percent(Conversion.IntToString(department.GetTax())));

                double result1 = department.CalculateTax();
                Console.Write("\tОбщая выплата по подоходному налогу составляет " + result1 + ".");

                Console.Write("\nВведите количество часов для увеличения нормы выработки: ");
                int increaseHours = 0;
                increaseHours = CheckingForInput.IncreaseAndDecrease(Conversion.IntToString(increaseHours));
                department.IncreaseProductionRate(increaseHours);

                Console.Write("\nВведите количество часов для уменьшения нормы выработки: ");
                int decreaseHours = 0;
                decreaseHours = CheckingForInput.IncreaseAndDecrease(Conversion.IntToString(decreaseHours));
                department.DecreaseProductionRate(decreaseHours);

                double result2 = department.CalculateTax();
                Console.WriteLine("\tОбщая выплата по подоходному налогу составляет " + result2 + ".");

                Console.Write("\nПродолжить(1)? Закончить(2)? ");
                string str = "\0";
                str = CheckingForInput.ContinuationAndTermination(str);
                switch (str)
                {
                    case "1": 
                        continueTheProgram = true;
                        break;
                    case "2": 
                        continueTheProgram = false;
                        break;
                }
            }while (continueTheProgram);
        }
    }
}
