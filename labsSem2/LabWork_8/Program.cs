using System;
using System.Collections.Generic;

namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PayrollDepartment department = new PayrollDepartment();
            department.AddTypeWithSurcharge("Programming", 25, 5000);
            department.AddTypeWithoutSurcharge("Testing", 4550.34m);
            Console.WriteLine("Средняя величина оплаты: "+department.GetAveragePayment());

            Console.WriteLine("\nВызов метода интерфейса через интерфейсную ссылку: ");
            List<TypesOfWork> types = department.GetTypesOfWork();

            foreach(TypesOfWork type in types)
            {
                IPayment paymentInterface = type.GetIPayment();
                decimal payment = paymentInterface.GetPayment();
                Console.WriteLine("Зарплата для типа работы " + type.GetType() + " составляет " + payment);
            }
            Console.WriteLine("\n");
        }
    }
}
