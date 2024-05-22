using System;


namespace _353504_Lebedeva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите делимое: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите делитель: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = a / b; 
            Console.WriteLine("Частное = " + Math.Round(result, 4));
        }
    }
}
