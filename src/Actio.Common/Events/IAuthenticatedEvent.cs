using System;

namespace Actio.Common.Events
{
    public interface IAuthenticatedEvent : IEvents
    {
        public Guid UserId { get; } // just get = readonly
    }
}