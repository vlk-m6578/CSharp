using System;

namespace lab9
{
    internal abstract class PizzaBase
    {
        protected string name;
        protected Size size;
        private IPizza pizza;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public PizzaBase(string name, Size size, IPizza pizza)
        {
            this.name = name;
            this.size = size;
            this.pizza = pizza;
        }

        public void Comment(string comment)
        {
            Console.WriteLine(name + comment);
        }
        
        public void SetPizza(IPizza pizza)
        {
            this.pizza = pizza;
        }
        public IPizza UsePizza()
        {
            return pizza;
        }

        public abstract void GetInfo();

        public override string ToString()
        {
            return string.Empty;
        }

        public Size Size
        {
            get => default;
            set
            {
            }
        }

        internal IPizza IPizza
        {
            get => default;
            set
            {
            }
        }
    }
}
