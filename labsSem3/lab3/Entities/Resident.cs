using System.Collections.Generic;

namespace lab3.Entities
{
    public class Resident
    {
        string name;
        List<Service> services;

        public Resident(string name) 
        {
            this.name = name;
            services = new List<Service>();
        }
        public string GetName()
        {
            return name;
        }
        public List<Service> Services { get {  return services; } }

    
    }
}
