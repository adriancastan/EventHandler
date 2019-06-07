using EventHandling.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventHandling.Implementations
{
    public class EventManager : IEventManager
    {
        private IList<IEventHandler> eventHandlers;

        public EventManager()
        {
            eventHandlers = new List<IEventHandler>();
        }
        public void AddHandler(IEventHandler eventHandler)
        {
            eventHandlers.Add(eventHandler);
        }

        public void HandleEvent<T>(IEvent<T> @event)
        {
            var handlers = eventHandlers.Where(o => o is IEventHandler<T> handler);

            foreach (IEventHandler<T> handler in handlers)
            {
                handler.Handle(@event);
            }
        }
        

        public IEnumerable<U> HandleEvent<T, U>(IEvent<T, U> @event)
        {
            var handlers = eventHandlers.Where(o => o is IEventHandler<T, U> handler);

            var results = new List<U>();

            foreach (IEventHandler<T, U> handler in handlers)
            {
                results.Add(handler.Handle(@event));
            }

            return results;
        }        
    }
}
