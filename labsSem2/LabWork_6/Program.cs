using System;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Cake cake = new Cake();
            IceCream iceCream = new IceCream();
            Chocolate chocolate = new Chocolate();
            Console.Clear();

            Menu menuLab = new Menu("6", "1", "16", "Изучить механизмы наследования в C#. Индивидуальное задание: Десерты", "Лебедева Милана", "353504");
            menuLab.ShowInfo();
            Console.WriteLine("Добро пожаловать в магазин десертов!\n");
            Menu.MainMenu();

            int choice = 0;
            do
            {
                Console.Write("\nВыбор: ");
                choice = CheckingForInput.Choice(choice.ToString());
                switch(choice)
                {
                    case 1:
                        cake.CreateDessert();
                        break;
                    case 2:
                        iceCream.CreateDessert();
                        break;
                    case 3:
                        chocolate.CreateDessert();
                        break;
                    case 4:
                        cake.PrintInformation();
                        break;
                    case 5:
                        iceCream.PrintInformation();
                        break;
                    case 6:
                        iceCream.PrintInformation("Мороженое содержит около 125 килокалорий!");
                        break;
                    case 7:
                        chocolate.PrintInformation();
                        break;
                    case 8:
                        Cake cake1 = new Cake();
                        break;
                    case 9:
                        break;
                }


            } while (choice!=9);
        }
    }
}
