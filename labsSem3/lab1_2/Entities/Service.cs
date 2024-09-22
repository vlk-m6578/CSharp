
namespace lab3.Entities
{
    public class Service
    {
        private Tariff tariff;
        public int consumption;

        public Service(Tariff tariff, int consumption)
        {
            this.tariff = tariff;
            this.consumption = consumption;
        }

        public decimal CalculateCost()
        {
            return tariff.Rate * consumption;
        }

        public Tariff GetTariff()
        {
            return tariff;
        }
    }
}
