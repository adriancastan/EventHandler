using EventHandling.Interfaces;
using EventHandling.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EventHandling.Implementations
{
    public class UserAddedEventHandler : IEventHandler<User>
    {
        public void Handle(IEvent<User> @event)
        {
            Debug.WriteLine(@event.EventData.Name);
        }
    }
}
