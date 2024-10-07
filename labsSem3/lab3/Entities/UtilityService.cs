using lab3.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab3.Entities
{
    public class UtilityService:IUtilityService
    {
        Dictionary<string, Service> services;
        List<Resident> residents;
        List<Service> residentsServices;
        List<Tariff> tariffs;
        Journal journal;

        public event Action<string> someAction;

        public Journal GetJournal() 
        { 
            return journal; 
        }

        private Resident FindResidentByName(string name)
        {
            foreach(Resident r in residents)
            {
                if (r.GetName().Equals(name))
                {
                    return r;
                }
            }
            return null;
        }
        private Tariff FindTariffByName(string name)
        {
            foreach (Tariff t in tariffs)
            {
                if (t.GetServiceName().Equals(name))
                {
                    return t;
                }
            }
            return null;
        }
        public UtilityService()
        {
            services = new Dictionary<string, Service>();
            residents = new List<Resident>();
            residentsServices = new List<Service>();
            journal = new Journal();
            tariffs = new List<Tariff>();

            tariffs.Add(new Tariff("Water supply", 1));
            tariffs.Add(new Tariff("Electricity", 7));
            tariffs.Add(new Tariff("Water supply+", 2));
            tariffs.Add(new Tariff("Electricity+", 8));

            services.Add("Water", new Service(FindTariffByName("Water supply"), "", 0));
            services.Add("Electro", new Service(FindTariffByName("Electricity"), "", 0));
            services.Add("Water+", new Service(FindTariffByName("Water supply+"), "", 0));
            services.Add("Electro+", new Service(FindTariffByName("Electricity+"), "", 0));
        }
        public void AddResident(string name)
        {
            residents.Add(new Resident(name));
            someAction.Invoke("New resident " + name);
        }

        public void UseService(string residentName, string serviceName, int consumption)
        {
            Resident resident = FindResidentByName(residentName);
            Service newService = new Service(services[serviceName].GetTariff(),residentName, consumption);
            resident.Services.Add(newService);
            residentsServices.Add(newService);
            someAction.Invoke(residentName + " buy service(" + serviceName + "), " + consumption);
        }

        public void SetTariff(string name, double price)
        {
            Tariff tariff=FindTariffByName(name);
            tariff.SetPrice(price);
            someAction.Invoke("Tariff " + name + " change to " + price);
        }

        public double CalculateTotalPayments()
        {
            double totalPayments = 0;
            totalPayments += (from service in residentsServices where service.GetTariff().GetServiceName().Equals("Water supply") select service.GetPrice()*service.GetConsumption()).Sum();
            totalPayments += (from service in residentsServices where service.GetTariff().GetServiceName().Equals("Water supply+") select service.GetPrice() * service.GetConsumption()).Sum();
            totalPayments += (from service in residentsServices where service.GetTariff().GetServiceName().Equals("Electricity") select service.GetPrice() * service.GetConsumption()).Sum();
            totalPayments += (from service in residentsServices where service.GetTariff().GetServiceName().Equals("Electricity+") select service.GetPrice() * service.GetConsumption()).Sum();

            return totalPayments;
        }

        public double CalculateResidentTotalPayment(string name)
        {
            Resident resident= FindResidentByName(name);
            double totalPayments = (from service in residentsServices where service.GetName().Equals(name) select service.GetPrice()*service.GetConsumption()).Sum();
            return totalPayments;
        }
        public string GetResidentNameMax()
        {
            var residentList = from resident in residents
                               orderby CalculateResidentTotalPayment(resident.GetName()) descending
                               select resident;

            List<Resident> res = residentList.ToList();
            return res[0].GetName();
        }
        public List<Service> GetSortServiceList()
        {
            List<Service> list = new List<Service>();
            list.Add(new Service(FindTariffByName("Water supply"), "", 0));
            list.Add(new Service(FindTariffByName("Electricity"), "", 0));
            list.Add(new Service(FindTariffByName("Water supply+"), "", 0));
            list.Add(new Service(FindTariffByName("Electricity+"), "", 0));

            var serviceList = from service in list 
                              orderby service.GetPrice() descending
                              select service;

            return serviceList.ToList();
        }
        public int GetCountOfResidentsPayMore(int price)
        {
            int count = residents.Aggregate(0, (tmp, resident) => CalculateResidentTotalPayment(resident.GetName()) > price ? tmp + 1 : tmp);
            return count;
        }
        public List<double> GetResidentsPaymentsByTariff(string name)
        {
            List<double> res = new List<double>();

            var listOfServicesByResident = from service in residentsServices where service.GetName().Equals(name) select service;

            var groupOfServicesByTariff = (listOfServicesByResident.GroupBy(service => service.GetTariff()));

            foreach (var group in groupOfServicesByTariff)
            {
                double totalAmount = 0;
                totalAmount += group.Sum(service => service.GetConsumption() * service.GetPrice());
                res.Add(totalAmount);
            }

            return res;
        }
        public void printJournal()
        {
            foreach (var e in journal.GetEvents())
            {
                Console.WriteLine(e);
            }
        }
    }
}
