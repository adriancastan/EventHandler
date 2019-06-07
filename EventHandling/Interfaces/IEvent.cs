using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandling.Interfaces
{
    public interface IEvent<T>
    {
        T EventData { get; set; }
    }

    public interface ICommand<T, U>
    {
        T CommandData { get; set; }
    }


}
