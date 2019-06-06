using EventHandling.Interfaces;
using System;
using System.Collections.Generic;
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
            for (int i = 0; i < eventHandlers.Count; i++)
            {
                if (eventHandlers[i] is IEventHandler<T> handler)
                    handler.Handle(@event);
            }           
        }
    }
}
