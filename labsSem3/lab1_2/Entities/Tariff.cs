
namespace lab3.Entities
{
    public class Tariff
    {
        public string ServiceName { get; }
        public decimal Rate { get; }

        public Tariff(string serviceName, decimal rate)
        {
            ServiceName = serviceName;
            Rate = rate;
        }
    }
}
