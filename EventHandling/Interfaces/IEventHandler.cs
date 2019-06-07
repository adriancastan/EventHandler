﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandling.Interfaces
{
    public interface IEventHandler<TEventData,UResponse>: IEventHandler
    {
        UResponse Handle(IEvent<TEventData,UResponse> @event);
    }

    public interface IEventHandler<TEventData> : IEventHandler
    {
        void Handle(IEvent<TEventData> @event);
    }

    public interface IEventHandler
    {

    }
}
