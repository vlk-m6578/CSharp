using lab3.Collections;
using System;
using System.Collections.Generic;

namespace lab3.Entities
{
    public class Journal
    {
        private List<string> events;

        public Journal()
        {
            events = new List<string>();
        }

        //запись события в журнал
        public void LogEvent(string description)
        {
            string eventLog = "Event: " + description;
            events.Add(eventLog);
        }

        //вывод всех зарегистрированных событий
        public void PrintAllEvents()
        {
            Console.WriteLine("\nJournal of events:");
            foreach (var eventInfo in events)
            {
                Console.WriteLine(eventInfo);
            }
        }
    }
}
