using System;

namespace lab6
{
    internal class Cake : Dessert
    {
        protected int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public override void PrintStatus()
        {
            Console.WriteLine("Торт готов!");
        }
        public void CountOfSlices()
        {
            Console.Write("Количество ярусов торта: " + count);
        }
        public override void CreateDessert()
        {
            isHaveDessert = true;
           
            Console.Write("Введите название торта: ");
            Name = Console.ReadLine();
            Console.Write("Введите цену торта: ");
            Price = CheckingForInput.Double(Price.ToString());
            Console.Write("Введите количество ярусов для торта: ");
            Count = CheckingForInput.Int(Count.ToString());
            PrintStatus();
        }
        public new void PrintInformation()
        {
            if(isHaveDessert)
            {
                Console.Write("Торт: " + Name + ". Цена: " + Price + ". ");
                CountOfSlices();
            }
            else
            {
                base.PrintInformation();
            }
        }
        public Cake()
        {
            Console.Write("Конструктор производного класса Cake вызван!\n\n");
        }
    }
}
