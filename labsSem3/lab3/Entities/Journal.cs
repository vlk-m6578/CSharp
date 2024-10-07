using System.Collections.Generic;

namespace lab3.Entities
{
    public class Journal
    {
        List<string> eventsList;

        public Journal()
        {
            eventsList = new List<string>();
        }

        public List<string> GetEvents() 
        { 
            return eventsList; 
        }
        public void LogEvent(string info)
        {
            eventsList.Add(info);
        }
    }
}
