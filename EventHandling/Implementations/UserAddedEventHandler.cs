using EventHandling.Interfaces;
using EventHandling.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EventHandling.Implementations
{
    public class UserAddedEventHandler : ICommandHandler<User,UserAddedResult>
    {       

        public UserAddedResult Handle(ICommand<User,UserAddedResult> @event)
        {
            return new UserAddedResult() { UserName = "Juanito Perez" };
        }
    }
}
