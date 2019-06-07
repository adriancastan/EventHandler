using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandling.Interfaces
{
    public interface IEvent<T>
    {
        T EventData { get; set; }
    }

    public interface IEvent<T, U>
    {
        T EventData { get; set; }
    }


}
