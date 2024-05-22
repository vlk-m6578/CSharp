using System;


namespace lab6
{
    internal class CheckingForInput
    {
        static public int Choice(string s)
        {
            int output = 0;
            while (true)
            {
                s = Console.ReadLine();
                if (int.TryParse(s,out output)&&output>0&&output<10)
                {
                    return output;
                }
                else
                {
                    Console.Write("Неправильный ввод! Попробуйте еще раз: ");
                }
            }

        }
        static public int Int(string s)
        {
            int output;
            while (true)
            {
                s = Console.ReadLine();
                if (int.TryParse(s, out output)&&output>0)
                {
                    return output;
                }
                else
                {
                    Console.Write("Неправильный ввод! Попробуй еще раз: ");
                }
            }
        }
        static public double Double(string s)
        {
            double output;
            while (true)
            {
                s = Console.ReadLine();
                if (double.TryParse(s, out output) && output > 0)
                {
                    return output;
                }
                else
                {
                    Console.Write("Неправильный ввод! Попробуй еще раз: ");
                }
            }
        }
    }
}
