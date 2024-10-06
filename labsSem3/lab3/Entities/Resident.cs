using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Name {  get { return name; } }
        public List<Service> Services { get {  return services; } }

    
    }
}
