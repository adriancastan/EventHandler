namespace EventHandling.Interfaces
{
    using System.Collections.Generic;
    public interface IEventManager
    {
        void AddHandler(IEventHandler eventHandler);
        void HandleEvent<T>(IEvent<T> @event);
        IEnumerable<U> HandleCommand<T, U>(ICommand<T, U> @event);
    }
}
