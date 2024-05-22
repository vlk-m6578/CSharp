using System;

namespace lab6
{
    internal abstract class Dessert
    {
        protected string name;
        protected double price;
        protected bool isHaveDessert = false;

        public string Name 
        {   get { return name; } 
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public abstract void CreateDessert();
        public void PrintInformation()
        {
            Console.WriteLine("Десерт не создан!");
        }
        public virtual void PrintStatus()
        {
            Console.WriteLine("Десерт готов!");
        }
        public Dessert()
        {
            Console.Write("\n\nКонструктор родительского класса вызван.\n");
        }
    }
}
