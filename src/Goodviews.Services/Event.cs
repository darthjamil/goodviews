using System;

namespace Goodviews.Services
{
    public abstract class Event
    {
        public Guid CorrelationId { get; set; }
        public DateTime EventDateUtc { get; set; }
    }
}
