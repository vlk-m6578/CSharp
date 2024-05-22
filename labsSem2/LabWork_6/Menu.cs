using System;

namespace lab6
{
    internal class Menu
    {
        string labNumber;
        string taskNumber;
        string optionNumber;
        string taskDescription;
        string studentData;
        string studentGroup;
        public Menu(string labNumber, string taskNumber, string optionNumber, string taskDescription, string studentData, string studentGroup)
        {
            this.labNumber = labNumber;
            this.taskNumber = taskNumber;
            this.optionNumber = optionNumber;
            this.taskDescription = taskDescription;
            this.studentData = studentData;
            this.studentGroup = studentGroup;
        }

        public void ShowInfo()
        {
            Console.Write("Лабораторная работа  № " + labNumber);
            Console.Write(". Индивидуальное задание " + taskNumber);
            Console.Write(". Вариант " + optionNumber);
            Console.Write(". Условие: " + taskDescription);
            Console.Write(". \nВыполнила " + studentData);
            Console.Write(", " + studentGroup + "\n\n");
        }

        public static void MainMenu()
        {
            Console.WriteLine("\nВыбери: ");
            Console.WriteLine("1)Создать десерт ТОРТ");
            Console.WriteLine("2)Создать десерт МОРОЖЕНОЕ");
            Console.WriteLine("3)Создать десерт ШОКОЛАД");
            Console.WriteLine("4)Получить информацию о торте");
            Console.WriteLine("5)Получить информацию о мороженом");
            Console.WriteLine("6)Получить инфоомацию о мороженом(с перегрузкой)");
            Console.WriteLine("7)Получить информацию о шоколаде");
            Console.WriteLine("8)Продемонстрировать вызов конструктора родительского класса при наследовании(Cоздание Cake)");
            Console.Write("9)Выход из программы.");


            //Cake cake = new Cake();
            //IceCream iceCream = new IceCream();
            //Chocolate chocolate = new Chocolate();

            //Console.Write("Сколько десертов хотите создать? ");
            //int n = 0;
            //n = CheckingForInput.Int(n.ToString());
            //if(n==0)
            //{
            //    Console.WriteLine("Конец программы.");
            //}
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write("\nНажмите (1), если хотите создать торт\nНажмите (2), если хотите создать мороженое\nНажмите (3), если хотите создать шоколад: ");
            //string choice = "\0";
            //choice = CheckingForInput.Choice(choice);
            //    switch (choice)
            //    {
            //        case "1":
            //            Console.Write("Введите название торта: ");
            //            cake.Name = Console.ReadLine();
            //            Console.Write("Введите цену торта: ");
            //            cake.Price = CheckingForInput.Double(cake.Price.ToString());
            //            Console.Write("Введите количество ярусов для торта: ");
            //            cake.Count = CheckingForInput.Int(cake.Count.ToString());
            //            cake.PrintStatus();
            //            cake.PrintInformation();
            //            cake.CountOfSlices();
            //            break;
            //        case "2":
            //            Console.WriteLine("Введите название мороженого: ");
            //            iceCream.Name = Console.ReadLine();
            //            Console.Write("Введите цену мороженого: ");
            //            iceCream.Price = CheckingForInput.Double(iceCream.Price.ToString());
            //            Console.Write("Введите количество шариков мороженого: ");
            //            iceCream.Count = CheckingForInput.Int(iceCream.Count.ToString());
            //            iceCream.PrintStatus();
            //            iceCream.PrintInformation();
            //            iceCream.CountOfSlices();
            //            break;
            //        case "3":
            //            Console.Write("Введите название шоколада: ");
            //            chocolate.Name = Console.ReadLine();
            //            Console.Write("Введите цену шоколада: ");
            //            chocolate.Price = CheckingForInput.Double(chocolate.Price.ToString());
            //            Console.Write("Введите происхождение шоколада: ");
            //            chocolate.Origin = Console.ReadLine();
            //            chocolate.PrintStatus();
            //            chocolate.PrintInformation();
            //            chocolate.CountOfSlices();
            //            break;
            //    }
            //}



        }
    }
}
