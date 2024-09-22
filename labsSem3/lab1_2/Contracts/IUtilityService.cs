
namespace lab3.Contracts
{
    public interface IUtilityService
    {
        void AddTariff(string name, decimal rate);//добавление нового тарифа
        void AddResident(string name);//ввод информации о жильце
        void AddService(string residentName, string serviceName, int count);//ввод информации об услуге
        decimal GetResidentServices(string residentName);//сумма всех потребленных услуг жильца
        decimal CalculateTotalServiceCost();//стоимость ВСЕХ услуг
        int GetServicesCount(string serviceName);//общее количество заказов на заданную услугу
    }
}
