using lab3.Entities;
using System.Collections.Generic;

namespace lab3.Contracts
{
    internal interface IUtilityService
    {
        void SetTariff(string name, double rate);//добавление нового тарифа
        void AddResident(string name);//добавление жильца
        void UseService(string residentName, string serviceName);//добавление услуги
        //double GetResidentServices();//сумма всех потребленных услуг жильца
        double CalculateTotalPayments();//стоимость ВСЕХ услуг
        int GetServicesCount(string serviceName);//общее количество заказов на заданную услугу

    }
}
