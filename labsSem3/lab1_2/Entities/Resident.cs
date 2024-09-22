using lab3.Collections;
using System.Collections.Generic;

namespace lab3.Entities
{
    public class Resident
    {
        private string name;
        public List<Service> services;

        public Resident(string name)
        {
            this.name = name;
            services = new List<Service>();
        }

        public void AddService(Service service)
        {
            services.Add(service);
        }

        public decimal GetTotalCost()
        {
            decimal total = 0;
            foreach (var service in services)
            {
                total += service.CalculateCost();
            }
            return total;
        }

        public string GetName()
        {
            return name;
        }
        public List<Service> GetServices() // Новый метод для получения услуг
        {
            return services;
        }
    }
}
