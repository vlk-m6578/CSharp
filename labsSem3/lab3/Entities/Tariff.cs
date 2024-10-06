using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string ServiceName {  get { return serviceName; } }
        public double GetPrice { get { return price; } }
        public void SetPrice(double price) { this.price = price;}
    }
}
