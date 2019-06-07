using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandling.Interfaces
{
    public interface IEventManager
    {
        void AddHandler(IEventHandler eventHandler);
        void HandleEvent<T>(IEvent<T> @event);
        IEnumerable<U> HandleCommand<T, U>(ICommand<T,U> @event);
    }
}
