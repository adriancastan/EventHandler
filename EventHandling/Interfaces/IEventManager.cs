using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandling.Interfaces
{
    public interface IEventManager
    {
        void AddHandler(IEventHandler eventHandler);
        void HandleEvent<T>(IEvent<T> @event);
        IEnumerable<U> HandleEvent<T, U>(IEvent<T,U> @event);
    }
}
