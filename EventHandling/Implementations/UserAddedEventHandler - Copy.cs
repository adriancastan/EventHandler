namespace EventHandling.Implementations
{
    using EventHandling.Interfaces;
    using EventHandling.Models;
    using System.Diagnostics;
    public class UserAddedEventHandler2 : IEventHandler<User>
    {
        public void Handle(IEvent<User> @event)
        {
            Debug.WriteLine(@event.EventData.Name+ " handler2");
        }
    }
}
