
namespace lab3.Entities
{
    public class Tariff
    {
        string serviceName;
        double price;

        public Tariff(string serviceName, double price)
        {
            this.serviceName = serviceName; 
            this.price = price;
        }
        public string GetServiceName() 
        {  
            return serviceName;
        }
        public double GetPrice() 
        { 
            return price; 
        }
        public void SetPrice(double price) { this.price = price;}
    }
}
