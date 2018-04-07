using RabbitMQ.Client;
using System;

namespace Com.PlatformServices.Communication.Events.Declaration
{
    public interface IRabbitMQPersistentConnection
        : IDisposable
    {
        bool IsConnected { get; }

        bool TryConnect();

        IModel CreateModel();
    }
}
