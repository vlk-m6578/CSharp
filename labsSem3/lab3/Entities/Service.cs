
namespace lab3.Entities
{
    public class Service
    {
        Tariff tariff;
        string nameOfResident;
        int consumption;
        public Service(Tariff tariff, string nameOfResident, int consumption) 
        {
            this.tariff = tariff;
            this.nameOfResident = nameOfResident;
            this.consumption = consumption;
        } 

        public void SetTariff(Tariff tariff)
        {
            this.tariff = tariff;
        }
        public double GetPrice()
        {
            return tariff.GetPrice();
        }
        public string GetName()
        {
            return nameOfResident;
        }
        public Tariff GetTariff()
        {
            return tariff;
        }
        public int GetConsumption()
        {
            return consumption;
        }
    }
}
