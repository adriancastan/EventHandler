namespace EventHandling.Interfaces
{
    public interface ICommandHandler<TEventData, UResponse> : IHandler
    {
        UResponse Handle(ICommand<TEventData, UResponse> @event);
    }
}
