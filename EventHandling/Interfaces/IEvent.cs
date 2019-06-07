namespace EventHandling.Interfaces
{
    public interface IEvent<T>
    {
        T EventData { get; set; }
    }

}
