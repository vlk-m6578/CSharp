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
            US.AddResident("Ivan");
            US.AddResident("Petr");

            US.UseService("Sasha", "Water+", 10);
            US.UseService("Sasha", "Electro", 20);
            US.UseService("Petr", "Water+", 30);
            US.UseService("Petr", "Electro+", 40);

            Console.WriteLine("Sorted list of names of all services (by cost): ");
            foreach (Service a in US.GetSortServiceList())
            {
                Console.WriteLine(a.GetTariff().GetServiceName() +" -- "+a.GetPrice());
            }

            Console.Write("The total cost of all completed utility services: ");
            Console.WriteLine(US.CalculateTotalPayments());

            Console.Write("The total cost of all services ordered by the resident: ");
            Console.WriteLine(US.CalculateResidentTotalPayment("Sasha"));

            Console.Write("The name of the resident who paid the maximum amount: ");
            Console.WriteLine(US.GetResidentNameMax());

            Console.Write("The number of residents who paid more than a certain amount: ");
            Console.WriteLine(US.GetCountOfResidentsPayMore(10));

            Console.WriteLine("List of amounts paid for each service: ");
            foreach (var a in US.GetResidentsPaymentsByTariff("Sasha"))
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("Event log: ");
            US.printJournal();
        }
    }
}
