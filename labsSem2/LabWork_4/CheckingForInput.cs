using System;

namespace lab4
{
    internal class CheckingForInput
    {
        static public string ContinuationAndTermination(string s)
        {
            while (true)
            {
                s = Console.ReadLine();
                if(s=="1"||s=="2")
                {
                    return s;
                }
                else
                {
                    Console.Write("Неправильный ввод! Попробуйте еще раз: ");
                }
            }
        }
        static public string StringOfName(string s)
        {
            bool isNormal = false;
            while(true)
            {
                s = Console.ReadLine();//32 -- пробел
                foreach(char c in s)
                {
                    if ((Char.IsLetter(c)||c== 32)&&(Char.IsUpper(c)||Char.IsLower(c)))
                    {
                        isNormal = true;
                        continue;
                    }
                    else
                    {
                        Console.Write("Неправильный ввод! Попробуй еще раз: ");
                        break;
                    }
                }
                if (isNormal)
                {
                    return s;
                }
            }
        }
        static public int Int(string s)
        {
            int output;
            while(true)
            {
                s = Console.ReadLine();
                if(int.TryParse(s, out output)&&output>0)
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
        static public int Percent(string s)
        {
            int output;
            while (true)
            {
                s = Console.ReadLine();
                if (int.TryParse(s, out output) && output >= 0 && output<=100)
                {
                    return output;
                }
                else
                {
                    Console.Write("Неправильный ввод! Попробуй еще раз: ");
                }
            }
        }
        static public int IncreaseAndDecrease(string s)
        {
            int output;
            while (true)
            {
                s = Console.ReadLine();
                if (int.TryParse(s, out output) && output >= 0)
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
