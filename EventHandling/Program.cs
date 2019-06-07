using EventHandling.Implementations;
using EventHandling.Interfaces;
using EventHandling.Models;
using System;

namespace EventHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEventManager evMan = new EventManager();

            IEventHandler<User, UserAddedResult> evWithResult = new UserAddedEventHandler();
            IEventHandler<User> evNoResult = new UserAddedEventHandler2();

            evMan.AddHandler(evWithResult);
            evMan.AddHandler(evNoResult);

            var results= evMan.HandleEvent(new UserAddedEventWithResult() { EventData = new Models.User() { Name = "Julian" } });


            foreach (var resul in results)
            {
                Console.WriteLine(resul.UserName);
            }

            evMan.HandleEvent(new UserAddedEvent() { EventData = new Models.User() { Name = "Julian" } });


        }
    }
}
