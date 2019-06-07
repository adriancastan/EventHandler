namespace EventHandling.Interfaces
{
    public interface IEventHandler<TEventData> : IHandler
    {
        void Handle(IEvent<TEventData> @event);
    }    

    public interface IHandler
    {

    }
}
