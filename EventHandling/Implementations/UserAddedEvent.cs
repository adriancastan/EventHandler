using EventHandling.Interfaces;
using EventHandling.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandling.Implementations
{
    public class UserAddedEvent : IEvent<User>
    {
        public User EventData { get; set; }
    }
}
