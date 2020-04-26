using System;

namespace Goodviews.Domain
{
    public class MovieRatedEvent : Event
    {
        public Guid MovieId { get; set; }
        public Guid UserId { get; set; }
        public int StarsOutOfFive { get; set; }
    }
}
