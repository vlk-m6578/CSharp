using System;

namespace lab6
{
    internal sealed class Chocolate : Dessert
    {
        private string origin;
        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }
        public override void PrintStatus()
        {
            Console.WriteLine("Шоколад готов!");
        }

        public new void PrintInformation()
        {
            if (isHaveDessert)
            {
                Console.WriteLine("Шоколад: " + Name + ". Цена: " + Price + ". Происхождение: " + origin);
            }
            else
            {
                base.PrintInformation();
            }
        }

        public override void CreateDessert()
        {
            isHaveDessert = true;

            Console.Write("Введите название шоколада: ");
            Name = Console.ReadLine();
            Console.Write("Введите цену шоколада: ");
            Price = CheckingForInput.Double(Price.ToString());
            Console.Write("Введите происхождение шоколада: ");
            Origin = Console.ReadLine();
            PrintStatus();

        }
    }
}
