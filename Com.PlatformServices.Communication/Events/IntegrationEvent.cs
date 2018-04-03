using System;
using System.Collections.Generic;
using System.Text;
using Com.PlatformServices.Communication.Events.Declaration;

namespace Com.PlatformServices.Communication.Events
{
    public class IntegrationEvent
    {
        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        public Guid Id { get; }
        public DateTime CreationDate { get; }
    }
}
