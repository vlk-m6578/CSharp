using System;
using lab3.Collections;
using lab3.Contracts;

namespace lab3.Entities
{
    internal class UtilityService : IUtilityService
    {
        private MyCustomCollection<Resident> residents;
        private MyCustomCollection<Tariff> tariffs;

        //cобытие при изменении списка тарифов или жильцов
        public event Action<string> ChangeTheList;

        //cобытие при покупке услуги жильцом
        public event Action<string> BuyOfService;

        public UtilityService()
        {
            residents = new MyCustomCollection<Resident>();
            tariffs = new MyCustomCollection<Tariff>();
        }

        //добавление нового тарифа
        public void AddTariff(string name, decimal rate)
        {
            Tariff newTariff = new Tariff(name, rate);
            tariffs.Add(newTariff);
        }

        //ввод информации о жильце
        public void AddResident(string name)
        {
            Resident newResident = new Resident(name);
            residents.Add(newResident);
        }

        //ввод информации об услуге
        public void AddService(string residentName, string serviceName, int count)
        {
            Resident resident = null;
            foreach (Resident r in residents)
            {
                if (r.GetName() == residentName)
                {
                    resident = r;
                    break;
                }
            }

            Tariff tariff = null;
            foreach (Tariff t in tariffs)
            {
                if (t.ServiceName == serviceName)
                {
                    tariff = t;
                    break;
                }
            }

            if (resident != null && tariff != null)
            {
                resident.AddService(new Service(tariff, count));
            }
        }

        //сумма всех потребленных услуг жильца
        public decimal GetResidentServices(string residentName)
        {
            Resident resident = null;

            foreach (Resident r in residents)
            {
                if (r.GetName() == residentName)
                {
                    resident = r;
                    break;
                }
            }

            if (resident == null)
            {
                return 0;
            }
            return resident.GetTotalCost();
        }

        //стоимость ВСЕХ услуг
        public decimal CalculateTotalServiceCost()
        {
            decimal totalCost = 0;
            foreach (var resident in residents)
            {
                totalCost += resident.GetTotalCost();
            }
            return totalCost;
        }

        //общее количество заказов на заданную услугу
        public int GetServicesCount(string serviceName)
        {
            int totalCount = 0;
            foreach (var resident in residents)
            {
                foreach (var service in resident.services)
                {
                    if (service.GetTariff().ServiceName == serviceName)
                    {
                        totalCount += service.consumption;
                    }
                }
            }
            return totalCount;
        }

        //добавление тарифа
        public void ChangeListT(string name, decimal rate)
        {
            Tariff newTariff = new Tariff(name, rate);
            tariffs.Add(newTariff);
            ChangeTheList?.Invoke("The tariff has been added: " + name);
        }

        public void ChangeListR(string name)
        {
            Resident newResident = new Resident(name);
            residents.Add(newResident);
            ChangeTheList?.Invoke("A resident has been added: " + name);
        }

        public void BuyTheService(string residentName, string serviceName)
        {
            Resident resident = FindResidentByName(residentName);

            if (resident == null)
            {
                BuyOfService?.Invoke("Resident " + residentName + " not found.");
                return;
            }

            Tariff tariff = FindTariffByName(serviceName);

            if (tariff == null)
            {
                BuyOfService?.Invoke("Service " + serviceName + " not found.");
                return;
            }

            Service existingService = FindServiceForResident(resident, serviceName);

            if (existingService != null)
            {
                //если услуга уже существует, можно увеличить потребление
                existingService.consumption += 1; //увеличиваем количество на 1
                BuyOfService?.Invoke("Resident " + residentName + " purchased an additional unit of service " + serviceName);
            }
            else
            {
                //если услуги нет, создаем новую и добавляем её
                Service newService = new Service(tariff, 1); //начинаем с 1 единицы потребления
                resident.AddService(newService);
                BuyOfService?.Invoke("Resident " + residentName + " bought the service " + serviceName);
            }
        }
        private Resident FindResidentByName(string name)
        {
            foreach (Resident resident in residents)
            {
                if (resident.GetName() == name)
                {
                    return resident;
                }
            }
            return null;
        }
        private Tariff FindTariffByName(string name)
        {
            foreach (Tariff tariff in tariffs)
            {
                if (tariff.ServiceName == name)
                {
                    return tariff;
                }
            }
            return null;
        }
        private Service FindServiceForResident(Resident resident, string serviceName)
        {
            if (resident != null)
            {
                foreach (Service service in resident.GetServices())
                {
                    if (service.GetTariff().ServiceName == serviceName)
                    {
                        return service;
                    }
                }
            }
            return null;
        }
    }
}

