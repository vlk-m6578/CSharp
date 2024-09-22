using lab3.Entities;
using System;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UtilityService utilityService = new UtilityService();

            //добавим тарифы
            utilityService.AddTariff("Water supply", 100);
            utilityService.AddTariff("Electricity", 50);

            //добавим жильцов
            utilityService.AddResident("RESIDENT 1");
            utilityService.AddResident("RESIDENT 2");

            //добавим услуги жильцам
            utilityService.AddService("RESIDENT 1", "Water supply", 5);
            utilityService.AddService("RESIDENT 1", "Electricity", 10);
            utilityService.AddService("RESIDENT 2", "Water supply", 3);

            Console.WriteLine("The sum of all services consumed for RESIDENT 1: " + utilityService.GetResidentServices("RESIDENT 1"));
            Console.WriteLine("The sum of all services consumed for RESIDENT 2: " + utilityService.GetResidentServices("RESIDENT 2"));
            Console.WriteLine("Total number of water supply orders: " + utilityService.GetServicesCount("Water supply"));
            Console.WriteLine("The cost of all services: " + utilityService.CalculateTotalServiceCost());


            Journal journal = new Journal();
            utilityService.ChangeTheList += (description) =>
            {
                journal.LogEvent(description);
            };
            //подписка program на покупку услуги жильцом
            utilityService.BuyOfService += (description) =>
            {
                //Console.WriteLine("Event: " + description);
                journal.LogEvent(description);
            };
            utilityService.ChangeListT("Water supply", 100);
            utilityService.ChangeListR("RESIDENT 1");
            utilityService.BuyTheService("RESIDENT 1", "Electricity"); 
            utilityService.BuyTheService("RESIDENT 2", "Water supply");

            //вывод всех зарегистрированных событий
            journal.PrintAllEvents();

            Console.WriteLine("______________________________________________________________________");

        }
    }
}
