using EventHandling.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace EventHandling.Implementations
{
    public class EventManager : IEventManager
    {
        private IList<IHandler> eventHandlers;

        public EventManager()
        {
            eventHandlers = new List<IHandler>();
        }
        public void AddHandler(IHandler eventHandler)
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
        

        public IEnumerable<U> HandleCommand<T, U>(ICommand<T, U> @event)
        {
            var handlers = eventHandlers.Where(o => o is ICommandHandler<T, U> handler);

            var results = new List<U>();

            foreach (ICommandHandler<T, U> handler in handlers)
            {
                results.Add(handler.Handle(@event));
            }

            return results;
        }        
    }
}
