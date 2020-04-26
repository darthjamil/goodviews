using Goodviews.Domain;
using System;

namespace Goodviews.Ratings
{
    public class MovieRatedEvent : Event
    {
        public Guid MovieId { get; set; }
        public Guid UserId { get; set; }
        public int StarsOutOfFive { get; set; }
    }
}
