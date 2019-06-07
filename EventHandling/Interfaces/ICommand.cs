namespace EventHandling.Interfaces
{
    public interface ICommand<T, U>
    {
        T CommandData { get; set; }
    }
}
