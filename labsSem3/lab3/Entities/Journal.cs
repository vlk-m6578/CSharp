using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Entities
{
    public class Journal
    {
        List<string> eventsList;

        public Journal()
        {
            eventsList = new List<string>();
        }

        public List<string> GetEvents() { return eventsList; }

        public void LogEvent(string info)
        {
            eventsList.Add(info);
        }
    }
}
