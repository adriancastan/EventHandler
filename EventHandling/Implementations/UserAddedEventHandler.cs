using EventHandling.Interfaces;
using EventHandling.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EventHandling.Implementations
{
    public class UserAddedEventHandler : IEventHandler<User,UserAddedResult>
    {       

        public UserAddedResult Handle(IEvent<User,UserAddedResult> @event)
        {
            return new UserAddedResult() { UserName = "Juanito Perez" };
        }
    }
}
