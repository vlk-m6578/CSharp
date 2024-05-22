using System;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(5, 9, 3);
            Vector vector2 = new Vector(1, 1, 1);

            Console.WriteLine(vector1.ToString());
            Console.WriteLine(vector2.ToString() + "\n");

            Console.WriteLine("Первый элемент Vector 1: " + vector1[0]);
            Console.WriteLine("Второй элемент Vector 1: " + vector1[1]);
            Console.WriteLine("Третий элемент Vector 1: " + vector1[2] + "\n");

            Vector sum = vector1 + vector2;
            Console.WriteLine("Сумма: " + sum);
            Vector difference = vector1 - vector2;
            Console.WriteLine("Разность: " + difference);
            Vector multiplication = vector1 * vector2;
            Console.WriteLine("Умножение: " + multiplication + "\n");

            Vector multiplicationByNumber1 = vector1 * 2;
            Console.WriteLine("Умножение вектора на число: " + multiplicationByNumber1);
            Vector multiplicationByNumber2 = vector2 * (-4);
            Console.WriteLine("Умножение вектора на число: " + multiplicationByNumber2 + "\n");

            Vector division1 = vector1 / 4;
            Console.WriteLine("Деление вектора на число: " + division1);
            Vector division2 = vector2 / 0;
            Console.WriteLine("Деление вектора на число: " + division2 + "\n");

            Vector increment = ++vector1;
            Console.WriteLine("Инкремент: " + increment);
            Vector decrement = --vector2;
            Console.WriteLine("Декремент: " + decrement + "\n");

            bool equal = vector1 == vector2;
            Console.WriteLine("Сравнение(==): " + equal);
            bool doesNotEqual = vector1 != vector2;
            Console.WriteLine("Сравнение(!=): " + doesNotEqual + "\n");

            bool bigger = vector1 > vector2;
            Console.WriteLine("Сравнение(>): " + bigger);
            bool smaller = vector1 < vector2;
            Console.WriteLine("Сравнение(<): " + smaller + "\n");

            if(vector1)
            {
                Console.WriteLine("Vector не равен (0,0,0).");
            }
            else
            {
                Console.WriteLine("Vector равен (0,0,0).");
            }

            if (vector2)
            {
                Console.WriteLine("Vector не равен (0,0,0).");
            }
            else
            {
                Console.WriteLine("Vector равен (0,0,0).");
            }
           
            double convertToDouble = (double)vector1;
            Console.WriteLine("\nПреобразование в double: " + convertToDouble);
            Vector convertToVectorFromDouble = (Vector)7.4;
            Console.WriteLine("Преобразование в Vector: " + convertToVectorFromDouble + "\n");

            int convertToInt = (int)vector2;
            Console.WriteLine("Преобразование в int(пользовательское): " + convertToInt);
            Vector convertToVectorFromInt = (Vector)(-23);
            Console.WriteLine("Преобразование в Vector: " + convertToVectorFromInt + "\n");

        }
    }
}
