using lab3.Entities;
using System.Collections.Generic;

namespace lab3.Contracts
{
    internal interface IUtilityService
    {
        void AddResident(string name);
        void UseService(string residentName, string serviceName, int consumption);
        void SetTariff(string name, double price);
        
        List<Service> GetSortServiceList();//получение списка названий всех услуг, отсортированного по стоимости
        double CalculateTotalPayments();//получение общей стоимости всех выполненных услуг ЖЭС
        double CalculateResidentTotalPayment(string name);//получение общей стоимости всех услуг, заказанных жильцом в соответствии с действующими тарифами
        string GetResidentNameMax();//получение имени жильца, заплатившего максимальную сумму
        int GetCountOfResidentsPayMore(int price);//получение количества жильцов, заплативших больше определеной суммы
        List<double> GetResidentsPaymentsByTariff(string name);//получение жильцом списка сумм, заплаченных по каждой услуге
    }
}
