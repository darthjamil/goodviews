using Goodviews.Domain;
using System;

namespace Goodviews.Discover
{
    public class MovieAddedToListEvent : Event
    {
        public Guid ListId { get; set; }
        public string ListName { get; set; }
        public Guid MovieId { get; set; }
        public Guid CreatorUserId { get; set; }
    }
}
