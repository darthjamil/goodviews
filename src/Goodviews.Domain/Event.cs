using System;

namespace Goodviews.Domain
{
    public abstract class Event
    {
        public Guid CorrelationId { get; set; }
        public DateTime EventDateUtc { get; set; }
    }
}
