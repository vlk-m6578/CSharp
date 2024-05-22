using System;

namespace lab6
{
    internal class IceCream : Dessert
    {
        protected int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public new void PrintInformation()
        {
            if (isHaveDessert)
            {
                Console.Write("Мороженое: " + Name + ". Цена: " + Price + ". ");
                CountOfSlices();
            }
            else
            {
                base.PrintInformation();
            }
        }
        public void PrintInformation(string additionalInfo)
        {
            if (isHaveDessert)
            {
                Console.Write("Мороженое: " + Name + ". Цена: " + Price + ". ");
                CountOfSlices();
                Console.WriteLine("\nДополнительная информация: " + additionalInfo);
            }
            else
            {
                base.PrintInformation();
            }
        }
        public override void PrintStatus()
        {
            Console.WriteLine("Мороженое готово!");
        }
        public void CountOfSlices()
        {
            Console.Write("Количество шариков мороженого: " + count);
        }
        public override void CreateDessert() 
        {
            isHaveDessert = true;
     
            Console.Write("Введите название мороженого: ");
            Name = Console.ReadLine();
            Console.Write("Введите цену мороженого: ");
            Price = CheckingForInput.Double(Price.ToString());
            Console.Write("Введите количество шариков мороженого: ");
            Count = CheckingForInput.Int(Count.ToString());
            PrintStatus();
        }
    }
}
