using EventHandling.Implementations;
using EventHandling.Interfaces;
using System;

namespace EventHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEventManager evMan = new EventManager();

            evMan.AddHandler(new UserAddedEventHandler());
            evMan.AddHandler(new UserAddedEventHandler2());

            evMan.HandleEvent(new UserAddedEvent() { EventData= new Models.User() { Name="Julian" } });
        }
    }
}
