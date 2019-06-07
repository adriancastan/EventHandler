namespace EventHandling.Interfaces
{
    public interface IEventHandler<TEventData,UResponse>: IEventHandler
    {
        UResponse Handle(ICommand<TEventData,UResponse> @event);
    }

    public interface IEventHandler<TEventData> : IEventHandler
    {
        void Handle(IEvent<TEventData> @event);
    }

    public interface IEventHandler
    {

    }
}
