using lab3.Entities;
using System;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UtilityService US = new UtilityService();

            US.someAction += US.GetJournal().LogEvent;

            US.AddResident("Sasha");
            US.AddResident("Sashka Kakashka");
            US.AddResident("Milana");

            US.UseService("Sasha", "Water+", 10);
            US.UseService("Sasha", "Electro", 20);
            US.UseService("Milana", "Water+", 30);
            US.UseService("Milana", "Electro+", 40);

            foreach(Service a in US.GetSortServiceList())
            {
                Console.WriteLine(a.GetPrice());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(US.CalculateTotalPayments());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(US.CalculateResidentTotalPayment("Sasha"));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(US.GetResidentNameMax());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(US.GetCountOfResidentsPayMore(10));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            foreach (var a in US.GetResidentsPaymentsByTariff("Sasha"))
            {
                Console.WriteLine(a);
            }



            US.printJournal();
        }
    }
}
